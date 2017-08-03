using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Invoke((Action)delegate {
                AddToGrid(text);
            });
        }
        private void AddToGrid(string text)
        {
            dataGridViewLog.Rows.Add($"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}", text);
            this.Visible = true;
        }
        private void LogViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }
    }
}
