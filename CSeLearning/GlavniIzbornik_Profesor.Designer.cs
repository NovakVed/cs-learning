namespace UserControls
{
	partial class GlavniIzbornik_Profesor
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rufMichOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pomoćF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ucIzbornik1 = new UserControls.UCIzbornik();
			this.ucKoriscnickiProfil1 = new UserControls.UCKoriscnickiProfil();
			this.ucPocetnaStranica1 = new UserControls.UCPocetnaStranica();
			this.ucPregledTematskihCjelinaProfesor1 = new UserControls.UCPregledTematskihCjelinaProfesor();
			this.ucPregledIspitaProfesor1 = new UserControls.UCPregledIspitaProfesor();
			this.ucPregledIzvjestajaProfesor1 = new UserControls.UCPregledIzvjestajaProfesor();
			this.ucTrgovina1 = new UserControls.UCTrgovina();
			this.ucPostavke1 = new UserControls.UCPostavke();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.oNamaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rufMichOnToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// rufMichOnToolStripMenuItem
			// 
			this.rufMichOnToolStripMenuItem.Name = "rufMichOnToolStripMenuItem";
			this.rufMichOnToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.rufMichOnToolStripMenuItem.Text = "Ruf mich On";
			// 
			// oNamaToolStripMenuItem
			// 
			this.oNamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomoćF1ToolStripMenuItem});
			this.oNamaToolStripMenuItem.Name = "oNamaToolStripMenuItem";
			this.oNamaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.oNamaToolStripMenuItem.Text = "O nama";
			// 
			// pomoćF1ToolStripMenuItem
			// 
			this.pomoćF1ToolStripMenuItem.Name = "pomoćF1ToolStripMenuItem";
			this.pomoćF1ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.pomoćF1ToolStripMenuItem.Text = "Pomoć (F1)";
			// 
			// ucIzbornik1
			// 
			this.ucIzbornik1.BackColor = System.Drawing.Color.White;
			this.ucIzbornik1.BojaIndikatora = System.Drawing.Color.LightSeaGreen;
			this.ucIzbornik1.BojaIsticanjaGumba = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
			this.ucIzbornik1.BojaOdabranogGumba = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.ucIzbornik1.BojaPozadineGumba = System.Drawing.Color.White;
			this.ucIzbornik1.Dock = System.Windows.Forms.DockStyle.Left;
			this.ucIzbornik1.Location = new System.Drawing.Point(0, 24);
			this.ucIzbornik1.Name = "ucIzbornik1";
			this.ucIzbornik1.Padding = new System.Windows.Forms.Padding(10);
			this.ucIzbornik1.Size = new System.Drawing.Size(112, 937);
			this.ucIzbornik1.TabIndex = 2;
			this.ucIzbornik1.Load += new System.EventHandler(this.ucIzbornik1_Load);
			// 
			// ucKoriscnickiProfil1
			// 
			this.ucKoriscnickiProfil1.BackColor = System.Drawing.Color.White;
			this.ucKoriscnickiProfil1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucKoriscnickiProfil1.Location = new System.Drawing.Point(112, 24);
			this.ucKoriscnickiProfil1.MinimumSize = new System.Drawing.Size(872, 937);
			this.ucKoriscnickiProfil1.Name = "ucKoriscnickiProfil1";
			this.ucKoriscnickiProfil1.Size = new System.Drawing.Size(1472, 937);
			this.ucKoriscnickiProfil1.TabIndex = 3;
			this.ucKoriscnickiProfil1.Visible = false;
			// 
			// ucPocetnaStranica1
			// 
			this.ucPocetnaStranica1.BackColor = System.Drawing.Color.White;
			this.ucPocetnaStranica1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPocetnaStranica1.Location = new System.Drawing.Point(0, 0);
			this.ucPocetnaStranica1.MinimumSize = new System.Drawing.Size(872, 937);
			this.ucPocetnaStranica1.Name = "ucPocetnaStranica1";
			this.ucPocetnaStranica1.Size = new System.Drawing.Size(1584, 961);
			this.ucPocetnaStranica1.TabIndex = 4;
			this.ucPocetnaStranica1.Visible = false;
			// 
			// ucPregledTematskihCjelinaProfesor1
			// 
			this.ucPregledTematskihCjelinaProfesor1.BackColor = System.Drawing.Color.White;
			this.ucPregledTematskihCjelinaProfesor1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPregledTematskihCjelinaProfesor1.Location = new System.Drawing.Point(0, 0);
			this.ucPregledTematskihCjelinaProfesor1.MinimumSize = new System.Drawing.Size(872, 937);
			this.ucPregledTematskihCjelinaProfesor1.Name = "ucPregledTematskihCjelinaProfesor1";
			this.ucPregledTematskihCjelinaProfesor1.Size = new System.Drawing.Size(1584, 961);
			this.ucPregledTematskihCjelinaProfesor1.TabIndex = 5;
			this.ucPregledTematskihCjelinaProfesor1.Visible = false;
			// 
			// ucPregledIspitaProfesor1
			// 
			this.ucPregledIspitaProfesor1.BackColor = System.Drawing.Color.White;
			this.ucPregledIspitaProfesor1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPregledIspitaProfesor1.Location = new System.Drawing.Point(112, 24);
			this.ucPregledIspitaProfesor1.MinimumSize = new System.Drawing.Size(872, 937);
			this.ucPregledIspitaProfesor1.Name = "ucPregledIspitaProfesor1";
			this.ucPregledIspitaProfesor1.Size = new System.Drawing.Size(1472, 937);
			this.ucPregledIspitaProfesor1.TabIndex = 6;
			this.ucPregledIspitaProfesor1.Visible = false;
			// 
			// ucPregledIzvjestajaProfesor1
			// 
			this.ucPregledIzvjestajaProfesor1.BackColor = System.Drawing.Color.White;
			this.ucPregledIzvjestajaProfesor1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPregledIzvjestajaProfesor1.Location = new System.Drawing.Point(112, 24);
			this.ucPregledIzvjestajaProfesor1.MinimumSize = new System.Drawing.Size(872, 937);
			this.ucPregledIzvjestajaProfesor1.Name = "ucPregledIzvjestajaProfesor1";
			this.ucPregledIzvjestajaProfesor1.Size = new System.Drawing.Size(1472, 937);
			this.ucPregledIzvjestajaProfesor1.TabIndex = 7;
			this.ucPregledIzvjestajaProfesor1.Visible = false;
			// 
			// ucTrgovina1
			// 
			this.ucTrgovina1.BackColor = System.Drawing.Color.White;
			this.ucTrgovina1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucTrgovina1.Location = new System.Drawing.Point(112, 24);
			this.ucTrgovina1.MinimumSize = new System.Drawing.Size(872, 937);
			this.ucTrgovina1.Name = "ucTrgovina1";
			this.ucTrgovina1.Size = new System.Drawing.Size(1472, 937);
			this.ucTrgovina1.TabIndex = 8;
			this.ucTrgovina1.Visible = false;
			// 
			// ucPostavke1
			// 
			this.ucPostavke1.BackColor = System.Drawing.Color.White;
			this.ucPostavke1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPostavke1.Location = new System.Drawing.Point(112, 24);
			this.ucPostavke1.MinimumSize = new System.Drawing.Size(872, 937);
			this.ucPostavke1.Name = "ucPostavke1";
			this.ucPostavke1.Size = new System.Drawing.Size(1472, 937);
			this.ucPostavke1.TabIndex = 9;
			this.ucPostavke1.Visible = false;
			// 
			// GlavniIzbornik_Profesor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1584, 961);
			this.Controls.Add(this.ucPostavke1);
			this.Controls.Add(this.ucTrgovina1);
			this.Controls.Add(this.ucPregledIzvjestajaProfesor1);
			this.Controls.Add(this.ucPregledIspitaProfesor1);
			this.Controls.Add(this.ucKoriscnickiProfil1);
			this.Controls.Add(this.ucIzbornik1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.ucPregledTematskihCjelinaProfesor1);
			this.Controls.Add(this.ucPocetnaStranica1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(1000, 1000);
			this.Name = "GlavniIzbornik_Profesor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "E - learning";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rufMichOnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem oNamaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pomoćF1ToolStripMenuItem;
		private UCIzbornik ucIzbornik1;
		private UCKoriscnickiProfil ucKoriscnickiProfil1;
		private UCPocetnaStranica ucPocetnaStranica1;
		private UCPregledTematskihCjelinaProfesor ucPregledTematskihCjelinaProfesor1;
		private UCPregledIspitaProfesor ucPregledIspitaProfesor1;
		private UCPregledIzvjestajaProfesor ucPregledIzvjestajaProfesor1;
		private UCTrgovina ucTrgovina1;
		private UCPostavke ucPostavke1;
	}
}

