using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sosyalKutuphane
{
    public partial class kullaniciHesabi : Form
    {
        public kullaniciHesabi()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void kutuphaneHesabim_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                // Yeni bir uyelikFormu (Form2) nesnesi oluştur
                Form1 form2 = new Form1();

                // Yeni formu aç
                form2.Show();

                // Mevcut formu kapat
                this.Close();
            

        }
    }
}
