using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletOtomasyon
{
    public partial class SecimEkrani : Form
    {
        public SecimEkrani()
        {
            InitializeComponent();
        }

        private void btn_biletSatis_Click(object sender, EventArgs e)
        {
            BiletSatis biletSatis = new BiletSatis();
            biletSatis.ShowDialog();
        }

        private void btn_satilanBiletler_Click(object sender, EventArgs e)
        {
            SatilanBiletler satilanBiletler = new SatilanBiletler();
            satilanBiletler.ShowDialog();    
        }

        private void btn_oturumKapat_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();            
        }

        private void SecimEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
