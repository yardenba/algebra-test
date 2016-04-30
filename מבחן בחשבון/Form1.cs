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
    public partial class Form1 : Form
    {


        //private bool pass;
        //public bool Passvalue
        //{
        // get { return pass; }
        //   set { pass = value; }
        // }
        public static bool passTestAdd = false;
        public static bool passTestMin = false;
        public static bool passTestMul = false;
        public static bool passTestDiv = false;


        public Form1()
        {
            InitializeComponent();
            button2B.Enabled = false;
            button3C.Enabled = false;
            button4D.Enabled = false;
            button5E.Enabled = false;
            //           if (passTestAdd)
            //             button2B.Enabled = true;

        }


        private void button1A_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            if (passTestAdd)
             button2B.Enabled = true;
        }



        private void button2B_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            //      f4.Owner = this;

            if (passTestMin)
                button3C.Enabled = true;

        }

        private void button3C_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();

            if (passTestMul)
                button4D.Enabled = true;
        }

        private void button4D_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
            if (passTestDiv)
                button5E.Enabled = true;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();

            if (passTestAdd)
                button2B.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}
