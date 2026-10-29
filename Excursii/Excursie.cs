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

      //  "Paris,Franta,5,300,20,true,Ana".split() => ["Paris","Franta","5","300"
      
        public Excursie(String text)
        {
            string[]campuri= text.Split(',');

            destinatie=campuri[0];
            tara=campuri[1];
            zile = int.Parse(campuri[2]);
            pretPeZi=int.Parse(campuri[3] );
            locuri = int.Parse(campuri[4]);
            confirmata =bool.Parse(campuri[5]);
            ghid=campuri[6];

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
