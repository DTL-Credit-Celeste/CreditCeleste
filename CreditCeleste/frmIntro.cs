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
    public partial class frmIntro : Form
    {
        public frmIntro()
        {
            InitializeComponent();
        }

        private void frmIntro_Load(object sender, EventArgs e)
        {
            foreach(Vendeur unVendeur in Globales.uneConcession.getLesVendeurs())
            {
                cboVendeur.Items.Add(unVendeur.getInfoVendeur());
            }

            // pour récupérer les infos, repartir de la collection des vendeurs
            // le 2ème de la comboBox correspond au deuxième de la collection
            // la comboBox me sert à récupérer l'index
            //
            //      afficher sur tous les écrans le nom du vendeur
            // lblNomVendeur.Text

            if (Globales.uneVoiture != null)
            {
                foreach (Control xControl in gpbAgeVehicule.Controls)
                {
                    if (xControl is RadioButton radioButton)
                    {

                        if (radioButton.Name == Globales.btnAgeCocher)
                        {
                            radioButton.Checked = true;
                            break; // Sort de la boucle une fois trouvé
                        }
                    }
                }

            }
            else if (!String.IsNullOrEmpty(Globales.btnAgeCocher))
            {
                foreach (Control xControl in gpbAgeVehicule.Controls)
                {
                    if (xControl is RadioButton radioButton)
                    {

                        if (radioButton.Name == Globales.btnAgeCocher)
                        {
                            radioButton.Checked = true;
                            break; // Sort de la boucle une fois trouvé
                        }
                    }
                }

            }

            if (Globales.unClient != null)
            {
                // récupération des éléments du client

                cboCiv.Text = Globales.unClient.getCivClient();
                txtNom.Text = Globales.unClient.getNomClient();
                txtPrenom.Text = Globales.unClient.getPrenomClient();
            }
        }

        // Fonction pour vérifier si les saisies sont valides
        private bool VerifierSaisie()
        {
            if (string.IsNullOrWhiteSpace(cboCiv.Text) || string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text) || string.IsNullOrWhiteSpace(cboVendeur.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }

            bool radioSelected = false;
            foreach (Control xControl in gpbAgeVehicule.Controls)
            {
                if (xControl is RadioButton radioButton && radioButton.Checked)
                {
                    radioSelected = true;
                    break;
                }
            }

            if (!radioSelected)
            {
                MessageBox.Show("Veuillez sélectionner une option d'âge pour le véhicule.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }

            if (string.IsNullOrWhiteSpace(txtNouvVhc.Text) && string.IsNullOrWhiteSpace(txtAncVhc.Text))
            {
                MessageBox.Show("Veuillez entrer un véhicule (nouveau ou ancien).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }

            return true; 
        }

        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            // On vérifie la saisie avant de continuer
            if (!VerifierSaisie())
            {
                return; // Si la vérification échoue, on sort de la méthode
            }

            string civ = cboCiv.Text;
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            Globales.unClient = new Client(civ, nom, prenom);

            lblVendeur.Text = cboVendeur.Text;
            Globales.nomVendeur = lblVendeur.Text;

            string affichage = cboCiv.Text + " " + txtNom.Text + " " +txtPrenom.Text + Environment.NewLine + cboVendeur.Text;

            foreach (Control xControl in gpbAgeVehicule.Controls)
            {
                if (xControl is RadioButton radioButton && radioButton.Checked)
                {
                    Globales.btnAgeCocher = radioButton.Name;
                    affichage += Environment.NewLine + radioButton.Text;
                    break;
                }
            }

            if (!string.IsNullOrEmpty(txtNouvVhc.Text))
            {
                Globales.uneVoiture = new Voiture(txtNouvVhc.Text, Globales.btnAgeCocher);
            }
            else if (!string.IsNullOrEmpty(txtAncVhc.Text))
            {
                Globales.uneVoiture = new Voiture(txtAncVhc.Text, Globales.btnAgeCocher);
            }

            MessageBox.Show(affichage, "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnVoiture_Click(object sender, EventArgs e)
        {
            Globales.fenVoiture = new frmVoiture();
            Globales.fenVoiture.FormClosed += new FormClosedEventHandler(FenVoiture_FormClosed);
            Globales.fenVoiture.Show();

            this.Hide();
        }

        void FenVoiture_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();

            if (Globales.uneVoiture != null)
            {
                foreach (Control xControl in gpbAgeVehicule.Controls)
                {
                    if (xControl is RadioButton radioButton)
                    {

                        if (radioButton.Name == Globales.btnAgeCocher)
                        {
                            radioButton.Checked = true;
                            break; // Sort de la boucle une fois trouvé
                        }
                    }
                }

                if(!String.IsNullOrEmpty(Globales.uneVoiture.getnomvehicule()))
                {
                    txtNouvVhc.Text = Globales.uneVoiture.getnomvehicule();
                }
            }
            else if (!String.IsNullOrEmpty(Globales.btnAgeCocher))
            {
                foreach (Control xControl in gpbAgeVehicule.Controls)
                {
                    if (xControl is RadioButton radioButton)
                    {

                        if (radioButton.Name == Globales.btnAgeCocher)
                        {
                            radioButton.Checked = true;
                            break; // Sort de la boucle une fois trouvé
                        }
                    }
                }

            }
        }

        private void cboVendeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lblVendeur.Text = Globales.uneConcession.getLesVendeurs()[0].getInfoVendeur();

            // lblVendeur.Text = Globales.uneConcession.getLesVendeurs()[cboVendeur.SelectedIndex].getInfoVendeur();

            lblVendeur.Text = Globales.uneConcession.getLesVendeurs()[cboVendeur.SelectedIndex].getInfoVendeur();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
