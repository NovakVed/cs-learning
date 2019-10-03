namespace CS_Learning
{
    partial class Zaboravljena_lozinka
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
            this.txtZaboravljenaEmail = new System.Windows.Forms.TextBox();
            this.btnGeneriraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZaboraviOdustani = new System.Windows.Forms.Button();
            this.lblZaboravljenaLozGreska = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtZaboravljenaEmail
            // 
            this.txtZaboravljenaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZaboravljenaEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtZaboravljenaEmail.Location = new System.Drawing.Point(585, 190);
            this.txtZaboravljenaEmail.Name = "txtZaboravljenaEmail";
            this.txtZaboravljenaEmail.Size = new System.Drawing.Size(297, 26);
            this.txtZaboravljenaEmail.TabIndex = 10;
            this.txtZaboravljenaEmail.Text = "Email";
            this.txtZaboravljenaEmail.Enter += new System.EventHandler(this.txtZaboravljenaEmail_Enter);
            this.txtZaboravljenaEmail.Leave += new System.EventHandler(this.txtZaboravljenaEmail_Leave);
            // 
            // btnGeneriraj
            // 
            this.btnGeneriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneriraj.Location = new System.Drawing.Point(585, 234);
            this.btnGeneriraj.Name = "btnGeneriraj";
            this.btnGeneriraj.Size = new System.Drawing.Size(180, 26);
            this.btnGeneriraj.TabIndex = 15;
            this.btnGeneriraj.Text = "Generiraj novu lozinku!";
            this.btnGeneriraj.UseVisualStyleBackColor = true;
            this.btnGeneriraj.Click += new System.EventHandler(this.btnGeneriraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Zaboravili ste lozinku?";
            // 
            // btnZaboraviOdustani
            // 
            this.btnZaboraviOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaboraviOdustani.Location = new System.Drawing.Point(771, 234);
            this.btnZaboraviOdustani.Name = "btnZaboraviOdustani";
            this.btnZaboraviOdustani.Size = new System.Drawing.Size(111, 26);
            this.btnZaboraviOdustani.TabIndex = 18;
            this.btnZaboraviOdustani.Text = "Natrag";
            this.btnZaboraviOdustani.UseVisualStyleBackColor = true;
            this.btnZaboraviOdustani.Click += new System.EventHandler(this.btnZaboraviOdustani_Click);
            // 
            // lblZaboravljenaLozGreska
            // 
            this.lblZaboravljenaLozGreska.AutoSize = true;
            this.lblZaboravljenaLozGreska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaboravljenaLozGreska.ForeColor = System.Drawing.Color.Red;
            this.lblZaboravljenaLozGreska.Location = new System.Drawing.Point(582, 285);
            this.lblZaboravljenaLozGreska.Name = "lblZaboravljenaLozGreska";
            this.lblZaboravljenaLozGreska.Size = new System.Drawing.Size(0, 20);
            this.lblZaboravljenaLozGreska.TabIndex = 20;
            // 
            // Zaboravljena_lozinka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblZaboravljenaLozGreska);
            this.Controls.Add(this.btnZaboraviOdustani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeneriraj);
            this.Controls.Add(this.txtZaboravljenaEmail);
            this.Name = "Zaboravljena_lozinka";
            this.Size = new System.Drawing.Size(1000, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZaboravljenaEmail;
        private System.Windows.Forms.Button btnGeneriraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZaboraviOdustani;
        private System.Windows.Forms.Label lblZaboravljenaLozGreska;
    }
}
