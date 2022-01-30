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
    public partial class Kalkulator : Form
    {
        private bool add = false;
        bool positive = true;
        private int openBracketCounter = 0;
        private bool closedBracket = false;
        static int g = 7;
        double memory = 0;
        private bool logicOperation = false;
        private string logicString = string.Empty;
        private string logicOperator = string.Empty;
        private string system;

        static double[] p = {0.99999999999980993, 676.5203681218851, -1259.1392167224028,
 771.32342877765313, -176.61502916214059, 12.507343278686905,
 -0.13857109526572012, 9.9843695780195716e-6, 1.5056327351493116e-7};
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqrtButton.Text = Convert.ToChar(0x221A).ToString();
            decRadioButton.Checked = true;
            rightBracketButton.Enabled = false;
            system = "DEC";
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
            if (logicOperation)
            {
                logicString += displayLabel.Text;
                string[] logicNumbers = logicString.Split(',');
                displayTextBox.Text = displayTextBox.Text.Replace($"{logicNumbers[0]}{logicOperator}{logicNumbers[1]}",
                    new Calculate().logicOperation(logicString, logicOperator, system));
                logicOperation = false;
            }
            else
            {
                if (closedBracket)
                {
                    displayTextBox.Text += ((Button)sender).Text;
                    closedBracket = false;
                }
                else
                {
                    if (displayTextBox.Text != string.Empty && displayLabel.Text == "0")
                    {
                        displayTextBox.Text += ((Button)sender).Text;
                        add = false;
                        positive = true;
                        rightBracketButton.Enabled = true;
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
            }
            
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            // CALCULATE
            displayTextBox.Text += displayLabel.Text;
            Calculate calculate = new Calculate(displayTextBox.Text, system);
            if (logicOperation)
            {
                calculate.logicOperation("", logicOperator, system);
            }
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
            rightBracketButton.Enabled = false;
            openBracketCounter = 0;
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
                if (displayLabel.Text[displayLabel.Text.Length-1] == '(')
                {
                    rightBracketButton.Enabled = false;
                    openBracketCounter--;
                }
                else if (displayLabel.Text[displayLabel.Text.Length - 1] == ')')
                {
                    rightBracketButton.Enabled = true;
                    openBracketCounter++;
                }
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
            dotButton.Enabled = true;
            displayTextBox.Text = string.Empty;
            displayLabel.Text = "0";
            system = "DEC";
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
            dotButton.Enabled = false;
            displayTextBox.Text = string.Empty;
            displayLabel.Text = "0";
            system = "HEX";
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
            dotButton.Enabled = false;
            displayTextBox.Text = string.Empty;
            displayLabel.Text = "0";
            system = "BIN";
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
            dotButton.Enabled = false;
            displayTextBox.Text = string.Empty;
            displayLabel.Text = "0";
            system = "OCT";
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
            if (displayLabel.Text == "0")
            {
                displayTextBox.Text += "2" + ((Button)sender).Text;
            }
            else if (displayTextBox.Text != string.Empty && displayLabel.Text == "0")
            {
                displayTextBox.Text += ((Button)sender).Text;
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
                Calculate calculate = new Calculate(displayTextBox.Text, system);
                displayTextBox.Text = GammaFunc((Convert.ToDouble(calculate.check())+1)).ToString();
                FontSize(displayLabel.Text.Length);
            }
            else
            {
                if (add)
                {
                    displayTextBox.Text = GammaFunc((Convert.ToDouble(displayLabel.Text) + 1)).ToString();
                }
                else
                {
                    displayTextBox.Text += GammaFunc((Convert.ToDouble(displayLabel.Text) + 1)).ToString();
                }
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

            Calculate calculate = new Calculate(displayTextBox.Text,system);
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

            Calculate calculate = new Calculate(displayTextBox.Text, system);
            displayTextBox.Text = calculate.check();
            FontSize(displayLabel.Text.Length);
            displayLabel.Text = "0";
            add = false;
        }

        private void sinButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = Math.Sin(Convert.ToDouble(displayLabel.Text)).ToString();
        }

        private void tgButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = Math.Tan(Convert.ToDouble(displayLabel.Text)).ToString();
        }

        private void cosButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = Math.Cos(Convert.ToDouble(displayLabel.Text)).ToString();
        }

        private void ctgButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = (1 / Math.Tan(Convert.ToDouble(displayLabel.Text))).ToString();
        }

        private void memoryAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                memory += Convert.ToDouble(displayTextBox.Text);
            }
            catch(FormatException)
            {
                Calculate calculate = new Calculate(displayTextBox.Text,system);
                displayTextBox.Text = calculate.check();
                FontSize(displayLabel.Text.Length);
                displayLabel.Text = "0";
                add = false;
                memory += Convert.ToDouble(displayTextBox.Text);
            }
            
        }

        private void memorySubstractButton_Click(object sender, EventArgs e)
        {
            try
            {
                memory -= Convert.ToDouble(displayTextBox.Text);
            }
            catch (FormatException)
            {
                Calculate calculate = new Calculate(displayTextBox.Text,system);
                displayTextBox.Text = calculate.check();
                FontSize(displayLabel.Text.Length);
                displayLabel.Text = "0";
                add = false;
                memory += Convert.ToDouble(displayTextBox.Text);
            }
        }

        private void memoryRecallButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = memory.ToString();
        }

        private void memoryClearButton_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!programmerToolStripMenuItem.Checked) 
            { 
                programmerToolStripMenuItem.Checked = true;
                andButton.Visible = true;
                orButton.Visible = true;
                notButton.Visible = true;
                xorButton.Visible = true;
                sqrtButton.Visible = false;
                powButton.Visible = false;
                logButton.Visible = false;
                lnButton.Visible = false;
                reciprocalButton.Visible = false;
                factorialButton.Visible = false; 
                sinButton.Visible = false;
                cosButton.Visible = false;
                tgButton.Visible = false;
                ctgButton.Visible = false;
                dotButton.Enabled = false;
            }
            else
            {
                programmerToolStripMenuItem.Checked = false;
                andButton.Visible = false;
                orButton.Visible = false;
                notButton.Visible = false;
                xorButton.Visible = false;
                sqrtButton.Visible = true;
                powButton.Visible = true;
                logButton.Visible = true;
                lnButton.Visible = true;
                reciprocalButton.Visible = true;
                factorialButton.Visible = true;
                sinButton.Visible = true;
                cosButton.Visible = true;
                tgButton.Visible = true;
                ctgButton.Visible = true;
                dotButton.Enabled = true;
                decRadioButton.Checked = true;

            }
            

        }

        private void andButton_Click(object sender, EventArgs e)
        {
            logicString = displayLabel.Text + ",";
            actionButton_Click(sender, e);
            logicOperation = true;
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            actionButton_Click(sender, e);
            logicOperation = true;
        }

        private void notButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = new Calculate().negate(displayLabel.Text, system);
        }

        private void xorButton_Click(object sender, EventArgs e)
        {
            actionButton_Click(sender, e);
            logicOperation = true;
        }


    }
}
