using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Moon_Coffee.Model;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core;

namespace Moon_Coffee
{

    public partial class Menu : Form
    {
        private readonly MoonCoffeeContext dbContext = new MoonCoffeeContext();
        private List<SepetUrun> sepetUrunListesi = new List<SepetUrun>();
        private Dictionary<string, int> sutIDMapping = new Dictionary<string, int>();
        private Dictionary<string, int> surupIDMapping = new Dictionary<string, int>();

        public Menu()
        {
            InitializeComponent();

            try
            {
                using (var dbContext = new MoonCoffeeContext())
                {
                    var sutListesi = dbContext.sut.ToList();
                    var surupListesi = dbContext.surup.ToList();

                    foreach (var sut in sutListesi)
                    {
                        sutIDMapping[sut.ad] = sut.sutID;
                    }

                    foreach (var surup in surupListesi)
                    {
                        surupIDMapping[surup.ad] = surup.surupID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void button4_Click(object sender, EventArgs e)
        {
            IcerikEkle ıcerikEkle = new IcerikEkle();
            ıcerikEkle.Show();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new MoonCoffeeContext())
                {
                    var sut = dbContext.sut.Select(u => u.ad).ToList();
                    var surup = dbContext.surup.Select(s => s.ad).ToList();
                    var masa = dbContext.Masa.Select(s => s.masaNo).ToList();


                    cmbSutSecimi.Items.Clear();
                    cmbSurupSecimi.Items.Clear();
                    cmbMasa.Items.Clear();


                    cmbSutSecimi.Items.AddRange(sut.Select(ad => ad.ToString()).ToArray());
                    cmbSurupSecimi.Items.AddRange(surup.Select(ad => ad.ToString()).ToArray());
                    cmbMasa.Items.AddRange(masa.Select(ad => ad.ToString()).ToArray());


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.ToString());
            }

        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new MoonCoffeeContext())
                {

                    DateTime tarih = DateTime.Now;
                    string odemeTurAdi = "Nakit";

                    OdemeTuru odemeTuru = GetOdemeTuruByAd(odemeTurAdi);

                    List<Satıs> satısListesi = new List<Satıs>();

                    string ad = txtMusteriAd.Text;
                    string soyad = txtMusteriSoyad.Text;
                    string toplamTutar = txtToplamTutar.Text;

                    Gecmis yeniGecmis = new Gecmis
                    {
                        ad = ad,
                        soyad = soyad,
                        tarihh = tarih,
                        toplamTutar = toplamTutar,
                        odemeTur = odemeTurAdi
                    };

                    dbContext.Gecmis.Add(yeniGecmis);
                    dbContext.SaveChanges();

                    int gecmisID = yeniGecmis.gecmisID;



                    foreach (DataGridViewRow row in dataGridViewSepet.Rows)
                    {
                        int urunID = Convert.ToInt32(row.Cells["UrunID"].Value);
                        int adet = Convert.ToInt32(row.Cells["UrunAdet"].Value);
                        string sutSecimi = row.Cells["SutSecimi"].Value.ToString();
                        string surupSecimi = row.Cells["surupSecimi"].Value.ToString();
                        string bardakBoy = row.Cells["BardakBoy"].Value.ToString(); 




                        int sutID = sutIDMapping.ContainsKey(sutSecimi) ? sutIDMapping[sutSecimi] : 0;
                        int surupID = surupIDMapping.ContainsKey(surupSecimi) ? surupIDMapping[surupSecimi] : 0;
                        int ekstraID = GetEkstraID(sutID, surupID);
                        int bardakBoyID = GetBardakBoyIDByText(bardakBoy);




                        for (int i = 0; i < adet; i++)
                        {
                            Satıs yeniSatis = new Satıs
                            {
                                gecmisID = gecmisID,
                                icerikID = urunID,
                                ekstraID = ekstraID,
                                bardakBoyID = bardakBoyID, 
                                tarih = tarih,


                            };

                            satısListesi.Add(yeniSatis);
                        }
                    }

                    dbContext.Satıs.AddRange(satısListesi);
                    dbContext.SaveChanges();

                    dataGridViewSepet.Rows.Clear();

                    MessageBox.Show("Satışlar başarıyla tamamlandı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private int GetBardakBoyIDByText(string bardakBoyText)
        {
            using (var dbContext = new MoonCoffeeContext())
            {
                BardakBoy bardakBoy = dbContext.BardakBoy.FirstOrDefault(b => b.boy == bardakBoyText);
                return bardakBoy != null ? bardakBoy.bardakBoyID : 0;
            }
        }

        private void btnSicakKahve_Click(object sender, EventArgs e)
        {
            try
            {
                var sicakKahveler = dbContext.Icerik
                    .Where(i => i.Kategori.ad == "Sıcak Kahve")
                    .Select(i => new
                    {
                        UrunID = i.icerikID,
                        UrunAd = i.ad,
                        UrunKategori = i.Kategori.ad,
                        UrunAdet = i.adet,
                        UrunFiyat = i.fiyat
                    })
                    .ToList();

                dataGridViewMenu.DataSource = sicakKahveler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem hatası: " + ex.Message);
            }
        }


        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                txtUrunID.Text = dataGridViewMenu.Rows[rowIndex].Cells["UrunID"].Value.ToString();
                txtUrunAd.Text = dataGridViewMenu.Rows[rowIndex].Cells["UrunAd"].Value.ToString();
                txtUrunKategori.Text = dataGridViewMenu.Rows[rowIndex].Cells["UrunKategori"].Value.ToString();
                txtUrunStok.Text = dataGridViewMenu.Rows[rowIndex].Cells["UrunAdet"].Value.ToString();
                txtUrunFiyat.Text = dataGridViewMenu.Rows[rowIndex].Cells["UrunFiyat"].Value.ToString();
            }

        }

        private void btnSogukKahve_Click(object sender, EventArgs e)
        {
            try
            {
                var sogukKahveler = dbContext.Icerik
                    .Where(i => i.Kategori.ad == "Soğuk Kahve")
                    .Select(i => new
                    {
                        UrunID = i.icerikID,
                        UrunAd = i.ad,
                        UrunKategori = i.Kategori.ad,
                        UrunAdet = i.adet,
                        UrunFiyat = i.fiyat
                    })
                    .ToList();

                dataGridViewMenu.DataSource = sogukKahveler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem hatası: " + ex.Message);
            }
        }

        private void dataGridViewSepet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chbKucuk_CheckedChanged(object sender, EventArgs e)
        {
            if (chbKucuk.Checked)
            {
                chbBuyuk.Checked = false;
                chbOrta.Checked = false;
            }
        }

        private void chbOrta_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOrta.Checked)
            {
                chbBuyuk.Checked = false;
                chbKucuk.Checked = false;
            }
        }

        private void chbBuyuk_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBuyuk.Checked)
            {
                chbOrta.Checked = false;
                chbKucuk.Checked = false;
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {

              
                    int urunID = Convert.ToInt32(txtUrunID.Text);
                    string urunAd = txtUrunAd.Text;
                    string urunKategori = txtUrunKategori.Text;

                    string bardakBoy = GetSeciliBardakBoy();

                    string sutSecimi = cmbSutSecimi.SelectedItem?.ToString() ?? "Normal Süt";
                    string surupSecimi = cmbSurupSecimi.SelectedItem?.ToString() ?? "Yok";

                    decimal urunFiyat = Convert.ToDecimal(txtUrunFiyat.Text.Replace(" TL", ""));


                    decimal toplamFiyat = 0;

                    toplamFiyat += urunFiyat;
                    decimal sutFiyat = 5.0m;
                    decimal surupFiyat = 5.0m;

                    if (!string.IsNullOrEmpty(sutSecimi) && sutSecimi != "Normal Süt")
                    {
                        toplamFiyat += sutFiyat;
                    }

                    if (!string.IsNullOrEmpty(surupSecimi) && surupSecimi != "Yok")
                    {
                        toplamFiyat += surupFiyat;
                    }

                    decimal kucukBoyFiyat = 2.0m;
                    decimal ortaBoyFiyat = 4.0m;
                    decimal buyukBoyFiyat = 6.0m;

                    if (chbKucuk.Checked)
                    {
                        toplamFiyat += kucukBoyFiyat;
                    }

                    if (chbOrta.Checked)
                    {
                        toplamFiyat += ortaBoyFiyat;
                    }

                    if (chbBuyuk.Checked)
                    {
                        toplamFiyat += buyukBoyFiyat;
                    }

                    bool enAzBirBoySecildi = chbKucuk.Checked || chbOrta.Checked || chbBuyuk.Checked;

                    if (!enAzBirBoySecildi)
                    {
                       MessageBox.Show("Bardak boyu seçiniz.");
                       return;
                    }



                SepetUrun sepetUrun = new SepetUrun
                    {
                        UrunID = urunID,
                        UrunAd = urunAd,
                        UrunAdet = 1,
                        SutSecimi = sutSecimi,
                        SurupSecimi = surupSecimi,
                        BardakBoy = bardakBoy,
                        UrunFiyat = toplamFiyat
                    };

                    EkleSepete(sepetUrun);

                




                GuncelleDataGridViewSepet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem hatası: " + ex.Message);
            }
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            dataGridViewSepet.Rows.Clear();
            sepetUrunListesi.Clear();
        }

        private void EkleSepete(SepetUrun sepetUrun)
        {
            for (int i = 0; i < sepetUrun.UrunAdet; i++)
            {
                var eskiUrun = sepetUrunListesi.FirstOrDefault(u =>
                    u.UrunID == sepetUrun.UrunID &&
                    u.SutSecimi == sepetUrun.SutSecimi &&
                    u.SurupSecimi == sepetUrun.SurupSecimi &&
                    u.BardakBoy == sepetUrun.BardakBoy);

                if (eskiUrun != null)
                {
                    int fiyat;
                    fiyat = Convert.ToInt32(txtUrunFiyat.Text);

                    eskiUrun.UrunAdet += sepetUrun.UrunAdet;

                    eskiUrun.UrunFiyat = eskiUrun.UrunAdet * fiyat;

                }
                else
                {
                    sepetUrunListesi.Add(new SepetUrun
                    {
                        UrunID = sepetUrun.UrunID,
                        UrunAd = sepetUrun.UrunAd,
                        UrunAdet = sepetUrun.UrunAdet,
                        SutSecimi = sepetUrun.SutSecimi,
                        SurupSecimi = sepetUrun.SurupSecimi,
                        BardakBoy = sepetUrun.BardakBoy,
                        UrunFiyat = sepetUrun.UrunFiyat
                    });
                }
            }
        }

        private void GuncelleDataGridViewSepet()
        {
            dataGridViewSepet.Rows.Clear();

            foreach (var sepetUrun in sepetUrunListesi)
            {
                dataGridViewSepet.Rows.Add(
                    sepetUrun.UrunID,
                    sepetUrun.UrunAd,
                    sepetUrun.UrunAdet,
                    sepetUrun.SutSecimi,
                    sepetUrun.SurupSecimi,
                    sepetUrun.BardakBoy,
                    sepetUrun.UrunFiyat.ToString("C"));
            }

            HesaplaVeToplamFiyatGuncelle();
        }

        private string GetSeciliBardakBoy()
        {
            if (chbBuyuk.Checked)
            {
                chbOrta.Checked = false;
                chbKucuk.Checked = false;
                return "Büyük";
            }
            else if (chbOrta.Checked)
            {
                chbBuyuk.Checked = false;
                chbKucuk.Checked = false;
                return "Orta";
            }
            else if (chbKucuk.Checked)
            {
                chbBuyuk.Checked = false;
                chbOrta.Checked = false;
                return "Küçük";
            }

            return string.Empty;
        }

        private void HesaplaVeToplamFiyatGuncelle()
        {
            decimal toplamFiyat = sepetUrunListesi.Sum(u => u.UrunFiyat);
            txtToplamTutar.Text = toplamFiyat.ToString("C");
        }



        private OdemeTuru GetOdemeTuruByAd(string odemeTurAdi)
        {
            using (var dbContext = new MoonCoffeeContext())
            {
                return dbContext.OdemeTuru.FirstOrDefault(ot => ot.odemeTuru1 == odemeTurAdi);
            }
        }

        private void btnKrediKarti_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new MoonCoffeeContext())
                {

                    DateTime tarih = DateTime.Now;
                    string odemeTurAdi = "Kredi Kartı";

                    OdemeTuru odemeTuru = GetOdemeTuruByAd(odemeTurAdi);

                    List<Satıs> satısListesi = new List<Satıs>();

                    string ad = txtMusteriAd.Text;
                    string soyad = txtMusteriSoyad.Text;
                    string toplamTutar = txtToplamTutar.Text;

                    Gecmis yeniGecmis = new Gecmis
                    {
                        ad = ad,
                        soyad = soyad,
                        tarihh = tarih,
                        toplamTutar = toplamTutar,
                        odemeTur = odemeTurAdi
                    };

                    dbContext.Gecmis.Add(yeniGecmis);
                    dbContext.SaveChanges();

                    int gecmisID = yeniGecmis.gecmisID;

                    foreach (DataGridViewRow row in dataGridViewSepet.Rows)
                    {
                        int urunID = Convert.ToInt32(row.Cells["UrunID"].Value);
                        int adet = Convert.ToInt32(row.Cells["UrunAdet"].Value);
                        string sutSecimi = row.Cells["SutSecimi"].Value.ToString();
                        string surupSecimi = row.Cells["surupSecimi"].Value.ToString();
                        string bardakBoy = row.Cells["BardakBoy"].Value.ToString(); 




                        int sutID = sutIDMapping.ContainsKey(sutSecimi) ? sutIDMapping[sutSecimi] : 0;
                        int surupID = surupIDMapping.ContainsKey(surupSecimi) ? surupIDMapping[surupSecimi] : 0;
                        int ekstraID = GetEkstraID(sutID, surupID);
                        int bardakBoyID = GetBardakBoyIDByText(bardakBoy);



                        for (int i = 0; i < adet; i++)
                        {
                            Satıs yeniSatis = new Satıs
                            {
                                gecmisID = gecmisID,
                                icerikID = urunID,
                                ekstraID = ekstraID,
                                bardakBoyID = bardakBoyID,

                                tarih = tarih,


                            };

                            satısListesi.Add(yeniSatis);
                        }
                    }

                    dbContext.Satıs.AddRange(satısListesi);
                    dbContext.SaveChanges();

                    dataGridViewSepet.Rows.Clear();

                    MessageBox.Show("Satışlar başarıyla tamamlandı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private int GetEkstraID(int sutID, int surupID)
        {
            using (var dbContext = new MoonCoffeeContext())
            {
                var ekstra = dbContext.Ekstra.FirstOrDefault(e => e.sutID == sutID && e.surupID == surupID);
                return ekstra != null ? ekstra.ekstraID : 0;
            }
        }



        private void btnBubbleTea_Click(object sender, EventArgs e)
        {
            try
            {
                var bubbletea = dbContext.Icerik
                    .Where(i => i.Kategori.ad == "Bubble Tea")
                    .Select(i => new
                    {
                        UrunID = i.icerikID,
                        UrunAd = i.ad,
                        UrunKategori = i.Kategori.ad,
                        UrunAdet = i.adet,
                        UrunFiyat = i.fiyat
                    })
                    .ToList();

                dataGridViewMenu.DataSource = bubbletea;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem hatası: " + ex.Message);
            }
        }

        private void btnFrozen_Click(object sender, EventArgs e)
        {
            try
            {
                var frozen = dbContext.Icerik
                    .Where(i => i.Kategori.ad == "Frozen")
                    .Select(i => new
                    {
                        UrunID = i.icerikID,
                        UrunAd = i.ad,
                        UrunKategori = i.Kategori.ad,
                        UrunAdet = i.adet,
                        UrunFiyat = i.fiyat
                    })
                    .ToList();

                dataGridViewMenu.DataSource = frozen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem hatası: " + ex.Message);
            }
        }

        private void btnMilkshake_Click(object sender, EventArgs e)
        {
            try
            {
                var milkshake = dbContext.Icerik
                    .Where(i => i.Kategori.ad == "Milkshake")
                    .Select(i => new
                    {
                        UrunID = i.icerikID,
                        UrunAd = i.ad,
                        UrunKategori = i.Kategori.ad,
                        UrunAdet = i.adet,
                        UrunFiyat = i.fiyat
                    })
                    .ToList();

                dataGridViewMenu.DataSource = milkshake;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem hatası: " + ex.Message);
            }
        }

        private void btnSmoothie_Click(object sender, EventArgs e)
        {
            try
            {
                var smoothie = dbContext.Icerik
                    .Where(i => i.Kategori.ad == "Smoothie")
                    .Select(i => new
                    {
                        UrunID = i.icerikID,
                        UrunAd = i.ad,
                        UrunKategori = i.Kategori.ad,
                        UrunAdet = i.adet,
                        UrunFiyat = i.fiyat
                    })
                    .ToList();

                dataGridViewMenu.DataSource = smoothie;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem hatası: " + ex.Message);
            }
        }

        private void btnIcecekler_Click(object sender, EventArgs e)
        {
            try
            {
                var icecekler = dbContext.Icerik
                    .Where(i => i.Kategori.ad == "içecekler")
                    .Select(i => new
                    {
                        UrunID = i.icerikID,
                        UrunAd = i.ad,
                        UrunKategori = i.Kategori.ad,
                        UrunAdet = i.adet,
                        UrunFiyat = i.fiyat
                    })
                    .ToList();

                dataGridViewMenu.DataSource = icecekler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem hatası: " + ex.Message);
            }
        }

        private void btnAtistirmalik_Click(object sender, EventArgs e)
        {
            try
            {
                var atıştırmalık = dbContext.Icerik
                    .Where(i => i.Kategori.ad == "Atıştırmalık")
                    .Select(i => new
                    {
                        UrunID = i.icerikID,
                        UrunAd = i.ad,
                        UrunKategori = i.Kategori.ad,
                        UrunAdet = i.adet,
                        UrunFiyat = i.fiyat
                    })
                    .ToList();

                dataGridViewMenu.DataSource = atıştırmalık;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem hatası: " + ex.Message);
            }
        }

        private void cmbSutSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSurupSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnMasaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new MoonCoffeeContext())
                {
                    DateTime tarih = DateTime.Now;

                    Masa guncellenecekMasa = dbContext.Masa.FirstOrDefault(m => m.masaNo == cmbMasa.SelectedItem.ToString());

                    if (guncellenecekMasa != null)
                    {
                        guncellenecekMasa.masaDurum = true;

                        dbContext.SaveChanges();
                    }

                    int masaID = guncellenecekMasa.masaID;

                    foreach (DataGridViewRow row in dataGridViewSepet.Rows)
                    {
                        int urunID = Convert.ToInt32(row.Cells["UrunID"].Value);
                        int adet = Convert.ToInt32(row.Cells["UrunAdet"].Value);
                        string sutSecimi = row.Cells["SutSecimi"].Value.ToString();
                        string surupSecimi = row.Cells["surupSecimi"].Value.ToString();
                        string bardakBoy = row.Cells["BardakBoy"].Value.ToString();


                        int sutID = sutIDMapping.ContainsKey(sutSecimi) ? sutIDMapping[sutSecimi] : 0;
                        int surupID = surupIDMapping.ContainsKey(surupSecimi) ? surupIDMapping[surupSecimi] : 0;
                        int ekstraID = GetEkstraID(sutID, surupID);
                        int bardakBoyID = GetBardakBoyIDByText(bardakBoy);


                        for (int i = 0; i < adet; i++)
                        {
                            Satıs yeniSatis = new Satıs
                            {
                                icerikID = urunID,
                                ekstraID = ekstraID,
                                bardakBoyID = bardakBoyID, 
                                tarih = tarih,
                                masaID = masaID,
                            };

                            dbContext.Satıs.Add(yeniSatis);
                        }
                    }

                    dbContext.SaveChanges();

                    MessageBox.Show("Masa başarıyla eklendi ve satışlar güncellendi!");
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void cmbMasa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void rbSelfServis_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
