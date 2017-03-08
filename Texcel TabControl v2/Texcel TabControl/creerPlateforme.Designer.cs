namespace Texcel_TabControl
{
    partial class creerPlateforme
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
            this.lblPlateforme = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.txtPlateforme = new System.Windows.Forms.TextBox();
            this.lblConfigPlateforme = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.comboTypePlateforme = new System.Windows.Forms.ComboBox();
            this.lblSE = new System.Windows.Forms.Label();
            this.comboSEPlateforme = new System.Windows.Forms.ComboBox();
            this.btnAjouterSE = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAjouterPLateforme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlateforme
            // 
            this.lblPlateforme.AutoSize = true;
            this.lblPlateforme.Location = new System.Drawing.Point(31, 45);
            this.lblPlateforme.Name = "lblPlateforme";
            this.lblPlateforme.Size = new System.Drawing.Size(76, 17);
            this.lblPlateforme.TabIndex = 0;
            this.lblPlateforme.Text = "Plateforme";
            // 
            // txtPlateforme
            // 
            this.txtPlateforme.Location = new System.Drawing.Point(161, 45);
            this.txtPlateforme.Name = "txtPlateforme";
            this.txtPlateforme.Size = new System.Drawing.Size(211, 22);
            this.txtPlateforme.TabIndex = 1;
            // 
            // lblConfigPlateforme
            // 
            this.lblConfigPlateforme.AutoSize = true;
            this.lblConfigPlateforme.Location = new System.Drawing.Point(31, 224);
            this.lblConfigPlateforme.Name = "lblConfigPlateforme";
            this.lblConfigPlateforme.Size = new System.Drawing.Size(92, 17);
            this.lblConfigPlateforme.TabIndex = 2;
            this.lblConfigPlateforme.Text = "Configuration";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(34, 102);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // comboTypePlateforme
            // 
            this.comboTypePlateforme.FormattingEnabled = true;
            this.comboTypePlateforme.Items.AddRange(new object[] {
            "Console",
            "Lunette",
            "Montre",
            "Ordinateur",
            "Tablette",
            "Téléphone",
            "Télévision",
            "",
            "",
            ""});
            this.comboTypePlateforme.Location = new System.Drawing.Point(161, 93);
            this.comboTypePlateforme.Name = "comboTypePlateforme";
            this.comboTypePlateforme.Size = new System.Drawing.Size(211, 24);
            this.comboTypePlateforme.TabIndex = 4;
            // 
            // lblSE
            // 
            this.lblSE.AutoSize = true;
            this.lblSE.Location = new System.Drawing.Point(34, 150);
            this.lblSE.Name = "lblSE";
            this.lblSE.Size = new System.Drawing.Size(148, 17);
            this.lblSE.TabIndex = 5;
            this.lblSE.Text = "Système d\'exploitation";
            // 
            // comboSEPlateforme
            // 
            this.comboSEPlateforme.FormattingEnabled = true;
            this.comboSEPlateforme.Items.AddRange(new object[] {
            "Windows 10",
            "Mac OS X",
            "Linux",
            "Desbian",
            "Ubuntu",
            "Android",
            "Windows 8",
            "Windowz 7",
            "Playstation 4",
            "Playstation 3",
            "Windows 10 Entreprise",
            ""});
            this.comboSEPlateforme.Location = new System.Drawing.Point(200, 147);
            this.comboSEPlateforme.Name = "comboSEPlateforme";
            this.comboSEPlateforme.Size = new System.Drawing.Size(172, 24);
            this.comboSEPlateforme.TabIndex = 6;
            // 
            // btnAjouterSE
            // 
            this.btnAjouterSE.Location = new System.Drawing.Point(272, 177);
            this.btnAjouterSE.Name = "btnAjouterSE";
            this.btnAjouterSE.Size = new System.Drawing.Size(100, 23);
            this.btnAjouterSE.TabIndex = 7;
            this.btnAjouterSE.Text = "Ajouter SE";
            this.btnAjouterSE.UseVisualStyleBackColor = true;
            this.btnAjouterSE.Click += new System.EventHandler(this.btnAjouterSE_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(150, 224);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(222, 88);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btnAjouterPLateforme
            // 
            this.btnAjouterPLateforme.Location = new System.Drawing.Point(232, 318);
            this.btnAjouterPLateforme.Name = "btnAjouterPLateforme";
            this.btnAjouterPLateforme.Size = new System.Drawing.Size(140, 23);
            this.btnAjouterPLateforme.TabIndex = 9;
            this.btnAjouterPLateforme.Text = "Ajouter plateforme";
            this.btnAjouterPLateforme.UseVisualStyleBackColor = true;
            // 
            // creerPlateforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 367);
            this.Controls.Add(this.btnAjouterPLateforme);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnAjouterSE);
            this.Controls.Add(this.comboSEPlateforme);
            this.Controls.Add(this.lblSE);
            this.Controls.Add(this.comboTypePlateforme);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblConfigPlateforme);
            this.Controls.Add(this.txtPlateforme);
            this.Controls.Add(this.lblPlateforme);
            this.Name = "creerPlateforme";
            this.Text = "Ajouter plateforme";
            this.Load += new System.EventHandler(this.creerPlateforme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlateforme;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox txtPlateforme;
        private System.Windows.Forms.Label lblConfigPlateforme;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboTypePlateforme;
        private System.Windows.Forms.Label lblSE;
        private System.Windows.Forms.ComboBox comboSEPlateforme;
        private System.Windows.Forms.Button btnAjouterSE;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAjouterPLateforme;
    }
}