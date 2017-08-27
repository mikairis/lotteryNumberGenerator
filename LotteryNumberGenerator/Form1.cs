using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, 9999);
            if (number < 10)
            {
                textBox1.Text = "000" + number.ToString();
            }
            else if (number >= 10 && number < 100)
            {
                textBox1.Text = "00" + number.ToString();
            }
            else if (number >= 100 && number < 1000)
            {
                textBox1.Text = "0" + number.ToString();
            }
            else
            textBox1.Text = number.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Random randomGenerator = new Random();
            int[] totoDigits = new int[6];

            for (int i = 0; i < 6; i++)
            {
                totoDigits[i] = randomGenerator.Next(0, 40);
            }
            textBox2.Text = totoDigits[0].ToString();
            textBox3.Text = totoDigits[1].ToString();
            textBox4.Text = totoDigits[2].ToString();
            textBox5.Text = totoDigits[3].ToString();
            textBox6.Text = totoDigits[4].ToString();
            textBox7.Text = totoDigits[5].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Random randomGenerator = new Random();
            int[] totoDigits7 = new int[7];

            for (int i = 0; i < 7; i++)
            {
                totoDigits7[i] = randomGenerator.Next(0, 40);
            }
            textBox8.Text = totoDigits7[0].ToString();
            textBox9.Text = totoDigits7[1].ToString();
            textBox10.Text = totoDigits7[2].ToString();
            textBox11.Text = totoDigits7[3].ToString();
            textBox12.Text = totoDigits7[4].ToString();
            textBox13.Text = totoDigits7[5].ToString();
            textBox14.Text = totoDigits7[6].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Random randomGenerator = new Random();
            int sgSweep = randomGenerator.Next(0, 9999999);
            if (sgSweep < 10)
            {
                textBox15.Text = "000000" + sgSweep.ToString();
            }
            else if (sgSweep >= 10 && sgSweep < 100)
            {
                textBox15.Text = "00000" + sgSweep.ToString();
            }
            else if (sgSweep >= 100 && sgSweep < 1000)
            {
                textBox15.Text = "0000" + sgSweep.ToString();
            }
            else if (sgSweep >= 1000 && sgSweep < 10000)
            {
                textBox15.Text = "000" + sgSweep.ToString();
            }
            else if (sgSweep >= 10000 && sgSweep < 100000)
            {
                textBox15.Text = "00" + sgSweep.ToString();
            }
            else if (sgSweep >= 100000 && sgSweep < 1000000)
            {
                textBox15.Text = "0" + sgSweep.ToString();
            }
            else
                textBox15.Text = sgSweep.ToString();
        }
    }
}