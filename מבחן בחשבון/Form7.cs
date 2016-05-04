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
    public partial class Form7 : Form
    {

        Random randomizer = new Random();
        int addend1, addend2, addend3, addend4, addend5, addend6;
        int sum1Dec, sum2Dec;
        
       
        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(1, 10);
            addend2 = randomizer.Next(1, addend1/2);
            addend3 = randomizer.Next(5, 10);
            addend4 = randomizer.Next(1, addend3/2);
            addend5 = randomizer.Next(5, 10);
            addend6 = randomizer.Next(1, addend5);
            
            sum1Dec = addend1 * addend2;
            sum2Dec = addend3 * addend4;

            label1.Text = sum1Dec.ToString();
            label2.Text = addend2.ToString();
            label3.Text = sum2Dec.ToString();
            label4.Text = addend4.ToString();
            label5.Text = addend5.ToString();
            label6.Text = addend6.ToString();

            sum1.Value = 0;
            sum2.Value = 0;
            sum3.Value = 0;

         

        }


        public Form7()
        {
            InitializeComponent();
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            button1.Enabled = false;
            button3.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           if ((sum1Dec / addend2 == sum1.Value) && (sum2Dec /  addend4== sum2.Value) && (addend5 *  addend6== sum3.Value))
             {
                Form3 f3 =new Form3();
                f3.ShowDialog();
                this.Close();
                Form1.passTestDiv = true;

            }
        }
   
    }
}
