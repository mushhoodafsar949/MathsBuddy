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
    public partial class Multiplication_Form : Form
    {
        public Multiplication_Form()
        {
            InitializeComponent();
        }





        private void Multiplication_Form_Load(object sender, EventArgs e)
        {

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mymultiplicationfunction();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mymultiplicationfunction1();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mymultiplicationfunction2();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mymultiplicationfunction3();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mymultiplicationfunction4();
            }



            /******************************************************************************************************************************/
            // FOR AGE 4
            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mymultiplicationfunction5();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mymultiplicationfunction6();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mymultiplicationfunction7();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mymultiplicationfunction8();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mymultiplicationfunction9();
            }
            /*****************************************************************************************************************************/



            /******************************************************************************************************************************/
            // FOR AGE 5
            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mymultiplicationfunction10();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mymultiplicationfunction11();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mymultiplicationfunction12();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mymultiplicationfunction13();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mymultiplicationfunction14();
            }
            /*****************************************************************************************************************************/

            /******************************************************************************************************************************/
            // FOR AGE 6
            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mymultiplicationfunction15();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mymultiplicationfunction16();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mymultiplicationfunction17();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mymultiplicationfunction18();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mymultiplicationfunction19();
            }
            /*****************************************************************************************************************************/

            /******************************************************************************************************************************/
            // FOR AGE 7
            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mymultiplicationfunction15();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mymultiplicationfunction16();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mymultiplicationfunction17();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mymultiplicationfunction18();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mymultiplicationfunction19();
            }
            /*****************************************************************************************************************************/



        }






        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Age 3 & Level 1: Weldone click ok to answer next question!");
                label2.Text = "";
               // textBox1.Text = "";
                mymultiplicationfunction();
            }
            else if(textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
               // textBox1.Text = "";
                mymultiplicationfunction1();
            }
            else if(textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
               // textBox1.Text = "";
                mymultiplicationfunction2();
            }
            else if(textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
               // textBox1.Text = "";
                mymultiplicationfunction3();
            }
            else if(textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
               // textBox1.Text = "";
                mymultiplicationfunction4();
            }


            /*******************************************************************************************************************************/
            //FOR AGE 4
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Age 4 & Level 1: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction5();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction6();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction7();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction8();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction9();
            }
            /*****************************************************************************************************************************/



            /*******************************************************************************************************************************/
            //FOR AGE 5
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Age 5 & Level 1: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction10();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction11();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction12();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction13();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction14();
            }
            /*****************************************************************************************************************************/


            /*******************************************************************************************************************************/
            //FOR AGE 6
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Age 6 & Level 1: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction15();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction16();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction17();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction18();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction19();
            }
            /*****************************************************************************************************************************/

            /*******************************************************************************************************************************/
            //FOR AGE 7
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Age 7 & Level 1: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction15();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction16();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction17();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction18();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mymultiplicationfunction19();
            }
            /*****************************************************************************************************************************/



            else
            {
                label2.Text = "That is the Wrong Answer!";

            }

        }



        //level 1 multiplication function
        private void mymultiplicationfunction()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 10;
            int rangeP = 10;

            int numR = R.Next(2, rangeR);
            int numP = P.Next(4, rangeP);

            int numT = numR * numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + " x " + label4.Text;
            label5.Text = numT.ToString();
        }


//level 2 multiplication function
        private void mymultiplicationfunction1()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 20;
            int rangeP = 20;

            int numR = R.Next(2, rangeR);
            int numP = P.Next(10, rangeP);

            int numT = numR * numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + " x " + label4.Text;
            label5.Text = numT.ToString();
        }

//level 3 multiplication function
        private void mymultiplicationfunction2()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 30;
            int rangeP = 30;

            int numR = R.Next(10, rangeR);
            int numP = P.Next(20, rangeP);

            int numT = numR * numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + " x " + label4.Text;
            label5.Text = numT.ToString();
        }

//level 4 multiplication function
        private void mymultiplicationfunction3()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 40;
            int rangeP = 40;

            int numR = R.Next(25, rangeR);
            int numP = P.Next(40, rangeP);

            int numT = numR * numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + " x " + label4.Text;
            label5.Text = numT.ToString();
        }


 //level 5 multiplication function
        private void mymultiplicationfunction4()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 100;
            int rangeP = 100;

            int numR = R.Next(2, rangeR);
            int numP = P.Next(60, rangeP);

            int numT = numR * numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + " x " + label4.Text;

            label5.Text = numT.ToString();
        }



        /***************************************************************************************************************************/
        //FOR AGE 4

        //level 1 multiplication function
        private void mymultiplicationfunction5()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 10;
            int rangeP = 10;
            int rangeQ = 10;


            double numR = R.Next(2, rangeR);
            double numP = P.Next(6, rangeP);
            double numQ = Q.Next(0, rangeQ);


            double numT = numR * numP * numQ;


            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + " x " + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 2 multiplication function
        private void mymultiplicationfunction6()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 20;
            int rangeP = 25;
            int rangeQ = 30;


            double numR = R.Next(10, rangeR);
            double numP = P.Next(20, rangeP);
            double numQ = Q.Next(25, rangeQ);


            double numT = numR * numP * numQ;


            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + " x " + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }

        //level 3 multiplication function
        private void mymultiplicationfunction7()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 30;
            int rangeP = 40;
            int rangeQ = 50;


            double numR = R.Next(15, rangeR);
            double numP = P.Next(25, rangeP);
            double numQ = Q.Next(35, rangeQ);


            double numT = numR * numP * numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + " x " + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }

        //level 4 multiplication function
        private void mymultiplicationfunction8()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 40;
            int rangeP = 50;
            int rangeQ = 60;


            double numR = R.Next(25, rangeR);
            double numP = P.Next(0, rangeP);
            double numQ = Q.Next(45, rangeQ);


            double numT = numR * numP * numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + " x " + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 5 multiplication function
        private void mymultiplicationfunction9()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 100;
            int rangeP = 100;
            int rangeQ = 100;


            double numR = R.Next(2, rangeR);
            double numP = P.Next(6, rangeP);
            double numQ = Q.Next(10, rangeQ);


            double numT = numR * numP * numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + " x " + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        /****************************************************************************************************************************/



        /***************************************************************************************************************************/
        //FOR AGE 5


        //level 1 multiplication function
        private void mymultiplicationfunction10()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 40;
            int rangeP = 40;
            int rangeQ = 40;


            double numR = R.Next(2, rangeR);
            double numP = P.Next(6, rangeP);
            double numQ = Q.Next(0, rangeQ);


            double numT = numR * numP * numQ;

          
            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + " x " + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 2 multiplication function
        private void mymultiplicationfunction11()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 50;
            int rangeP = 55;
            int rangeQ = 50;


            double numR = R.Next(10, rangeR);
            double numP = P.Next(20, rangeP);
            double numQ = Q.Next(25, rangeQ);


            double numT = numR * numP * numQ;

      
            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + " x " + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }

        //level 3 multiplication function
        private void mymultiplicationfunction12()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 60;
            int rangeP = 70;
            int rangeQ = 100;


            double numR = R.Next(15, rangeR);
            double numP = P.Next(25, rangeP);
            double numQ = Q.Next(35, rangeQ);


            double numT = numR * numP * numQ;

          
            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + " x " + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }

        //level 4 multiplication function
        private void mymultiplicationfunction13()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 100;
            int rangeP = 200;
            int rangeQ = 50;


            double numR = R.Next(25, rangeR);
            double numP = P.Next(0, rangeP);
            double numQ = Q.Next(45, rangeQ);


            double numT = numR * numP * numQ;


            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + " x " + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 5 multiplication function
        private void mymultiplicationfunction14()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 300;
            int rangeP = 300;
            int rangeQ = 300;


            double numR = R.Next(200, rangeR);
            double numP = P.Next(250, rangeP);
            double numQ = Q.Next(10, rangeQ);


            double numT = numR * numP * numQ;


            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + " x " + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        /****************************************************************************************************************************/


        /***************************************************************************************************************************/
        //FOR AGE 6


        //level 1 multiplication function
        private void mymultiplicationfunction15()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 40;
            int rangeP = 40;
            int rangeQ = 40;
            int rangeS = 40;



            double numR = R.Next(10, rangeR);
            double numP = P.Next(20, rangeP);
            double numQ = Q.Next(25, rangeQ);
            double numS = S.Next(30, rangeS);



            double numT = numR * numP * numQ * numS;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "x" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;


            label5.Text = numT.ToString();
        }


        //level 2 multiplication function
        private void mymultiplicationfunction16()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 100;
            int rangeP = 40;
            int rangeQ = 200;
            int rangeS = 150;



            double numR = R.Next(70, rangeR);
            double numP = P.Next(20, rangeP);
            double numQ = Q.Next(165, rangeQ);
            double numS = S.Next(110, rangeS);



            double numT = numR * numP * numQ * numS;


            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "x" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;


            label5.Text = numT.ToString();
        }

        //level 3 multiplication function
        private void mymultiplicationfunction17()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 300;
            int rangeP = 300;
            int rangeQ = 300;
            int rangeS = 400;



            double numR = R.Next(100, rangeR);
            double numP = P.Next(200, rangeP);
            double numQ = Q.Next(290, rangeQ);
            double numS = S.Next(350, rangeS);



            double numT = numR * numP * numQ * numS;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "x" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;


            label5.Text = numT.ToString();
        }

        //level 4 multiplication function
        private void mymultiplicationfunction18()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 600;
            int rangeP = 700;
            int rangeQ = 600;
            int rangeS = 800;



            double numR = R.Next(300, rangeR);
            double numP = P.Next(400, rangeP);
            double numQ = Q.Next(25, rangeQ);
            double numS = S.Next(700, rangeS);



            double numT = numR * numP * numQ * numS;


            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "x" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;


            label5.Text = numT.ToString();
        }


        //level 5 multiplication function
        private void mymultiplicationfunction19()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 1000;
            int rangeP = 1000;
            int rangeQ = 1000;
            int rangeS = 1000;



            double numR = R.Next(900, rangeR);
            double numP = P.Next(20, rangeP);
            double numQ = Q.Next(500, rangeQ);
            double numS = S.Next(300, rangeS);



            double numT = numR * numP * numQ * numS;



            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();

            label10.Text = label1.Text + "x" + label4.Text+""+label7.Text+ "" + label6.Text + ""+label9.Text+ ""+ label8.Text;


            label5.Text = numT.ToString();
        }


        /****************************************************************************************************************************/






        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
           
                if (label5.Visible == false)
                {
                    label5.Visible = true;
                }
                else
                {
                    label5.Visible = false;
                }
            
        }


    }
}
