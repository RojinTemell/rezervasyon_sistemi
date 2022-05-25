using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervasyonSistemiYMT
{
    public partial class girisForm : Form
    {
        public girisForm()
        {
            InitializeComponent();
        }

        private void btnYoneticiGrs_Click(object sender, EventArgs e)
        {
            YoneticiForm yoneticiForm = new YoneticiForm();
            yoneticiForm.Show();
            this.Hide();
        }

        private void btnRezYap_Click(object sender, EventArgs e)
        {
            rezervasyonForm rezervasyonForm = new rezervasyonForm();
            rezervasyonForm.Show();
            this.Hide();
        }
    }
}
