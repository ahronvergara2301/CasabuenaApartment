namespace CasabuenaApartment
{
    partial class frmTenantRecord
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
            this.ddfdsfs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ddfdsfs
            // 
            this.ddfdsfs.Location = new System.Drawing.Point(12, 12);
            this.ddfdsfs.Name = "ddfdsfs";
            this.ddfdsfs.Size = new System.Drawing.Size(334, 177);
            this.ddfdsfs.TabIndex = 0;
            this.ddfdsfs.Text = "THIS IS A BUTTON";
            this.ddfdsfs.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 177);
            this.button1.TabIndex = 1;
            this.button1.Text = "THIS IS A BUTTON";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(334, 177);
            this.button2.TabIndex = 2;
            this.button2.Text = "THIS IS A BUTTON";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 3;
            // 
            // frmTenantRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ddfdsfs);
            this.Name = "frmTenantRecord";
            this.Text = "frmTenantRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ddfdsfs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}