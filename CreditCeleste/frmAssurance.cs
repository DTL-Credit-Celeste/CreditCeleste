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
            // LA PRECEDENTE PAGE DOIT ETRE SAUVEGARDER CAR POUR LINSTANT CA VA SUR INTRODUCTION

            Globales.fenIntro = new frmIntro();
            Globales.fenIntro.FormClosed += new FormClosedEventHandler(FenIntro_FormClosed);
            Globales.fenIntro.Show();

            this.Hide();
        }

        void FenIntro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();

            if (Globales.uneVoiture != null)
            {
                foreach (Control xControl in gpbDureeAssurance.Controls)
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

                //if (!String.IsNullOrEmpty(Globales.uneVoiture.getnomvehicule()))
                //{
                //    txtNouvVhc.Text = Globales.uneVoiture.getnomvehicule();
                //}
            }
            else if (!String.IsNullOrEmpty(Globales.btnAgeCocher))
            {
                foreach (Control xControl in gpbDureeAssurance.Controls)
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
    }
}
