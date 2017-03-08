namespace Texcel_TabControl
{
    partial class creerSE
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
            this.lblSE = new System.Windows.Forms.Label();
            this.txtSE = new System.Windows.Forms.TextBox();
            this.lblEdition = new System.Windows.Forms.Label();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.brtnAjouterSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSE
            // 
            this.lblSE.AutoSize = true;
            this.lblSE.Location = new System.Drawing.Point(39, 46);
            this.lblSE.Name = "lblSE";
            this.lblSE.Size = new System.Drawing.Size(148, 17);
            this.lblSE.TabIndex = 0;
            this.lblSE.Text = "Système d\'exploitation";
            // 
            // txtSE
            // 
            this.txtSE.Location = new System.Drawing.Point(207, 46);
            this.txtSE.Name = "txtSE";
            this.txtSE.Size = new System.Drawing.Size(181, 22);
            this.txtSE.TabIndex = 1;
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Location = new System.Drawing.Point(42, 105);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(55, 17);
            this.lblEdition.TabIndex = 2;
            this.lblEdition.Text = "Édition ";
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(207, 99);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(181, 22);
            this.txtEdition.TabIndex = 3;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(207, 153);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(181, 22);
            this.txtVersion.TabIndex = 4;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(42, 156);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(56, 17);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version";
            // 
            // brtnAjouterSE
            // 
            this.brtnAjouterSE.Location = new System.Drawing.Point(276, 211);
            this.brtnAjouterSE.Name = "brtnAjouterSE";
            this.brtnAjouterSE.Size = new System.Drawing.Size(112, 32);
            this.brtnAjouterSE.TabIndex = 6;
            this.brtnAjouterSE.Text = "Ajouter";
            this.brtnAjouterSE.UseVisualStyleBackColor = true;
            // 
            // creerSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 272);
            this.Controls.Add(this.brtnAjouterSE);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.txtSE);
            this.Controls.Add(this.lblSE);
            this.Name = "creerSE";
            this.Text = "Ajouter système d\'exploitation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSE;
        private System.Windows.Forms.TextBox txtSE;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button brtnAjouterSE;
    }
}