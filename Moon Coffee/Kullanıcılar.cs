using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moon_Coffee.Model;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Moon_Coffee
{
    public partial class Kullanıcılar : Form
    {
        private MoonCoffeeContext dbContext = new MoonCoffeeContext();

        public Kullanıcılar()
        {
            InitializeComponent();
            cmbCinsiyet.Items.AddRange(new string[] { "Erkek", "Kadın" });
            cmbUnvan.Items.AddRange(new string[] { "Barmen", "Kasiyer", "Temizlikçi", "Garson", "Yönetici" });
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MoonCoffeeContext())
                {
                    var kullaniciListesi = context.Kullanici.ToList();

                    dgvSonuc.Rows.Clear();

                    if (dgvSonuc.ColumnCount == 0)
                    {
                        dgvSonuc.Columns.Add("kullaniciID", "Kullanıcı ID");
                        dgvSonuc.Columns.Add("ad", "Ad");
                        dgvSonuc.Columns.Add("soyad", "Soyad");
                        dgvSonuc.Columns.Add("telefon", "Telefon");
                        dgvSonuc.Columns.Add("eposta", "Eposta");
                        dgvSonuc.Columns.Add("adres", "Adres");
                        dgvSonuc.Columns.Add("cinsiyet", "Cinsiyet");
                        dgvSonuc.Columns.Add("unvan", "Unvan");
                        dgvSonuc.Columns.Add("kayitTarihi", "Kayit Tarihi");
                        dgvSonuc.Columns.Add("ayrilmaTarihi", "Ayrılma Tarihi");
                    }

                    foreach (var kullanici in kullaniciListesi)
                    {
                        dgvSonuc.Rows.Add(
                            kullanici.kullaniciID,
                            kullanici.ad,
                            kullanici.soyad,
                            kullanici.telefon,
                            kullanici.eposta,
                            kullanici.adres,
                            kullanici.cinsiyet,
                            kullanici.unvan,
                            kullanici.kayitTarihi,
                            kullanici.ayrilmaTarihi
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}\nİç Hata: {ex.InnerException?.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSonuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSonuc.Rows[e.RowIndex];

                string kullaniciID = row.Cells["kullaniciID"].Value.ToString();
                string ad = row.Cells["ad"].Value.ToString();
                string soyad = row.Cells["soyad"].Value.ToString();
                string telefon = row.Cells["telefon"].Value.ToString();
                string eposta = row.Cells["eposta"].Value.ToString();
                string adres = row.Cells["adres"].Value.ToString();
                string cinsiyet = row.Cells["cinsiyet"].Value.ToString();
                string unvan = row.Cells["unvan"].Value.ToString();

                txtID.Text = kullaniciID;
                txtAd.Text = ad;
                txtSoyad.Text = soyad;
                txtTelefon.Text = telefon;
                txtEposta.Text = eposta;
                txtAdres.Text = adres;
                cmbCinsiyet.SelectedItem = cinsiyet;
                cmbUnvan.SelectedItem = unvan;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string idStr = txtID.Text.Trim();

            if (!string.IsNullOrEmpty(idStr) && int.TryParse(idStr, out int selectedUserID))
            {
                DialogResult result = MessageBox.Show("Belirtilen kullanıcıyı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var context = new MoonCoffeeContext())
                        {
                            var userToDelete = context.Kullanici.FirstOrDefault(k => k.kullaniciID == selectedUserID);

                            if (userToDelete != null)
                            {
                                context.Kullanici.Remove(userToDelete);
                                context.SaveChanges();

                                MessageBox.Show("Kullanıcı başarıyla silindi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtID.Clear();

                                var rowToDelete = dgvSonuc.Rows
                                    .Cast<DataGridViewRow>()
                                    .FirstOrDefault(row => Convert.ToInt32(row.Cells["kullaniciID"].Value) == selectedUserID);

                                if (rowToDelete != null)
                                    dgvSonuc.Rows.Remove(rowToDelete);
                            }
                            else
                            {
                                MessageBox.Show("Belirtilen ID ile kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ID girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                int kullaniciID;

                if (!int.TryParse(txtID.Text, out kullaniciID))
                {
                    MessageBox.Show("Geçerli bir KullaniciID girin.");
                    return;
                }

                Kullanici guncellenecekKullanici = dbContext.Kullanici.FirstOrDefault(k => k.kullaniciID == kullaniciID);

                if (guncellenecekKullanici != null)
                {
                    guncellenecekKullanici.ad = txtAd.Text;
                    guncellenecekKullanici.soyad = txtSoyad.Text;
                    guncellenecekKullanici.telefon = txtTelefon.Text;
                    guncellenecekKullanici.eposta = txtEposta.Text;
                    guncellenecekKullanici.adres = txtAdres.Text;
                    guncellenecekKullanici.cinsiyet = cmbCinsiyet.Text;
                    guncellenecekKullanici.unvan = cmbUnvan.Text;

                    dbContext.SaveChanges();

                    btnListele.PerformClick();

                    MessageBox.Show("Kullanıcı başarıyla düzenlendi.");
                }
                else
                {
                    MessageBox.Show("Düzenlenecek kullanıcı bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}



