﻿namespace XlsDataProcessing
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tpCellProcess = new System.Windows.Forms.TabPage();
            this.cellsModifyPanel1 = new XlsDataProcessing.Panel.CellsModifyPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCellProcess.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpCellProcess
            // 
            this.tpCellProcess.Controls.Add(this.cellsModifyPanel1);
            this.tpCellProcess.Location = new System.Drawing.Point(4, 22);
            this.tpCellProcess.Name = "tpCellProcess";
            this.tpCellProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tpCellProcess.Size = new System.Drawing.Size(628, 585);
            this.tpCellProcess.TabIndex = 0;
            this.tpCellProcess.Text = "修改温湿度信息";
            this.tpCellProcess.ToolTipText = "批量修改温湿度信息";
            this.tpCellProcess.UseVisualStyleBackColor = true;
            // 
            // cellsModifyPanel1
            // 
            this.cellsModifyPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cellsModifyPanel1.Location = new System.Drawing.Point(3, 3);
            this.cellsModifyPanel1.Name = "cellsModifyPanel1";
            this.cellsModifyPanel1.Size = new System.Drawing.Size(622, 579);
            this.cellsModifyPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCellProcess);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 611);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.tpCellProcess.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpCellProcess;
        private System.Windows.Forms.TabControl tabControl1;
        private Panel.CellsModifyPanel cellsModifyPanel1;
    }
}

