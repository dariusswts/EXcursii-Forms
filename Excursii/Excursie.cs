using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//cONSTRUCTORUL este o functie ce are aceasi nume ca si clasa 
// nu are tip returnat
// se apeleaza automat la instantiere(new)
// se poate supraincarca
namespace Excursii
{
    public class Excursie
    {  //atributele
        public string destinatie;
        public string tara;
        public int zile;
        public double pretPeZi;
        public int locuri;
        public bool confirmata;

        public string ghid;

      //  constructori
        public Excursie()
        {
            Console.WriteLine("Ce mai faci");

        }


        public Excursie(String destinatiaNou)
        {
            this.destinatie = destinatiaNou;

        }

       public Excursie(String destinatieNou,String taraNou,int zileNou,double pretPeZiNou,int locuriNou,bool confirmataN,string ghid)
        {
            this.destinatie = destinatieNou;
            this.tara=taraNou;
            this.zile=zileNou;
            this.pretPeZi=pretPeZiNou;
            this.locuri=locuriNou;
            this.confirmata=confirmataN;
        }


        

        //metodele 

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
