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
    public partial class Masalar : Form
    {
        private ButtonManager buttonManager;
        private string secilenButonText;


        public Masalar()
        {
            InitializeComponent();
            buttonManager = new ButtonManager(5, 6);
            InitializeUI();
            buttonManager.ButtonClick += ButtonManager_ButtonClick;

        }
        private void InitializeUI()
        {
            List<System.Windows.Forms.Button> buttons = buttonManager.GetButtons();
            pnlMasa.Controls.AddRange(buttons.ToArray());
        }

        private void Masa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Gezgin gezgin = new Gezgin();
            gezgin.Show();
            this.Close();
        }

        private void pnlMasa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string masaNo = txtMasaNo.Text;

            if (string.IsNullOrEmpty(masaNo))
            {
                MessageBox.Show("Lütfen masa numarasını girin.");
                return;
            }

            int masaID = GetMasaIDFromMasaNo(masaNo);

            if (masaID == -1)
            {
                MessageBox.Show("Masa bulunamadı.");
                return;
            }


            UpdateDataGridViewWithSiparis(masaID);
            decimal total = 0;


            foreach (DataGridViewRow row in dgvSepet.Rows)
            {
                if (row.Cells["Fiyat"].Value != null)
                {

                    total += Convert.ToDecimal(row.Cells["Fiyat"].Value);
                }
            }


            txtToplamTutar.Text = total.ToString();
        }
        private void UpdateDataGridViewWithSiparis(int masaID)
        {
            using (var dbContext = new MoonCoffeeContext())
            {
                var satısListesi = dbContext.Satıs
                    .Where(s => s.masaID == masaID) 
                    .Select(s => new
                    {
                        SatisID = s.satisID,
                        IcerikAd = s.Icerik.ad,
                        Surup = s.Ekstra.surup.ad,
                        Sut = s.Ekstra.sut.ad,
                        BardakBoy = s.BardakBoy.boy,
                        MasaNo = s.Masa.masaNo,
                        Fiyat = s.Icerik.fiyat,
                        Tarih = s.tarih

            })
                    .ToList();


                dgvSepet.DataSource = satısListesi;
            }
        }

        private int GetMasaIDFromMasaNo(string masaNo)
        {
            using (var dbContext = new MoonCoffeeContext())
            {
                Masa masa = dbContext.Masa.FirstOrDefault(m => m.masaNo == masaNo);

                return masa != null ? masa.masaID : -1;
            }
        }

        private void btnKrediKarti_Click(object sender, EventArgs e)
        {

            using (var dbContext = new MoonCoffeeContext())
            {
                DateTime tarih = DateTime.Now;
                string odemeTurAdi = "Kredi Kartı";



                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string toplamTutar = txtToplamTutar.Text;

                if (dgvSepet.Rows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir masa seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Gecmis yeniGecmisIslem = new Gecmis
                {
                    ad = ad,
                    soyad = soyad,
                    tarihh = tarih,
                    toplamTutar = toplamTutar,
                    odemeTur = odemeTurAdi
                };

                dbContext.Gecmis.Add(yeniGecmisIslem);
                dbContext.SaveChanges();

                int gecmisID = yeniGecmisIslem.gecmisID; 

                foreach (DataGridViewRow row in dgvSepet.Rows)
                {
                    if (row.Cells["SatisID"].Value != null)
                    {
                        int siparisID = Convert.ToInt32(row.Cells["SatisID"].Value);

                  
                        var siparis = dbContext.Satıs.FirstOrDefault(s => s.satisID == siparisID);

                        if (siparis != null)
                        {
              
                            siparis.gecmisID = gecmisID;
                            siparis.Masa.masaDurum = false;
                            siparis.masaID = 0;
                        }
                    }
                }
                dbContext.SaveChanges();

            }

            MessageBox.Show("İşlem başarıyla gerçekleştirildi.");
            Masalar yeniMasalarFormu = new Masalar();

         
            this.Close();

        
            yeniMasalarFormu.Show();

        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
            using (var dbContext = new MoonCoffeeContext())
            {
                DateTime tarih = DateTime.Now;
                string odemeTurAdi = "Nakit";



                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string toplamTutar = txtToplamTutar.Text;

                if (dgvSepet.Rows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir masa seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Gecmis yeniGecmisIslem = new Gecmis
                {
                    ad = ad,
                    soyad = soyad,
                    tarihh = tarih,
                    toplamTutar = toplamTutar,
                    odemeTur = odemeTurAdi
                };

                dbContext.Gecmis.Add(yeniGecmisIslem);
                dbContext.SaveChanges();

                int gecmisID = yeniGecmisIslem.gecmisID; 

                foreach (DataGridViewRow row in dgvSepet.Rows)
                {
                    if (row.Cells["SatisID"].Value != null)
                    {
                        int siparisID = Convert.ToInt32(row.Cells["SatisID"].Value);

                   
                        var siparis = dbContext.Satıs.FirstOrDefault(s => s.satisID == siparisID);

                        if (siparis != null)
                        {
                     
                            siparis.gecmisID = gecmisID;
                            siparis.Masa.masaDurum = false;
                            siparis.masaID = 0;
                        }
                    }
                }

          
                dbContext.SaveChanges();
            }

            MessageBox.Show("İşlem başarıyla gerçekleştirildi.");
            Masalar yeniMasalarFormu = new Masalar();

      
            this.Close();

      
            yeniMasalarFormu.Show();

        }

        private void txtToplamTutar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMasaNo_TextChanged(object sender, EventArgs e)
        {

            buttonManager.ButtonClick += ButtonManager_ButtonClick;

        }
        private void ButtonManager_ButtonClick(object sender, ButtonClickEventArgs e)
        {
            secilenButonText = e.ButtonText;

            if (secilenButonText.Length == 6)
            {
                string sonIkiKarakter = secilenButonText.Substring(secilenButonText.Length - 1);
                txtMasaNo.Text = sonIkiKarakter;

            }
            else
            {
                string altiVeYedinciKarakterler = secilenButonText.Substring(5, 2);
                txtMasaNo.Text = altiVeYedinciKarakterler;
            }
        }
    }
}
