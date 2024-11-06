using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmAssurance : Form
    {
        public frmAssurance()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            //if (VerifierSaisie())
            //{
            //    // Si la saisie est valide, exécute le reste du code
            //    string affichage = "Détails du Nouveau Véhicule : " +
            //                       Environment.NewLine + "Nom du Véhicule : " + txtNouveauVhc.Text +
            //                       Environment.NewLine + "Date de Première Immatriculation : " + txtDate1ereImat.Text +
            //                       Environment.NewLine + "Numéro d'Immatriculation : " + txtNumImmat.Text +
            //                       Environment.NewLine + "Numéro de Série : " + txtNumSerie.Text +
            //                       Environment.NewLine + "Puissance : " + txtPuissance.Text;

            //    string nvVehicule = txtNouveauVhc.Text;
            //    string Date1erImma = txtDate1ereImat.Text;
            //    string numImma = txtNumImmat.Text;
            //    string numSerie = txtNumSerie.Text;
            //    string Puissance = txtPuissance.Text;

            //    //foreach (Control xControl in gpbAgeVehicule.Controls)
            //    //{
            //    //    if (xControl is RadioButton)
            //    //    {
            //    //        RadioButton radioButton = xControl as RadioButton;

            //    //        if (radioButton.Checked)
            //    //        {
            //    //            Globales.btnAgeCocher = radioButton.Name;
            //    //            break;
            //    //        }
            //    //    }
            //    //}

            //    Globales.uneVoiture = new Voiture(nvVehicule, Date1erImma, numImma, numSerie, Puissance, Globales.btnAgeCocher);

            //    MessageBox.Show(affichage, "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAssurance_Load(object sender, EventArgs e)
        {
            lblVendeur.Text = Globales.nomVendeur;

            //if (Globales.uneVoiture != null)
            //{
            //    //foreach (Control xControl in gpbAgeVehicule.Controls)
            //    //{
            //    //    if (xControl is RadioButton radioButton)
            //    //    {

            //    //        if (radioButton.Name == Globales.btnAgeCocher)
            //    //        {
            //    //            radioButton.Checked = true;
            //    //            break; // Sort de la boucle une fois trouvé
            //    //        }
            //    //    }
            //    //}

            //    txtNouveauVhc.Text = Globales.uneVoiture.getnomvehicule();

            //    if (Globales.uneVoiture.getNumImma() != "44458884AE")
            //    {
            //        txtDate1ereImat.Text = Globales.uneVoiture.getDate1erImma();
            //        txtNumImmat.Text = Globales.uneVoiture.getNumImma();
            //        txtNumSerie.Text = Globales.uneVoiture.getnumSerie();
            //        txtPuissance.Text = Globales.uneVoiture.getPuissance();

            //    }

            //}
            //else if (!String.IsNullOrEmpty(Globales.btnAgeCocher))
            //{
            //    //foreach (Control xControl in gpbAgeVehicule.Controls)
            //    //{
            //    //    if (xControl is RadioButton radioButton)
            //    //    {

            //    //        if (radioButton.Name == Globales.btnAgeCocher)
            //    //        {
            //    //            radioButton.Checked = true;
            //    //            break; // Sort de la boucle une fois trouvé
            //    //        }
            //    //    }
            //    //}

            //}
        }
    }
}
