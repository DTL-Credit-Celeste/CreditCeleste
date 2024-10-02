using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCeleste
{
    class Voiture
    {
        private string nvVehicule = "PG 208";
        private string Date1erImma = "17/07/2005";
        private string numImma = "44458884AE";
        private string numSerie = "12345777";
        private string Puissance = "17ch";
        private string rdAge;


        public Voiture()
        {

        }

        public Voiture(string nvVH, string rdAge)
        {
            nvVehicule = nvVH;

            this.rdAge = rdAge;
        }

        public Voiture(string nvVH, string Date1Imma, string numI, string numS, string xPuissance, string rdAge)
        {
            nvVehicule = nvVH;
            Date1erImma = Date1Imma;
            numImma = numI;
            numSerie = numS;
            Puissance = xPuissance;

            this.rdAge = rdAge;
        }

        public string getnomvehicule() { return nvVehicule; }  
        public string getDate1erImma() { return Date1erImma; }
        public string getnumSerie() { return numSerie; }
        public string getPuissance() { return Puissance; }
        public string getrdAge() { return rdAge; }
        public string getNumImma() { return numImma; }
        
    }


}
