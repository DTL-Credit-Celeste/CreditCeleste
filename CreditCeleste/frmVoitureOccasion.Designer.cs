
namespace CreditCeleste
{
    partial class frmVoitureOccasion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVendeur = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnEnregistre = new System.Windows.Forms.Button();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtNumImmat = new System.Windows.Forms.TextBox();
            this.txtChoixVhcOcca = new System.Windows.Forms.TextBox();
            this.txtDate1ereImat = new System.Windows.Forms.TextBox();
            this.txtPuissance = new System.Windows.Forms.TextBox();
            this.gpbAgeVehicule = new System.Windows.Forms.GroupBox();
            this.rdbOccas5OuPlus = new System.Windows.Forms.RadioButton();
            this.rdbOccas3a5 = new System.Windows.Forms.RadioButton();
            this.rdbOccasMoins3 = new System.Windows.Forms.RadioButton();
            this.btnAssurance = new System.Windows.Forms.Button();
            this.gpbAgeVehicule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVendeur
            // 
            this.lblVendeur.AutoSize = true;
            this.lblVendeur.Location = new System.Drawing.Point(114, 189);
            this.lblVendeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendeur.Name = "lblVendeur";
            this.lblVendeur.Size = new System.Drawing.Size(12, 17);
            this.lblVendeur.TabIndex = 41;
            this.lblVendeur.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Vendeur:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Puissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Numéro de série";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Numéro Immatriculation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Date 1ère Immatriculation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Choix Véhicule Occasion";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(460, 285);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(175, 35);
            this.btnValider.TabIndex = 34;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(13, 285);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(100, 35);
            this.btnInfo.TabIndex = 33;
            this.btnInfo.Text = "Retour";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnEnregistre
            // 
            this.btnEnregistre.Location = new System.Drawing.Point(352, 285);
            this.btnEnregistre.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistre.Name = "btnEnregistre";
            this.btnEnregistre.Size = new System.Drawing.Size(100, 35);
            this.btnEnregistre.TabIndex = 32;
            this.btnEnregistre.Text = "Enregistrer";
            this.btnEnregistre.UseVisualStyleBackColor = true;
            this.btnEnregistre.Click += new System.EventHandler(this.btnEnregistre_Click);
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(190, 73);
            this.txtNumSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(132, 22);
            this.txtNumSerie.TabIndex = 31;
            // 
            // txtNumImmat
            // 
            this.txtNumImmat.Location = new System.Drawing.Point(190, 43);
            this.txtNumImmat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumImmat.Name = "txtNumImmat";
            this.txtNumImmat.Size = new System.Drawing.Size(132, 22);
            this.txtNumImmat.TabIndex = 30;
            // 
            // txtChoixVhcOcca
            // 
            this.txtChoixVhcOcca.Location = new System.Drawing.Point(503, 13);
            this.txtChoixVhcOcca.Margin = new System.Windows.Forms.Padding(4);
            this.txtChoixVhcOcca.Name = "txtChoixVhcOcca";
            this.txtChoixVhcOcca.Size = new System.Drawing.Size(132, 22);
            this.txtChoixVhcOcca.TabIndex = 29;
            // 
            // txtDate1ereImat
            // 
            this.txtDate1ereImat.Location = new System.Drawing.Point(190, 13);
            this.txtDate1ereImat.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate1ereImat.Name = "txtDate1ereImat";
            this.txtDate1ereImat.Size = new System.Drawing.Size(132, 22);
            this.txtDate1ereImat.TabIndex = 28;
            // 
            // txtPuissance
            // 
            this.txtPuissance.Location = new System.Drawing.Point(190, 103);
            this.txtPuissance.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuissance.Name = "txtPuissance";
            this.txtPuissance.Size = new System.Drawing.Size(132, 22);
            this.txtPuissance.TabIndex = 27;
            // 
            // gpbAgeVehicule
            // 
            this.gpbAgeVehicule.Controls.Add(this.rdbOccas5OuPlus);
            this.gpbAgeVehicule.Controls.Add(this.rdbOccas3a5);
            this.gpbAgeVehicule.Controls.Add(this.rdbOccasMoins3);
            this.gpbAgeVehicule.Location = new System.Drawing.Point(344, 163);
            this.gpbAgeVehicule.Margin = new System.Windows.Forms.Padding(4);
            this.gpbAgeVehicule.Name = "gpbAgeVehicule";
            this.gpbAgeVehicule.Padding = new System.Windows.Forms.Padding(4);
            this.gpbAgeVehicule.Size = new System.Drawing.Size(291, 114);
            this.gpbAgeVehicule.TabIndex = 26;
            this.gpbAgeVehicule.TabStop = false;
            this.gpbAgeVehicule.Text = "Age du véhicule";
            // 
            // rdbOccas5OuPlus
            // 
            this.rdbOccas5OuPlus.AutoSize = true;
            this.rdbOccas5OuPlus.Location = new System.Drawing.Point(8, 81);
            this.rdbOccas5OuPlus.Margin = new System.Windows.Forms.Padding(4);
            this.rdbOccas5OuPlus.Name = "rdbOccas5OuPlus";
            this.rdbOccas5OuPlus.Size = new System.Drawing.Size(115, 21);
            this.rdbOccas5OuPlus.TabIndex = 3;
            this.rdbOccas5OuPlus.Text = "Plus de 5 ans";
            this.rdbOccas5OuPlus.UseVisualStyleBackColor = true;
            // 
            // rdbOccas3a5
            // 
            this.rdbOccas3a5.AutoSize = true;
            this.rdbOccas3a5.Location = new System.Drawing.Point(8, 52);
            this.rdbOccas3a5.Margin = new System.Windows.Forms.Padding(4);
            this.rdbOccas3a5.Name = "rdbOccas3a5";
            this.rdbOccas3a5.Size = new System.Drawing.Size(88, 21);
            this.rdbOccas3a5.TabIndex = 2;
            this.rdbOccas3a5.Text = "3 à 5 ans";
            this.rdbOccas3a5.UseVisualStyleBackColor = true;
            // 
            // rdbOccasMoins3
            // 
            this.rdbOccasMoins3.AutoSize = true;
            this.rdbOccasMoins3.Location = new System.Drawing.Point(8, 23);
            this.rdbOccasMoins3.Margin = new System.Windows.Forms.Padding(4);
            this.rdbOccasMoins3.Name = "rdbOccasMoins3";
            this.rdbOccasMoins3.Size = new System.Drawing.Size(125, 21);
            this.rdbOccasMoins3.TabIndex = 1;
            this.rdbOccasMoins3.Text = "Moins de 3 ans";
            this.rdbOccasMoins3.UseVisualStyleBackColor = true;
            // 
            // btnAssurance
            // 
            this.btnAssurance.Location = new System.Drawing.Point(121, 285);
            this.btnAssurance.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssurance.Name = "btnAssurance";
            this.btnAssurance.Size = new System.Drawing.Size(100, 35);
            this.btnAssurance.TabIndex = 42;
            this.btnAssurance.Text = "Assurance";
            this.btnAssurance.UseVisualStyleBackColor = true;
            this.btnAssurance.Click += new System.EventHandler(this.btnAssurance_Click);
            // 
            // frmVoitureOccasion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 333);
            this.Controls.Add(this.btnAssurance);
            this.Controls.Add(this.lblVendeur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnEnregistre);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.txtNumImmat);
            this.Controls.Add(this.txtChoixVhcOcca);
            this.Controls.Add(this.txtDate1ereImat);
            this.Controls.Add(this.txtPuissance);
            this.Controls.Add(this.gpbAgeVehicule);
            this.Name = "frmVoitureOccasion";
            this.ShowIcon = false;
            this.Text = "Credit Celeste - Voiture Occasion";
            this.Load += new System.EventHandler(this.frmVoitureOccasion_Load);
            this.gpbAgeVehicule.ResumeLayout(false);
            this.gpbAgeVehicule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendeur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnEnregistre;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtNumImmat;
        private System.Windows.Forms.TextBox txtChoixVhcOcca;
        private System.Windows.Forms.TextBox txtDate1ereImat;
        private System.Windows.Forms.TextBox txtPuissance;
        private System.Windows.Forms.GroupBox gpbAgeVehicule;
        private System.Windows.Forms.RadioButton rdbOccas5OuPlus;
        private System.Windows.Forms.RadioButton rdbOccas3a5;
        private System.Windows.Forms.RadioButton rdbOccasMoins3;
        private System.Windows.Forms.Button btnAssurance;
    }
}