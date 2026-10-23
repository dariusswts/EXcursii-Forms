using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excursii
{
    public partial class ExcursiiForm : Form
    {
        public List<Excursie> lista = new List<Excursie>();
        public ExcursiiForm()
        {
            InitializeComponent();
           
             
        }

        public void LoadExcursii()
        {
            lista.Clear();
            lista = DateExcursii();
        }
        


        private List<Excursie> DateExcursii()
        {
            Excursie e1 = new Excursie();
            e1.destinatie = "Roma";
            e1.tara = "Italia";
            e1.zile = 4;
            e1.pretPeZi = 250;
            e1.locuri = 12;
            e1.confirmata = true;


            Excursie e2 = new Excursie();
            e2.destinatie = "Paris";
            e2.tara = "Franta";
            e2.zile = 4;
            e2.pretPeZi = 300;
            e2.locuri = 20;
            e2.confirmata = true;
            Excursie e3 = new Excursie();
            e3.destinatie = "Barcelona";
            e3.tara = "Spania";
            e3.zile = 5;
            e3.pretPeZi = 220;
            e3.locuri = 15;
            e3.confirmata = true;

            Excursie e4 = new Excursie();
            e4.destinatie = "Viena";
            e4.tara = "Austria";
            e4.zile = 3;
            e4.pretPeZi = 180;
            e4.locuri = 25;
            e4.confirmata = true;

            Excursie e5 = new Excursie();
            e5.destinatie = "Praga";
            e5.tara = "Cehia";
            e5.zile = 4;
            e5.pretPeZi = 140;
            e5.locuri = 18;
            e5.confirmata = false;

            Excursie e6 = new Excursie();
            e6.destinatie = "Atena";
            e6.tara = "Grecia";
            e6.zile = 6;
            e6.pretPeZi = 190;
            e6.locuri = 30;
            e6.confirmata = true;

            Excursie e7 = new Excursie();
            e7.destinatie = "Amsterdam";
            e7.tara = "Olanda";
            e7.zile = 4;
            e7.pretPeZi = 320;
            e7.locuri = 10;
            e7.confirmata = false;

            Excursie e8 = new Excursie();
            e8.destinatie = "Londra";
            e8.tara = "Marea Britanie";
            e8.zile = 5;
            e8.pretPeZi = 350;
            e8.locuri = 22;
            e8.confirmata = true;

            Excursie e9 = new Excursie();
            e9.destinatie = "Lisabona";
            e9.tara = "Portugalia";
            e9.zile = 5;
            e9.pretPeZi = 200;
            e9.locuri = 14;
            e9.confirmata = true;

            Excursie e10 = new Excursie();
            e10.destinatie = "Budapesta";
            e10.tara = "Ungaria";
            e10.zile = 3;
            e10.pretPeZi = 130;
            e10.locuri = 40;
            e10.confirmata = true;


            lista.Add(e1);
            lista.Add(e2);
            lista.Add(e3);
            lista.Add(e4);
            lista.Add(e5);
            lista.Add(e6);
            lista.Add(e7);
            lista.Add(e8);
            lista.Add(e9);
            lista.Add(e10);
        
            return lista;
        }


        private void ExcursiiForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIncarca_Click(object sender, EventArgs e)
        {
            lstExcursii.ClearSelected();
            LoadExcursii();
            for(int i = 0; i < lista.Count; i++)
            {
                lstExcursii.Items.Add(lista[i].destinatie + "- (" + lista[i].tara + ") -" + lista[i].zile + " zile-" + lista[i].pretPeZi);
            }
            lblStare.Text = "Numar excursii: " + lista.Count; 
        }

        private void s(object sender, MouseEventArgs e)
        {

            

        }

        private void lstExcursii_SelectedIndexChanged(object sender, EventArgs e)
        {
            int poz = lstExcursii.SelectedIndex;



            txtDetalii.Text = lista[poz].Desriere();
        }
    }
}
