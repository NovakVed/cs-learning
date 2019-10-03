namespace UserControls
{
	partial class GlavniIzbornik_Student
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
			this.ucIzbornik1 = new UserControls.UCIzbornik();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ucKoriscnickiProfil1 = new UserControls.UCKoriscnickiProfil();
			this.ucPocetnaStranica1 = new UserControls.UCPocetnaStranica();
			this.ucPregledTematskihCjelinaStudent1 = new UserControls.UCPregledTematskihCjelinaStudent();
			this.ucPregledIspitaStudent1 = new UserControls.UCPregledIspitaStudent();
			this.ucPregledIzvjestajaStudent1 = new UserControls.UCPregledIzvjestajaStudent();
			this.ucTrgovina1 = new UserControls.UCTrgovina();
			this.ucPostavke1 = new UserControls.UCPostavke();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ucIzbornik1
			// 
			this.ucIzbornik1.BackColor = System.Drawing.Color.White;
			this.ucIzbornik1.BojaIndikatora = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(152)))), ((int)(((byte)(10)))));
			this.ucIzbornik1.BojaIsticanjaGumba = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(157)))));
			this.ucIzbornik1.BojaOdabranogGumba = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(168)))));
			this.ucIzbornik1.BojaPozadineGumba = System.Drawing.Color.White;
			this.ucIzbornik1.Dock = System.Windows.Forms.DockStyle.Left;
			this.ucIzbornik1.Location = new System.Drawing.Point(0, 24);
			this.ucIzbornik1.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.ucIzbornik1.Name = "ucIzbornik1";
			this.ucIzbornik1.Padding = new System.Windows.Forms.Padding(10);
			this.ucIzbornik1.Size = new System.Drawing.Size(112, 937);
			this.ucIzbornik1.TabIndex = 0;
			this.ucIzbornik1.Load += new System.EventHandler(this.ucIzbornik1_Load);
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
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// oNamaToolStripMenuItem
			// 
			this.oNamaToolStripMenuItem.Name = "oNamaToolStripMenuItem";
			this.oNamaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.oNamaToolStripMenuItem.Text = "O nama";
			// 
			// ucKoriscnickiProfil1
			// 
			this.ucKoriscnickiProfil1.BackColor = System.Drawing.Color.White;
			this.ucKoriscnickiProfil1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucKoriscnickiProfil1.Location = new System.Drawing.Point(112, 24);
			this.ucKoriscnickiProfil1.MinimumSize = new System.Drawing.Size(872, 937);
			this.ucKoriscnickiProfil1.Name = "ucKoriscnickiProfil1";
			this.ucKoriscnickiProfil1.Size = new System.Drawing.Size(1472, 937);
			this.ucKoriscnickiProfil1.TabIndex = 2;
			this.ucKoriscnickiProfil1.Visible = false;
			// 
			// ucPocetnaStranica1
			// 
			this.ucPocetnaStranica1.BackColor = System.Drawing.Color.White;
			this.ucPocetnaStranica1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPocetnaStranica1.Location = new System.Drawing.Point(112, 24);
			this.ucPocetnaStranica1.MinimumSize = new System.Drawing.Size(872, 937);
			this.ucPocetnaStranica1.Name = "ucPocetnaStranica1";
			this.ucPocetnaStranica1.Size = new System.Drawing.Size(1472, 937);
			this.ucPocetnaStranica1.TabIndex = 3;
			this.ucPocetnaStranica1.Visible = false;
			// 
			// ucPregledTematskihCjelinaStudent1
			// 
			this.ucPregledTematskihCjelinaStudent1.BackColor = System.Drawing.Color.White;
			this.ucPregledTematskihCjelinaStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPregledTematskihCjelinaStudent1.Location = new System.Drawing.Point(112, 24);
			this.ucPregledTematskihCjelinaStudent1.MinimumSize = new System.Drawing.Size(872, 937);
			this.ucPregledTematskihCjelinaStudent1.Name = "ucPregledTematskihCjelinaStudent1";
			this.ucPregledTematskihCjelinaStudent1.Size = new System.Drawing.Size(1472, 937);
			this.ucPregledTematskihCjelinaStudent1.TabIndex = 4;
			this.ucPregledTematskihCjelinaStudent1.Visible = false;
			// 
			// ucPregledIspitaStudent1
			// 
			this.ucPregledIspitaStudent1.BackColor = System.Drawing.Color.White;
			this.ucPregledIspitaStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPregledIspitaStudent1.Location = new System.Drawing.Point(112, 24);
			this.ucPregledIspitaStudent1.MinimumSize = new System.Drawing.Size(872, 937);
			this.ucPregledIspitaStudent1.Name = "ucPregledIspitaStudent1";
			this.ucPregledIspitaStudent1.Size = new System.Drawing.Size(1472, 937);
			this.ucPregledIspitaStudent1.TabIndex = 5;
			this.ucPregledIspitaStudent1.Visible = false;
			// 
			// ucPregledIzvjestajaStudent1
			// 
			this.ucPregledIzvjestajaStudent1.BackColor = System.Drawing.Color.White;
			this.ucPregledIzvjestajaStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucPregledIzvjestajaStudent1.Location = new System.Drawing.Point(112, 24);
			this.ucPregledIzvjestajaStudent1.MinimumSize = new System.Drawing.Size(872, 937);
			this.ucPregledIzvjestajaStudent1.Name = "ucPregledIzvjestajaStudent1";
			this.ucPregledIzvjestajaStudent1.Size = new System.Drawing.Size(1472, 937);
			this.ucPregledIzvjestajaStudent1.TabIndex = 6;
			this.ucPregledIzvjestajaStudent1.Visible = false;
			// 
			// ucTrgovina1
			// 
			this.ucTrgovina1.BackColor = System.Drawing.Color.White;
			this.ucTrgovina1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucTrgovina1.Location = new System.Drawing.Point(112, 24);
			this.ucTrgovina1.MinimumSize = new System.Drawing.Size(872, 937);
			this.ucTrgovina1.Name = "ucTrgovina1";
			this.ucTrgovina1.Size = new System.Drawing.Size(1472, 937);
			this.ucTrgovina1.TabIndex = 7;
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
			this.ucPostavke1.TabIndex = 8;
			this.ucPostavke1.Visible = false;
			// 
			// GlavniIzbornik_Student
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1584, 961);
			this.Controls.Add(this.ucPostavke1);
			this.Controls.Add(this.ucTrgovina1);
			this.Controls.Add(this.ucPregledIzvjestajaStudent1);
			this.Controls.Add(this.ucPregledIspitaStudent1);
			this.Controls.Add(this.ucPregledTematskihCjelinaStudent1);
			this.Controls.Add(this.ucPocetnaStranica1);
			this.Controls.Add(this.ucKoriscnickiProfil1);
			this.Controls.Add(this.ucIzbornik1);
			this.Controls.Add(this.menuStrip1);
			this.MinimumSize = new System.Drawing.Size(1000, 1000);
			this.Name = "GlavniIzbornik_Student";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "E - learning";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UCIzbornik ucIzbornik1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem oNamaToolStripMenuItem;
		private UCKoriscnickiProfil ucKoriscnickiProfil1;
		private UCPocetnaStranica ucPocetnaStranica1;
		private UCPregledTematskihCjelinaStudent ucPregledTematskihCjelinaStudent1;
		private UCPregledIspitaStudent ucPregledIspitaStudent1;
		private UCPregledIzvjestajaStudent ucPregledIzvjestajaStudent1;
		private UCTrgovina ucTrgovina1;
		private UCPostavke ucPostavke1;
	}
}