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

namespace RezervasyonSistemiYMT
{
    public partial class YoneticiForm : Form
    {
        public YoneticiForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-D966NE9; Initial Catalog = Mimari; Integrated Security = True");
        private void btnYoneticiGrs_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string giris = "select * from tblYonetici where ad =@ad and soyad=@soyad and sifre=@sifre";
            SqlParameter prm1 = new SqlParameter("ad", txtAd.Text.Trim());
            SqlParameter prm2 = new SqlParameter("soyad", txtSoyad.Text.Trim());
            SqlParameter prm3 = new SqlParameter("Sifre", txtSifre.Text.Trim());
            SqlCommand komut = new SqlCommand(giris, baglanti);
            komut.Parameters.Add(prm1);
            komut.Parameters.Add(prm2);
            komut.Parameters.Add(prm3);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                RaporlarForm rapor_form = new RaporlarForm();
                rapor_form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");

            }
            baglanti.Close();

        }

        private void YoneticiForm_Load(object sender, EventArgs e)
        {
           


        }
    }
}
