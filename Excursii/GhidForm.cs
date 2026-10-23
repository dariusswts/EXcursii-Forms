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
    public partial class GhidForm : Form
    {
        public GhidForm()
        {
            InitializeComponent();
        }

        private void GhidForm_Load(object sender, EventArgs e)
        {

        }

        public string Nume {
            get { return txtNume.Text; }
        }




        public string Telefon {
            get { return txtTelefon.Text; }
            }
        }
    }
 

