namespace CS_Learning
{
    partial class Prijava
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
            this.linkZaboravi = new System.Windows.Forms.LinkLabel();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.txtPrijavaLozinka = new System.Windows.Forms.TextBox();
            this.txtPrijavaEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkRegistracija = new System.Windows.Forms.LinkLabel();
            this.PrikazGresakaPrijave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkZaboravi
            // 
            this.linkZaboravi.AutoSize = true;
            this.linkZaboravi.Location = new System.Drawing.Point(770, 289);
            this.linkZaboravi.Name = "linkZaboravi";
            this.linkZaboravi.Size = new System.Drawing.Size(112, 13);
            this.linkZaboravi.TabIndex = 15;
            this.linkZaboravi.TabStop = true;
            this.linkZaboravi.Text = "Zaboravili ste lozinku?";
            this.linkZaboravi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkZaboravi_LinkClicked);
            // 
            // btnPrijava
            // 
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Location = new System.Drawing.Point(586, 282);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(105, 26);
            this.btnPrijava.TabIndex = 14;
            this.btnPrijava.Text = "Prijavi se!";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // txtPrijavaLozinka
            // 
            this.txtPrijavaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrijavaLozinka.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrijavaLozinka.Location = new System.Drawing.Point(585, 235);
            this.txtPrijavaLozinka.Name = "txtPrijavaLozinka";
            this.txtPrijavaLozinka.Size = new System.Drawing.Size(297, 26);
            this.txtPrijavaLozinka.TabIndex = 12;
            this.txtPrijavaLozinka.Text = "Lozinka";
            this.txtPrijavaLozinka.Enter += new System.EventHandler(this.txtPrijavaLozinka_Enter);
            this.txtPrijavaLozinka.Leave += new System.EventHandler(this.txtPrijavaLozinka_Leave);
            // 
            // txtPrijavaEmail
            // 
            this.txtPrijavaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrijavaEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrijavaEmail.Location = new System.Drawing.Point(585, 190);
            this.txtPrijavaEmail.Name = "txtPrijavaEmail";
            this.txtPrijavaEmail.Size = new System.Drawing.Size(297, 26);
            this.txtPrijavaEmail.TabIndex = 9;
            this.txtPrijavaEmail.Text = "Korisničko ime";
            this.txtPrijavaEmail.Enter += new System.EventHandler(this.txtPrijavaEmail_Enter);
            this.txtPrijavaEmail.Leave += new System.EventHandler(this.txtPrijavaEmail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Prijava";
            // 
            // linkRegistracija
            // 
            this.linkRegistracija.AutoSize = true;
            this.linkRegistracija.Location = new System.Drawing.Point(755, 155);
            this.linkRegistracija.Name = "linkRegistracija";
            this.linkRegistracija.Size = new System.Drawing.Size(127, 13);
            this.linkRegistracija.TabIndex = 17;
            this.linkRegistracija.TabStop = true;
            this.linkRegistracija.Text = "Nemate korisnički račun?";
            this.linkRegistracija.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistracija_LinkClicked);
            // 
            // PrikazGresakaPrijave
            // 
            this.PrikazGresakaPrijave.AutoSize = true;
            this.PrikazGresakaPrijave.BackColor = System.Drawing.Color.Transparent;
            this.PrikazGresakaPrijave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrikazGresakaPrijave.ForeColor = System.Drawing.Color.Red;
            this.PrikazGresakaPrijave.Location = new System.Drawing.Point(524, 337);
            this.PrikazGresakaPrijave.Name = "PrikazGresakaPrijave";
            this.PrikazGresakaPrijave.Size = new System.Drawing.Size(0, 20);
            this.PrikazGresakaPrijave.TabIndex = 19;
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrikazGresakaPrijave);
            this.Controls.Add(this.linkRegistracija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkZaboravi);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtPrijavaLozinka);
            this.Controls.Add(this.txtPrijavaEmail);
            this.Name = "Prijava";
            this.Size = new System.Drawing.Size(1000, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkZaboravi;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.TextBox txtPrijavaLozinka;
        private System.Windows.Forms.TextBox txtPrijavaEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkRegistracija;
        private System.Windows.Forms.Label PrikazGresakaPrijave;
    }
}
