using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_X_uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 f;

        public static int Tur;
        private void button1_Click(object sender, EventArgs e)
        {
            f = new Form1();
            f.Owner = this;

            Tur = 3;

            f.lbl_Tur.Text = Tur.ToString();

            f.ShowDialog();
            this.Close();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = new Form1();
            f.Owner = this;

            Tur = 5;

            f.lbl_Tur.Text = Tur.ToString(); 

            f.ShowDialog();
            this.Close();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f = new Form1();
            f.Owner = this;

            Tur = 10;

            f.lbl_Tur.Text = Tur.ToString();

            f.ShowDialog();
            this.Close();
            this.Hide();
        }
    }
}
