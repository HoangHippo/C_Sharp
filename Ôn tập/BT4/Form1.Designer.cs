
namespace BT4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCD = new System.Windows.Forms.TextBox();
            this.txtTenCD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Công Dân";
            // 
            // txtMaCD
            // 
            this.txtMaCD.Location = new System.Drawing.Point(326, 108);
            this.txtMaCD.Name = "txtMaCD";
            this.txtMaCD.Size = new System.Drawing.Size(114, 22);
            this.txtMaCD.TabIndex = 1;
            // 
            // txtTenCD
            // 
            this.txtTenCD.Location = new System.Drawing.Point(326, 176);
            this.txtTenCD.Name = "txtTenCD";
            this.txtTenCD.Size = new System.Drawing.Size(114, 22);
            this.txtTenCD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Công Dân";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTenCD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaCD);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCD;
        private System.Windows.Forms.TextBox txtTenCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

