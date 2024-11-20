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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Tur, sayac = 2, GX = 0, GO = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Tur = Convert.ToInt32(lbl_Tur.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sayac % 2 == 0)  // Sırasıyla tuşlanan butonlara önce 'X' sonra 'O' verir
            {
                button1.Text = "X";
            }
            else { button1.Text = "O"; }
            sayac++;
            button1.Enabled = false;

            if  // X oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                )
            {

                GX++;
                lbl_Gx.Text = GX.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'X' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else if  // O oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                )
            {
                GO++;
                lbl_Go.Text = GO.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'O' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'O' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else if (GX < GO)
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Maç berabere bitti.", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else // Oyun berabere bittiyse 
            {
                if
                (
                (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&
                 button4.Enabled == false && button5.Enabled == false && button6.Enabled == false &&
                 button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                )
                {
                    MessageBox.Show("Oyun berabere bitti", "BERABERE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sayac % 2 == 0)
            {
                button2.Text = "X";
            }
            else { button2.Text = "O"; }
            sayac++;
            button2.Enabled = false;

            if  // X oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                )
            {

                GX++;
                lbl_Gx.Text = GX.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'X' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else if  // O oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                )
            {
                GO++;
                lbl_Go.Text = GO.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'O' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'O' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else if (GX < GO)
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Maç berabere bitti.", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else // Oyun berabere bittiyse 
            {
                if
                (
                (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&
                 button4.Enabled == false && button5.Enabled == false && button6.Enabled == false &&
                 button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                )
                {
                    MessageBox.Show("Oyun berabere bitti", "BERABERE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sayac % 2 == 0)
            {
                button3.Text = "X";
            }
            else { button3.Text = "O"; }
            sayac++;
            button3.Enabled = false;

            if  // X oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                )
            {

                GX++;
                lbl_Gx.Text = GX.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'X' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else if  // O oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                )
            {
                GO++;
                lbl_Go.Text = GO.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'O' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'O' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else if (GX < GO)
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Maç berabere bitti.", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else // Oyun berabere bittiyse 
            {
                if
                (
                (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&
                 button4.Enabled == false && button5.Enabled == false && button6.Enabled == false &&
                 button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                )
                {
                    MessageBox.Show("Oyun berabere bitti", "BERABERE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sayac % 2 == 0)
            {
                button4.Text = "X";
            }
            else { button4.Text = "O"; }
            sayac++;
            button4.Enabled = false;

            if  // X oyuncusu 3 tane yan yana koyabildi mi
                 (
                 (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                 (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") ||
                 (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                 )
            {

                GX++;
                lbl_Gx.Text = GX.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'X' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else if  // O oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                )
            {
                GO++;
                lbl_Go.Text = GO.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'O' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'O' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else if (GX < GO)
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Maç berabere bitti.", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else // Oyun berabere bittiyse 
            {
                if
                (
                (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&
                 button4.Enabled == false && button5.Enabled == false && button6.Enabled == false &&
                 button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                )
                {
                    MessageBox.Show("Oyun berabere bitti", "BERABERE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sayac % 2 == 0)
            {
                button5.Text = "X";
            }
            else { button5.Text = "O"; }
            sayac++;
            button5.Enabled = false;

            if  // X oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                )
            {

                GX++;
                lbl_Gx.Text = GX.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'X' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else if  // O oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                )
            {
                GO++;
                lbl_Go.Text = GO.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'O' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'O' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else if (GX < GO)
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Maç berabere bitti.", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else // Oyun berabere bittiyse 
            {
                if
                (
                (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&
                 button4.Enabled == false && button5.Enabled == false && button6.Enabled == false &&
                 button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                )
                {
                    MessageBox.Show("Oyun berabere bitti", "BERABERE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sayac % 2 == 0)
            {
                button6.Text = "X";
            }
            else { button6.Text = "O"; }
            sayac++;
            button6.Enabled = false;

            if  // X oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                )
            {

                GX++;
                lbl_Gx.Text = GX.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'X' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else if  // O oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                )
            {
                GO++;
                lbl_Go.Text = GO.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'O' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'O' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else if (GX < GO)
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Maç berabere bitti.", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else // Oyun berabere bittiyse 
            {
                if
                (
                (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&
                 button4.Enabled == false && button5.Enabled == false && button6.Enabled == false &&
                 button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                )
                {
                    MessageBox.Show("Oyun berabere bitti", "BERABERE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sayac % 2 == 0)
            {
                button7.Text = "X";
            }
            else { button7.Text = "O"; }
            sayac++;
            button7.Enabled = false;

            if  // X oyuncusu 3 tane yan yana koyabildi mi
                  (
                  (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                  (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") ||
                  (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                  )
            {

                GX++;
                lbl_Gx.Text = GX.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'X' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else if  // O oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                )
            {
                GO++;
                lbl_Go.Text = GO.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'O' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'O' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else if (GX < GO)
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Maç berabere bitti.", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else // Oyun berabere bittiyse 
            {
                if
                (
                (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&
                 button4.Enabled == false && button5.Enabled == false && button6.Enabled == false &&
                 button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                )
                {
                    MessageBox.Show("Oyun berabere bitti", "BERABERE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sayac % 2 == 0)
            {
                button8.Text = "X";
            }
            else { button8.Text = "O"; }
            sayac++;
            button8.Enabled = false;


            if  // X oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                )
            {

                GX++;
                lbl_Gx.Text = GX.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'X' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else if  // O oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                )
            {
                GO++;
                lbl_Go.Text = GO.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'O' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'O' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else if (GX < GO)
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Maç berabere bitti.", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else // Oyun berabere bittiyse 
            {
                if
                (
                (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&
                 button4.Enabled == false && button5.Enabled == false && button6.Enabled == false &&
                 button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                )
                {
                    MessageBox.Show("Oyun berabere bitti", "BERABERE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sayac % 2 == 0)
            {
                button9.Text = "X";
            }
            else { button9.Text = "O"; }
            sayac++;
            button9.Enabled = false;

            if  // X oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                )
            {

                GX++;
                lbl_Gx.Text = GX.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'X' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else if  // O oyuncusu 3 tane yan yana koyabildi mi
                (
                (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                )
            {
                GO++;
                lbl_Go.Text = GO.ToString();

                if (Tur > 1) // Kalan Tur sayısı 1'den büyükse oyun devam eder
                {
                    Tur--;
                    lbl_Tur.Text = Tur.ToString();
                    MessageBox.Show("Oyunu 'O' kazandı.", "Kazanan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
                else
                {
                    if (GX > GO)  // X daha fazla kazandıysa maçı X yener
                    {
                        MessageBox.Show("Maçı 'O' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else if (GX < GO)
                    {
                        MessageBox.Show("Maçı 'X' kazandı", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Maç berabere bitti.", "Maç Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            else // Oyun berabere bittiyse 
            {
                if
                (
                (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false &&
                 button4.Enabled == false && button5.Enabled == false && button6.Enabled == false &&
                 button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                )
                {
                    MessageBox.Show("Oyun berabere bitti", "BERABERE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = true;
                    button1.Text = "";

                    button2.Enabled = true;
                    button2.Text = "";

                    button3.Enabled = true;
                    button3.Text = "";

                    button4.Enabled = true;
                    button4.Text = "";

                    button5.Enabled = true;
                    button5.Text = "";

                    button6.Enabled = true;
                    button6.Text = "";

                    button7.Enabled = true;
                    button7.Text = "";

                    button8.Enabled = true;
                    button8.Text = "";

                    button9.Enabled = true;
                    button9.Text = "";
                }
            }

        }
    }
}
