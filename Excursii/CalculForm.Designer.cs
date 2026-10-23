namespace Excursii
{
    partial class CalculForm
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
            this.txtPretZi = new System.Windows.Forms.TextBox();
            this.txtZile = new System.Windows.Forms.TextBox();
            this.txtPersoane = new System.Windows.Forms.TextBox();
            this.chkGrup = new System.Windows.Forms.CheckBox();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPretZi
            // 
            this.txtPretZi.Location = new System.Drawing.Point(32, 42);
            this.txtPretZi.Name = "txtPretZi";
            this.txtPretZi.Size = new System.Drawing.Size(100, 20);
            this.txtPretZi.TabIndex = 0;
            // 
            // txtZile
            // 
            this.txtZile.Location = new System.Drawing.Point(32, 92);
            this.txtZile.Name = "txtZile";
            this.txtZile.Size = new System.Drawing.Size(100, 20);
            this.txtZile.TabIndex = 1;
            // 
            // txtPersoane
            // 
            this.txtPersoane.Location = new System.Drawing.Point(32, 135);
            this.txtPersoane.Name = "txtPersoane";
            this.txtPersoane.Size = new System.Drawing.Size(100, 20);
            this.txtPersoane.TabIndex = 2;
            // 
            // chkGrup
            // 
            this.chkGrup.AutoSize = true;
            this.chkGrup.Location = new System.Drawing.Point(141, 191);
            this.chkGrup.Name = "chkGrup";
            this.chkGrup.Size = new System.Drawing.Size(135, 17);
            this.chkGrup.TabIndex = 3;
            this.chkGrup.Text = "Reducere de grup 10%";
            this.chkGrup.UseVisualStyleBackColor = true;
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.Location = new System.Drawing.Point(32, 235);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(277, 35);
            this.btnCalculeaza.TabIndex = 4;
            this.btnCalculeaza.Text = "Calculeaza";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(29, 195);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pret pe zi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Persoane";
            // 
            // CalculForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalculeaza);
            this.Controls.Add(this.chkGrup);
            this.Controls.Add(this.txtPersoane);
            this.Controls.Add(this.txtZile);
            this.Controls.Add(this.txtPretZi);
            this.Name = "CalculForm";
            this.Text = "CalculForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretZi;
        private System.Windows.Forms.TextBox txtZile;
        private System.Windows.Forms.TextBox txtPersoane;
        private System.Windows.Forms.CheckBox chkGrup;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}