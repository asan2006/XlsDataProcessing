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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCells)).BeginInit();
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
            this.dgvCells.Location = new System.Drawing.Point(0, 0);
            this.dgvCells.Name = "dgvCells";
            this.dgvCells.RowTemplate.Height = 23;
            this.dgvCells.Size = new System.Drawing.Size(243, 226);
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
            // CellsAndValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCells);
            this.Name = "CellsAndValue";
            this.Size = new System.Drawing.Size(243, 226);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCells)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn cCells;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValue;
        private System.Windows.Forms.DataGridView dgvCells;
    }
}
