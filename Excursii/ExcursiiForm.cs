using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
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
            CreateColumns();


        }

   
   

        public  void  IncarcaExcursiiFisier()
        {

            this.lista.Clear();
            
            StreamReader streamreadear = new StreamReader("excursii.txt");
            string linie;
            
            while ((linie=streamreadear.ReadLine()) != null) {
                Excursie a = new Excursie(linie);
                this.lista.Add(a);

            }
        }

        

        private void ExcursiiForm_Load(object sender, EventArgs e)
        {

        }

        private void btnIncarca_Click(object sender, EventArgs e)
        {

            IncarcaLista();
            IncarcaDataGridView();
        }

        private void s(object sender, MouseEventArgs e)
        {



        }

        private void lstExcursii_SelectedIndexChanged(object sender, EventArgs e)
        {
            
              int poz = lstExcursii.SelectedIndex;

              if (poz >= 0 && poz < lista.Count)
              {
                  txtDetalii.Text = lista[poz].Desriere();
              }
            
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("destinatie", "Destinatie");
            dataGridView1.Columns.Add("tara", "Tara");
            dataGridView1.Columns.Add("zile", "Zile");
            dataGridView1.Columns.Add("pretPeZi", "Pret pe zi");
            dataGridView1.Columns.Add("locuri", "Locuri");
            dataGridView1.Columns.Add("confirmata", "Confirmata");
            dataGridView1.Columns.Add("ghid", "Ghid");

            

        }

        private void btnDetali_Click(object sender, EventArgs e)
        {
            int poz = lstExcursii.SelectedIndex;
            
          
            if (poz == -1)
            {
                MessageBox.Show("nu ai selectat nici o excurisie");
            }
            else
            {
                Excursie exc = lista[poz];
                DetaliiForm d = new DetaliiForm(exc);

                d.ShowDialog();
            }
            

         

            

        }

        public void IncarcaDataGridView()
        {

            dataGridView1.Rows.Clear();

            IncarcaExcursiiFisier();

            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add(
                    lista[i].destinatie,
                    lista[i].tara,
                    lista[i].zile,
                    lista[i].pretPeZi,
                    lista[i].locuri,
                    lista[i].confirmata,
                    lista[i].ghid
                );
            }
        }


        public void IncarcaLista()
        {
            lstExcursii.Items.Clear();
            IncarcaExcursiiFisier();
            for (int i = 0; i < lista.Count; i++)
            {
                lstExcursii.Items.Add(lista[i].destinatie + "- (" + lista[i].tara + ") -" + lista[i].zile + " zile-" + lista[i].pretPeZi);
            }
            lblStare.Text = "Numar excursii: " + lista.Count;
        }
    }
    
}
