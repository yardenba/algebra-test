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
    public partial class Form5 : Form
    {
        Random randomizer = new Random();
        int addend1, addend2, addend3, addend4,  addend5, addend6;

       

        double sum2Dec,addend4Dec, sum3Dec, addend6Dec;
 



        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(1,10);
            addend2 = randomizer.Next(1,10);
            addend4 = randomizer.Next(5,20);
            addend3 = randomizer.Next(1,addend4);
            addend6 = randomizer.Next(5,20);
            addend5 = randomizer.Next(1, addend6);

            //addend4Dec = addend4;
            sum2Dec = addend4 / addend3;
            addend4Dec = Math.Round(sum2Dec) * addend3;
            addend4 = (int)addend4Dec;

            sum3Dec = addend6 / addend5;
            addend6Dec = Math.Round(sum3Dec) * addend5;
            addend6 = (int)addend6Dec;

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

        public Form5()
        {

            InitializeComponent();
            button2.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StartTheQuiz();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)       
        {
            if ((addend1 * addend2 == sum1.Value) && (addend3 * sum2.Value == addend4 ) && (addend5 * sum3.Value== addend6))
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Close();
                Form1.passTestMul = true;
            }
        }
    }
}