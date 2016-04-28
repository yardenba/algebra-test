using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        Random randomizer = new Random();
        int addend1, addend2, addend3, addend4, addend5, addend6;

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(addend1);
            addend4 = randomizer.Next(51);
            addend3 = randomizer.Next(addend3);
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
        private void button2_Click(object sender, EventArgs e)

        {
            if ((addend1 - addend2 == sum1.Value) && (addend4 + addend3 == sum2.Value) && (addend6 + addend5 == sum3.Value))
            {
                Form5 f2 = new Form5();
                f2.ShowDialog();
                this.Close();
            }
        }
        public Form3()
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
