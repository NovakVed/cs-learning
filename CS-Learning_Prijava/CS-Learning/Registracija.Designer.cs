namespace CS_Learning
{
    partial class Registracija
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegistracijaLozinka = new System.Windows.Forms.TextBox();
            this.txtRegistracijaKorIme = new System.Windows.Forms.TextBox();
            this.txtRegistracijaEmail = new System.Windows.Forms.TextBox();
            this.txtRegistracijaPotvrda = new System.Windows.Forms.TextBox();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.btnRegistracijaNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registracija";
            // 
            // txtRegistracijaLozinka
            // 
            this.txtRegistracijaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistracijaLozinka.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRegistracijaLozinka.Location = new System.Drawing.Point(586, 273);
            this.txtRegistracijaLozinka.Name = "txtRegistracijaLozinka";
            this.txtRegistracijaLozinka.Size = new System.Drawing.Size(297, 26);
            this.txtRegistracijaLozinka.TabIndex = 20;
            this.txtRegistracijaLozinka.Text = "Lozinka";
            this.txtRegistracijaLozinka.Enter += new System.EventHandler(this.txtRegistracijaLozinka_Enter);
            this.txtRegistracijaLozinka.Leave += new System.EventHandler(this.txtRegistracijaLozinka_Leave);
            // 
            // txtRegistracijaKorIme
            // 
            this.txtRegistracijaKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistracijaKorIme.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRegistracijaKorIme.Location = new System.Drawing.Point(586, 231);
            this.txtRegistracijaKorIme.Name = "txtRegistracijaKorIme";
            this.txtRegistracijaKorIme.Size = new System.Drawing.Size(297, 26);
            this.txtRegistracijaKorIme.TabIndex = 19;
            this.txtRegistracijaKorIme.Text = "Korisničko ime";
            this.txtRegistracijaKorIme.Enter += new System.EventHandler(this.txtRegistracijaKorIme_Enter);
            this.txtRegistracijaKorIme.Leave += new System.EventHandler(this.txtRegistracijaKorIme_Leave);
            // 
            // txtRegistracijaEmail
            // 
            this.txtRegistracijaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistracijaEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRegistracijaEmail.Location = new System.Drawing.Point(586, 188);
            this.txtRegistracijaEmail.Name = "txtRegistracijaEmail";
            this.txtRegistracijaEmail.Size = new System.Drawing.Size(297, 26);
            this.txtRegistracijaEmail.TabIndex = 18;
            this.txtRegistracijaEmail.Text = "Email";
            this.txtRegistracijaEmail.Enter += new System.EventHandler(this.txtRegistracijaEmail_Enter);
            this.txtRegistracijaEmail.Leave += new System.EventHandler(this.txtRegistracijaEmail_Leave);
            // 
            // txtRegistracijaPotvrda
            // 
            this.txtRegistracijaPotvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistracijaPotvrda.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRegistracijaPotvrda.Location = new System.Drawing.Point(586, 315);
            this.txtRegistracijaPotvrda.Name = "txtRegistracijaPotvrda";
            this.txtRegistracijaPotvrda.Size = new System.Drawing.Size(297, 26);
            this.txtRegistracijaPotvrda.TabIndex = 21;
            this.txtRegistracijaPotvrda.Text = "Potvrdi lozinku";
            this.txtRegistracijaPotvrda.Enter += new System.EventHandler(this.txtRegistracijaPotvrda_Enter);
            this.txtRegistracijaPotvrda.Leave += new System.EventHandler(this.txtRegistracijaPotvrda_Leave);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracija.Location = new System.Drawing.Point(586, 363);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(135, 26);
            this.btnRegistracija.TabIndex = 22;
            this.btnRegistracija.Text = "Registriraj se!";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // btnRegistracijaNatrag
            // 
            this.btnRegistracijaNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracijaNatrag.Location = new System.Drawing.Point(748, 363);
            this.btnRegistracijaNatrag.Name = "btnRegistracijaNatrag";
            this.btnRegistracijaNatrag.Size = new System.Drawing.Size(135, 26);
            this.btnRegistracijaNatrag.TabIndex = 23;
            this.btnRegistracijaNatrag.Text = "Natrag";
            this.btnRegistracijaNatrag.UseVisualStyleBackColor = true;
            this.btnRegistracijaNatrag.Click += new System.EventHandler(this.btnRegistracijaNatrag_Click);
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRegistracijaNatrag);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.txtRegistracijaPotvrda);
            this.Controls.Add(this.txtRegistracijaLozinka);
            this.Controls.Add(this.txtRegistracijaKorIme);
            this.Controls.Add(this.txtRegistracijaEmail);
            this.Controls.Add(this.label1);
            this.Name = "Registracija";
            this.Size = new System.Drawing.Size(1000, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegistracijaLozinka;
        private System.Windows.Forms.TextBox txtRegistracijaKorIme;
        private System.Windows.Forms.TextBox txtRegistracijaEmail;
        private System.Windows.Forms.TextBox txtRegistracijaPotvrda;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Button btnRegistracijaNatrag;
    }
}
