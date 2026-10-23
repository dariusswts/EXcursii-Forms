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
            
            double total = double.Parse(txtPretZi.Text) *
                    int.Parse(txtZile.Text) *
                    int.Parse(txtPersoane.Text);
            if (chkGrup.Checked) {
                total = total * 0.9;
            }
            lblTotal.Text = "Total: " + total + " lei";
        }
    }
}
