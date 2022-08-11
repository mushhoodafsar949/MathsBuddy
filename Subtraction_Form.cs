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
    public partial class Subtraction_Form : Form
    {
        public Subtraction_Form()
        {
            InitializeComponent();
        }

        private void Subtraction_Form_Load(object sender, EventArgs e)
        {

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mysubtractionfunction();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mysubtractionfunction1();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mysubtractionfunction2();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mysubtractionfunction3();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mysubtractionfunction4();
            }



            /******************************************************************************************************************************/
            // FOR AGE 4
            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mysubtractionfunction5();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mysubtractionfunction6();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mysubtractionfunction7();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mysubtractionfunction8();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mysubtractionfunction9();
            }
            /*****************************************************************************************************************************/



            /******************************************************************************************************************************/
            // FOR AGE 5
            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mysubtractionfunction10();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mysubtractionfunction11();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mysubtractionfunction12();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mysubtractionfunction13();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mysubtractionfunction14();
            }
            /*****************************************************************************************************************************/

            /******************************************************************************************************************************/
            // FOR AGE 6
            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mysubtractionfunction15();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mysubtractionfunction16();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mysubtractionfunction17();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mysubtractionfunction18();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mysubtractionfunction19();
            }
            /*****************************************************************************************************************************/

            /******************************************************************************************************************************/
            // FOR AGE 7
            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mysubtractionfunction15();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mysubtractionfunction16();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mysubtractionfunction17();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mysubtractionfunction18();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mysubtractionfunction19();
            }
            /*****************************************************************************************************************************/
        }









        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 1: Weldone click ok to answer next question!");
                label2.Text = "";
               // textBox1.Text = "";
                mysubtractionfunction();
            }
            else if(textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction1();
            }
            else if(textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
               // textBox1.Text = "";
                mysubtractionfunction2();
            }
            else if(textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction3();
            }
            else if(textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
               // textBox1.Text = "";
                mysubtractionfunction4();
            }


            /*******************************************************************************************************************************/
            //FOR AGE 4
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 1: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction5();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction6();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction7();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction8();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction9();
            }
            /*****************************************************************************************************************************/



            /*******************************************************************************************************************************/
            //FOR AGE 5
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 1: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction10();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction11();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction12();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction13();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction14();
            }
            /*****************************************************************************************************************************/


            /*******************************************************************************************************************************/
            //FOR AGE 6
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 1: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction15();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction16();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction17();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction18();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction19();
            }
            /*****************************************************************************************************************************/

            /*******************************************************************************************************************************/
            //FOR AGE 7
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 1: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction15();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction16();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction17();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction18();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mysubtractionfunction19();
            }
            /*****************************************************************************************************************************/
            else
            {
                label2.Text = "That is the Wrong Answer!";

            }

        }













/******************************************************************************************************************************/
                                                                  //FOR AGE 3
        //level 1 subtraction function
        private void mysubtractionfunction()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 10;
            int rangeP = 10;

            int numR = R.Next(2, rangeR);
            int numP = P.Next(4, rangeP);

            int numT = numR - numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "-" + label4.Text;

            label5.Text = numT.ToString();
        }


        //level 2 subtraction function
        private void mysubtractionfunction1()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 20;
            int rangeP = 20;

            int numR = R.Next(2, rangeR);
            int numP = P.Next(10, rangeP);

            int numT = numR - numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "-" + label4.Text;

            label5.Text = numT.ToString();
        }

        //level 3 subtraction function
        private void mysubtractionfunction2()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 30;
            int rangeP = 30;

            int numR = R.Next(10, rangeR);
            int numP = P.Next(20, rangeP);

            int numT = numR - numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "-" + label4.Text;

            label5.Text = numT.ToString();
        }

        //level 4 subtraction function
        private void mysubtractionfunction3()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 40;
            int rangeP = 40;

            int numR = R.Next(25, rangeR);
            int numP = P.Next(40, rangeP);

            int numT = numR - numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "-" + label4.Text;

            label5.Text = numT.ToString();
        }


        //level 5 subtraction function
        private void mysubtractionfunction4()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 100;
            int rangeP = 100;

            int numR = R.Next(2, rangeR);
            int numP = P.Next(60, rangeP);

            int numT = numR - numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "-" + label4.Text;

            label5.Text = numT.ToString();
        }


        /***************************************************************************************************************************/
        //FOR AGE 4

        //level 1 subtraction function
        private void mysubtractionfunction5()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 10;
            int rangeP = 10;
            int rangeQ = 10;


            int numR = R.Next(2, rangeR);
            int numP = P.Next(6, rangeP);
            int numQ = Q.Next(0, rangeQ);


            int numT = numR - numP - numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 2 subtraction function
        private void mysubtractionfunction6()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 20;
            int rangeP = 25;
            int rangeQ = 30;


            int numR = R.Next(10, rangeR);
            int numP = P.Next(20, rangeP);
            int numQ = Q.Next(25, rangeQ);


            int numT = numR - numP - numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text;
            label5.Text = numT.ToString();
        }

        //level 3 subtraction function
        private void mysubtractionfunction7()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 30;
            int rangeP = 40;
            int rangeQ = 50;


            int numR = R.Next(15, rangeR);
            int numP = P.Next(25, rangeP);
            int numQ = Q.Next(35, rangeQ);


            int numT = numR - numP - numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text;
            label5.Text = numT.ToString();
        }

        //level 4 subtraction function
        private void mysubtractionfunction8()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 40;
            int rangeP = 50;
            int rangeQ = 60;


            int numR = R.Next(25, rangeR);
            int numP = P.Next(0, rangeP);
            int numQ = Q.Next(45, rangeQ);


            int numT = numR - numP - numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 5 subtraction function
        private void mysubtractionfunction9()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 100;
            int rangeP = 100;
            int rangeQ = 100;


            int numR = R.Next(2, rangeR);
            int numP = P.Next(6, rangeP);
            int numQ = Q.Next(10, rangeQ);


            int numT = numR - numP - numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        /****************************************************************************************************************************/



        /***************************************************************************************************************************/
        //FOR AGE 5


        //level 1 subtraction function
        private void mysubtractionfunction10()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 40;
            int rangeP = 40;
            int rangeQ = 40;


            int numR = R.Next(2, rangeR);
            int numP = P.Next(6, rangeP);
            int numQ = Q.Next(0, rangeQ);


            int numT = numR - numP - numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text;
            label5.Text = numT.ToString();
        }


        //level 2 subtraction function
        private void mysubtractionfunction11()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 50;
            int rangeP = 55;
            int rangeQ = 50;


            int numR = R.Next(10, rangeR);
            int numP = P.Next(20, rangeP);
            int numQ = Q.Next(25, rangeQ);


            int numT = numR - numP - numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text;
            label5.Text = numT.ToString();
        }

        //level 3 subtraction function
        private void mysubtractionfunction12()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 60;
            int rangeP = 70;
            int rangeQ = 100;


            int numR = R.Next(15, rangeR);
            int numP = P.Next(25, rangeP);
            int numQ = Q.Next(35, rangeQ);


            int numT = numR - numP - numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }

        //level 4 subtraction function
        private void mysubtractionfunction13()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 100;
            int rangeP = 200;
            int rangeQ = 50;


            int numR = R.Next(25, rangeR);
            int numP = P.Next(0, rangeP);
            int numQ = Q.Next(45, rangeQ);


            int numT = numR - numP - numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text;
            label5.Text = numT.ToString();
        }


        //level 5 subtraction function
        private void mysubtractionfunction14()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 300;
            int rangeP = 300;
            int rangeQ = 300;


            int numR = R.Next(200, rangeR);
            int numP = P.Next(250, rangeP);
            int numQ = Q.Next(10, rangeQ);


            int numT = numR - numP - numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        /****************************************************************************************************************************/


        /***************************************************************************************************************************/
        //FOR AGE 6


        //level 1 subtraction function
        private void mysubtractionfunction15()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 40;
            int rangeP = 40;
            int rangeQ = 40;
            int rangeS = 40;



            int numR = R.Next(10, rangeR);
            int numP = P.Next(20, rangeP);
            int numQ = Q.Next(25, rangeQ);
            int numS = S.Next(30, rangeS);



            int numT = numR - numP - numQ - numS;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;

            label5.Text = numT.ToString();
        }


        //level 2 subtraction function
        private void mysubtractionfunction16()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 100;
            int rangeP = 40;
            int rangeQ = 200;
            int rangeS = 150;



            int numR = R.Next(70, rangeR);
            int numP = P.Next(20, rangeP);
            int numQ = Q.Next(165, rangeQ);
            int numS = S.Next(110, rangeS);



            int numT = numR - numP - numQ - numS;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;


            label5.Text = numT.ToString();
        }

        //level 3 subtraction function
        private void mysubtractionfunction17()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 300;
            int rangeP = 300;
            int rangeQ = 300;
            int rangeS = 400;



            int numR = R.Next(100, rangeR);
            int numP = P.Next(200, rangeP);
            int numQ = Q.Next(290, rangeQ);
            int numS = S.Next(350, rangeS);



            int numT = numR - numP - numQ - numS;


            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;

            label5.Text = numT.ToString();
        }

        //level 4 subtraction function
        private void mysubtractionfunction18()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 600;
            int rangeP = 700;
            int rangeQ = 600;
            int rangeS = 800;



            int numR = R.Next(300, rangeR);
            int numP = P.Next(400, rangeP);
            int numQ = Q.Next(25, rangeQ);
            int numS = S.Next(700, rangeS);



            int numT = numR - numP - numQ - numS;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;

            label5.Text = numT.ToString();
        }


        //level 5 subtraction function
        private void mysubtractionfunction19()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 1000;
            int rangeP = 1000;
            int rangeQ = 1000;
            int rangeS = 1000;



            int numR = R.Next(900, rangeR);
            int numP = P.Next(20, rangeP);
            int numQ = Q.Next(500, rangeQ);
            int numS = S.Next(300, rangeS);



            int numT = numR - numP - numQ - numS;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "-" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;

            label5.Text = numT.ToString();
        }


        /****************************************************************************************************************************/












        private void quit_Click_1(object sender, EventArgs e)
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
