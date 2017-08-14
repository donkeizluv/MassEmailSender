using System;
using System.Windows.Forms;

namespace MassEmailSender.Forms
{
    public partial class LogViewer : Form
    {
        public LogViewer()
        {
            InitializeComponent();
        }
        public void AppendLog(string text)
        {
            Visible = true;
            if (!IsHandleCreated || !dataGridViewLog.IsHandleCreated) return;
            if (InvokeRequired)
                Invoke((Action) delegate { AddToGrid(text); });
            else
                AddToGrid(text);
        }
        private void AddToGrid(string text)
        {
            dataGridViewLog.Rows.Add($"{DateTime.Now:dd/MM/yyyy hh:mm:ss tt}", text);
            this.Visible = true;
        }
        private void LogViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }
    }
}
