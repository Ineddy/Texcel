namespace Texcel_TabControl
{
    partial class creerJeu
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
            this.lblJeu = new System.Windows.Forms.Label();
            this.txtJeu = new System.Windows.Forms.TextBox();
            this.lbnlkc = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblJeu
            // 
            this.lblJeu.AutoSize = true;
            this.lblJeu.Location = new System.Drawing.Point(37, 31);
            this.lblJeu.Name = "lblJeu";
            this.lblJeu.Size = new System.Drawing.Size(31, 17);
            this.lblJeu.TabIndex = 0;
            this.lblJeu.Text = "Jeu";
            // 
            // txtJeu
            // 
            this.txtJeu.Location = new System.Drawing.Point(138, 31);
            this.txtJeu.Name = "txtJeu";
            this.txtJeu.Size = new System.Drawing.Size(247, 22);
            this.txtJeu.TabIndex = 1;
            // 
            // lbnlkc
            // 
            this.lbnlkc.AutoSize = true;
            this.lbnlkc.Location = new System.Drawing.Point(40, 77);
            this.lbnlkc.Name = "lbnlkc";
            this.lbnlkc.Size = new System.Drawing.Size(46, 17);
            this.lbnlkc.TabIndex = 2;
            this.lbnlkc.Text = "label1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "3 ans et moins",
            "3 à 5 ans",
            "5 à 8 ans",
            "8 à 12 ans",
            "12 à 15 ans",
            "15 à 18 ans",
            "18 et +"});
            this.checkedListBox1.Location = new System.Drawing.Point(138, 77);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(247, 123);
            this.checkedListBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(152, 222);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(304, 222);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // creerJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 255);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbnlkc);
            this.Controls.Add(this.txtJeu);
            this.Controls.Add(this.lblJeu);
            this.Name = "creerJeu";
            this.Text = "creerJeu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJeu;
        private System.Windows.Forms.TextBox txtJeu;
        private System.Windows.Forms.Label lbnlkc;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}