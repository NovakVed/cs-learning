namespace UserControls
{
	partial class PocetniIzbornik
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
            this.GlavniPanel = new System.Windows.Forms.Panel();
            this.prijava1 = new CS_Learning.Prijava();
            this.zaboravljena_lozinka1 = new CS_Learning.Zaboravljena_lozinka();
            this.registracija1 = new CS_Learning.Registracija();
            this.GlavniPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlavniPanel
            // 
            this.GlavniPanel.Controls.Add(this.prijava1);
            this.GlavniPanel.Controls.Add(this.zaboravljena_lozinka1);
            this.GlavniPanel.Controls.Add(this.registracija1);
            this.GlavniPanel.Location = new System.Drawing.Point(0, -1);
            this.GlavniPanel.Name = "GlavniPanel";
            this.GlavniPanel.Size = new System.Drawing.Size(946, 505);
            this.GlavniPanel.TabIndex = 0;
            // 
            // prijava1
            // 
            this.prijava1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prijava1.Location = new System.Drawing.Point(0, 0);
            this.prijava1.Name = "prijava1";
            this.prijava1.Size = new System.Drawing.Size(946, 505);
            this.prijava1.TabIndex = 2;
            // 
            // zaboravljena_lozinka1
            // 
            this.zaboravljena_lozinka1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zaboravljena_lozinka1.Location = new System.Drawing.Point(0, 0);
            this.zaboravljena_lozinka1.Name = "zaboravljena_lozinka1";
            this.zaboravljena_lozinka1.Size = new System.Drawing.Size(946, 505);
            this.zaboravljena_lozinka1.TabIndex = 1;
            // 
            // registracija1
            // 
            this.registracija1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registracija1.Location = new System.Drawing.Point(0, 0);
            this.registracija1.Name = "registracija1";
            this.registracija1.Size = new System.Drawing.Size(946, 505);
            this.registracija1.TabIndex = 0;
            // 
            // PocetniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 504);
            this.Controls.Add(this.GlavniPanel);
            this.Name = "PocetniIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-learning Prijava";
            this.GlavniPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel GlavniPanel;
        private CS_Learning.Prijava prijava1;
        private CS_Learning.Zaboravljena_lozinka zaboravljena_lozinka1;
        private CS_Learning.Registracija registracija1;
    }
}