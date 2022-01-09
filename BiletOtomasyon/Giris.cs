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

namespace BiletOtomasyon
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(BaglantiSinif.adres);
        private void Giris_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("select Username, Password from Admin " +
                "where Username = '" + txt_username.Text + "' and "+
                "Password = '" + txt_password.Text + "'", conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            try
            {
                if (reader.Read())
                {
                    SecimEkrani secim = new SecimEkrani();
                    secim.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();

                Giris giris = new Giris();
                giris.Visible = false;
            }
            
        }
    }
}
