using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    static class Globales   // pas la peine de faire un new, classe statique
    {

        // public string nomUtilisateur = "Soares";      // un seul ;    attribut de l'objet

        public static string nomUtilisateur = "Soares";  // un seul ;    attribut de classe
        public static string region = "Alsace";
        public static frmIntro fenIntro;
        public static frmAccueil fenAccueil;
        public static frmVoiture fenVoiture;
        public static Concession uneConcession;
        public static Voiture uneVoiture;
        public static Client unClient;
        public static string nomVendeur;
        public static string btnAgeCocher;
    }
}
