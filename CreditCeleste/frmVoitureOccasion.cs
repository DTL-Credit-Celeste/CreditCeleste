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
    public partial class frmVoitureOccasion : Form
    {
        public frmVoitureOccasion()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Globales.fenIntro = new frmIntro();
            Globales.fenIntro.FormClosed += new FormClosedEventHandler(FenVoitureOccasion_FormClosed);
            Globales.fenIntro.Show();

            this.Hide();
        }

        void FenVoitureOccasion_FormClosed(object sender, FormClosedEventArgs e)
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
        
                //if(!String.IsNullOrEmpty(Globales.uneVoiture.getnomvehicule()))
                //{
                //    txtNouvVhc.Text = Globales.uneVoiture.getnomvehicule();
                //}
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

        private void btnEnregistre_Click(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {

        }

        private void frmVoitureOccasion_Load(object sender, EventArgs e)
        {

        }

        private void btnAssurance_Click(object sender, EventArgs e)
        {
            Globales.fenAssurance = new frmAssurance();
            Globales.fenAssurance.FormClosed += new FormClosedEventHandler(FenAssurance_FormClosed);
            Globales.fenAssurance.Show();

            this.Hide();
        }

        void FenAssurance_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();

            //if (Globales.uneVoiture != null)
            //{
            //    foreach (Control xControl in gpbAgeVehicule.Controls)
            //    {
            //        if (xControl is RadioButton radioButton)
            //        {

            //            if (radioButton.Name == Globales.btnAgeCocher)
            //            {
            //                radioButton.Checked = true;
            //                break; // Sort de la boucle une fois trouvé
            //            }
            //        }
            //    }

            //    if (!String.IsNullOrEmpty(Globales.uneVoiture.getnomvehicule()))
            //    {
            //        txtNouvVhc.Text = Globales.uneVoiture.getnomvehicule();
            //    }
            //}
            //else if (!String.IsNullOrEmpty(Globales.btnAgeCocher))
            //{
            //    foreach (Control xControl in gpbAgeVehicule.Controls)
            //    {
            //        if (xControl is RadioButton radioButton)
            //        {

            //            if (radioButton.Name == Globales.btnAgeCocher)
            //            {
            //                radioButton.Checked = true;
            //                break; // Sort de la boucle une fois trouvé
            //            }
            //        }
            //    }

            //}
        }
    }
}
