using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KalkulatorZal.Calculate;

namespace KalkulatorZal
{
    public partial class Form1 : Form
    {
        private bool add = false;
        bool positive = true;
        private int openBracketCounter = 0;
        private bool closedBracket = false;
        private bool clear = false;
        static int g = 7;
        static double[] p = {0.99999999999980993, 676.5203681218851, -1259.1392167224028,
 771.32342877765313, -176.61502916214059, 12.507343278686905,
 -0.13857109526572012, 9.9843695780195716e-6, 1.5056327351493116e-7};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqrtButton.Text = Convert.ToChar(0x221A).ToString();
            decRadioButton.Checked = true;
            rightBracketButton.Enabled = false;
        }

        private void FontSize(int lenght)
        {
            if (lenght <= 10)
            {
                displayLabel.Font = new Font("Microsoft Sans Serif", 25);
            }
            else if (lenght > 10 && lenght <= 18)
            {
                displayLabel.Font = new Font("Microsoft Sans Serif", 20);
            }
            else if (lenght > 18)
            {
                displayLabel.Font = new Font("Microsoft Sans Serif", 15);
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (add)
            {
                displayLabel.Text += ((Button)sender).Text;
            }
            else
            {
                displayLabel.Text = ((Button)sender).Text;
                add = true;
            }

            FontSize(displayLabel.Text.Length);
        }

        private void BracketClick(object sender, EventArgs e)
        {
            displayTextBox.Text += ((Button)sender).Text;
            rightBracketButton.Enabled = false;
            openBracketCounter++;
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += ((Button)sender).Text;
            add = true;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            if (closedBracket)
            {
                displayTextBox.Text += ((Button)sender).Text;
                closedBracket = false;
            }
            else
            {
                displayTextBox.Text += displayLabel.Text;
                displayTextBox.Text += ((Button)sender).Text;
                add = false;
                positive = true;
                rightBracketButton.Enabled = true;
            }  
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            // CALCULATE
            displayTextBox.Text += displayLabel.Text;
            
            Calculate calculate = new Calculate(displayTextBox.Text);
            displayTextBox.Text  = calculate.check();
            FontSize(displayLabel.Text.Length);
            displayLabel.Text = "0";
            add = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
            displayTextBox.Text = "";
            add = false;
            positive = true;
            FontSize(displayLabel.Text.Length);
        }

        private void resetLastButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
            add = false;
            positive = true;
            FontSize(displayLabel.Text.Length);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int length = displayLabel.Text.Length;
            if (length == 1)
            {
                displayLabel.Text = "0";
                add = false;
                positive = true;
            }
            else
            {
                displayLabel.Text = displayLabel.Text.Remove(displayLabel.Text.Length - 1, 1);
            }
            FontSize(displayLabel.Text.Length);
        }
       
        private void positiveNegativeButton_Click(object sender, EventArgs e)
        {

            if (positive)
            {
                displayLabel.Text = "-" + displayLabel.Text;
                positive = false;
            }
            else
            {
                displayLabel.Text = displayLabel.Text.Remove(0, 1);
                positive = true;
            }

        } 
        #region
        /*
                public void searchForBrackets(string equation, int index)
                {
                    int bracketOpenCount = 0;
                    int indexOfLastOpenBracket = 0;
                    for (int i = index; i < equation.Length; i++)
                    {
                        if (equation[i].Equals('('))
                        {
                            bracketOpenCount++;
                            indexOfLastOpenBracket = i;
                        }
                        if (equation[i].Equals(')'))
                        {
                            string tempEquation = equation.Remove(0, indexOfLastOpenBracket);
                            tempEquation = tempEquation.Remove(i - (indexOfLastOpenBracket-1), tempEquation.Length - (i - (indexOfLastOpenBracket -1 )));
                            Priority(equation, tempEquation, 0);
                            break;
                        }

                    }
                    Priority(equation, equation, 0);         
                    displayLabel.Text = equation.ToString();
                }

                private void Priority(string equation, string tempEquation, int start)
                {
                    char symbol;
                    int[] numbers;
                    int currentresult;
                    //MessageBox.Show(equation);
                    *//*MessageBox.Show(tempEquation);*//*
                    for (int i = start; i < tempEquation.Length; i++)//Mnożenie
                    {
                        if (tempEquation[i] == '*')
                        {
                            symbol = tempEquation[i];
                            numbers = FindNumbers(tempEquation, i, symbol);

                            currentresult = numbers[0] * numbers[1];

                            equation = equation.Replace($"({numbers[0]}{symbol}{numbers[1]})", currentresult.ToString());
                            tempEquation = tempEquation.Replace($"({numbers[0]}{symbol}{numbers[1]})", currentresult.ToString());
                        }
                    }
                    for (int i = 0; i < tempEquation.Length; i++)//Dzielenie
                    {
                        if (tempEquation[i] == '/')
                        {
                            symbol = tempEquation[i];
                            numbers = FindNumbers(tempEquation, i, symbol);

                            currentresult = numbers[0] / numbers[1];

                            equation = equation.Replace($"({numbers[0]}{symbol}{numbers[1]})", currentresult.ToString());
                            tempEquation = tempEquation.Replace($"({numbers[0]}{symbol}{numbers[1]})", currentresult.ToString());
                        }
                    }
                    for (int i = start; i < tempEquation.Length; i++)//Dodawanie
                    {
                        if (tempEquation[i] == '+')
                        {
                            symbol = tempEquation[i];
                            numbers = FindNumbers(tempEquation, i, symbol);

                            currentresult = numbers[0] + numbers[1];

                            equation = equation.Replace($"({numbers[0]}{symbol}{numbers[1]})", currentresult.ToString());
                            tempEquation = tempEquation.Replace($"({numbers[0]}{symbol}{numbers[1]})", currentresult.ToString());

                        }
                    }
                    for (int i = 0; i < tempEquation.Length; i++)//Odejmowanie
                    {
                        if (tempEquation[i] == '-')
                        {
                            symbol = tempEquation[i];
                            numbers = FindNumbers(tempEquation, i, symbol);

                            currentresult = numbers[0] - numbers[1];

                            equation = equation.Replace($"({numbers[0]}{symbol}{numbers[1]})", currentresult.ToString());
                            tempEquation = tempEquation.Replace($"({numbers[0]}{symbol}{numbers[1]})", currentresult.ToString());
                        }
                    }
                    searchForSymbols(tempEquation, equation);
                    searchForBrackets(equation, 0);

                }

                private static int[] FindNumbers(string equation, int start, char symbol)
                {
                    int[] numbers = new int[2];
                    string number1String = string.Empty;
                    string number2String = string.Empty;

                    if (equation[start] == symbol)
                    {
                        for (int j = start - 1; j >= 0; j--) // Liczba z lewej
                        { 
                            if (char.IsDigit(equation[j]))
                            {
                                number1String = equation[j] + number1String;
                            }
                            else
                            {
                                break;
                            }
                        }
                        for (int j = start + 1; j < equation.Length; j++) // Liczba z prawej
                        {
                            if (char.IsDigit(equation[j]))
                            {
                                number2String += equation[j];
                            }
                            else
                            {
                                break;
                            }
                        }
                        numbers[0] = int.Parse(number1String);
                        numbers[1] = int.Parse(number2String);
                    }
                    return numbers;
                }

                private void searchForSymbols(string tempEquation, string equation)
                {
                    for (int i = 0; i < tempEquation.Length; i++)//Poszukiwanie kolejnych znaków.
                    {
                        if (char.IsSymbol(tempEquation[i])) 
                        {
                            Priority(equation, tempEquation, 0);
                        }
                    }
                    searchForBrackets(equation, 0);
                }
        */
        #endregion
        private void decRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            numberButton0.Enabled = true;
            numberButton1.Enabled = true;
            numberButton2.Enabled = true;
            numberButton3.Enabled = true;
            numberButton4.Enabled = true;
            numberButton5.Enabled = true;
            numberButton6.Enabled = true;
            numberButton7.Enabled = true;
            numberButton8.Enabled = true;
            numberButton9.Enabled = true;
            numberButtonA.Enabled = false;
            numberButtonB.Enabled = false;
            numberButtonC.Enabled = false;
            numberButtonD.Enabled = false;
            numberButtonE.Enabled = false;
            numberButtonF.Enabled = false;
        }

        private void hexRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            numberButton0.Enabled = true;
            numberButton1.Enabled = true;
            numberButton2.Enabled = true;
            numberButton3.Enabled = true;
            numberButton4.Enabled = true;
            numberButton5.Enabled = true;
            numberButton6.Enabled = true;
            numberButton7.Enabled = true;
            numberButton8.Enabled = true;
            numberButton9.Enabled = true;
            numberButtonA.Enabled = true;
            numberButtonB.Enabled = true;
            numberButtonC.Enabled = true;
            numberButtonD.Enabled = true;
            numberButtonE.Enabled = true;
            numberButtonF.Enabled = true;
        }

        private void binRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            numberButton0.Enabled = true;
            numberButton1.Enabled = true;
            numberButton2.Enabled = false;
            numberButton3.Enabled = false;
            numberButton4.Enabled = false;
            numberButton5.Enabled = false;
            numberButton6.Enabled = false;
            numberButton7.Enabled = false;
            numberButton8.Enabled = false;
            numberButton9.Enabled = false;
            numberButtonA.Enabled = false;
            numberButtonB.Enabled = false;
            numberButtonC.Enabled = false;
            numberButtonD.Enabled = false;
            numberButtonE.Enabled = false;
            numberButtonF.Enabled = false;
        }

        private void octRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            numberButton0.Enabled = true;
            numberButton1.Enabled = true;
            numberButton2.Enabled = true;
            numberButton3.Enabled = true;
            numberButton4.Enabled = true;
            numberButton5.Enabled = true;
            numberButton6.Enabled = true;
            numberButton7.Enabled = true;
            numberButton8.Enabled = false;
            numberButton9.Enabled = false;
            numberButtonA.Enabled = false;
            numberButtonB.Enabled = false;
            numberButtonC.Enabled = false;
            numberButtonD.Enabled = false;
            numberButtonE.Enabled = false;
            numberButtonF.Enabled = false;
        }

        private void rightBracketButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += displayLabel.Text;
            displayTextBox.Text += ((Button)sender).Text;
            add = false;
            positive = true;
            openBracketCounter--;
            closedBracket = true;
            if (openBracketCounter == 0)
            {
                rightBracketButton.Enabled = false;
            }
            
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            if(displayLabel.Text == "0")
            {
                displayTextBox.Text += "2" + ((Button)sender).Text;
            }
            else
            {
                displayTextBox.Text += ((Button)sender).Text;
            }
            
        }

        private void factorialButton_Click(object sender, EventArgs e)
        {
            if (closedBracket)
            {
                Calculate calculate = new Calculate(displayTextBox.Text);
                displayTextBox.Text = GammaFunc((Convert.ToDouble(calculate.check())+1)).ToString();
                FontSize(displayLabel.Text.Length);
            }
            else
            {
                displayTextBox.Text += GammaFunc((Convert.ToDouble(displayLabel.Text) + 1)).ToString();
            }
        }

        private double GammaFunc(double z)
        {
            if (z < 0.5)
                return Math.PI / (Math.Sin(Math.PI * z) * GammaFunc(1 - z));
            z -= 1;
            double x = p[0];
            for (var i = 1; i < g + 2; i++)
                x += p[i] / (z + i);
            double t = z + g + 0.5;
            return Math.Sqrt(2 * Math.PI) * (Math.Pow(t, z + 0.5)) * Math.Exp(-t) * x;
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = Math.Log10(Convert.ToDouble(displayLabel.Text)).ToString(); 
        }

        private void lnButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = Math.Log(Convert.ToDouble(displayLabel.Text)).ToString();
        }

        private void reciprocalButton_Click(object sender, EventArgs e)
        {
            // CALCULATE
            displayTextBox.Text += displayLabel.Text;

            Calculate calculate = new Calculate(displayTextBox.Text);
            displayTextBox.Text = calculate.check();
            FontSize(displayLabel.Text.Length);
            displayLabel.Text = "0";
            add = false;

            displayTextBox.Text = (1 / Convert.ToDouble(displayTextBox.Text)).ToString();
        }

        private void equalsButton_Click_1(object sender, EventArgs e)
        {
            // CALCULATE
            displayTextBox.Text += displayLabel.Text;

            Calculate calculate = new Calculate(displayTextBox.Text);
            displayTextBox.Text = calculate.check();
            FontSize(displayLabel.Text.Length);
            displayLabel.Text = "0";
            add = false;
        }
    }
}
