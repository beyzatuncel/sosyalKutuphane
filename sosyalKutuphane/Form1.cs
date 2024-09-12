using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sosyalKutuphane
{
    public partial class Form1 : Form
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tcText.Text == "TC. Kimlik No")
            {
                tcText.Text = "";
                tcText.ForeColor = Color.Black;
            }
            

        }
        

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyelikFormu form2 = new uyelikFormu();

            // Eğer formu modal olarak açmak isterseniz:
            form2.ShowDialog();  // Bu, Form2 kapanana kadar Form1'in kilitlenmesini sağlar
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciHesabi form3 = new kullaniciHesabi();
            // Eğer formu modal olarak açmak isterseniz:
            form3.Show();  // Bu, Form2 kapanana kadar Form1'in kilitlenmesini sağlar
            this.Hide();
            
        }
    }
}
