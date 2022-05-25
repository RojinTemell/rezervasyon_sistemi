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
    public partial class rezervasyonForm : Form
    {
        public rezervasyonForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-D966NE9; Initial Catalog = Mimari; Integrated Security = True");

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "insert into tblRezervasyon(ulasimTip,konaklamaTip,gidisTarihi,donusTarih,nereden,nereye,firmaAdi,fiyat) " +
                "values(@ulasimTip,@konaklamaTip,@gidisTarihi,@donusTarih,@nereden,@nereye,@firmaAdi,@fiyat)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);

            komut.Parameters.AddWithValue("@gidisTarihi", dateGidis.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@donusTarih", dateDonus.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@nereden", txtNereden.Text);
            komut.Parameters.AddWithValue("@nereye", txtNereye.Text);
            komut.Parameters.AddWithValue("@firmaAdi",cmbFirmaAdi.Text);

            Musteri musteri = new Musteri();
            Seyahat ucak_cadir= new Seyahat(new Ucak_Cadir(),musteri);
            

            Seyahat ucak_otel = new Seyahat(new Ucak_Otel(), musteri);
            
            Seyahat otobus_cadir = new Seyahat(new Otobus_Cadir(), musteri);
            
            Seyahat otobus_otel = new Seyahat(new Otobus_Otel(), musteri);


            if(rbCadir.Checked==true && rbUcak.Checked == true)
            {
                ucak_cadir.GidisTarihi = dateGidis.Value;
                ucak_cadir.DonusTarihi = dateDonus.Value;
                ucak_cadir.FirmaAdi=cmbFirmaAdi.SelectedItem.ToString();
                ucak_cadir.Nereden = txtNereden.Text;
                ucak_cadir.Nereye= txtNereye.Text;
                ucak_cadir.Fiyat = Convert.ToInt32(lblFiyat.Text);
                komut.Parameters.AddWithValue("@ulasimTip", rbUcak.Text);
                komut.Parameters.AddWithValue("@konaklamaTip", rbCadir.Text);
              
                komut.Parameters.AddWithValue("@fiyat", lblFiyat.Text);
                

            }
            else if (rbCadir.Checked == true && rbOtobus.Checked == true)
            {
                otobus_cadir.GidisTarihi = dateGidis.Value;
                otobus_cadir.DonusTarihi = dateDonus.Value;
                otobus_cadir.FirmaAdi = cmbFirmaAdi.SelectedItem.ToString();
                otobus_cadir.Nereden = txtNereden.Text;
                otobus_cadir.Nereye = txtNereye.Text;
                otobus_cadir.Fiyat = Convert.ToInt32(lblFiyat.Text);

                komut.Parameters.AddWithValue("@ulasimTip", rbOtobus.Text);
                komut.Parameters.AddWithValue("@konaklamaTip", rbCadir.Text);

                komut.Parameters.AddWithValue("@fiyat", lblFiyat.Text);
            }
            else if (rbOtel.Checked == true && rbOtobus.Checked == true)
            {
                otobus_otel.GidisTarihi = dateGidis.Value;
                otobus_otel.DonusTarihi = dateDonus.Value;
                otobus_otel.FirmaAdi = cmbFirmaAdi.SelectedItem.ToString();
                otobus_otel.Nereden = txtNereden.Text;
                otobus_otel.Nereye = txtNereye.Text;

                otobus_otel.Fiyat = Convert.ToInt32(lblFiyat.Text);
                komut.Parameters.AddWithValue("@ulasimTip", rbOtobus.Text);
                komut.Parameters.AddWithValue("@konaklamaTip", rbOtel.Text);

                komut.Parameters.AddWithValue("@fiyat", lblFiyat.Text);
            }
            else if (rbOtel.Checked == true && rbUcak.Checked == true)
            {
                ucak_otel.GidisTarihi = dateGidis.Value;
                ucak_otel.DonusTarihi = dateDonus.Value;
                ucak_otel.FirmaAdi = cmbFirmaAdi.SelectedItem.ToString();
                ucak_otel.Nereden = txtNereden.Text;
                ucak_otel.Nereye = txtNereye.Text;

                ucak_otel.Fiyat = Convert.ToInt32(lblFiyat.Text);
                komut.Parameters.AddWithValue("@ulasimTip", rbUcak.Text);
                komut.Parameters.AddWithValue("@konaklamaTip", rbOtel.Text);

                komut.Parameters.AddWithValue("@fiyat", lblFiyat.Text);
            }



            komut.ExecuteNonQuery();
            baglanti.Close();








            Odeme odeme = new Odeme();
            odeme.Show();
            this.Hide();
        }

        private void btnFiyatGor_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            Seyahat ucak_cadir = new Seyahat(new Ucak_Cadir(), musteri);


            Seyahat ucak_otel = new Seyahat(new Ucak_Otel(), musteri);

            Seyahat otobus_cadir = new Seyahat(new Otobus_Cadir(), musteri);

            Seyahat otobus_otel = new Seyahat(new Otobus_Otel(), musteri);

            if (rbCadir.Checked == true && rbUcak.Checked == true)
            {
                ucak_cadir.Fiyat = Convert.ToInt32(lblFiyat.Text);
                ucak_cadir.Fiyat = 400;
                lblFiyat.Text = ucak_cadir.Fiyat.ToString();
                    


            }
            else if (rbCadir.Checked == true && rbOtobus.Checked == true)
            {
                
                otobus_cadir.Fiyat = Convert.ToInt32(lblFiyat.Text);
                otobus_cadir.Fiyat = 300;
                lblFiyat.Text = otobus_cadir.Fiyat.ToString();


            }
            else if (rbOtel.Checked == true && rbOtobus.Checked == true)
            {
                
                otobus_otel.Fiyat = Convert.ToInt32(lblFiyat.Text);
                otobus_otel.Fiyat = 500;
                lblFiyat.Text = otobus_otel.Fiyat.ToString();

            }
            else if (rbOtel.Checked == true && rbUcak.Checked == true)
            {
                ucak_otel.Fiyat = Convert.ToInt32(lblFiyat.Text);
                ucak_otel.Fiyat = 900;
                lblFiyat.Text = ucak_otel.Fiyat.ToString();
            }



         

        }
    }
}
