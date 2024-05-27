using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Moon_Coffee.Model;

namespace Moon_Coffee
{
    public partial class IcerikEkle : Form
    {
        private MoonCoffeeContext dbContext = new MoonCoffeeContext();
        public IcerikEkle()
        {
            InitializeComponent();
        }

        private void IcerikEkle_Load(object sender, EventArgs e)
        {
            FillCategoryComboBox();
            dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvSearch.AutoGenerateColumns = false;
            dgvSearch.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "İçerik ID",
                DataPropertyName = "icerikID" 
            });

            dgvSearch.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ad",
                DataPropertyName = "ad" 
            });

            dgvSearch.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Adet",
                DataPropertyName = "adet" 
            });

            dgvSearch.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fiyat",
                DataPropertyName = "fiyat" 
            });

            
            btnAra.PerformClick();
        
        }


        private void button34_Click(object sender, EventArgs e)
        {
            Gezgin gezgin = new Gezgin();
            gezgin.Show();
            this.Hide();

        }

        private void FillCategoryComboBox()
        {
            try
            {
                var distinctCategories = dbContext.Icerik.Select(i => i.Kategori.ad).Distinct().ToList();
                cmbKategoriAdi.DataSource = distinctCategories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        
        private void cmbKategoriAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
  

        }
     

        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DgvSatirindanBilgileriAl();

        }
        private void DgvSatirindanBilgileriAl()
        {
            if (dgvSearch.SelectedRows.Count > 0)
            {
                int rowIndex = dgvSearch.SelectedRows[0].Index;

                txtIcerikID.Text = dgvSearch.Rows[rowIndex].Cells[0].Value.ToString();  
                txtIcerikAdi.Text = dgvSearch.Rows[rowIndex].Cells[1].Value.ToString(); 
                cmbAdet.Text = dgvSearch.Rows[rowIndex].Cells[2].Value.ToString();      
                txtFiyat.Text = dgvSearch.Rows[rowIndex].Cells[3].Value.ToString();                                                                                           
            }
           
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            string selectedCategory = cmbKategoriAdi.SelectedItem?.ToString();

            try
            {
                Icerik yeniIcerik = new Icerik
                {
                    ad = txtIcerikAdi.Text,
                    adet = cmbAdet.Text,
                    fiyat = txtFiyat.Text,
                };

                yeniIcerik.kategoriID = dbContext.Kategori
                    .Where(k => k.ad == selectedCategory)
                    .Select(k => k.kategoriID)
                    .FirstOrDefault();

                dbContext.Icerik.Add(yeniIcerik);
                dbContext.SaveChanges();

                btnAra.PerformClick(); 

                MessageBox.Show("İçerik başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {

           

            string selectedCategory = cmbKategoriAdi.SelectedItem?.ToString();

            try
            {
                var query = dbContext.Icerik
                    .Include(i => i.Kategori)
                    .Where(i => i.Kategori.ad == selectedCategory)
                    .ToList();

                dgvSearch.DataSource = null;

                dgvSearch.AutoGenerateColumns = false;

                dgvSearch.DataSource = query;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int icerikID;

                if (!int.TryParse(txtIcerikID.Text, out icerikID))
                {
                    MessageBox.Show("Geçerli bir IcerikID girin.");
                    return;
                }

                Icerik silinecekIcerik = dbContext.Icerik.FirstOrDefault(i => i.icerikID == icerikID);

                if (silinecekIcerik != null)
                {
                    dbContext.Icerik.Remove(silinecekIcerik);
                    dbContext.SaveChanges();

                    txtIcerikAdi.Clear();
                    cmbAdet.SelectedIndex = -1; 
                    txtFiyat.Clear();
                    txtIcerikID.Clear();

                    MessageBox.Show("İçerik başarıyla silindi.");
                    btnAra.PerformClick(); 

                }
                else
                {
                    MessageBox.Show("Silinecek içerik bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int icerikID;

                if (!int.TryParse(txtIcerikID.Text, out icerikID))
                {
                    MessageBox.Show("Geçerli bir IcerikID girin.");
                    return;
                }

                Icerik guncellenecekIcerik = dbContext.Icerik.FirstOrDefault(i => i.icerikID == icerikID);

                if (guncellenecekIcerik != null)
                {
                    guncellenecekIcerik.ad = txtIcerikAdi.Text;
                    guncellenecekIcerik.adet = cmbAdet.Text;
                    guncellenecekIcerik.fiyat = txtFiyat.Text;

                    dbContext.SaveChanges();

                    btnAra.PerformClick(); 

                    MessageBox.Show("İçerik başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncellenecek içerik bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void txtIcerikID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}