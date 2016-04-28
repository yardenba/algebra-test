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
    public partial class Form2 : Form
    {

        Random randomizer = new Random();
        int addend1, addend2, addend3, addend4, addend5, addend6;


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StartTheQuiz();
            button1.Enabled = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            addend4 = randomizer.Next(51);
            addend3 = randomizer.Next(addend4);
            addend6 = randomizer.Next(51);
            addend5 = randomizer.Next(addend6);


            label1.Text = addend1.ToString();
            label2.Text = addend2.ToString();
            label3.Text = addend3.ToString();
            label4.Text = addend4.ToString();
            label5.Text = addend5.ToString();
            label6.Text = addend6.ToString();

            sum1.Value = 0;
            sum2.Value = 0;
            sum3.Value = 0;
/// שלום
///שלום 2

        }
        private void button2_Click(object sender, EventArgs e)

        {
            if ((addend1 + addend2 == sum1.Value) && (addend4 - addend3 == sum2.Value) && (addend6 - addend5 == sum3.Value))
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Close();
            }




        }

        public Form2()

        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            button1.Enabled = false;
        }

    }
}


