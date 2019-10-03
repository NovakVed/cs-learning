namespace UserControls
{
    partial class UCDodajSliku
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
            this.PBSlika = new System.Windows.Forms.PictureBox();
            this.BTNDodaj = new System.Windows.Forms.Button();
            this.BTNIzbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // PBSlika
            // 
            this.PBSlika.Location = new System.Drawing.Point(3, 3);
            this.PBSlika.Name = "PBSlika";
            this.PBSlika.Size = new System.Drawing.Size(494, 144);
            this.PBSlika.TabIndex = 0;
            this.PBSlika.TabStop = false;
            // 
            // BTNDodaj
            // 
            this.BTNDodaj.Location = new System.Drawing.Point(6, 124);
            this.BTNDodaj.Name = "BTNDodaj";
            this.BTNDodaj.Size = new System.Drawing.Size(494, 23);
            this.BTNDodaj.TabIndex = 1;
            this.BTNDodaj.Text = "Dodaj";
            this.BTNDodaj.UseVisualStyleBackColor = true;
            this.BTNDodaj.Click += new System.EventHandler(this.OnDodajSlikuClick);
            // 
            // BTNIzbrisi
            // 
            this.BTNIzbrisi.Location = new System.Drawing.Point(452, 3);
            this.BTNIzbrisi.Name = "BTNIzbrisi";
            this.BTNIzbrisi.Size = new System.Drawing.Size(45, 35);
            this.BTNIzbrisi.TabIndex = 2;
            this.BTNIzbrisi.Text = "Izbriši";
            this.BTNIzbrisi.UseVisualStyleBackColor = true;
            this.BTNIzbrisi.Click += new System.EventHandler(this.OnIzbrisiClick);
            // 
            // UCDodajSliku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTNIzbrisi);
            this.Controls.Add(this.BTNDodaj);
            this.Controls.Add(this.PBSlika);
            this.Name = "UCDodajSliku";
            this.Size = new System.Drawing.Size(500, 150);
            ((System.ComponentModel.ISupportInitialize)(this.PBSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBSlika;
        private System.Windows.Forms.Button BTNDodaj;
        private System.Windows.Forms.Button BTNIzbrisi;
    }
}
