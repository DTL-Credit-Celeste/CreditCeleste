namespace CreditCeleste
{
    partial class frmVoiture
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
            this.gpbAgeVehicule = new System.Windows.Forms.GroupBox();
            this.rdbOccas5OuPlus = new System.Windows.Forms.RadioButton();
            this.rdbOccas3a5 = new System.Windows.Forms.RadioButton();
            this.rdbOccasMoins3 = new System.Windows.Forms.RadioButton();
            this.rdbNeuf = new System.Windows.Forms.RadioButton();
            this.txtNumImmat = new System.Windows.Forms.TextBox();
            this.txtNouveauVhc = new System.Windows.Forms.TextBox();
            this.txtDate1ereImat = new System.Windows.Forms.TextBox();
            this.txtPuissance = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnEnregistre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVendeur = new System.Windows.Forms.Label();
            this.gpbAgeVehicule.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAgeVehicule
            // 
            this.gpbAgeVehicule.Controls.Add(this.rdbOccas5OuPlus);
            this.gpbAgeVehicule.Controls.Add(this.rdbOccas3a5);
            this.gpbAgeVehicule.Controls.Add(this.rdbOccasMoins3);
            this.gpbAgeVehicule.Controls.Add(this.rdbNeuf);
            this.gpbAgeVehicule.Location = new System.Drawing.Point(250, 29);
            this.gpbAgeVehicule.Name = "gpbAgeVehicule";
            this.gpbAgeVehicule.Size = new System.Drawing.Size(218, 117);
            this.gpbAgeVehicule.TabIndex = 9;
            this.gpbAgeVehicule.TabStop = false;
            this.gpbAgeVehicule.Text = "Age du véhicule";
            // 
            // rdbOccas5OuPlus
            // 
            this.rdbOccas5OuPlus.AutoSize = true;
            this.rdbOccas5OuPlus.Location = new System.Drawing.Point(6, 89);
            this.rdbOccas5OuPlus.Name = "rdbOccas5OuPlus";
            this.rdbOccas5OuPlus.Size = new System.Drawing.Size(136, 17);
            this.rdbOccas5OuPlus.TabIndex = 3;
            this.rdbOccas5OuPlus.Text = "Occasion 5 ans ou plus";
            this.rdbOccas5OuPlus.UseVisualStyleBackColor = true;
            // 
            // rdbOccas3a5
            // 
            this.rdbOccas3a5.AutoSize = true;
            this.rdbOccas3a5.Location = new System.Drawing.Point(6, 66);
            this.rdbOccas3a5.Name = "rdbOccas3a5";
            this.rdbOccas3a5.Size = new System.Drawing.Size(132, 17);
            this.rdbOccas3a5.TabIndex = 2;
            this.rdbOccas3a5.Text = "Occasion de 3 à 5 ans";
            this.rdbOccas3a5.UseVisualStyleBackColor = true;
            // 
            // rdbOccasMoins3
            // 
            this.rdbOccasMoins3.AutoSize = true;
            this.rdbOccasMoins3.Location = new System.Drawing.Point(6, 42);
            this.rdbOccasMoins3.Name = "rdbOccasMoins3";
            this.rdbOccasMoins3.Size = new System.Drawing.Size(120, 17);
            this.rdbOccasMoins3.TabIndex = 1;
            this.rdbOccasMoins3.Text = "Occasion - de 3 ans";
            this.rdbOccasMoins3.UseVisualStyleBackColor = true;
            // 
            // rdbNeuf
            // 
            this.rdbNeuf.AutoSize = true;
            this.rdbNeuf.Location = new System.Drawing.Point(6, 19);
            this.rdbNeuf.Name = "rdbNeuf";
            this.rdbNeuf.Size = new System.Drawing.Size(48, 17);
            this.rdbNeuf.TabIndex = 0;
            this.rdbNeuf.Text = "Neuf";
            this.rdbNeuf.UseVisualStyleBackColor = true;
            // 
            // txtNumImmat
            // 
            this.txtNumImmat.Location = new System.Drawing.Point(142, 29);
            this.txtNumImmat.Name = "txtNumImmat";
            this.txtNumImmat.Size = new System.Drawing.Size(100, 20);
            this.txtNumImmat.TabIndex = 14;
            // 
            // txtNouveauVhc
            // 
            this.txtNouveauVhc.Location = new System.Drawing.Point(369, 5);
            this.txtNouveauVhc.Name = "txtNouveauVhc";
            this.txtNouveauVhc.Size = new System.Drawing.Size(100, 20);
            this.txtNouveauVhc.TabIndex = 13;
            // 
            // txtDate1ereImat
            // 
            this.txtDate1ereImat.Location = new System.Drawing.Point(142, 5);
            this.txtDate1ereImat.Name = "txtDate1ereImat";
            this.txtDate1ereImat.Size = new System.Drawing.Size(100, 20);
            this.txtDate1ereImat.TabIndex = 12;
            // 
            // txtPuissance
            // 
            this.txtPuissance.Location = new System.Drawing.Point(142, 78);
            this.txtPuissance.Name = "txtPuissance";
            this.txtPuissance.Size = new System.Drawing.Size(100, 20);
            this.txtPuissance.TabIndex = 11;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(142, 54);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(100, 20);
            this.txtNumSerie.TabIndex = 15;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(394, 154);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 20);
            this.btnValider.TabIndex = 18;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 154);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(74, 20);
            this.btnInfo.TabIndex = 17;
            this.btnInfo.Text = "Introduction";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // btnEnregistre
            // 
            this.btnEnregistre.Location = new System.Drawing.Point(318, 154);
            this.btnEnregistre.Name = "btnEnregistre";
            this.btnEnregistre.Size = new System.Drawing.Size(74, 20);
            this.btnEnregistre.TabIndex = 16;
            this.btnEnregistre.Text = "Enregistrer";
            this.btnEnregistre.UseVisualStyleBackColor = true;
            this.btnEnregistre.Click += new System.EventHandler(this.btnEnregistre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mon Nouveau Véhicule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Date 1ère Immatriculation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Numéro Immatriculation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Numéro de série";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Puissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Vendeur";
            // 
            // lblVendeur
            // 
            this.lblVendeur.AutoSize = true;
            this.lblVendeur.Location = new System.Drawing.Point(86, 120);
            this.lblVendeur.Name = "lblVendeur";
            this.lblVendeur.Size = new System.Drawing.Size(12, 13);
            this.lblVendeur.TabIndex = 25;
            this.lblVendeur.Text = "/";
            // 
            // frmVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 186);
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
            this.Controls.Add(this.txtNouveauVhc);
            this.Controls.Add(this.txtDate1ereImat);
            this.Controls.Add(this.txtPuissance);
            this.Controls.Add(this.gpbAgeVehicule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVoiture";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Celeste - Voiture";
            this.Load += new System.EventHandler(this.frmVoiture_Load);
            this.gpbAgeVehicule.ResumeLayout(false);
            this.gpbAgeVehicule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAgeVehicule;
        private System.Windows.Forms.RadioButton rdbOccas5OuPlus;
        private System.Windows.Forms.RadioButton rdbOccas3a5;
        private System.Windows.Forms.RadioButton rdbOccasMoins3;
        private System.Windows.Forms.RadioButton rdbNeuf;
        private System.Windows.Forms.TextBox txtNumImmat;
        private System.Windows.Forms.TextBox txtNouveauVhc;
        private System.Windows.Forms.TextBox txtDate1ereImat;
        private System.Windows.Forms.TextBox txtPuissance;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnEnregistre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVendeur;
    }
}