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
            this.folderList1 = new XlsDataProcessing.Unit.FolderList();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmDinfo1 = new XlsDataProcessing.Unit.CMDinfo();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cellsAndValue1 = new XlsDataProcessing.Unit.CellsAndValue();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderList1
            // 
            this.folderList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderList1.Location = new System.Drawing.Point(3, 17);
            this.folderList1.Name = "folderList1";
            this.folderList1.Size = new System.Drawing.Size(355, 326);
            this.folderList1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.folderList1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 346);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件夹列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmDinfo1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 233);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "程序运行信息";
            // 
            // cmDinfo1
            // 
            this.cmDinfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmDinfo1.Location = new System.Drawing.Point(3, 17);
            this.cmDinfo1.Name = "cmDinfo1";
            this.cmDinfo1.Size = new System.Drawing.Size(618, 213);
            this.cmDinfo1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cellsAndValue1);
            this.groupBox3.Location = new System.Drawing.Point(370, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 243);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "批量修改的单元格";
            // 
            // cellsAndValue1
            // 
            this.cellsAndValue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cellsAndValue1.Location = new System.Drawing.Point(3, 17);
            this.cellsAndValue1.Name = "cellsAndValue1";
            this.cellsAndValue1.Size = new System.Drawing.Size(242, 223);
            this.cellsAndValue1.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(373, 252);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(105, 42);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "开始处理";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // CellsModifyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CellsModifyPanel";
            this.Size = new System.Drawing.Size(624, 588);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Unit.FolderList folderList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Unit.CMDinfo cmDinfo1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Unit.CellsAndValue cellsAndValue1;
        private System.Windows.Forms.Button btnRun;
    }
}
