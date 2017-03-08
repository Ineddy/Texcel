namespace Texcel_TabControl
{
    partial class frmTexcel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTexcel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPsw = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnAdminTemp = new System.Windows.Forms.Button();
            this.btnDirecteurTemp = new System.Windows.Forms.Button();
            this.tabControlFonctionnalites = new System.Windows.Forms.TabControl();
            this.tabTableauDeBord = new System.Windows.Forms.TabPage();
            this.dgvPlateformes = new System.Windows.Forms.DataGridView();
            this.dgvNomPlateformes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTypePlateformes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.dgvNomOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEditionOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListeJeux = new System.Windows.Forms.DataGridView();
            this.dgvNomJeux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDevellopeurJeux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreerPlateforme = new System.Windows.Forms.Button();
            this.lblPlateforme = new System.Windows.Forms.Label();
            this.btnCreerSE = new System.Windows.Forms.Button();
            this.lblSO = new System.Windows.Forms.Label();
            this.btnCreerJeu = new System.Windows.Forms.Button();
            this.listBoxJeux = new System.Windows.Forms.ListBox();
            this.lblListeJeux = new System.Windows.Forms.Label();
            this.btnSeDeconnecter = new System.Windows.Forms.Button();
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabEmployes = new System.Windows.Forms.TabPage();
            this.btnFormerEquipe = new System.Windows.Forms.Button();
            this.btnCreerEmploye = new System.Windows.Forms.Button();
            this.lblEmploye = new System.Windows.Forms.Label();
            this.pictureLogoTexcel3 = new System.Windows.Forms.PictureBox();
            this.bdTexcelDataSet = new Texcel_TabControl.BdTexcelDataSet();
            this.tblSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSETableAdapter = new Texcel_TabControl.BdTexcelDataSetTableAdapters.tblSETableAdapter();
            this.dgvEmployes = new System.Windows.Forms.DataGridView();
            this.NoEmployé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlFonctionnalites.SuspendLayout();
            this.tabTableauDeBord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlateformes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeJeux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabEmployes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoTexcel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexcelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(447, 193);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Location = new System.Drawing.Point(397, 227);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(93, 17);
            this.lblPsw.TabIndex = 2;
            this.lblPsw.Text = "Mot de passe";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogin.Location = new System.Drawing.Point(515, 193);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(168, 22);
            this.txtLogin.TabIndex = 3;
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(515, 227);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(168, 22);
            this.txtPsw.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(579, 268);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 32);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Se connecter";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnAdminTemp
            // 
            this.btnAdminTemp.Location = new System.Drawing.Point(378, 517);
            this.btnAdminTemp.Name = "btnAdminTemp";
            this.btnAdminTemp.Size = new System.Drawing.Size(112, 31);
            this.btnAdminTemp.TabIndex = 6;
            this.btnAdminTemp.Text = "Administrateur";
            this.btnAdminTemp.UseVisualStyleBackColor = true;
            this.btnAdminTemp.Click += new System.EventHandler(this.btnAdminTemp_Click);
            // 
            // btnDirecteurTemp
            // 
            this.btnDirecteurTemp.Location = new System.Drawing.Point(588, 517);
            this.btnDirecteurTemp.Name = "btnDirecteurTemp";
            this.btnDirecteurTemp.Size = new System.Drawing.Size(119, 30);
            this.btnDirecteurTemp.TabIndex = 7;
            this.btnDirecteurTemp.Text = "Directeur";
            this.btnDirecteurTemp.UseVisualStyleBackColor = true;
            this.btnDirecteurTemp.Click += new System.EventHandler(this.btnDirecteurTemp_Click);
            // 
            // tabControlFonctionnalites
            // 
            this.tabControlFonctionnalites.Controls.Add(this.tabTableauDeBord);
            this.tabControlFonctionnalites.Controls.Add(this.tabEmployes);
            this.tabControlFonctionnalites.Enabled = false;
            this.tabControlFonctionnalites.Location = new System.Drawing.Point(-2, -1);
            this.tabControlFonctionnalites.Name = "tabControlFonctionnalites";
            this.tabControlFonctionnalites.SelectedIndex = 0;
            this.tabControlFonctionnalites.Size = new System.Drawing.Size(1138, 655);
            this.tabControlFonctionnalites.TabIndex = 8;
            this.tabControlFonctionnalites.Visible = false;
            // 
            // tabTableauDeBord
            // 
            this.tabTableauDeBord.Controls.Add(this.dgvPlateformes);
            this.tabTableauDeBord.Controls.Add(this.dgvOS);
            this.tabTableauDeBord.Controls.Add(this.dgvListeJeux);
            this.tabTableauDeBord.Controls.Add(this.btnCreerPlateforme);
            this.tabTableauDeBord.Controls.Add(this.lblPlateforme);
            this.tabTableauDeBord.Controls.Add(this.btnCreerSE);
            this.tabTableauDeBord.Controls.Add(this.lblSO);
            this.tabTableauDeBord.Controls.Add(this.btnCreerJeu);
            this.tabTableauDeBord.Controls.Add(this.listBoxJeux);
            this.tabTableauDeBord.Controls.Add(this.lblListeJeux);
            this.tabTableauDeBord.Controls.Add(this.btnSeDeconnecter);
            this.tabTableauDeBord.Controls.Add(this.lblBienvenue);
            this.tabTableauDeBord.Controls.Add(this.pictureBox2);
            this.tabTableauDeBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTableauDeBord.Location = new System.Drawing.Point(4, 25);
            this.tabTableauDeBord.Name = "tabTableauDeBord";
            this.tabTableauDeBord.Padding = new System.Windows.Forms.Padding(3);
            this.tabTableauDeBord.Size = new System.Drawing.Size(1130, 626);
            this.tabTableauDeBord.TabIndex = 0;
            this.tabTableauDeBord.Text = "Tableau de bord";
            this.tabTableauDeBord.UseVisualStyleBackColor = true;
            // 
            // dgvPlateformes
            // 
            this.dgvPlateformes.AllowUserToAddRows = false;
            this.dgvPlateformes.AllowUserToDeleteRows = false;
            this.dgvPlateformes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPlateformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlateformes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNomPlateformes,
            this.dgvTypePlateformes});
            this.dgvPlateformes.Location = new System.Drawing.Point(658, 169);
            this.dgvPlateformes.Name = "dgvPlateformes";
            this.dgvPlateformes.RowHeadersWidth = 40;
            this.dgvPlateformes.RowTemplate.Height = 24;
            this.dgvPlateformes.Size = new System.Drawing.Size(391, 130);
            this.dgvPlateformes.TabIndex = 15;
            // 
            // dgvNomPlateformes
            // 
            this.dgvNomPlateformes.FillWeight = 1F;
            this.dgvNomPlateformes.HeaderText = "Nom";
            this.dgvNomPlateformes.Name = "dgvNomPlateformes";
            this.dgvNomPlateformes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNomPlateformes.Width = 170;
            // 
            // dgvTypePlateformes
            // 
            this.dgvTypePlateformes.HeaderText = "Type";
            this.dgvTypePlateformes.Name = "dgvTypePlateformes";
            this.dgvTypePlateformes.Width = 170;
            // 
            // dgvOS
            // 
            this.dgvOS.AllowUserToAddRows = false;
            this.dgvOS.AllowUserToDeleteRows = false;
            this.dgvOS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNomOS,
            this.dgvEditionOS});
            this.dgvOS.Location = new System.Drawing.Point(658, 385);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.RowHeadersWidth = 40;
            this.dgvOS.RowTemplate.Height = 24;
            this.dgvOS.Size = new System.Drawing.Size(391, 130);
            this.dgvOS.TabIndex = 14;
            // 
            // dgvNomOS
            // 
            this.dgvNomOS.FillWeight = 1F;
            this.dgvNomOS.HeaderText = "Nom";
            this.dgvNomOS.Name = "dgvNomOS";
            this.dgvNomOS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNomOS.Width = 165;
            // 
            // dgvEditionOS
            // 
            this.dgvEditionOS.HeaderText = "Edition";
            this.dgvEditionOS.Name = "dgvEditionOS";
            this.dgvEditionOS.Width = 165;
            // 
            // dgvListeJeux
            // 
            this.dgvListeJeux.AllowUserToAddRows = false;
            this.dgvListeJeux.AllowUserToDeleteRows = false;
            this.dgvListeJeux.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListeJeux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeJeux.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNomJeux,
            this.dgvDevellopeurJeux});
            this.dgvListeJeux.Location = new System.Drawing.Point(106, 169);
            this.dgvListeJeux.Name = "dgvListeJeux";
            this.dgvListeJeux.RowHeadersWidth = 40;
            this.dgvListeJeux.RowTemplate.Height = 24;
            this.dgvListeJeux.Size = new System.Drawing.Size(485, 346);
            this.dgvListeJeux.TabIndex = 13;
            // 
            // dgvNomJeux
            // 
            this.dgvNomJeux.HeaderText = "Nom";
            this.dgvNomJeux.Name = "dgvNomJeux";
            this.dgvNomJeux.Width = 220;
            // 
            // dgvDevellopeurJeux
            // 
            this.dgvDevellopeurJeux.HeaderText = "Devellopeur";
            this.dgvDevellopeurJeux.Name = "dgvDevellopeurJeux";
            this.dgvDevellopeurJeux.Width = 220;
            // 
            // btnCreerPlateforme
            // 
            this.btnCreerPlateforme.Location = new System.Drawing.Point(911, 530);
            this.btnCreerPlateforme.Name = "btnCreerPlateforme";
            this.btnCreerPlateforme.Size = new System.Drawing.Size(138, 29);
            this.btnCreerPlateforme.TabIndex = 11;
            this.btnCreerPlateforme.Text = "Créer plateforme";
            this.btnCreerPlateforme.UseVisualStyleBackColor = true;
            this.btnCreerPlateforme.Click += new System.EventHandler(this.btnCreerPlateforme_Click);
            // 
            // lblPlateforme
            // 
            this.lblPlateforme.AutoSize = true;
            this.lblPlateforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPlateforme.Location = new System.Drawing.Point(655, 333);
            this.lblPlateforme.Name = "lblPlateforme";
            this.lblPlateforme.Size = new System.Drawing.Size(110, 20);
            this.lblPlateforme.TabIndex = 9;
            this.lblPlateforme.Text = "Plateformes";
            // 
            // btnCreerSE
            // 
            this.btnCreerSE.Location = new System.Drawing.Point(949, 305);
            this.btnCreerSE.Name = "btnCreerSE";
            this.btnCreerSE.Size = new System.Drawing.Size(99, 27);
            this.btnCreerSE.TabIndex = 8;
            this.btnCreerSE.Text = "Créer SE";
            this.btnCreerSE.UseVisualStyleBackColor = true;
            this.btnCreerSE.Click += new System.EventHandler(this.btnCreerSE_Click);
            // 
            // lblSO
            // 
            this.lblSO.AutoSize = true;
            this.lblSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSO.Location = new System.Drawing.Point(654, 132);
            this.lblSO.Name = "lblSO";
            this.lblSO.Size = new System.Drawing.Size(208, 20);
            this.lblSO.TabIndex = 6;
            this.lblSO.Text = "Systèmes d\'exploitation";
            // 
            // btnCreerJeu
            // 
            this.btnCreerJeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreerJeu.Location = new System.Drawing.Point(491, 528);
            this.btnCreerJeu.Name = "btnCreerJeu";
            this.btnCreerJeu.Size = new System.Drawing.Size(99, 31);
            this.btnCreerJeu.TabIndex = 5;
            this.btnCreerJeu.Text = "Créer jeu";
            this.btnCreerJeu.UseVisualStyleBackColor = true;
            this.btnCreerJeu.Click += new System.EventHandler(this.btnCreerJeu_Click);
            // 
            // listBoxJeux
            // 
            this.listBoxJeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxJeux.FormattingEnabled = true;
            this.listBoxJeux.ItemHeight = 18;
            this.listBoxJeux.Items.AddRange(new object[] {
            "Zelda Ocarina Of Time\t\tNintendo",
            "Mario\t\t\t\tNintendo",
            "Call Of Duty Modern Warfare 2\t\tActivision",
            "Fifa 17\t\t\t\tEASport",
            "Les Sims\t\t\t\tEA",
            "Gran Turismo\t\t\tSony",
            "Bomberman",
            "Star Wars - Épisode 1\t\tDisney",
            "Mario Kart 8\t\t\tNintendo"});
            this.listBoxJeux.Location = new System.Drawing.Point(106, 169);
            this.listBoxJeux.Name = "listBoxJeux";
            this.listBoxJeux.Size = new System.Drawing.Size(484, 346);
            this.listBoxJeux.TabIndex = 4;
            this.listBoxJeux.Visible = false;
            // 
            // lblListeJeux
            // 
            this.lblListeJeux.AutoSize = true;
            this.lblListeJeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeJeux.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblListeJeux.Location = new System.Drawing.Point(101, 132);
            this.lblListeJeux.Name = "lblListeJeux";
            this.lblListeJeux.Size = new System.Drawing.Size(48, 20);
            this.lblListeJeux.TabIndex = 3;
            this.lblListeJeux.Text = "Jeux";
            // 
            // btnSeDeconnecter
            // 
            this.btnSeDeconnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeDeconnecter.Location = new System.Drawing.Point(860, 56);
            this.btnSeDeconnecter.Name = "btnSeDeconnecter";
            this.btnSeDeconnecter.Size = new System.Drawing.Size(127, 41);
            this.btnSeDeconnecter.TabIndex = 2;
            this.btnSeDeconnecter.Text = "Se déconnecter";
            this.btnSeDeconnecter.UseVisualStyleBackColor = true;
            this.btnSeDeconnecter.Click += new System.EventHandler(this.btnSeDeconnecter_Click);
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBienvenue.Location = new System.Drawing.Point(786, 16);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(101, 18);
            this.lblBienvenue.TabIndex = 1;
            this.lblBienvenue.Text = "Bienvenue M. ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(448, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 81);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabEmployes
            // 
            this.tabEmployes.Controls.Add(this.lblNom);
            this.tabEmployes.Controls.Add(this.dgvEmployes);
            this.tabEmployes.Controls.Add(this.btnFormerEquipe);
            this.tabEmployes.Controls.Add(this.btnCreerEmploye);
            this.tabEmployes.Controls.Add(this.lblEmploye);
            this.tabEmployes.Controls.Add(this.pictureLogoTexcel3);
            this.tabEmployes.Location = new System.Drawing.Point(4, 25);
            this.tabEmployes.Name = "tabEmployes";
            this.tabEmployes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployes.Size = new System.Drawing.Size(1130, 626);
            this.tabEmployes.TabIndex = 1;
            this.tabEmployes.Text = "Employés";
            this.tabEmployes.UseVisualStyleBackColor = true;
            // 
            // btnFormerEquipe
            // 
            this.btnFormerEquipe.Location = new System.Drawing.Point(398, 493);
            this.btnFormerEquipe.Name = "btnFormerEquipe";
            this.btnFormerEquipe.Size = new System.Drawing.Size(113, 23);
            this.btnFormerEquipe.TabIndex = 4;
            this.btnFormerEquipe.Text = "Former équipe";
            this.btnFormerEquipe.UseVisualStyleBackColor = true;
            // 
            // btnCreerEmploye
            // 
            this.btnCreerEmploye.Location = new System.Drawing.Point(398, 493);
            this.btnCreerEmploye.Name = "btnCreerEmploye";
            this.btnCreerEmploye.Size = new System.Drawing.Size(113, 23);
            this.btnCreerEmploye.TabIndex = 3;
            this.btnCreerEmploye.Text = "Créer employé";
            this.btnCreerEmploye.UseVisualStyleBackColor = true;
            // 
            // lblEmploye
            // 
            this.lblEmploye.AutoSize = true;
            this.lblEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmploye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEmploye.Location = new System.Drawing.Point(91, 106);
            this.lblEmploye.Name = "lblEmploye";
            this.lblEmploye.Size = new System.Drawing.Size(102, 24);
            this.lblEmploye.TabIndex = 1;
            this.lblEmploye.Text = "Employés";
            // 
            // pictureLogoTexcel3
            // 
            this.pictureLogoTexcel3.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogoTexcel3.Image")));
            this.pictureLogoTexcel3.Location = new System.Drawing.Point(448, 16);
            this.pictureLogoTexcel3.Name = "pictureLogoTexcel3";
            this.pictureLogoTexcel3.Size = new System.Drawing.Size(201, 76);
            this.pictureLogoTexcel3.TabIndex = 0;
            this.pictureLogoTexcel3.TabStop = false;
            // 
            // bdTexcelDataSet
            // 
            this.bdTexcelDataSet.DataSetName = "BdTexcelDataSet";
            this.bdTexcelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSEBindingSource
            // 
            this.tblSEBindingSource.DataMember = "tblSE";
            this.tblSEBindingSource.DataSource = this.bdTexcelDataSet;
            // 
            // tblSETableAdapter
            // 
            this.tblSETableAdapter.ClearBeforeFill = true;
            // 
            // dgvEmployes
            // 
            this.dgvEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoEmployé,
            this.prenom,
            this.Column1});
            this.dgvEmployes.Location = new System.Drawing.Point(95, 145);
            this.dgvEmployes.Name = "dgvEmployes";
            this.dgvEmployes.RowTemplate.Height = 24;
            this.dgvEmployes.Size = new System.Drawing.Size(416, 333);
            this.dgvEmployes.TabIndex = 5;
            // 
            // NoEmployé
            // 
            this.NoEmployé.HeaderText = "No Employé";
            this.NoEmployé.Name = "NoEmployé";
            this.NoEmployé.Width = 90;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Nom";
            this.prenom.Name = "prenom";
            this.prenom.Width = 140;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Prénom";
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(606, 145);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(67, 20);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "lblNom";
            // 
            // frmTexcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 650);
            this.Controls.Add(this.tabControlFonctionnalites);
            this.Controls.Add(this.btnDirecteurTemp);
            this.Controls.Add(this.btnAdminTemp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmTexcel";
            this.Text = "Texcel - Gestion de tests de jeux vidéo";
            this.Load += new System.EventHandler(this.frmTexcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlFonctionnalites.ResumeLayout(false);
            this.tabTableauDeBord.ResumeLayout(false);
            this.tabTableauDeBord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlateformes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeJeux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabEmployes.ResumeLayout(false);
            this.tabEmployes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoTexcel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTexcelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnAdminTemp;
        private System.Windows.Forms.Button btnDirecteurTemp;
        private System.Windows.Forms.TabControl tabControlFonctionnalites;
        private System.Windows.Forms.TabPage tabTableauDeBord;
        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabEmployes;
        private System.Windows.Forms.Button btnSeDeconnecter;
        private System.Windows.Forms.ListBox listBoxJeux;
        private System.Windows.Forms.Label lblListeJeux;
        private System.Windows.Forms.Label lblSO;
        private System.Windows.Forms.Button btnCreerJeu;
        private System.Windows.Forms.Button btnCreerPlateforme;
        private System.Windows.Forms.Label lblPlateforme;
        private System.Windows.Forms.Button btnCreerSE;
        private System.Windows.Forms.PictureBox pictureLogoTexcel3;
        private System.Windows.Forms.Button btnFormerEquipe;
        private System.Windows.Forms.Button btnCreerEmploye;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.DataGridView dgvListeJeux;
        private System.Windows.Forms.DataGridView dgvOS;
        private BdTexcelDataSet bdTexcelDataSet;
        private System.Windows.Forms.BindingSource tblSEBindingSource;
        private BdTexcelDataSetTableAdapters.tblSETableAdapter tblSETableAdapter;
        private System.Windows.Forms.DataGridView dgvPlateformes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomPlateformes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTypePlateformes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomJeux;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDevellopeurJeux;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEditionOS;
        private System.Windows.Forms.DataGridView dgvEmployes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoEmployé;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblNom;
    }
}

