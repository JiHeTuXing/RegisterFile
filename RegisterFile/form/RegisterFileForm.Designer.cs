namespace RegisterFile
{
    partial class RegisterFileForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterFileForm));
            this.dlgFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.labDir = new System.Windows.Forms.Label();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.labFileType = new System.Windows.Forms.Label();
            this.progBarRegister = new System.Windows.Forms.ProgressBar();
            this.cbFileType = new System.Windows.Forms.ComboBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dlgFolderBrowser
            // 
            this.dlgFolderBrowser.Description = "文件夹选择";
            this.dlgFolderBrowser.ShowNewFolderButton = false;
            // 
            // labDir
            // 
            this.labDir.AutoSize = true;
            this.labDir.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDir.Location = new System.Drawing.Point(12, 26);
            this.labDir.Name = "labDir";
            this.labDir.Size = new System.Drawing.Size(49, 14);
            this.labDir.TabIndex = 0;
            this.labDir.Text = "文件夹";
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(77, 25);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(177, 21);
            this.tbDir.TabIndex = 1;
            this.tbDir.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbDir_MouseDoubleClick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 108);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(234, 26);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始注册";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labFileType
            // 
            this.labFileType.AutoSize = true;
            this.labFileType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFileType.Location = new System.Drawing.Point(13, 76);
            this.labFileType.Name = "labFileType";
            this.labFileType.Size = new System.Drawing.Size(49, 14);
            this.labFileType.TabIndex = 3;
            this.labFileType.Text = "后缀名";
            // 
            // progBarRegister
            // 
            this.progBarRegister.Location = new System.Drawing.Point(16, 141);
            this.progBarRegister.Name = "progBarRegister";
            this.progBarRegister.Size = new System.Drawing.Size(234, 18);
            this.progBarRegister.TabIndex = 5;
            this.progBarRegister.MarginChanged += new System.EventHandler(this.btnStart_Click);
            // 
            // cbFileType
            // 
            this.cbFileType.FormattingEnabled = true;
            this.cbFileType.Items.AddRange(new object[] {
            "*.dll",
            "*.ocx",
            "*.reg",
            "*.lic"});
            this.cbFileType.Location = new System.Drawing.Point(77, 75);
            this.cbFileType.Name = "cbFileType";
            this.cbFileType.Size = new System.Drawing.Size(177, 20);
            this.cbFileType.TabIndex = 6;
            this.cbFileType.Text = "*.dll";
            // 
            // rtbInfo
            // 
            this.rtbInfo.BackColor = System.Drawing.SystemColors.Info;
            this.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInfo.Enabled = false;
            this.rtbInfo.ForeColor = System.Drawing.Color.DimGray;
            this.rtbInfo.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.rtbInfo.Location = new System.Drawing.Point(16, 165);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(234, 54);
            this.rtbInfo.TabIndex = 7;
            this.rtbInfo.Text = "";
            // 
            // RegisterFileForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(266, 222);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.cbFileType);
            this.Controls.Add(this.progBarRegister);
            this.Controls.Add(this.labFileType);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbDir);
            this.Controls.Add(this.labDir);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RegisterFile.Properties.Settings.Default, "注册文件", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(282, 260);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(282, 260);
            this.Name = "RegisterFileForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = global::RegisterFile.Properties.Settings.Default.注册文件;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterFileForm_FormClosed);
            this.Load += new System.EventHandler(this.RegisterFileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDir;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labFileType;
        public System.Windows.Forms.FolderBrowserDialog dlgFolderBrowser;
        private System.Windows.Forms.ProgressBar progBarRegister;
        private System.Windows.Forms.ComboBox cbFileType;
        private System.Windows.Forms.RichTextBox rtbInfo;
    }
}

