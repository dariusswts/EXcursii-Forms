namespace Excursii
{
    partial class MeniuForm
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
            this.btnCalcul = new System.Windows.Forms.Button();
            this.btnGhid = new System.Windows.Forms.Button();
            this.btnExcursii = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.lblGhid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(144, 12);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(240, 58);
            this.btnCalcul.TabIndex = 0;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGhid
            // 
            this.btnGhid.Location = new System.Drawing.Point(144, 76);
            this.btnGhid.Name = "btnGhid";
            this.btnGhid.Size = new System.Drawing.Size(240, 59);
            this.btnGhid.TabIndex = 1;
            this.btnGhid.Text = "Ghid";
            this.btnGhid.UseVisualStyleBackColor = true;
            this.btnGhid.Click += new System.EventHandler(this.btnGhid_Click);
            // 
            // btnExcursii
            // 
            this.btnExcursii.Location = new System.Drawing.Point(144, 141);
            this.btnExcursii.Name = "btnExcursii";
            this.btnExcursii.Size = new System.Drawing.Size(240, 55);
            this.btnExcursii.TabIndex = 2;
            this.btnExcursii.Text = "Excursii";
            this.btnExcursii.UseVisualStyleBackColor = true;
            this.btnExcursii.Click += new System.EventHandler(this.btnExcursii_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.Location = new System.Drawing.Point(144, 202);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(240, 52);
            this.btnIesire.TabIndex = 3;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // lblGhid
            // 
            this.lblGhid.AutoSize = true;
            this.lblGhid.Location = new System.Drawing.Point(141, 275);
            this.lblGhid.Name = "lblGhid";
            this.lblGhid.Size = new System.Drawing.Size(35, 13);
            this.lblGhid.TabIndex = 4;
            this.lblGhid.Text = "Ghid: ";
            // 
            // MeniuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 312);
            this.Controls.Add(this.lblGhid);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnExcursii);
            this.Controls.Add(this.btnGhid);
            this.Controls.Add(this.btnCalcul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MeniuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excursii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Button btnGhid;
        private System.Windows.Forms.Button btnExcursii;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Label lblGhid;
    }
}

