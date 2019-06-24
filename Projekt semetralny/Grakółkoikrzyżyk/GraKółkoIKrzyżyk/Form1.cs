using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraKółkoIKrzyżyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool blokada = true;
        int liczba_klikniec = 0 ;
        int liczba_ruchów = 0;
        

        private void button1_Click(object sender, EventArgs e)

        {

            if (liczba_klikniec % 2 == 1 && button1.Text != "X" && blokada== true)
            {
                button1.Text = "O";
                liczba_klikniec++;
                label3.Text = "Następny ruch : X";
            }

            if (liczba_klikniec % 2 == 0 && button1.Text != "O" && blokada == true)
            {
                button1.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }

            if (button3.Text == "X" && button2.Text == "X" && button1.Text == "X")
            {
                label3.Text = " Gre wygrał gracz X";
                blokada = false;
            }

            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;

        }

        private void button3_Click(object sender, EventArgs e)

        {     

            if (liczba_klikniec % 2 == 1 && button3.Text != "X"  && blokada == true)  
            {
                button3.Text = "O";
                liczba_klikniec++;
                label3.Text = "Następny ruch : X";
            }
         
            if (liczba_klikniec % 2 == 0 && button3.Text != "O" && blokada == true)
            {
                button3.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }

            if (button3.Text == "X" && button2.Text == "X" && button1.Text == "X")
            {
                label3.Text = " Gre wygrał gracz X";
                blokada = false;
            }

            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów; 
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           

            if (liczba_klikniec % 2 == 1 && button6.Text != "X" && blokada == true)  
            {
                button6.Text = "O";
                liczba_klikniec++;
                label3.Text = "Następny ruch : X";
            }
         
            if (liczba_klikniec % 2 == 0 && button6.Text != "O" && blokada == true)
            {
                button6.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = " Gre wygrał gracz X";
                blokada = false;
            }

            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów; 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (liczba_klikniec % 2 == 1 && button2.Text != "X" && blokada == true)
            {
                button2.Text = "O";
                liczba_klikniec++;
                label3.Text = "Następny ruch : X";
            }

            if (liczba_klikniec % 2 == 0 && button2.Text != "O" && blokada == true)
            {
                button2.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }

            if (button3.Text == "X" && button2.Text == "X" && button1.Text == "X")
            {
                label3.Text = " Gre wygrał gracz X";
                blokada = false;
            }

            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;

        }
        private void button5_Click(object sender, EventArgs e)
        {


            if (liczba_klikniec % 2 == 1 && button5.Text != "X" && blokada == true)
            {
                button5.Text = "O";
                liczba_klikniec++;
                label3.Text = "Następny ruch : X";
            }

            if (liczba_klikniec % 2 == 0 && button5.Text != "O" && blokada == true)
            {
                button5.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = " Gre wygrał gracz X";
            }

            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;
            blokada = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (liczba_klikniec % 2 == 1 && button4.Text != "X"  && blokada == true)
            {
                button4.Text = "O";
                liczba_klikniec++;
                label3.Text = "Następny ruch : X";
            }

            if (liczba_klikniec % 2 == 0 && button4.Text != "O" && blokada == true)
            {
                button4.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = " Gre wygrał gracz X";
                blokada = false;
            }

            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;

        }
        private void button9_Click(object sender, EventArgs e)
        {


            if (liczba_klikniec % 2 == 1 && button9.Text != "X" && blokada == true)
            {
                button9.Text = "O";
                liczba_klikniec++;
                label3.Text = "Następny ruch : X";
            }

            if (liczba_klikniec % 2 == 0 && button9.Text != "O"  && blokada == true)
            {
                button9.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = " Gre wygrał gracz X";
                blokada = false;
            }

            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;

        }
        private void button8_Click(object sender, EventArgs e)
        {


            if (liczba_klikniec % 2 == 1 && button8.Text != "X"  && blokada == true)
            {
                button8.Text = "O";
                liczba_klikniec++;
                label3.Text = "Następny ruch : X";
            }

            if (liczba_klikniec % 2 == 0 && button8.Text != "O"  && blokada == true)
            {
                button8.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = " Gre wygrał gracz X";
                blokada = false;
            }

            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;

        }

        private void button7_Click(object sender, EventArgs e)
        {


            if (liczba_klikniec % 2 == 1 && button7.Text != "X"  && blokada == true)
            {
                button7.Text = "O";
                liczba_klikniec++;
                label3.Text = "Następny ruch : X";
            }

            if (liczba_klikniec % 2 == 0 && button7.Text != "O"  && blokada == true)
            {
                button7.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = " Gre wygrał gracz X";
                blokada = false;
            }

            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label3.Text = "Trwa rozgrywka ... ";
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
