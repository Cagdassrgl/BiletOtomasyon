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

namespace BiletOtomasyon
{
    public partial class BiletSatis : Form
    {

        public BiletSatis()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(BaglantiSinif.adres);
        private void BiletSatis_Load(object sender, EventArgs e)
        {
            bilgiDoldur();

        }
        public void bilgiDoldur()
        {
            Random random = new Random();
            text_rezNo.Text = random.Next(999999).ToString();
            text_fiyat.Text = "25";
            text_firma.Text = "Kamilkoç";

            combo_kalkisNoktasi.Items.Add("Kırıkkale");
            combo_kalkisNoktasi.Items.Add("Ankara");

            combo_varisNoktasi.Items.Add("Ankara");
            combo_varisNoktasi.Items.Add("Kırıkkale");

            combo_saatBox.Items.Add("07.00-08.00");
            combo_saatBox.Items.Add("07.30-08.30");
            combo_saatBox.Items.Add("08.00-09.00");
            combo_saatBox.Items.Add("08.30-09.30");
            combo_saatBox.Items.Add("09.00-10.00");
            combo_saatBox.Items.Add("09.30-10.30");
            combo_saatBox.Items.Add("10.00-11.00");
            combo_saatBox.Items.Add("10.30-11.30");
            combo_saatBox.Items.Add("12.00-13.00");
            combo_saatBox.Items.Add("14.00-15.00");
            combo_saatBox.Items.Add("15.00-16.00");
            combo_saatBox.Items.Add("15.30-16.30");
            combo_saatBox.Items.Add("16.00-17.00");
            combo_saatBox.Items.Add("16.30-17.30");
            combo_saatBox.Items.Add("17.00-18.00");
            combo_saatBox.Items.Add("17.30-18.30");
            combo_saatBox.Items.Add("18.00-19.00");
            combo_saatBox.Items.Add("19.00-20.00");
            combo_saatBox.Items.Add("20.00-21.00");
        }
        public void rezNoDegistir_Temizle()
        {
            Random random = new Random();
            text_rezNo.Text = random.Next(999999).ToString();
            text_ad.Clear();
            text_soyAd.Clear();

        }

        public void koltukSatıs(string ad, string soyad, string kalkis, string varis, string koltuk,
            string tarih, string saat)
        {
            conn.Open();

            string fiyat = "25";
            string rezNo = text_rezNo.Text;

            SqlCommand cmd = new SqlCommand("insert into biletBilgi " +
                "(ad,soyad,binisYeri,inisYeri,fiyat,saat,tarih,rezervasyonNo,koltukNo)" +
                "values ('" + ad + "','" + soyad + "','" +
                kalkis + "','" + varis + "','" +
                fiyat + "','" + saat + "','" + tarih + "','" + rezNo + "','" + koltuk + "')", conn);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void button_1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_1.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_1.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_1.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_2.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_2.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_2.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_3.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_3.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_3.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_4.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_4.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_4.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_5.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_5.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_5.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_6.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_6.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_6.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_7.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_7.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_7.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_8.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_8.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_8.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_9.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_9.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_9.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_10_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_10.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_10.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_10.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_11_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_11.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_11.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_11.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_12_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_12.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_12.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_12.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_13_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_13.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_13.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_13.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_14_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                 " from biletBilgi " +
                 "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                 "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                 "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                 "saat = '" + combo_saatBox.Text + "' and " +
                 "koltukNo = '" + button_14.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_14.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_14.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void button_15_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select binisYeri,inisYeri,tarih,saat,koltukNo" +
                " from biletBilgi " +
                "where binisYeri = '" + combo_kalkisNoktasi.Text + "' and " +
                "inisYeri = '" + combo_varisNoktasi.Text + "' and " +
                "tarih = '" + date_tarih.Value.Date.ToString() + "' and " +
                "saat = '" + combo_saatBox.Text + "' and " +
                "koltukNo = '" + button_15.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = komut.ExecuteReader();
            try
            {
                if (dr.Read())
                {
                    MessageBox.Show("Almak istediğiniz bilet önceden satılmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    conn.Close();

                    koltukSatıs(text_ad.Text,
                    text_soyAd.Text,
                    combo_kalkisNoktasi.SelectedItem.ToString(),
                    combo_varisNoktasi.SelectedItem.ToString(),
                    button_15.Text,
                    date_tarih.Value.Date.ToString(),
                    combo_saatBox.SelectedItem.ToString());

                    rezNoDegistir_Temizle();
                    button_15.Enabled = false;

                    MessageBox.Show("Bilet satış işlemi başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                conn.Close();
            }
        }

        private void date_tarih_ValueChanged(object sender, EventArgs e)
        {
            butonEnable();
        }
        private void combo_saatBox_SelectedValueChanged(object sender, EventArgs e)
        {
            butonEnable();
        }
        public void butonEnable()
        {
            button_1.Enabled = true;
            button_2.Enabled = true;
            button_3.Enabled = true;
            button_4.Enabled = true;
            button_5.Enabled = true;
            button_6.Enabled = true;
            button_7.Enabled = true;
            button_8.Enabled = true;
            button_9.Enabled = true;
            button_10.Enabled = true;
            button_11.Enabled = true;
            button_12.Enabled = true;
            button_13.Enabled = true;
            button_14.Enabled = true;
            button_15.Enabled = true;
        }

    }
}
