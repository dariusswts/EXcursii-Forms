using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excursii
{
    public partial class CalculForm : Form
    {
        public CalculForm()
        {
            InitializeComponent();
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            double pret=0;
            int zile=0;
            int persoane=0;
            if (double.TryParse(txtPretZi.Text,out pret)==false) {
                MessageBox.Show("Introdu corect pretul!!");
                return;
            }
            if (int.TryParse(txtZile.Text, out zile) == false) {
                MessageBox.Show("Introdu un numar de zile corect !!");
                return;
            }
            if (int.TryParse(txtPersoane.Text, out persoane) == false) {
                MessageBox.Show("Introdu un numar de persoane corect");
                return;
            }

            double total = pret * zile * persoane;
            
            
            if (chkGrup.Checked) {
                total = total * 0.9;
            }
            lblTotal.Text = "Total: " + total + " lei";
        }
    }
}
