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
    public partial class SatilanBiletler : Form
    {
        public SatilanBiletler()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(BaglantiSinif.adres);
        private void SatilanBiletler_Load(object sender, EventArgs e)
        {
            getSatilanBilet();
           
        }

        private void btn_iade_Click(object sender, EventArgs e)
        {
            conn.Open();
            DialogResult result = MessageBox.Show("İade işleminizden emin misiniz?", "Doğrulama", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if(result == DialogResult.Yes)
            {
                SqlCommand sql = new SqlCommand("delete from biletBilgi where rezervasyonNo = " + txt_iade.Text, conn);
                sql.ExecuteNonQuery();
                conn.Close();
                getSatilanBilet();
                txt_iade.Clear();
            }
            else
            {
                conn.Close();
                txt_iade.Clear();
                
            }
        }

        public void getSatilanBilet()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from biletBilgi", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            BiletGuncelle biletGuncelle = new BiletGuncelle();
            biletGuncelle.rezNo = txt_guncelle.Text;
            biletGuncelle.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != null)
            {
                txt_guncelle.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_iade.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
