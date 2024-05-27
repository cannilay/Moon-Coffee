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
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;

namespace Moon_Coffee
{
    public partial class Kayit : Form
    {
        private readonly MoonCoffeeContext dbContext = new MoonCoffeeContext();
        public Kayit()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void Kayit_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string cinsiyet = cmbCinsiyet.Text;
            string telefon = txtTelefon.Text;
            string eposta = txtEposta.Text;
            string adres = txtAdres.Text;
            string unvan = cmbUnvan.Text;
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(cinsiyet) ||
                string.IsNullOrWhiteSpace(telefon) || string.IsNullOrWhiteSpace(eposta) || string.IsNullOrWhiteSpace(adres) ||
                string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre) || string.IsNullOrWhiteSpace(unvan))
            {
                MessageBox.Show("Tüm bilgileri eksiksiz doldurun!");
                return;
            }

            if (KayitEkle(ad, soyad, cinsiyet, telefon, eposta, adres, unvan, kullaniciAdi, sifre))
            {
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt eklenirken bir hata oluştu.");
            }
        }
        private bool KayitEkle(string ad, string soyad, string cinsiyet, string telefon, string eposta, string adres, string unvan, string kullaniciAdi, string sifre)
        {
            try
            {
                Kullanici yeniKullanici = new Kullanici
                {
                    ad = ad,
                    soyad = soyad,
                    cinsiyet = cinsiyet,
                    telefon = telefon,
                    eposta = eposta,
                    adres = adres,
                    unvan = unvan,
                    kullaniciAdi = kullaniciAdi,
                    sifre = sifre,
                    kayitTarihi = DateTime.Now 
                };

                dbContext.Kullanici.Add(yeniKullanici);
                dbContext.SaveChanges();

                int kullaniciSayisi = dbContext.Kullanici.Count(k => k.ad == kullaniciAdi && k.sifre == sifre);

                return kullaniciSayisi > 0;
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder errorDetails = new StringBuilder("Validation Errors:");
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var error in validationErrors.ValidationErrors)
                    {
                        errorDetails.AppendLine($"Property: {error.PropertyName}, Error: {error.ErrorMessage}");
                    }
                }
                MessageBox.Show(errorDetails.ToString());
                return false;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("DbUpdateException: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return false;
            }
        }
    

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

