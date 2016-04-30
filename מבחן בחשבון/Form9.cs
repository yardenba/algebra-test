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
    public partial class Form9 : Form
    {

        Random randomizer = new Random();
        int addend1, addend2, addend3, addend4, addend5, addend6,addend7, addend8;

        private void sum1_ValueChanged(object sender, EventArgs e)
        {

        }

        int sum1Dec;

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

 
     

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(1, 20);
            addend2 = randomizer.Next(1, 20);
            addend3 = randomizer.Next(1,20);
            addend4 = randomizer.Next(1, addend3);
            addend5 = randomizer.Next(1, 10);
            addend6 = randomizer.Next(1, 10);
            addend7 = randomizer.Next(1, 10);
            addend8 = randomizer.Next(1, addend7);

            sum1Dec = addend7 * addend8;

            label1.Text = addend1.ToString();
            label2.Text = addend2.ToString();
            label3.Text = addend3.ToString();
            label4.Text = addend4.ToString();
            label5.Text = addend5.ToString();
            label6.Text = addend6.ToString();
            label7.Text = sum1Dec.ToString();
            label8.Text = addend8.ToString();

            sum1.Value = 0;
            sum2.Value = 0;
            sum3.Value = 0;
            sum4.Value = 0;

        }
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if ((addend1 + addend2 == sum1.Value) && (addend3 - addend4 == sum2.Value) && (addend5 * addend6 == sum3.Value) && (sum1Dec / addend8 == sum4.Value))
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            button1.Enabled = false;

        }

    }
}
