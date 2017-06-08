namespace XlsDataProcessing.Panel
{
    partial class PST5XProcessPanel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.folderList1 = new XlsDataProcessing.Unit.FolderList();
            this.cmDinfo1 = new XlsDataProcessing.Unit.CMDinfo();
            this.btn_iTest = new System.Windows.Forms.Button();
            this.btn_aTest = new System.Windows.Forms.Button();
            this.btn_cTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderList1
            // 
            this.folderList1.Location = new System.Drawing.Point(3, 3);
            this.folderList1.Name = "folderList1";
            this.folderList1.Size = new System.Drawing.Size(361, 346);
            this.folderList1.TabIndex = 0;
            this.folderList1.TextTip = "文件夹列表";
            // 
            // cmDinfo1
            // 
            this.cmDinfo1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmDinfo1.Location = new System.Drawing.Point(0, 355);
            this.cmDinfo1.Name = "cmDinfo1";
            this.cmDinfo1.Size = new System.Drawing.Size(670, 245);
            this.cmDinfo1.TabIndex = 1;
            this.cmDinfo1.TextTip = "程序运行信息";
            // 
            // btn_iTest
            // 
            this.btn_iTest.Location = new System.Drawing.Point(459, 55);
            this.btn_iTest.Name = "btn_iTest";
            this.btn_iTest.Size = new System.Drawing.Size(120, 55);
            this.btn_iTest.TabIndex = 2;
            this.btn_iTest.Text = "iTest";
            this.btn_iTest.UseVisualStyleBackColor = true;
            this.btn_iTest.Click += new System.EventHandler(this.btn_iTest_Click);
            // 
            // btn_aTest
            // 
            this.btn_aTest.Location = new System.Drawing.Point(459, 156);
            this.btn_aTest.Name = "btn_aTest";
            this.btn_aTest.Size = new System.Drawing.Size(120, 55);
            this.btn_aTest.TabIndex = 2;
            this.btn_aTest.Text = "aTest";
            this.btn_aTest.UseVisualStyleBackColor = true;
            // 
            // btn_cTest
            // 
            this.btn_cTest.Location = new System.Drawing.Point(459, 257);
            this.btn_cTest.Name = "btn_cTest";
            this.btn_cTest.Size = new System.Drawing.Size(120, 55);
            this.btn_cTest.TabIndex = 2;
            this.btn_cTest.Text = "cTest";
            this.btn_cTest.UseVisualStyleBackColor = true;
            // 
            // PST5XProcessPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_cTest);
            this.Controls.Add(this.btn_aTest);
            this.Controls.Add(this.btn_iTest);
            this.Controls.Add(this.cmDinfo1);
            this.Controls.Add(this.folderList1);
            this.Name = "PST5XProcessPanel";
            this.Size = new System.Drawing.Size(670, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private Unit.FolderList folderList1;
        private Unit.CMDinfo cmDinfo1;
        private System.Windows.Forms.Button btn_iTest;
        private System.Windows.Forms.Button btn_aTest;
        private System.Windows.Forms.Button btn_cTest;
    }
}
