
namespace b12
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
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(319, 126);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 22);
            this.txtma.TabIndex = 0;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(319, 191);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 22);
            this.txtten.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button button1;
    }
}

