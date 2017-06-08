namespace XlsDataProcessing.Panel
{
    partial class CellsModifyPanel
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
            this.cmDinfo1 = new XlsDataProcessing.Unit.CMDinfo();
            this.btnRun = new System.Windows.Forms.Button();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.folderList1 = new XlsDataProcessing.Unit.FolderList();
            this.cellsAndValue1 = new XlsDataProcessing.Unit.CellsAndValue();
            this.SuspendLayout();
            // 
            // cmDinfo1
            // 
            this.cmDinfo1.AutoScroll = true;
            this.cmDinfo1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmDinfo1.Location = new System.Drawing.Point(0, 355);
            this.cmDinfo1.Name = "cmDinfo1";
            this.cmDinfo1.Size = new System.Drawing.Size(670, 245);
            this.cmDinfo1.TabIndex = 0;
            this.cmDinfo1.TextTip = "程序运行信息";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(373, 252);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(125, 46);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // bgw
            // 
            this.bgw.WorkerReportsProgress = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            // 
            // folderList1
            // 
            this.folderList1.Location = new System.Drawing.Point(3, 3);
            this.folderList1.Name = "folderList1";
            this.folderList1.Size = new System.Drawing.Size(361, 346);
            this.folderList1.TabIndex = 0;
            this.folderList1.TextTip = "文件夹列表";
            // 
            // cellsAndValue1
            // 
            this.cellsAndValue1.blCellsData = null;
            this.cellsAndValue1.Location = new System.Drawing.Point(373, 3);
            this.cellsAndValue1.Name = "cellsAndValue1";
            this.cellsAndValue1.Size = new System.Drawing.Size(245, 243);
            this.cellsAndValue1.TabIndex = 0;
            this.cellsAndValue1.TextTip = "批量修改单元格";
            // 
            // CellsModifyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmDinfo1);
            this.Controls.Add(this.cellsAndValue1);
            this.Controls.Add(this.folderList1);
            this.Controls.Add(this.btnRun);
            this.Name = "CellsModifyPanel";
            this.Size = new System.Drawing.Size(670, 600);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRun;
        private Unit.CMDinfo cmDinfo1;
        private System.ComponentModel.BackgroundWorker bgw;
        private Unit.FolderList folderList1;
        private Unit.CellsAndValue cellsAndValue1;
    }
}
