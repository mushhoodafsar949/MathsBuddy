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
    public partial class Division_Form : Form
    {
        public Division_Form()
        {
            InitializeComponent();
        }



        private void Division_Form_Load(object sender, EventArgs e)
        {

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mydivisionfunction();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mydivisionfunction1();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mydivisionfunction2();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mydivisionfunction3();
            }

            if (Main_Form.age3 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mydivisionfunction4();
            }



            /******************************************************************************************************************************/
            // FOR AGE 4
            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mydivisionfunction5();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mydivisionfunction6();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mydivisionfunction7();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mydivisionfunction8();
            }

            if (Main_Form.age4 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mydivisionfunction9();
            }
            /*****************************************************************************************************************************/



            /******************************************************************************************************************************/
            // FOR AGE 5
            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mydivisionfunction10();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mydivisionfunction11();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mydivisionfunction12();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mydivisionfunction13();
            }

            if (Main_Form.age5 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mydivisionfunction14();
            }
            /*****************************************************************************************************************************/

            /******************************************************************************************************************************/
            // FOR AGE 6
            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mydivisionfunction15();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mydivisionfunction16();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mydivisionfunction17();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mydivisionfunction18();
            }

            if (Main_Form.age6 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mydivisionfunction19();
            }
            /*****************************************************************************************************************************/

            /******************************************************************************************************************************/
            // FOR AGE 7
            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                mydivisionfunction15();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                mydivisionfunction16();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                mydivisionfunction17();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                mydivisionfunction18();
            }

            if (Main_Form.age7 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                mydivisionfunction19();
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
                mydivisionfunction();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                mydivisionfunction1();
            }
           else if (textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                mydivisionfunction2();
            }
           else if (textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                mydivisionfunction3();
            }
           else if (textBox1.Text == label5.Text && Main_Form.age3 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                mydivisionfunction4();
            }


            /*******************************************************************************************************************************/
            //FOR AGE 4
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev1 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 1: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction5();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction6();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction7();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction8();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age4 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction9();
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
                mydivisionfunction10();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction11();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction12();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction13();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age5 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction14();
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
                mydivisionfunction15();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction16();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction17();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction18();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age6 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction19();
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
                mydivisionfunction15();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev2 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 2: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction16();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev3 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 3: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction17();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev4 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 4: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction18();
            }
            else if (textBox1.Text == label5.Text && Main_Form.age7 == Main_Form.mlabl && Main_Form.lev5 == Main_Form.mlab2)
            {
                label2.Text = "That is Correct!";
                MessageBox.Show("Level 5: Weldone click ok to answer next question!");
                label2.Text = "";
                //textBox1.Text = "";
                mydivisionfunction19();
            }
            /*****************************************************************************************************************************/



            else
            {
                label2.Text = "That is the Wrong Answer!";

            }

        }



        //level 1 division function
        private void mydivisionfunction()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 10;
            int rangeP = 10;
            int num1 = R.Next(4, rangeR);
            int num2 = P.Next(2, rangeP);
            double numR = num1;
            double numP = num2;
            double num = numR / numP;
            double numT = Math.Round(num, 2);
            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "/" + label4.Text;
            label5.Text = numT.ToString();
        }


        //level 2 division function
        private void mydivisionfunction1()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 20;
            int rangeP = 20;

            int num1 = R.Next(10, rangeR);
            int num2 = P.Next(2, rangeP);

            double numR = num1;
            double numP = num2;

            double num = numR / numP;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "/" + label4.Text;

            label5.Text = numT.ToString();
        }

        //level 3 division function
        private void mydivisionfunction2()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 30;
            int rangeP = 30;

            int num1 = R.Next(20, rangeR);
            int num2 = P.Next(10, rangeP);

            double numR = num1;
            double numP = num2;

            double num = numR / numP;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "/" + label4.Text;

            label5.Text = numT.ToString();
        }

        //level 4 division function
        private void mydivisionfunction3()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 50;
            int rangeP = 40;

            int num1 = R.Next(45, rangeR);
            int num2 = P.Next(25, rangeP);

            double numR = num1;
            double numP = num2;

            double num = numR / numP;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "/" + label4.Text;

            label5.Text = numT.ToString();
        }


        //level 5 division function
        private void mydivisionfunction4()
        {
            Random R = new Random();
            Random P = new Random();
            int rangeR = 100;
            int rangeP = 100;

            int num1 = R.Next(60, rangeR);
            int num2 = P.Next(2, rangeP);


            double numR = num1;
            double numP = num2;

            double num = numR / numP;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label10.Text = label1.Text + "/" + label4.Text ;

            label5.Text = numT.ToString();
        }


        /***************************************************************************************************************************/
        //FOR AGE 4

        //level 1 addition function
        private void mydivisionfunction5()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 10;
            int rangeP = 10;
            int rangeQ = 10;


            int num1 = R.Next(2, rangeR);
            int num2 = P.Next(6, rangeP);
            int num3 = Q.Next(0, rangeQ);

            double numR = num1;
            double numP = num2;
            double numQ = num3;


            double num = numR / numP / numQ;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 2 addition function
        private void mydivisionfunction6()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 20;
            int rangeP = 25;
            int rangeQ = 30;


            int num1 = R.Next(10, rangeR);
            int num2 = P.Next(20, rangeP);
            int num3 = Q.Next(25, rangeQ);

            double numR = num1;
            double numP = num2;
            double numQ = num3;


            double num = numR / numP / numQ;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }

        //level 3 addition function
        private void mydivisionfunction7()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 30;
            int rangeP = 40;
            int rangeQ = 50;


            int num1 = R.Next(15, rangeR);
            int num2 = P.Next(25, rangeP);
            int num3 = Q.Next(35, rangeQ);

            double numR = num1;
            double numP = num2;
            double numQ = num3;


            double num = numR / numP / numQ;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }

        //level 4 addition function
        private void mydivisionfunction8()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 40;
            int rangeP = 50;
            int rangeQ = 60;


            int num1 = R.Next(25, rangeR);
            int num2 = P.Next(0, rangeP);
            int num3 = Q.Next(45, rangeQ);


            double numR = num1;
            double numP = num2;
            double numQ = num3;


            double num = numR / numP / numQ;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 5 addition function
        private void mydivisionfunction9()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 100;
            int rangeP = 100;
            int rangeQ = 100;


            int num1 = R.Next(2, rangeR);
            int num2 = P.Next(6, rangeP);
            int num3 = Q.Next(10, rangeQ);

            double numR = num1;
            double numP = num2;
            double numQ = num3;


            double num = numR / numP / numQ;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        /****************************************************************************************************************************/



        /***************************************************************************************************************************/
        //FOR AGE 5


        //level 1 addition function
        private void mydivisionfunction10()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 40;
            int rangeP = 40;
            int rangeQ = 40;


            int num1 = R.Next(2, rangeR);
            int num2 = P.Next(6, rangeP);
            int num3 = Q.Next(0, rangeQ);

            double numR = num1;
            double numP = num2;
            double numQ = num3;


            double num = numR / numP / numQ;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 2 addition function
        private void mydivisionfunction11()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 50;
            int rangeP = 55;
            int rangeQ = 50;


            int num1 = R.Next(10, rangeR);
            int num2 = P.Next(20, rangeP);
            int num3 = Q.Next(25, rangeQ);


            double numR = num1;
            double numP = num2;
            double numQ = num3;


            double num = numR / numP / numQ;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }

        //level 3 addition function
        private void mydivisionfunction12()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 60;
            int rangeP = 70;
            int rangeQ = 100;


            int num1 = R.Next(15, rangeR);
            int num2 = P.Next(25, rangeP);
            int num3 = Q.Next(35, rangeQ);

            double numR = num1;
            double numP = num2;
            double numQ = num3;


            double num = numR / numP / numQ;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }

        //level 4 addition function
        private void mydivisionfunction13()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 100;
            int rangeP = 200;
            int rangeQ = 50;


            int num1 = R.Next(25, rangeR);
            int num2 = P.Next(0, rangeP);
            int num3 = Q.Next(45, rangeQ);

            double numR = num1;
            double numP = num2;
            double numQ = num3;


            double num = numR / numP / numQ;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        //level 5 addition function
        private void mydivisionfunction14()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();


            int rangeR = 300;
            int rangeP = 300;
            int rangeQ = 300;


            int num1 = R.Next(200, rangeR);
            int num2 = P.Next(250, rangeP);
            int num3 = Q.Next(10, rangeQ);

            double numR = num1;
            double numP = num2;
            double numQ = num3;


            double num = numR / numP / numQ;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text;

            label5.Text = numT.ToString();
        }


        /****************************************************************************************************************************/


        /***************************************************************************************************************************/
        //FOR AGE 5


        //level 1 addition function
        private void mydivisionfunction15()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 40;
            int rangeP = 40;
            int rangeQ = 40;
            int rangeS = 40;



            int num1 = R.Next(10, rangeR);
            int num2 = P.Next(20, rangeP);
            int num3 = Q.Next(25, rangeQ);
            int num4 = S.Next(30, rangeS);


            double numR = num1;
            double numP = num2;
            double numQ = num3;
            double numS = num4;



            double num = numR / numP / numQ / numS;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;

            label5.Text = numT.ToString();
        }


        //level 2 addition function
        private void mydivisionfunction16()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 100;
            int rangeP = 40;
            int rangeQ = 200;
            int rangeS = 150;



            int num1 = R.Next(70, rangeR);
            int num2 = P.Next(20, rangeP);
            int num3 = Q.Next(165, rangeQ);
            int num4 = S.Next(110, rangeS);


            double numR = num1;
            double numP = num2;
            double numQ = num3;
            double numS = num4;



            double num = numR / numP / numQ / numS;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;

            label5.Text = numT.ToString();
        }

        //level 3 addition function
        private void mydivisionfunction17()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 300;
            int rangeP = 300;
            int rangeQ = 300;
            int rangeS = 400;



            int num1 = R.Next(100, rangeR);
            int num2 = P.Next(200, rangeP);
            int num3 = Q.Next(290, rangeQ);
            int num4 = S.Next(350, rangeS);


            double numR = num1;
            double numP = num2;
            double numQ = num3;
            double numS = num4;



            double num = numR / numP / numQ / numS;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;

            label5.Text = numT.ToString();
        }

        //level 4 addition function
        private void mydivisionfunction18()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 600;
            int rangeP = 700;
            int rangeQ = 600;
            int rangeS = 800;



            int num1 = R.Next(300, rangeR);
            int num2 = P.Next(400, rangeP);
            int num3 = Q.Next(25, rangeQ);
            int num4 = S.Next(700, rangeS);


            double numR = num1;
            double numP = num2;
            double numQ = num3;
            double numS = num4;



            double num = numR / numP / numQ / numS;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;

            label5.Text = numT.ToString();
        }


        //level 5 addition function
        private void mydivisionfunction19()
        {
            Random R = new Random();
            Random P = new Random();
            Random Q = new Random();
            Random S = new Random();



            int rangeR = 1000;
            int rangeP = 1000;
            int rangeQ = 1000;
            int rangeS = 1000;



            int num1 = R.Next(900, rangeR);
            int num2 = P.Next(20, rangeP);
            int num3 = Q.Next(500, rangeQ);
            int num4 = S.Next(300, rangeS);


            double numR = num1;
            double numP = num2;
            double numQ = num3;
            double numS = num4;



            double num = numR / numP / numQ / numS;
            double numT = Math.Round(num, 2);

            label1.Text = numR.ToString();
            label4.Text = numP.ToString();
            label6.Text = numQ.ToString();
            label8.Text = numS.ToString();
            label10.Text = label1.Text + "/" + label4.Text + "" + label7.Text + "" + label6.Text + "" + label9.Text + "" + label8.Text;

            label5.Text = numT.ToString();
        }


        /****************************************************************************************************************************/





        private void quit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            if(label5.Visible == false)
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
