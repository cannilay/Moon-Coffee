using Moon_Coffee.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon_Coffee
{
    public partial class Gecmisler : Form
    {

        public Gecmisler()
        {
            InitializeComponent();
          
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Gezgin gezgin = new Gezgin();
            gezgin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSonuc.Rows.Count)
            {
                DataGridViewRow row = dgvSonuc.Rows[e.RowIndex];


                cmbUrunAd.Text = row.Cells["İcerikAd"].Value.ToString();
                cmbKategori.Text = row.Cells["Kategori"].Value.ToString();
                txtAd.Text = row.Cells["MusteriAd"].Value.ToString();
                txtSoyad.Text = row.Cells["MusteriSoyad"].Value.ToString();              
                dtpTarih.Text = row.Cells["Tarih"].Value.ToString();
                txtToplam.Text = row.Cells["Fiyat"].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MoonCoffeeContext())
                {
                    var filtrelenmisIslemler = context.Satıs
                        .Select(g => new
                        {
                            SatısID = g.satisID,
                            MusteriAd = g.Gecmis.ad,
                            MusteriSoyad = g.Gecmis.soyad,
                            Kategori = g.Icerik.Kategori.ad,
                            Icerik = g.Icerik.fiyat,
                            İcerikAd = g.Icerik.ad,
                            Sut = g.Ekstra.sut.ad,
                            Surup = g.Ekstra.surup.ad,
                            BardakBoy = g.BardakBoy.boy,
                            Tarih = g.tarih,
                            Fiyat = g.Gecmis.toplamTutar
                            
                        })
                        .ToList();


                    if (!string.IsNullOrEmpty(txtAd.Text))
                    {
                        filtrelenmisIslemler = filtrelenmisIslemler
                            .Where(g => g.MusteriAd.ToLower().Contains(txtAd.Text.ToLower()))
                            .ToList();
                    }

                    if (!string.IsNullOrEmpty(txtSoyad.Text))
                    {
                        filtrelenmisIslemler = filtrelenmisIslemler
                            .Where(g => g.MusteriSoyad.ToLower().Contains(txtSoyad.Text.ToLower()))
                            .ToList();
                    }

                    if (!string.IsNullOrEmpty(cmbKategori.Text))
                    {
                        filtrelenmisIslemler = filtrelenmisIslemler
                            .Where(g => g.Kategori.ToLower().Contains(cmbKategori.Text.ToLower()))
                            .ToList();
                    }

                    if (!string.IsNullOrEmpty(cmbUrunAd.Text))
                    {
                        filtrelenmisIslemler = filtrelenmisIslemler
                            .Where(g => g.İcerikAd.ToLower().Contains(cmbUrunAd.Text.ToLower()))
                            .ToList();
                    }

                    if (dtpTarih.Checked)
                    {
                        filtrelenmisIslemler = filtrelenmisIslemler
                            .Where(g => g.Tarih == dtpTarih.Value.Date)
                            .ToList();
                    }

                    dgvSonuc.DataSource = filtrelenmisIslemler.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

     

        }

        private void Gecmis_Load(object sender, EventArgs e)
        {
            LoadSepetData();
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            try
            {
                using (var dbContext = new MoonCoffeeContext())
                {
                    var kategori = dbContext.Kategori.Select(k => k.ad).ToList();
                    var icerik = dbContext.Icerik.Select(i => i.ad).ToList();

                    cmbKategori.Items.Clear();
                    cmbUrunAd.Items.Clear();

                    cmbKategori.Items.AddRange(kategori.Select(ad => ad.ToString()).ToArray());
                    cmbUrunAd.Items.AddRange(icerik.Select(ad => ad.ToString()).ToArray());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.ToString());
            }

        }

        private void LoadSepetData()
        {
            try
            {
                using (var context = new MoonCoffeeContext())
                {
                    var gecmisIslemler = context.Satıs
                        .Where(g => g.Gecmis.gecmisID != null)  
                        .Select(g => new
                        {
                            SatısID = g.satisID,
                            MusteriAd = g.Gecmis.ad,
                            MusteriSoyad = g.Gecmis.soyad,
                            Kategori = g.Icerik.Kategori.ad,
                            Icerik = g.Icerik.fiyat,
                            İcerikAd = g.Icerik.ad,
                            Sut = g.Ekstra.sut.ad,
                            Surup = g.Ekstra.surup.ad,
                            BardakBoy = g.BardakBoy.boy,
                            Tarih = g.tarih,
                            Fiyat = g.Gecmis.toplamTutar
                        })
                        .ToList();

                    dgvSonuc.DataSource = gecmisIslemler;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
