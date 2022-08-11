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
    public partial class Addition_Form : Form
    {


        public Addition_Form()
        {
            InitializeComponent();
        }


  




        private void addition_Load(object sender, EventArgs e)
        {
            // FOR AGE 3

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                myadditionfunction();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                myadditionfunction1();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                myadditionfunction2();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                myadditionfunction3();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                myadditionfunction4();
            }



            /******************************************************************************************************************************/
                                                        // FOR AGE 4
            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                myadditionfunction5();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                myadditionfunction6();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                myadditionfunction7();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                myadditionfunction8();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                myadditionfunction9();
            }
            /*****************************************************************************************************************************/



            /******************************************************************************************************************************/
                                                         // FOR AGE 5
            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                myadditionfunction10();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                myadditionfunction11();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                myadditionfunction12();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                myadditionfunction13();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                myadditionfunction14();
            }
            /*****************************************************************************************************************************/

            /******************************************************************************************************************************/
                                                                 // FOR AGE 6
            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                myadditionfunction15();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                myadditionfunction16();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                myadditionfunction17();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                myadditionfunction18();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                myadditionfunction19();
            }
            /*****************************************************************************************************************************/

            /******************************************************************************************************************************/
                                                                            // FOR AGE 7
            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                myadditionfunction15();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                myadditionfunction16();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                myadditionfunction17();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                myadditionfunction18();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                myadditionfunction19();
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
                myadditionfunction();
            }
           else if (textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
               // textBox1.Text = "";
                myadditionfunction1();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
               // textBox1.Text = "";
                myadditionfunction2();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
               // textBox1.Text = "";
                myadditionfunction3();
            }
           else if (textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction4();
            }


/*******************************************************************************************************************************/
                                                    //FOR AGE 4
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 1: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction5();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction6();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction7();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction8();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction9();
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
                myadditionfunction10();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction11();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction12();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction13();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction14();
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
                myadditionfunction15();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction16();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction17();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction18();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction19();
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
                myadditionfunction15();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction16();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction17();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction18();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                myadditionfunction19();
            }
            /*****************************************************************************************************************************/


            else
            {
                label2.Text = "That is the Wrong Answer!";

            }

        }









/********************************************************************************************************************************/
                                                //FOR AGE 3
//level 1 addition function
        private void myadditionfunction()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 10;
            int rangeP = 10;

            int numR = R.Next(2, rangeR);
            int numP = P.Next(4, rangeP);

            int numT = numR + numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "+" + label4.Text;

            label5.Text = numT.ToString();
        }


//level 2 addition function
        private void myadditionfunction1()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 20;
            int rangeP = 20;

            int numR = R.Next(2, rangeR);
            int numP = P.Next(10, rangeP);

            int numT = numR + numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "+" + label4.Text;

            label5.Text = numT.ToString();
        }

//level 3 addition function
        private void myadditionfunction2()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 30;
            int rangeP = 30;

            int numR = R.Next(10, rangeR);
            int numP = P.Next(20, rangeP);

            int numT = numR + numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "+" + label4.Text;

            label5.Text = numT.ToString();
        }

//level 4 addition function
        private void myadditionfunction3()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 40;
            int rangeP = 40;

            int numR = R.Next(25, rangeR);
            int numP = P.Next(40, rangeP);

            int numT = numR + numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "+" + label4.Text;
            label5.Text = numT.ToString();
        }


 //level 5 addition function
        private void myadditionfunction4()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 100;
            int rangeP = 100;

            int numR = R.Next(2, rangeR);
            int numP = P.Next(60, rangeP);

            int numT = numR + numP;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "+" + label4.Text;

            label5.Text = numT.ToString();
        }


        /***************************************************************************************************************************/
                                                                    //FOR AGE 4

        //level 1 addition function
        private void myadditionfunction5()
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


            int numT = numR + numP + numQ;
            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 2 addition function
        private void myadditionfunction6()
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


            int numT = numR + numP + numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }

        //level 3 addition function
        private void myadditionfunction7()
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


            int numT = numR + numP + numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text;
            label5.Text = numT.ToString();
        }

        //level 4 addition function
        private void myadditionfunction8()
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


            int numT = numR + numP + numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 5 addition function
        private void myadditionfunction9()
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


            int numT = numR + numP + numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        /****************************************************************************************************************************/



        /***************************************************************************************************************************/
                                                                    //FOR AGE 6


        //level 1 addition function
        private void myadditionfunction10()
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


            int numT = numR + numP + numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 2 addition function
        private void myadditionfunction11()
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


            int numT = numR + numP + numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }

        //level 3 addition function
        private void myadditionfunction12()
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


            int numT = numR + numP + numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }

        //level 4 addition function
        private void myadditionfunction13()
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


            int numT = numR + numP + numQ;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 5 addition function
        private void myadditionfunction14()
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


            int numT = numR + numP + numQ;


            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        /****************************************************************************************************************************/


        /***************************************************************************************************************************/
                                                                    //FOR AGE 5


        //level 1 addition function
        private void myadditionfunction15()
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



            int numT = numR + numP + numQ + numS;

            
            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;

            label5.Text = numT.ToString();
        }


        //level 2 addition function
        private void myadditionfunction16()
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



            int numT = numR + numP + numQ + numS;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;


            label5.Text = numT.ToString();
        }

        //level 3 addition function
        private void myadditionfunction17()
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



            int numT = numR + numP + numQ + numS;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;


            label5.Text = numT.ToString();
        }

        //level 4 addition function
        private void myadditionfunction18()
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



            int numT = numR + numP + numQ + numS;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;


            label5.Text = numT.ToString();
        }


        //level 5 addition function
        private void myadditionfunction19()
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



            int numT = numR + numP + numQ + numS;

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "+" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;

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
