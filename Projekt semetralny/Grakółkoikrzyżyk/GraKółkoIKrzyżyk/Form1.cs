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

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Liczba ruchów" + liczba_ruchow;
        }
        int liczba_ruchow = 1;
        int liczba_klikniec = 0 ; 

        private void button1_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2==0)
            {
                button1.Text = "X";
                liczba_klikniec++;
            }
            else if ( liczba_klikniec %2 == 1)
            {
                button1.Text = "O";
                liczba_klikniec++;
            }
            liczba_ruchow = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button3.Text = "X";
                liczba_klikniec++;
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button3.Text = "O";
                liczba_klikniec++;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button6.Text = "X";
                liczba_klikniec++;
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button6.Text = "O";
                liczba_klikniec++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button2.Text = "X";
                liczba_klikniec++;
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button2.Text = "O";
                liczba_klikniec++;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button5.Text = "X";
                liczba_klikniec++;
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button5.Text = "O";
                liczba_klikniec++;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button4.Text = "X";
                liczba_klikniec++;
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button4.Text = "O";
                liczba_klikniec++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button9.Text = "X";
                liczba_klikniec++;
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button9.Text = "O";
                liczba_klikniec++;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        { 
            if (liczba_klikniec % 2 == 0)
            {
                button8.Text = "X";
                liczba_klikniec++;
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button8.Text = "O";
                liczba_klikniec++;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (liczba_klikniec % 2 == 0)
            {
                button7.Text = "X";
                liczba_klikniec++;
            }
            else if (liczba_klikniec % 2 == 1)
            {
                button7.Text = "O";
                liczba_klikniec++;
            }

        }
    }
}
