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
    public partial class BiletGuncelle : Form
    {
        public BiletGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(BaglantiSinif.adres);

        public string rezNo { get; set; }
        private void BiletGuncelle_Load(object sender, EventArgs e)
        {
            combo_saatGuncelle.Items.Add("07.00-08.00");
            combo_saatGuncelle.Items.Add("07.30-08.30");
            combo_saatGuncelle.Items.Add("08.00-09.00");
            combo_saatGuncelle.Items.Add("08.30-09.30");
            combo_saatGuncelle.Items.Add("09.00-10.00");
            combo_saatGuncelle.Items.Add("09.30-10.30");
            combo_saatGuncelle.Items.Add("10.00-11.00");
            combo_saatGuncelle.Items.Add("10.30-11.30");
            combo_saatGuncelle.Items.Add("12.00-13.00");
            combo_saatGuncelle.Items.Add("14.00-15.00");
            combo_saatGuncelle.Items.Add("15.00-16.00");
            combo_saatGuncelle.Items.Add("15.30-16.30");
            combo_saatGuncelle.Items.Add("16.00-17.00");
            combo_saatGuncelle.Items.Add("16.30-17.30");
            combo_saatGuncelle.Items.Add("17.00-18.00");
            combo_saatGuncelle.Items.Add("17.30-18.30");
            combo_saatGuncelle.Items.Add("18.00-19.00");
            combo_saatGuncelle.Items.Add("19.00-20.00");
            combo_saatGuncelle.Items.Add("20.00-21.00");

            text_rezGuncelle.Text = rezNo;

            conn.Open();
            SqlCommand cmd = new SqlCommand("select koltukNo from biletBilgi where rezervasyonNo = " + text_rezGuncelle.Text, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                text_koltukGuncelle.Text = dr["koltukNo"].ToString();
            }
            conn.Close();

        }

        private void buton_guncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("update biletBilgi set tarih = '"+
                dateTime_guncelle.Value.Date.ToString()+"',"+
                " saat = '"+combo_saatGuncelle.SelectedItem.ToString()+"',"+
                " koltukNo = '"+text_koltukGuncelle.Text+"'"+
                " where rezervasyonNo = "+text_rezGuncelle.Text, conn);
            sql.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Bilet bilgileriniz güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }
    }
}
