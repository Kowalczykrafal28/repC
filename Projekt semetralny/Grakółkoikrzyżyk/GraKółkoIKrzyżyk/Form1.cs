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

        
       
        int liczba_klikniec = 0 ;
        int liczba_ruchów = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2==0)
            {
                button1.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }
           
            else if ( liczba_klikniec %2 == 1)
            {
                button1.Text = "O";
                label3.Text = "Następny ruch : X";
                liczba_klikniec++;
            }
            else if (button3.Text == "O" && button2.Text == "O" && button1.Text == "O")
            {
                label3.Text = " Wygrał O";
            }


            liczba_klikniec++;
            liczba_ruchów ++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button3.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }
           
            else if (liczba_klikniec % 2 == 1)
            {
                button3.Text = "O";
                label3.Text = "Następny ruch : X";
                liczba_klikniec++;
            }
            else if (button3.Text == "O" && button2.Text == "O" && button1.Text == "O")
            {
                label3.Text = " Wygrał O";
            }

            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button6.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }

            else if (liczba_klikniec % 2 == 1)
            {
                button6.Text = "O";
                liczba_klikniec++;
                label3.Text = "Następny ruch : X";
            }
            else if (button3.Text == "O" && button2.Text == "O" && button1.Text == "O")
            {
                label3.Text = " Wygrał O";
            }


            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów; 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button2.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }
            else if (button3.Text == "X" && button2.Text == "X" && button1.Text == "X")
            {
                label3.Text = " Wygrał X";
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button2.Text = "O";
                label3.Text = "Następny ruch : X";
                liczba_klikniec++;
            }
            
            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button5.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = " Wygrał X";
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button5.Text = "O";
                label3.Text = "Następny ruch : X";
                liczba_klikniec++;
            }
          

            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button4.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = " Wygrał X";
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button4.Text = "O";
                label3.Text = "Następny ruch : X";
                liczba_klikniec++;
            }
            
            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button9.Text = "X";
                liczba_klikniec++;
                label3.Text = "Następny ruch : O";
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = " Wygrał X";
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button9.Text = "O";
                label3.Text = "Następny ruch : X";
                liczba_klikniec++;
            }
            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;
        }

        private void button8_Click(object sender, EventArgs e)
        { 
            if (liczba_klikniec % 2 == 0)
            {
                button8.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = " Wygrał X";
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button8.Text = "O";
                label3.Text = "Następny ruch : X";
                liczba_klikniec++;
            }
            liczba_ruchów++;
            label1.Text = " Liczba ruchów : " + liczba_ruchów;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button7.Text = "X";
                label3.Text = "Następny ruch : O";
                liczba_klikniec++;
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = " Wygrał X";
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button7.Text = "O";
                label3.Text = "Następny ruch : X";
                liczba_klikniec++;
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
