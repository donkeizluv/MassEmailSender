using EmailSender;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MassEmailSender
{
    public partial class FormMain : Form
    {
        private ExcelPackage _currentPackage;
        private int _limit = 0;
        private Dictionary<string, List<string>> _mailAttatchmentDict = new Dictionary<string, List<string>>();
        private List<MailJob> _jobs = new List<MailJob>();
        private string _subject = string.Empty;
        private string _body = string.Empty;
        private SmtpMailSender _smtpMail;

        public string MailServer { get; set; } = "mail.hdsaison.com.vn";
        public int Port { get; set; } = 25;
        public int TotalEmails { get; private set; }
        public FormMain(string mailServer, int port) : this()
        {
            MailServer = mailServer;
            Port = port;
        }

        public FormMain()
        {
            _smtpMail = new SmtpMailSender(MailServer, Port);
            _smtpMail.OnEmailSendingThreadExit += _smtpMail_OnEmailSendingThreadExit;
            _smtpMail.OnEmailSendingProgressChangedExit += _smtpMail_OnEmailSendingProgressChangedExit;
            InitializeComponent();
            ReadEmailContentConfig();
        }

        private void _smtpMail_OnEmailSendingProgressChangedExit(object sender, EmailSendingProgressChangedArgs e)
        {
            Invoke((Action)delegate {
                SetProgressLabel("Sending:", e.Sent, TotalEmails);
            });
        }

        private void _smtpMail_OnEmailSendingThreadExit(object sender, EmailSendingThreadEventArgs e)
        {
           
            Invoke((Action)delegate
            {
                if(e.StopOnUnrecoverableException)
                {
                    SetProgressLabel($"Fail: {e.ExceptionMessage}");
                }
                else
                {
                    SetProgressLabel("Done!");
                }
                //return control to normal
                EnableControls(true);
                buttonCancel.Enabled = false;
                //set label to empty
                this.Cursor = Cursors.Arrow;
            });
            
        }

        private void ReadEmailContentConfig()
        {
            try
            {
                var subjectFilename = new FileInfo($"{Program.ExeDir}\\{EmailContentFolder}\\{EmailSubjectFile}");
                var contentFilename = new FileInfo($"{Program.ExeDir}\\{EmailContentFolder}\\{EmailContentFile}");
                if (!subjectFilename.Exists)
                {
                    File.Create(subjectFilename.FullName);
                    _subject = string.Empty;
                }
                else
                {
                    _subject = File.ReadAllText(subjectFilename.FullName, Encoding.UTF8);
                }
                //read body content config
                if (!contentFilename.Exists)
                {
                    File.Create(contentFilename.FullName);
                    _body = string.Empty;
                }
                else
                {
                    _body = File.ReadAllText(contentFilename.FullName, Encoding.UTF8);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Fail to read config");
                Environment.FailFast("read config exception");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Fail to read config: Unauthorized");
                Environment.FailFast("read config exception");
            }
        }
        private void SetVer(string ver)
        {
            labelVer.Text = $"Ver. {ver}";
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            SetVer(Program.Version);
        }
        private bool VadidateSend()
        {
            if (_jobs.Count < 1)
            {
                MessageBox.Show("Add some job first!");
                return false;
            }
            if (textBoxSmtpAccountName.Text.Length < 1 || textBoxSmtpAccountPwd.Text.Length < 1)
            {
                if (MessageBox.Show(this, "Are you sure to start with empty SMTP account?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return false;
            }
            if(checkBoxRoute.Checked)
            {
                if(textBoxRouteTo.Text.Length < 1)
                {
                    MessageBox.Show("Add address to route to!");
                    return false;
                }
            }
            return true;
        }
        //TODO: catch ex
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (!VadidateSend())
                return;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                SetProgressLabel("Spliting files.....");
                //set control enable
                EnableControls(false);
                buttonCancel.Enabled = true;
                //spliting files
                var emailAttDict = MakeExcelFiles(_jobs, _currentPackage);
                var emails = MakeEmails(emailAttDict);
                //take limit amount of email
                int limit = GetLimit();
                if (limit > 0)
                {
                    emails = emails.Take(limit).ToList();
                }
                TotalEmails = emails.Count;
                if (MessageBox.Show(this, $"Start sending {emails.Count}(s)?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    //return control to normal
                    EnableControls(true);
                    buttonCancel.Enabled = false;
                    SetProgressLabel("...");
                    this.Cursor = Cursors.Arrow;
                    return;
                }
                
                //set account
                _smtpMail.SetSmtpAccount(textBoxSmtpAccountName.Text, textBoxSmtpAccountPwd.Text);
                _smtpMail.EnqueueEmail(emails);
                _smtpMail.StartSending();
                SetProgressLabel("Connecting...");
            }
            catch (Exception ex)
            {
                var builder = new StringBuilder();
                builder.Append(ex.Message);
                builder.Append(Environment.NewLine);
                builder.Append(ex.StackTrace);
                MessageBox.Show(this, builder.ToString(), "Screen shot this!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetLimit()
        {
            int lim = 0;
            int.TryParse(textBoxLimit.Text.TrimStart('0'), out lim);
            return lim;

        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _smtpMail.CancelThread = true;
        }

        private void SetProgressLabel(string prefix, int current, int max)
        {
            labelProgess.Text = string.Format("{0}: {1}/{2}", prefix, current, max);
        }
        private void SetProgressLabel(string s)
        {
            labelProgess.Text = s;
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewMailJob.Rows.Clear();
            _jobs.Clear();
            var fileDialog = new OpenFileDialog()
            {
                Filter = "xlsx|*.xlsx",
                Multiselect = false
            };

            if (fileDialog.ShowDialog() != DialogResult.OK) return;
            var fileName = fileDialog.FileName;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                _currentPackage = new ExcelPackage(new FileInfo(fileName));
                PopulateSheetsCbBox(ExcelUltility.GetSheetNames(_currentPackage).ToList());
                if (comboBoxSheet.Items.Count > 0)
                {
                    comboBoxSheet.SelectedIndex = 0;
                }
            }
            catch (IOException ex)
            {

                MessageBox.Show("Cant open file, make sure its not opened by any programs");
                return;
            }
            catch(InvalidDataException ex)
            {
                MessageBox.Show("Cant read this file!");
                return;
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void PopulateGroupCbBox(List<string> list)
        {
            comboBoxGroup.Items.Clear();
            foreach (var item in list)
            {
                comboBoxGroup.Items.Add(item);
            }
        }

        private void PopulateSheetsCbBox(List<string> list)
        {
            comboBoxSheet.Items.Clear();
            foreach (var item in list)
            {
                comboBoxSheet.Items.Add(item);
            }
        }

        private void ComboBoxSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSheet = comboBoxSheet.SelectedItem.ToString();
            var ws = _currentPackage.Workbook.Worksheets[selectedSheet];
            PopulateGroupCbBox(ExcelUltility.GetFirstRow(ws).ToList());
            //select first index
            if (comboBoxGroup.Items.Count > 0)
            {
                comboBoxGroup.SelectedIndex = 0;
            }
        }
      
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void TextBoxLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxLimit_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxLimit.Text, out _limit))
            {
                textBoxLimit.Text = string.Empty;
                return;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ver 1.0 by Hongln");
        }

        private void ButtonAddJob_Click(object sender, EventArgs e)
        {
            if (comboBoxSheet.SelectedIndex == -1 || comboBoxGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Choose Sheet & Group first!");
                return;
            }
            //add to job list
            var job = new MailJob(comboBoxSheet.SelectedItem.ToString(), comboBoxGroup.SelectedItem.ToString());
            _jobs.Add(job);
            //add to grid
            var row = dataGridViewMailJob.Rows[dataGridViewMailJob.Rows.Add(job.ToObjectArray())];
            //save job to Tag
            row.Tag = job;
        }

        private void EnableControls(bool enable)
        {
            foreach (Control control in Controls)
            {
                if (control is Label) continue;
                control.Enabled = enable;
            }
        }
        //delete job
        private void DataGridViewMailJob_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataGridViewMailJob.SelectedRows.Count > 0)
            {
                var row = dataGridViewMailJob.SelectedRows[0];
                var job = row.Tag as MailJob;
                dataGridViewMailJob.Rows.Remove(row);
                if (!_jobs.Remove(job))
                {
                    MessageBox.Show("Fail to delete job!");
                }
            }
        }
    }
}