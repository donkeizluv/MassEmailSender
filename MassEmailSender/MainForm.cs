using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassEmailSender
{
    public partial class FormMain : Form
    {
        //private ExcelUltility _excel;
        //private OutlookEmailSender _mailSender;
        //private List<string> _uniqueList;
        //private List<NameMapping> _nameMap;
        private string _header;
        private int _limit = 0;
        private const string EmailIdentify = @"@hdsaison.com.vn";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RefreshLabels()
        {

        }
        private void Reset()
        {
         
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void PopulateHeaderCbBox(List<string> list)
        {

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
            if(!int.TryParse(textBoxLimit.Text, out _limit))
            {
                textBoxLimit.Text = string.Empty;
                return;
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ver 1.0 by Hongln");
        }

        private void buttonAddJob_Click(object sender, EventArgs e)
        {

        }
    }
}
