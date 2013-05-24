/*
 * Created by SharpDevelop.
 * User: MADARA UCHIHA (Ahmad Rizal Afani - http://calonpresident.blogspot.com)
 * Date: 23/04/2013
 * Time: 20:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace crud_access
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			connection = Connection.GetInstance();
		}
		
		private Connection connection;
		private DataSet ds;
		private int result;
		private string number, address;
		
		private void SetDataGridView(DataSet ds)
		{
			try
			{
				dataGridView1.DataSource = ds.Tables[0];
				dataGridView1.Columns[0].HeaderText = "Nama Contact";
				dataGridView1.Columns[0].Width = 160;
				dataGridView1.Columns[1].HeaderText = "Nomer Telp";
				dataGridView1.Columns[1].Width = 130;
				dataGridView1.Columns[2].HeaderText = "Alamat";
				dataGridView1.Columns[2].Width = 230;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			try
			{
				SetDataGridView(connection.GetContact());
				txt_nama.Clear();
				txt_nomer.Clear();
				txt_alamat.Clear();
				txt_nama.Enabled = true;
				txt_nomer.Enabled = true;
				txt_alamat.Enabled = true;
				btn_tambah.Enabled = true;
				btn_ubah.Enabled = false;
				btn_hapus.Enabled = false;
				btn_bersih.Enabled = false;
				btn_cari.Enabled = true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}			
		}
		
		void Btn_tambahClick(object sender, EventArgs e)
		{
			try 
			{
				if(txt_nama.Text != "" && txt_nomer.Text != "" && txt_alamat.Text != "")
				{
					ds = connection.GetContact(txt_nama.Text);
					if(ds.Tables[0].Rows.Count < 1){
						result = connection.TambahContact(txt_nama.Text,txt_nomer.Text,txt_alamat.Text);
						if(result == 1){
							MessageBox.Show("Simpan Data sukses !!");
						}else{
							MessageBox.Show("Simpan Data gagal !!");
						}
						MainFormLoad(null,null);
					}else{
						MessageBox.Show("nama contact terpakai !!!");
					}
				}else
				{
					MessageBox.Show("input gak lengkap !!!");
				}
			}
			catch (Exception ex) 
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Btn_cariClick(object sender, EventArgs e)
		{
			try {
				if(txt_nama.Text != ""){
					ds = connection.GetContact(txt_nama.Text);
					if(ds.Tables[0].Rows.Count > 0){
						foreach(DataRow kolom in ds.Tables[0].Rows){
							txt_nama.Text = kolom["contact_name"].ToString();
							txt_nomer.Text = kolom["contact_number"].ToString();
							txt_alamat.Text = kolom["address"].ToString();
							number = kolom["contact_number"].ToString();
							address = kolom["address"].ToString();
						}
						txt_nama.Enabled = false;
						btn_tambah.Enabled = false;
						btn_ubah.Enabled = true;
						btn_hapus.Enabled = true;
						btn_bersih.Enabled = true;
						btn_cari.Enabled = false;
					}else{
						MessageBox.Show("data yang anda cari tidak ada !!!");
					}
				}else{
					MessageBox.Show("input gak lengkap !!!");
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Btn_bersihClick(object sender, EventArgs e)
		{
			try {
				MainFormLoad(null,null);
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Btn_hapusClick(object sender, EventArgs e)
		{
			try {
				if(MessageBox.Show("yakin hapus data ini ? ","Question",MessageBoxButtons.YesNo) == DialogResult.Yes){
					result = connection.DeleteContact(txt_nama.Text);
					if(result == 1){
						MessageBox.Show("Hapus Data sukses !!");
					}else{
						MessageBox.Show("Hapus Data gagal !!");
					}
					MainFormLoad(null,null);
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		void Btn_ubahClick(object sender, EventArgs e)
		{
			try {
				if(txt_nomer.Text != "" && txt_alamat.Text != ""){
					if(txt_nomer.Text != number || txt_alamat.Text != address){
						if(MessageBox.Show("yakin ubah data ini ? ","Question",MessageBoxButtons.YesNo) == DialogResult.Yes){
							result = connection.UbahContact(txt_nama.Text,txt_nomer.Text,txt_alamat.Text);
							if(result == 1){
								MessageBox.Show("Ubah Data sukses !!");
							}else{
								MessageBox.Show("Ubah Data gagal !!");
							}							
						}
					}
					MainFormLoad(null,null);
				}else{
					MessageBox.Show("input gak lengkap !!!");
				}				
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		void AboutMeToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Contoh CRUD C# dan Database Access\nOleh Ahmad Rizal Afani\nhttp://calonpresident.blogspot.com","About me",
			                MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
	}
}
