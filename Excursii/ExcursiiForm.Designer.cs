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
            this.txtDetalii = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDetali = new System.Windows.Forms.Button();
            this.btnGhid = new System.Windows.Forms.Button();
            this.btnBuget = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstExcursii
            // 
            this.lstExcursii.FormattingEnabled = true;
            this.lstExcursii.Location = new System.Drawing.Point(7, 12);
            this.lstExcursii.Name = "lstExcursii";
            this.lstExcursii.Size = new System.Drawing.Size(291, 134);
            this.lstExcursii.TabIndex = 0;
            this.lstExcursii.MouseClick += new System.Windows.Forms.MouseEventHandler(this.s);
            this.lstExcursii.SelectedIndexChanged += new System.EventHandler(this.lstExcursii_SelectedIndexChanged);
            // 
            // btnIncarca
            // 
            this.btnIncarca.Location = new System.Drawing.Point(7, 165);
            this.btnIncarca.Name = "btnIncarca";
            this.btnIncarca.Size = new System.Drawing.Size(154, 44);
            this.btnIncarca.TabIndex = 1;
            this.btnIncarca.Text = "Incarca Lista";
            this.btnIncarca.UseVisualStyleBackColor = true;
            this.btnIncarca.Click += new System.EventHandler(this.btnIncarca_Click);
            // 
            // lblStare
            // 
            this.lblStare.AutoSize = true;
            this.lblStare.Location = new System.Drawing.Point(304, 9);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(35, 13);
            this.lblStare.TabIndex = 2;
            this.lblStare.Text = "label1";
            // 
            // txtDetalii
            // 
            this.txtDetalii.Location = new System.Drawing.Point(534, 12);
            this.txtDetalii.Multiline = true;
            this.txtDetalii.Name = "txtDetalii";
            this.txtDetalii.ReadOnly = true;
            this.txtDetalii.Size = new System.Drawing.Size(254, 117);
            this.txtDetalii.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(781, 173);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnDetali
            // 
            this.btnDetali.Location = new System.Drawing.Point(12, 215);
            this.btnDetali.Name = "btnDetali";
            this.btnDetali.Size = new System.Drawing.Size(106, 44);
            this.btnDetali.TabIndex = 5;
            this.btnDetali.Text = "Detalii";
            this.btnDetali.UseVisualStyleBackColor = true;
            this.btnDetali.Click += new System.EventHandler(this.btnDetali_Click);
            // 
            // btnGhid
            // 
            this.btnGhid.Location = new System.Drawing.Point(140, 215);
            this.btnGhid.Name = "btnGhid";
            this.btnGhid.Size = new System.Drawing.Size(98, 44);
            this.btnGhid.TabIndex = 6;
            this.btnGhid.Text = "Alege Ghid";
            this.btnGhid.UseVisualStyleBackColor = true;
            // 
            // btnBuget
            // 
            this.btnBuget.Location = new System.Drawing.Point(534, 219);
            this.btnBuget.Name = "btnBuget";
            this.btnBuget.Size = new System.Drawing.Size(110, 40);
            this.btnBuget.TabIndex = 7;
            this.btnBuget.Text = "BUGET";
            this.btnBuget.UseVisualStyleBackColor = true;
            // 
            // ExcursiiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuget);
            this.Controls.Add(this.btnGhid);
            this.Controls.Add(this.btnDetali);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDetalii);
            this.Controls.Add(this.lblStare);
            this.Controls.Add(this.btnIncarca);
            this.Controls.Add(this.lstExcursii);
            this.Name = "ExcursiiForm";
            this.Text = "ExcursiiForm";
            this.Load += new System.EventHandler(this.ExcursiiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstExcursii;
        private System.Windows.Forms.Button btnIncarca;
        private System.Windows.Forms.Label lblStare;
        private System.Windows.Forms.TextBox txtDetalii;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDetali;
        private System.Windows.Forms.Button btnGhid;
        private System.Windows.Forms.Button btnBuget;
    }
}