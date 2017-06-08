namespace XlsDataProcessing.Unit
{
    partial class FolderList
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
            this.components = new System.ComponentModel.Container();
            this.lbFolder = new System.Windows.Forms.ListBox();
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbText = new System.Windows.Forms.GroupBox();
            this.cms1.SuspendLayout();
            this.gbText.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFolder
            // 
            this.lbFolder.AllowDrop = true;
            this.lbFolder.ContextMenuStrip = this.cms1;
            this.lbFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFolder.FormattingEnabled = true;
            this.lbFolder.HorizontalScrollbar = true;
            this.lbFolder.ItemHeight = 12;
            this.lbFolder.Location = new System.Drawing.Point(3, 17);
            this.lbFolder.Name = "lbFolder";
            this.lbFolder.ScrollAlwaysVisible = true;
            this.lbFolder.Size = new System.Drawing.Size(355, 326);
            this.lbFolder.TabIndex = 0;
            this.lbFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbFolder_DragDrop);
            this.lbFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbFolder_DragEnter);
            // 
            // cms1
            // 
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(114, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // gbText
            // 
            this.gbText.Controls.Add(this.lbFolder);
            this.gbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbText.Location = new System.Drawing.Point(0, 0);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(361, 346);
            this.gbText.TabIndex = 1;
            this.gbText.TabStop = false;
            this.gbText.Text = "文件夹列表";
            // 
            // FolderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbText);
            this.Name = "FolderList";
            this.Size = new System.Drawing.Size(361, 346);
            this.cms1.ResumeLayout(false);
            this.gbText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFolder;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbText;
    }
}
