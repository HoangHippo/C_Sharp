
namespace b13
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.Ten,
            this.sl,
            this.nsx,
            this.nhh,
            this.ncc});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(776, 426);
            this.dgv.TabIndex = 0;
            // 
            // ma
            // 
            this.ma.DataPropertyName = "ma";
            this.ma.HeaderText = "Mã";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            this.ma.Width = 125;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 125;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "sl";
            this.sl.HeaderText = "số lượng";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            this.sl.Width = 125;
            // 
            // nsx
            // 
            this.nsx.DataPropertyName = "nsx";
            this.nsx.HeaderText = "Ngày Sản Xuất";
            this.nsx.MinimumWidth = 6;
            this.nsx.Name = "nsx";
            this.nsx.Width = 125;
            // 
            // nhh
            // 
            this.nhh.DataPropertyName = "nhh";
            this.nhh.HeaderText = "ngày hết hạn";
            this.nhh.MinimumWidth = 6;
            this.nhh.Name = "nhh";
            this.nhh.Width = 125;
            // 
            // ncc
            // 
            this.ncc.DataPropertyName = "ncc";
            this.ncc.HeaderText = "nhà cung cấp";
            this.ncc.MinimumWidth = 6;
            this.ncc.Name = "ncc";
            this.ncc.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncc;
    }
}

