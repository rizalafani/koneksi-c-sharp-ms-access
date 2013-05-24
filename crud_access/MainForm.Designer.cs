/*
 * Created by SharpDevelop.
 * User: MADARA UCHIHA
 * Date: 23/04/2013
 * Time: 20:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace crud_access
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txt_nama = new System.Windows.Forms.TextBox();
			this.txt_nomer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_alamat = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_tambah = new System.Windows.Forms.Button();
			this.btn_ubah = new System.Windows.Forms.Button();
			this.btn_hapus = new System.Windows.Forms.Button();
			this.btn_cari = new System.Windows.Forms.Button();
			this.btn_bersih = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(42, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nama Contact";
			// 
			// txt_nama
			// 
			this.txt_nama.Location = new System.Drawing.Point(137, 40);
			this.txt_nama.Name = "txt_nama";
			this.txt_nama.Size = new System.Drawing.Size(237, 20);
			this.txt_nama.TabIndex = 1;
			// 
			// txt_nomer
			// 
			this.txt_nomer.Location = new System.Drawing.Point(137, 66);
			this.txt_nomer.Name = "txt_nomer";
			this.txt_nomer.Size = new System.Drawing.Size(151, 20);
			this.txt_nomer.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(62, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nomer HP";
			// 
			// txt_alamat
			// 
			this.txt_alamat.Location = new System.Drawing.Point(137, 92);
			this.txt_alamat.Name = "txt_alamat";
			this.txt_alamat.Size = new System.Drawing.Size(304, 20);
			this.txt_alamat.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(42, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Alamat Rumah";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(27, 146);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(564, 161);
			this.dataGridView1.TabIndex = 6;
			// 
			// btn_tambah
			// 
			this.btn_tambah.Location = new System.Drawing.Point(137, 117);
			this.btn_tambah.Name = "btn_tambah";
			this.btn_tambah.Size = new System.Drawing.Size(75, 23);
			this.btn_tambah.TabIndex = 7;
			this.btn_tambah.Text = "Tambah";
			this.btn_tambah.UseVisualStyleBackColor = true;
			this.btn_tambah.Click += new System.EventHandler(this.Btn_tambahClick);
			// 
			// btn_ubah
			// 
			this.btn_ubah.Location = new System.Drawing.Point(218, 117);
			this.btn_ubah.Name = "btn_ubah";
			this.btn_ubah.Size = new System.Drawing.Size(75, 23);
			this.btn_ubah.TabIndex = 8;
			this.btn_ubah.Text = "Ubah";
			this.btn_ubah.UseVisualStyleBackColor = true;
			this.btn_ubah.Click += new System.EventHandler(this.Btn_ubahClick);
			// 
			// btn_hapus
			// 
			this.btn_hapus.Location = new System.Drawing.Point(299, 117);
			this.btn_hapus.Name = "btn_hapus";
			this.btn_hapus.Size = new System.Drawing.Size(75, 23);
			this.btn_hapus.TabIndex = 9;
			this.btn_hapus.Text = "Hapus";
			this.btn_hapus.UseVisualStyleBackColor = true;
			this.btn_hapus.Click += new System.EventHandler(this.Btn_hapusClick);
			// 
			// btn_cari
			// 
			this.btn_cari.Location = new System.Drawing.Point(380, 38);
			this.btn_cari.Name = "btn_cari";
			this.btn_cari.Size = new System.Drawing.Size(75, 23);
			this.btn_cari.TabIndex = 10;
			this.btn_cari.Text = "Cari";
			this.btn_cari.UseVisualStyleBackColor = true;
			this.btn_cari.Click += new System.EventHandler(this.Btn_cariClick);
			// 
			// btn_bersih
			// 
			this.btn_bersih.Location = new System.Drawing.Point(380, 117);
			this.btn_bersih.Name = "btn_bersih";
			this.btn_bersih.Size = new System.Drawing.Size(75, 23);
			this.btn_bersih.TabIndex = 11;
			this.btn_bersih.Text = "Bersih";
			this.btn_bersih.UseVisualStyleBackColor = true;
			this.btn_bersih.Click += new System.EventHandler(this.Btn_bersihClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutMeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(618, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aboutMeToolStripMenuItem
			// 
			this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
			this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.aboutMeToolStripMenuItem.Text = "About me";
			this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.AboutMeToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 329);
			this.Controls.Add(this.btn_bersih);
			this.Controls.Add(this.btn_cari);
			this.Controls.Add(this.btn_hapus);
			this.Controls.Add(this.btn_ubah);
			this.Controls.Add(this.btn_tambah);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txt_alamat);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_nomer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_nama);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phone Book [CRUD Ms. Access]";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TextBox txt_nama;
		private System.Windows.Forms.TextBox txt_nomer;
		private System.Windows.Forms.TextBox txt_alamat;
		private System.Windows.Forms.Button btn_tambah;
		private System.Windows.Forms.Button btn_ubah;
		private System.Windows.Forms.Button btn_hapus;
		private System.Windows.Forms.Button btn_cari;
		private System.Windows.Forms.Button btn_bersih;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
