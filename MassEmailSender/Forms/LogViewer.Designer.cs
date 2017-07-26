namespace MassEmailSender.Forms
{
    partial class LogViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewLog = new System.Windows.Forms.DataGridView();
            this.ColumnTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLog
            // 
            this.dataGridViewLog.AllowUserToAddRows = false;
            this.dataGridViewLog.AllowUserToDeleteRows = false;
            this.dataGridViewLog.AllowUserToResizeRows = false;
            this.dataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTimeStamp,
            this.ColumnMess});
            this.dataGridViewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLog.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLog.Name = "dataGridViewLog";
            this.dataGridViewLog.ReadOnly = true;
            this.dataGridViewLog.RowHeadersVisible = false;
            this.dataGridViewLog.RowTemplate.Height = 24;
            this.dataGridViewLog.Size = new System.Drawing.Size(702, 465);
            this.dataGridViewLog.TabIndex = 0;
            // 
            // ColumnTimeStamp
            // 
            this.ColumnTimeStamp.HeaderText = "Time";
            this.ColumnTimeStamp.Name = "ColumnTimeStamp";
            this.ColumnTimeStamp.ReadOnly = true;
            // 
            // ColumnMess
            // 
            this.ColumnMess.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnMess.HeaderText = "Message";
            this.ColumnMess.Name = "ColumnMess";
            this.ColumnMess.ReadOnly = true;
            this.ColumnMess.Width = 94;
            // 
            // LogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 465);
            this.Controls.Add(this.dataGridViewLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogViewer";
            this.Text = "Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogViewer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMess;
    }
}