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
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.buttonAddJob = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSend = new System.Windows.Forms.Button();
            this.checkBoxRoute = new System.Windows.Forms.CheckBox();
            this.textBoxLimit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMailJob = new System.Windows.Forms.DataGridView();
            this.columnSheetname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSheet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.textBoxSuffix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSmtpAccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSmtpAccountPwd = new System.Windows.Forms.TextBox();
            this.textBoxCc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRouteTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelProgess = new System.Windows.Forms.Label();
            this.labelVer = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMailJob)).BeginInit();
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
            // comboBoxGroup
            // 
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(305, 267);
            this.comboBoxGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(166, 24);
            this.comboBoxGroup.TabIndex = 1;
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
            this.buttonAddJob.Click += new System.EventHandler(this.ButtonAddJob_Click);
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(197, 494);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 33);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Start";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // checkBoxRoute
            // 
            this.checkBoxRoute.AutoSize = true;
            this.checkBoxRoute.Checked = true;
            this.checkBoxRoute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRoute.Location = new System.Drawing.Point(176, 88);
            this.checkBoxRoute.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRoute.Name = "checkBoxRoute";
            this.checkBoxRoute.Size = new System.Drawing.Size(68, 21);
            this.checkBoxRoute.TabIndex = 6;
            this.checkBoxRoute.Text = "Route";
            this.checkBoxRoute.UseVisualStyleBackColor = true;
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
            // dataGridViewMailJob
            // 
            this.dataGridViewMailJob.AllowUserToAddRows = false;
            this.dataGridViewMailJob.AllowUserToDeleteRows = false;
            this.dataGridViewMailJob.AllowUserToResizeColumns = false;
            this.dataGridViewMailJob.AllowUserToResizeRows = false;
            this.dataGridViewMailJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMailJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSheetname,
            this.columnGroup});
            this.dataGridViewMailJob.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMailJob.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewMailJob.MultiSelect = false;
            this.dataGridViewMailJob.Name = "dataGridViewMailJob";
            this.dataGridViewMailJob.ReadOnly = true;
            this.dataGridViewMailJob.RowHeadersVisible = false;
            this.dataGridViewMailJob.RowTemplate.Height = 24;
            this.dataGridViewMailJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMailJob.ShowCellErrors = false;
            this.dataGridViewMailJob.ShowCellToolTips = false;
            this.dataGridViewMailJob.ShowEditingIcon = false;
            this.dataGridViewMailJob.ShowRowErrors = false;
            this.dataGridViewMailJob.Size = new System.Drawing.Size(541, 169);
            this.dataGridViewMailJob.TabIndex = 14;
            this.dataGridViewMailJob.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataGridViewMailJob_KeyUp);
            // 
            // columnSheetname
            // 
            this.columnSheetname.HeaderText = "Sheet";
            this.columnSheetname.Name = "columnSheetname";
            this.columnSheetname.ReadOnly = true;
            this.columnSheetname.Width = 200;
            // 
            // columnGroup
            // 
            this.columnGroup.HeaderText = "Group";
            this.columnGroup.Name = "columnGroup";
            this.columnGroup.ReadOnly = true;
            this.columnGroup.Width = 200;
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
            this.comboBoxSheet.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSheet_SelectedIndexChanged);
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
            this.groupBoxSetting.Controls.Add(this.textBoxSuffix);
            this.groupBoxSetting.Controls.Add(this.label5);
            this.groupBoxSetting.Controls.Add(this.groupBox1);
            this.groupBoxSetting.Controls.Add(this.textBoxCc);
            this.groupBoxSetting.Controls.Add(this.label8);
            this.groupBoxSetting.Controls.Add(this.textBoxRouteTo);
            this.groupBoxSetting.Controls.Add(this.label4);
            this.groupBoxSetting.Controls.Add(this.textBoxLimit);
            this.groupBoxSetting.Controls.Add(this.label2);
            this.groupBoxSetting.Controls.Add(this.checkBoxRoute);
            this.groupBoxSetting.Location = new System.Drawing.Point(16, 305);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(529, 184);
            this.groupBoxSetting.TabIndex = 18;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "Setting";
            // 
            // textBoxSuffix
            // 
            this.textBoxSuffix.Location = new System.Drawing.Point(87, 147);
            this.textBoxSuffix.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSuffix.Name = "textBoxSuffix";
            this.textBoxSuffix.Size = new System.Drawing.Size(157, 22);
            this.textBoxSuffix.TabIndex = 31;
            this.textBoxSuffix.Text = "@hdsaison.com.vn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Suffix:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSmtpAccountName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSmtpAccountPwd);
            this.groupBox1.Location = new System.Drawing.Point(296, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 109);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // textBoxSmtpAccountName
            // 
            this.textBoxSmtpAccountName.Location = new System.Drawing.Point(68, 33);
            this.textBoxSmtpAccountName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSmtpAccountName.Name = "textBoxSmtpAccountName";
            this.textBoxSmtpAccountName.Size = new System.Drawing.Size(120, 22);
            this.textBoxSmtpAccountName.TabIndex = 21;
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
            // textBoxSmtpAccountPwd
            // 
            this.textBoxSmtpAccountPwd.Font = new System.Drawing.Font("Webdings", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxSmtpAccountPwd.Location = new System.Drawing.Point(68, 66);
            this.textBoxSmtpAccountPwd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSmtpAccountPwd.Name = "textBoxSmtpAccountPwd";
            this.textBoxSmtpAccountPwd.Size = new System.Drawing.Size(120, 20);
            this.textBoxSmtpAccountPwd.TabIndex = 23;
            // 
            // textBoxCc
            // 
            this.textBoxCc.Location = new System.Drawing.Point(87, 117);
            this.textBoxCc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCc.Name = "textBoxCc";
            this.textBoxCc.Size = new System.Drawing.Size(157, 22);
            this.textBoxCc.TabIndex = 28;
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
            // textBoxRouteTo
            // 
            this.textBoxRouteTo.Location = new System.Drawing.Point(87, 63);
            this.textBoxRouteTo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRouteTo.Name = "textBoxRouteTo";
            this.textBoxRouteTo.Size = new System.Drawing.Size(157, 22);
            this.textBoxRouteTo.TabIndex = 25;
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
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(289, 494);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 33);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelProgess
            // 
            this.labelProgess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelProgess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelProgess.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgess.ForeColor = System.Drawing.Color.Red;
            this.labelProgess.Location = new System.Drawing.Point(0, 536);
            this.labelProgess.Name = "labelProgess";
            this.labelProgess.Size = new System.Drawing.Size(565, 37);
            this.labelProgess.TabIndex = 30;
            this.labelProgess.Text = "...";
            this.labelProgess.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelVer
            // 
            this.labelVer.AutoSize = true;
            this.labelVer.Location = new System.Drawing.Point(453, 510);
            this.labelVer.Name = "labelVer";
            this.labelVer.Size = new System.Drawing.Size(47, 17);
            this.labelVer.TabIndex = 33;
            this.labelVer.Text = "Ver. X";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 573);
            this.Controls.Add(this.labelVer);
            this.Controls.Add(this.labelProgess);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.comboBoxSheet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewMailJob);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonAddJob);
            this.Controls.Add(this.comboBoxGroup);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMailJob)).EndInit();
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxSetting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmailCol;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Button buttonAddJob;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.CheckBox checkBoxRoute;
        private System.Windows.Forms.TextBox textBoxLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewMailJob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSheet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.TextBox textBoxCc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRouteTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSmtpAccountPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSmtpAccountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelProgess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSheetname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGroup;
        private System.Windows.Forms.TextBox textBoxSuffix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelVer;
    }
}

