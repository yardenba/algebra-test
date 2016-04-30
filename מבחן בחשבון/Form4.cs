using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace מבחן_בחשבון
{
    public partial class Form4 : Form
    {

        Random randomizer = new Random();
        int addend1, addend2, addend3, addend4, addend5, addend6;

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(addend1);
             addend3 = randomizer.Next(51);
            addend4 = randomizer.Next(addend3);
            addend5 = randomizer.Next(51);
            addend6 = randomizer.Next(addend5);


            label1.Text = addend1.ToString();
            label2.Text = addend2.ToString();
            label3.Text = addend3.ToString();
            label4.Text = addend4.ToString();
            label5.Text = addend5.ToString();
            label6.Text = addend6.ToString();

            sum1.Value = 0;
            sum2.Value = 0;
            sum3.Value = 0;
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
   
            if ((addend1 - addend2 == sum1.Value) && (addend3 - addend4 == sum2.Value) && (addend6 + addend5 == sum3.Value))
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Close();
                Form1.passTestMin = true;
            }
        

    }


        private void sum3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sum2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sum1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
