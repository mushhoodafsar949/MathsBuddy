using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Maths_Buddy
{
    
    public partial class Main_Form : Form
    {
        private readonly object y = new object();
        int x = 1;
        public static string mlabl, mlab2;
        string ab = "Lets Play a Maths game!";
        string ac = "Answer The following Questions.";
        string ad = "Press the quit button to stop the game";
        string ae = "choose your Age!";

        public bool button1WasClicked = false;
        public static string age3 = "Age 3";
        public static string age4 = "Age 4";
        public static string age5 = "Age 5";
        public static string age6 = "Age 6";
        public static string age7 = "Age 7";

        public static string lev1 = "Level 1";
        public static string lev2 = "Level 2";
        public static string lev3 = "Level 3";
        public static string lev4 = "Level 4";
        public static string lev5 = "Level 5";
        public Main_Form()
        {
            InitializeComponent();
           
        }
        System.Timers.Timer myTimer = new System.Timers.Timer(2000);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged_1(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() => {
                lock (y)
                {
                    // label1.Text = x.ToString(); 

                    if (x == 2)
                    {
                        label1.Text = ab;
                    }
                    if (x == 5)
                    {
                        label1.Text = ac;
                    }
                    if (x == 9)
                    {
                        label1.Text = ad;
                    }
                    if (x == 12)
                    {
                        label1.Text = ae;
                    }
                    if (x == 15)
                    {
                        label1.Visible = false;
                        button1.Visible = true;
                        button2.Visible = true;
                        button3.Visible = true;
                        button4.Visible = true;
                        button5.Visible = true;
                        label2.Visible = true;
                       
                    }

                    if (x == 18)
                    {
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;

                        button6.Visible = true;
                        button7.Visible = true;
                        button8.Visible = true;
                        button9.Visible = true;
                        button10.Visible = true;
                        label3.Visible = true;
                    }

                    if (x == 21)
                    {
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;
                        button6.Visible = false;
                        button7.Visible = false;
                        button8.Visible = false;
                        button9.Visible = false;
                        button10.Visible = false;

                        division_btn.Visible = true;
                        multiplication_btn.Visible = true;
                        subtraction_btn.Visible = true;
                        addtion_btn.Visible = true;
                    }
                    x++;
                }
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myTimer.Elapsed += label1_TextChanged_1;
            myTimer.Start();
        }



        private void button1_Click(object sender, EventArgs e)
        {
         label2.Text = age3;
            mlabl = label2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = age4;
            mlabl = label2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = age5;
            mlabl = label2.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = age6;
            mlabl = label2.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = age7;
            mlabl = label2.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = lev1;
            mlab2 = label3.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = lev2;
            mlab2 = label3.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Text = lev3;
            mlab2 = label3.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text = lev4;
            mlab2 = label3.Text;
        }

        private void addition_Click(object sender, EventArgs e)
        {
            Main_Form fm = new Main_Form();
            fm.Hide();
            Addition_Form ad = new Addition_Form();
            ad.Show();
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            Main_Form fm1 = new Main_Form();
            fm1.Hide();
            Subtraction_Form sb1 = new Subtraction_Form();
            sb1.Show();
        }

        private void multiplication_btn_Click(object sender, EventArgs e)
        {
            Main_Form fm2 = new Main_Form();
            fm2.Hide();
            Multiplication_Form ad1 = new Multiplication_Form();
            ad1.Show();
        }

        private void division_btn_Click(object sender, EventArgs e)
        {
            Main_Form fm3 = new Main_Form();
            fm3.Hide();
            Division_Form dv1 = new Division_Form();
            dv1.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath); 
            this.Close(); 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label3.Text = lev5;
            mlab2 = label3.Text;
        }
    }
}
