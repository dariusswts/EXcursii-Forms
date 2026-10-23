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
    public partial class MeniuForm : Form
    {
        public MeniuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculForm f = new CalculForm();
            f.Show();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGhid_Click(object sender, EventArgs e)
        {
            GhidForm f = new GhidForm();
            if (f.ShowDialog() == DialogResult.OK) { 
                lblGhid.Text="Ghid: "+f.Nume+" (" +f.Telefon+ ")";
                
            }
            
        }

        private void btnExcursii_Click(object sender, EventArgs e)
        {
           /// ExcursiiForm f = new ExcursiiForm();
           /// f.Show();
        }
    }
}
