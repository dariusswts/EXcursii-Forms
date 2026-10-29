using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Excursii
{
    public class Excursie
    {
        public string destinatie;
        public string tara;
        public int zile;
        public double pretPeZi;
        public int locuri;
        public bool confirmata;

        public string ghid;



        public double calcultotal()
        {
            return zile * pretPeZi;
        }
        public string afisare()
        {
            return destinatie + " (" + tara + ") - " + zile + "zile - " + calcultotal() + " lei ";
        }
        public string Desriere()
        {
            string text = "Destinatie: " + destinatie + ", " + tara + "\n";
            text = text + "Durata: " + zile + " zile" + "\n";
            text = text + "Total: " + calcultotal() + " lei" + "\n";
            text = text + "Locuri libere: " + locuri;
            if (confirmata == true)
            {
                text = text + "Confirmata:  da ";
            }
            else
            {
                text = text + "Confirmata:  da ";
            }
            return text;
        }


    }
}
