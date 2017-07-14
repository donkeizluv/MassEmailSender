namespace MassEmailSender
{
    partial class FormMain
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
            this.labelEmailCol = new System.Windows.Forms.Label();
            this.comboBoxEmailCol = new System.Windows.Forms.ComboBox();
            this.buttonAddJob = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSend = new System.Windows.Forms.Button();
            this.checkBoxDisplayEmail = new System.Windows.Forms.CheckBox();
            this.textBoxLimit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnSheetname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSheet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSetBody = new System.Windows.Forms.Button();
            this.buttonSetTitle = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgess = new System.Windows.Forms.Label();
            this.labelTextTotal = new System.Windows.Forms.Label();
            this.labelEmails = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSetting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEmailCol
            // 
            this.labelEmailCol.AutoSize = true;
            this.labelEmailCol.Location = new System.Drawing.Point(247, 270);
            this.labelEmailCol.Name = "labelEmailCol";
            this.labelEmailCol.Size = new System.Drawing.Size(52, 17);
            this.labelEmailCol.TabIndex = 0;
            this.labelEmailCol.Text = "Group:";
            // 
            // comboBoxEmailCol
            // 
            this.comboBoxEmailCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmailCol.FormattingEnabled = true;
            this.comboBoxEmailCol.Location = new System.Drawing.Point(305, 267);
            this.comboBoxEmailCol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEmailCol.Name = "comboBoxEmailCol";
            this.comboBoxEmailCol.Size = new System.Drawing.Size(166, 24);
            this.comboBoxEmailCol.TabIndex = 1;
            // 
            // buttonAddJob
            // 
            this.buttonAddJob.Location = new System.Drawing.Point(478, 267);
            this.buttonAddJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddJob.Name = "buttonAddJob";
            this.buttonAddJob.Size = new System.Drawing.Size(75, 26);
            this.buttonAddJob.TabIndex = 2;
            this.buttonAddJob.Text = "Add";
            this.buttonAddJob.UseVisualStyleBackColor = true;
            this.buttonAddJob.Click += new System.EventHandler(this.buttonAddJob_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(565, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(197, 501);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 33);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Start";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // checkBoxDisplayEmail
            // 
            this.checkBoxDisplayEmail.AutoSize = true;
            this.checkBoxDisplayEmail.Checked = true;
            this.checkBoxDisplayEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisplayEmail.Location = new System.Drawing.Point(176, 88);
            this.checkBoxDisplayEmail.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDisplayEmail.Name = "checkBoxDisplayEmail";
            this.checkBoxDisplayEmail.Size = new System.Drawing.Size(68, 21);
            this.checkBoxDisplayEmail.TabIndex = 6;
            this.checkBoxDisplayEmail.Text = "Route";
            this.checkBoxDisplayEmail.UseVisualStyleBackColor = true;
            // 
            // textBoxLimit
            // 
            this.textBoxLimit.Location = new System.Drawing.Point(87, 30);
            this.textBoxLimit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLimit.Name = "textBoxLimit";
            this.textBoxLimit.Size = new System.Drawing.Size(55, 22);
            this.textBoxLimit.TabIndex = 7;
            this.textBoxLimit.TextChanged += new System.EventHandler(this.textBoxLimit_TextChanged);
            this.textBoxLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLimit_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Limit:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSheetname,
            this.columnGroup});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(541, 169);
            this.dataGridView1.TabIndex = 14;
            // 
            // columnSheetname
            // 
            this.columnSheetname.HeaderText = "Sheet";
            this.columnSheetname.Name = "columnSheetname";
            this.columnSheetname.ReadOnly = true;
            // 
            // columnGroup
            // 
            this.columnGroup.HeaderText = "Group";
            this.columnGroup.Name = "columnGroup";
            this.columnGroup.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Jobs:";
            // 
            // comboBoxSheet
            // 
            this.comboBoxSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSheet.FormattingEnabled = true;
            this.comboBoxSheet.Location = new System.Drawing.Point(64, 267);
            this.comboBoxSheet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSheet.Name = "comboBoxSheet";
            this.comboBoxSheet.Size = new System.Drawing.Size(167, 24);
            this.comboBoxSheet.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sheet:";
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Controls.Add(this.groupBox1);
            this.groupBoxSetting.Controls.Add(this.textBox4);
            this.groupBoxSetting.Controls.Add(this.label8);
            this.groupBoxSetting.Controls.Add(this.label5);
            this.groupBoxSetting.Controls.Add(this.textBox3);
            this.groupBoxSetting.Controls.Add(this.label4);
            this.groupBoxSetting.Controls.Add(this.buttonSetBody);
            this.groupBoxSetting.Controls.Add(this.buttonSetTitle);
            this.groupBoxSetting.Controls.Add(this.textBoxLimit);
            this.groupBoxSetting.Controls.Add(this.label2);
            this.groupBoxSetting.Controls.Add(this.checkBoxDisplayEmail);
            this.groupBoxSetting.Location = new System.Drawing.Point(16, 305);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(529, 189);
            this.groupBoxSetting.TabIndex = 18;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "Setting";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(296, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 109);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Pwd:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 66);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(87, 117);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(157, 22);
            this.textBox4.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Content:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(87, 63);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 22);
            this.textBox3.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Route to:";
            // 
            // buttonSetBody
            // 
            this.buttonSetBody.Location = new System.Drawing.Point(169, 149);
            this.buttonSetBody.Name = "buttonSetBody";
            this.buttonSetBody.Size = new System.Drawing.Size(75, 23);
            this.buttonSetBody.TabIndex = 20;
            this.buttonSetBody.Text = "Body";
            this.buttonSetBody.UseVisualStyleBackColor = true;
            // 
            // buttonSetTitle
            // 
            this.buttonSetTitle.Location = new System.Drawing.Point(88, 149);
            this.buttonSetTitle.Name = "buttonSetTitle";
            this.buttonSetTitle.Size = new System.Drawing.Size(75, 23);
            this.buttonSetTitle.TabIndex = 19;
            this.buttonSetTitle.Text = "Title";
            this.buttonSetTitle.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(289, 501);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 33);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 570);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(565, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // labelProgess
            // 
            this.labelProgess.AutoSize = true;
            this.labelProgess.Location = new System.Drawing.Point(267, 546);
            this.labelProgess.Name = "labelProgess";
            this.labelProgess.Size = new System.Drawing.Size(28, 17);
            this.labelProgess.TabIndex = 30;
            this.labelProgess.Text = "0/0";
            // 
            // labelTextTotal
            // 
            this.labelTextTotal.AutoSize = true;
            this.labelTextTotal.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextTotal.Location = new System.Drawing.Point(448, 238);
            this.labelTextTotal.Name = "labelTextTotal";
            this.labelTextTotal.Size = new System.Drawing.Size(64, 17);
            this.labelTextTotal.TabIndex = 31;
            this.labelTextTotal.Text = "Emails:";
            // 
            // labelEmails
            // 
            this.labelEmails.AutoSize = true;
            this.labelEmails.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmails.Location = new System.Drawing.Point(510, 238);
            this.labelEmails.Name = "labelEmails";
            this.labelEmails.Size = new System.Drawing.Size(16, 17);
            this.labelEmails.TabIndex = 32;
            this.labelEmails.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 593);
            this.Controls.Add(this.labelEmails);
            this.Controls.Add(this.labelTextTotal);
            this.Controls.Add(this.labelProgess);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.comboBoxSheet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonAddJob);
            this.Controls.Add(this.comboBoxEmailCol);
            this.Controls.Add(this.labelEmailCol);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Mass Email Sender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxSetting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmailCol;
        private System.Windows.Forms.ComboBox comboBoxEmailCol;
        private System.Windows.Forms.Button buttonAddJob;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.CheckBox checkBoxDisplayEmail;
        private System.Windows.Forms.TextBox textBoxLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSheetname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSheet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetBody;
        private System.Windows.Forms.Button buttonSetTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgess;
        private System.Windows.Forms.Label labelTextTotal;
        private System.Windows.Forms.Label labelEmails;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

