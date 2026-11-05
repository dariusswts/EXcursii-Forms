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
    public partial class DetaliiForm : Form
    {
        public Excursie excursie;
        public DetaliiForm()
        {
            InitializeComponent();
        }


        public DetaliiForm(Excursie e)
        {
            InitializeComponent();

            excursie = e;

            Text = excursie.destinatie + " " + excursie.tara;

            lblZile.Text =e.zile.ToString();
            lblPretPeZi.Text=e.pretPeZi.ToString();
            lblLocuri.Text =e.locuri.ToString();
            lblConfirmata.Text =e.confirmata.ToString();
            lblGhid.Text = e.ghid;



        }

        private void DetaliiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
