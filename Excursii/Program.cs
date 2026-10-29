using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excursii
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MeniuForm());
            
            Excursie x = new Excursie();
            x.destinatie = "Sagrada Familia";
            x.tara = "Spania";
            x.zile = 4;
            x.pretPeZi = 100;
            x.confirmata = true;
            x.locuri = 25;
            x.ghid = "Danut ";

            Excursie a = new Excursie("destinatie exemplu");
      
            a.tara = "Brazilia";
            a.zile = 14;
            a.pretPeZi = 148;
            a.confirmata = false;
            a.locuri = 40;
            a.ghid = "Darius";

            Excursie b=new Excursie("Paris","Frata",4,80,80,true,"Maria");

            Console.WriteLine(b.Desriere());
            

            


            
        }
    
       


    }
}
