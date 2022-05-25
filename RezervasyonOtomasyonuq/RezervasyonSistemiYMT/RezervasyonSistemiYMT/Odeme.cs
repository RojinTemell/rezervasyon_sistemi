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
using System.IO;
namespace RezervasyonSistemiYMT
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-D966NE9; Initial Catalog = Mimari; Integrated Security = True");
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {   

            Musteri musteri = new Musteri();
            musteri.Ad = txtAd.Text;
            musteri.Soyad = txtSoyad.Text;
            musteri.CVV =Convert.ToInt16(txtCVV.Text);
            musteri.KartNo = Convert.ToInt64(txtKartNo.Text);
            musteri.SKT = Convert.ToInt16(txtSKT.Text);

            baglanti.Open();
            string kayit = "insert into tblMusteri(ad,soyad,kartNo,cvv,skt) " +
               "values(@ad,@soyad,@kartNo,@cvv,@skt)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@ad",txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@kartNo", txtKartNo.Text);
            komut.Parameters.AddWithValue("@cvv", txtCVV.Text);
            komut.Parameters.AddWithValue("@skt", txtSKT.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Rezervasyonunuz yapıldı");
            

        }
    }
}
