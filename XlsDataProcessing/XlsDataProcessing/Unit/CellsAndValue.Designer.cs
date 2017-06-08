namespace XlsDataProcessing.Unit
{
    partial class CellsAndValue
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
            this.dgvCells = new System.Windows.Forms.DataGridView();
            this.cCells = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbText = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCells)).BeginInit();
            this.gbText.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCells
            // 
            this.dgvCells.AllowUserToOrderColumns = true;
            this.dgvCells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCells,
            this.cValue});
            this.dgvCells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCells.Location = new System.Drawing.Point(3, 17);
            this.dgvCells.Name = "dgvCells";
            this.dgvCells.RowTemplate.Height = 23;
            this.dgvCells.Size = new System.Drawing.Size(242, 169);
            this.dgvCells.TabIndex = 0;
            // 
            // cCells
            // 
            this.cCells.Frozen = true;
            this.cCells.HeaderText = "单元格";
            this.cCells.Name = "cCells";
            // 
            // cValue
            // 
            this.cValue.Frozen = true;
            this.cValue.HeaderText = "值";
            this.cValue.Name = "cValue";
            // 
            // gbText
            // 
            this.gbText.Controls.Add(this.dgvCells);
            this.gbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbText.Location = new System.Drawing.Point(0, 0);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(248, 189);
            this.gbText.TabIndex = 1;
            this.gbText.TabStop = false;
            this.gbText.Text = "批量修改单元格";
            // 
            // CellsAndValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbText);
            this.Name = "CellsAndValue";
            this.Size = new System.Drawing.Size(248, 189);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCells)).EndInit();
            this.gbText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn cCells;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValue;
        private System.Windows.Forms.DataGridView dgvCells;
        private System.Windows.Forms.GroupBox gbText;
    }
}
