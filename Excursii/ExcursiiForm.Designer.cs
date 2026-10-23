namespace Excursii
{
    partial class ExcursiiForm
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
            this.lstExcursii = new System.Windows.Forms.ListBox();
            this.btnIncarca = new System.Windows.Forms.Button();
            this.lblStare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstExcursii
            // 
            this.lstExcursii.FormattingEnabled = true;
            this.lstExcursii.Location = new System.Drawing.Point(27, 12);
            this.lstExcursii.Name = "lstExcursii";
            this.lstExcursii.Size = new System.Drawing.Size(716, 160);
            this.lstExcursii.TabIndex = 0;
            // 
            // btnIncarca
            // 
            this.btnIncarca.Location = new System.Drawing.Point(12, 367);
            this.btnIncarca.Name = "btnIncarca";
            this.btnIncarca.Size = new System.Drawing.Size(191, 71);
            this.btnIncarca.TabIndex = 1;
            this.btnIncarca.Text = "Incarca Lista";
            this.btnIncarca.UseVisualStyleBackColor = true;
            this.btnIncarca.Click += new System.EventHandler(this.btnIncarca_Click);
            // 
            // lblStare
            // 
            this.lblStare.AutoSize = true;
            this.lblStare.Location = new System.Drawing.Point(531, 396);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(35, 13);
            this.lblStare.TabIndex = 2;
            this.lblStare.Text = "label1";
            // 
            // ExcursiiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStare);
            this.Controls.Add(this.btnIncarca);
            this.Controls.Add(this.lstExcursii);
            this.Name = "ExcursiiForm";
            this.Text = "ExcursiiForm";
            this.Load += new System.EventHandler(this.ExcursiiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstExcursii;
        private System.Windows.Forms.Button btnIncarca;
        private System.Windows.Forms.Label lblStare;
    }
}