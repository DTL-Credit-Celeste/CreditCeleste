﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    static class Globales   // pas la peine de faire un new, classe statique
    {
        // DTLA = Daniels, Thierry, Ludo, Alexandru

        // public string nomUtilisateur = "DTLA";      // un seul ;    attribut de l'objet

        // utilisateur et region
        public static string nomUtilisateur = "DTLA";   // un seul ;    attribut de classe
        public static string region = "Alsace";

        // forms
        public static frmAccueil fenAccueil;
        public static frmIntro fenIntro;
        public static frmVoiture fenVoiture;
        public static frmVoitureOccasion fenVoitureOccasion;
        public static frmAssurance fenAssurance;

        // autre
        public static Concession uneConcession;
        public static Client unClient;
        public static Voiture uneVoiture;

        public static string nomVendeur;
        public static string btnAgeCocher;
    }
}
