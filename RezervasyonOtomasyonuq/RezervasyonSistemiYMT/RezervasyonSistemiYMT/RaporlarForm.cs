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
    public partial class RaporlarForm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-D966NE9; Initial Catalog = Mimari; Integrated Security = True");
        
        public RaporlarForm()
        {
            InitializeComponent();
        }

        private void RaporlarForm_Load(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            string kayit = "select  * from tblMusteri";
             SqlCommand komut2 = new SqlCommand("select * from tblRezervasyon", baglanti);
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataAdapter da2=new SqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            da.Fill(dt);
            da2.Fill(dt2);

            dgMusteri.DataSource = dt;
            



            dgRez.DataSource = dt2;
            dgRez.AllowUserToAddRows = false;

            baglanti.Close();

        }
    }
}
