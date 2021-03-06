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
using static KalkulatorZal.History;

namespace KalkulatorZal
{
    public partial class Kalkulator : Form
    {
        private bool add = false; // Adding numbers to displayLabel
        private bool positive = true; // Positive/negative number
        private int openBracketCounter = 0; // bracket counter
        private bool closedBracket = false; // if last mark in textbox is closing bracket
        private static int g = 7; // for gamma func
        private double memory = 0; // Calc Memory
        private bool logicOperation = false; // for logic operations 
        private string logicString = string.Empty; // logic operation
        private string logicOperator = string.Empty; // logic operator (and/or/...)
        private string system; // dec/hex/...
        private bool clear = true; // if displayTextBox is should be overrided
        public static Kalkulator kalkulator;
        public ToolStripMenuItem converterMenuItem;

        
        public delegate void UpdateUI(string str, string system);
        public UpdateUI update;

        public delegate void CloseConverter();
        public CloseConverter closeConverter;

        private List<HistoryElement> history = new List<HistoryElement>();
        public HistoryElement backFromHistory;

        static double[] p = {0.99999999999980993, 676.5203681218851, -1259.1392167224028,
 771.32342877765313, -176.61502916214059, 12.507343278686905,
 -0.13857109526572012, 9.9843695780195716e-6, 1.5056327351493116e-7}; // for gamma func
        public Kalkulator()
        {
            InitializeComponent();
            kalkulator = this;
            converterMenuItem = konwerterToolStripMenuItem;
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
                displayLabel.Text += ((Button)sender).Text[1];
            }
            else
            {
                displayLabel.Text = ((Button)sender).Text[1].ToString();
                add = true;
            }

            FontSize(displayLabel.Text.Length);
        }

        private void BracketClick(object sender, EventArgs e)
        {
            if (clear)
            {
                displayTextBox.Text = ((Button)sender).Text[1].ToString();
                rightBracketButton.Enabled = false;
                openBracketCounter++;
                clear = false;
            }
            else
            { 
                if (displayTextBox.Text[displayTextBox.Text.Length-1] == ')')
                {
                    displayTextBox.Text += '*';
                    displayTextBox.Text += ((Button)sender).Text[1];
                    rightBracketButton.Enabled = false;
                    openBracketCounter++;
                }
                else
                {
                    displayTextBox.Text += ((Button)sender).Text[1];
                    rightBracketButton.Enabled = false;
                    openBracketCounter++;
                }
                
            }

        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += ((Button)sender).Text[1];
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
                    displayTextBox.Text += ((Button)sender).Text[1];
                    closedBracket = false;
                }
                else
                {
                    if (displayTextBox.Text != string.Empty && displayLabel.Text == "0")
                    {
                        if (displayTextBox.Text[displayTextBox.Text.Length-1].Equals('+') || 
                            displayTextBox.Text[displayTextBox.Text.Length - 1].Equals('-') ||
                            displayTextBox.Text[displayTextBox.Text.Length - 1].Equals('*') ||
                            displayTextBox.Text[displayTextBox.Text.Length - 1].Equals('/') ||
                            displayTextBox.Text[displayTextBox.Text.Length - 1].Equals('^'))
                        { displayTextBox.Text = displayTextBox.Text.Remove(displayTextBox.Text.Length - 1, 1); } // Anty multiple marks after first equation

                        displayTextBox.Text += ((Button)sender).Text[1];
                        add = false;
                        positive = true;
                        if (openBracketCounter == 0) { rightBracketButton.Enabled = false; }
                        else { rightBracketButton.Enabled = true; }
                        clear = false;
                    }
                    else if (clear)
                    {
                        displayTextBox.Text = displayLabel.Text;
                        displayTextBox.Text += ((Button)sender).Text[1];
                        add = false;
                        positive = true;
                        if (openBracketCounter == 0) { rightBracketButton.Enabled = false; }
                        else { rightBracketButton.Enabled = true; }
                        clear = false;
                    }
                    else
                    {
                        displayTextBox.Text += displayLabel.Text;
                        displayTextBox.Text += ((Button)sender).Text[1];
                        add = false;
                        positive = true;
                        if (openBracketCounter == 0) { rightBracketButton.Enabled = false; }
                        else { rightBracketButton.Enabled = true; }
                        clear = false;
                    }
                }
            }
            
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
            add = false;
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
            add = false;
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
            add = false;
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
            add = false;
            system = "OCT";
        }

        private void rightBracketButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += displayLabel.Text;
            displayTextBox.Text += ((Button)sender).Text[1];
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
            if (logicOperation)
            {
                logicString += displayLabel.Text;
                string[] logicNumbers = logicString.Split(',');
                displayTextBox.Text = displayTextBox.Text.Replace($"{logicNumbers[0].ToUpper()}{logicOperator}",
                    new Calculate().logicOperation(logicString, logicOperator, system));
                logicOperation = false;
            }
            
            if (!isDigit(displayTextBox.Text[displayTextBox.Text.Length-1])) 
            {
                displayTextBox.Text += displayLabel.Text;
            }
            else if (displayTextBox.Text[displayTextBox.Text.Length - 1] != ')' && displayLabel.Text != "0")
            {
                displayTextBox.Text += displayLabel.Text;
            }
            // CALCULATE
            if (openBracketCounter > 0)
            {
                for (int i = openBracketCounter; i > 0; i--)
                {
                    displayTextBox.Text += ')';
                    openBracketCounter--;
                }
            }
            string forHistory = displayTextBox.Text;
            Calculate calculate = new Calculate(displayTextBox.Text, system);
            displayTextBox.Text = calculate.check();
            FontSize(displayLabel.Text.Length);
            history.Add(new HistoryElement(forHistory, displayTextBox.Text));
            displayLabel.Text = "0";
            add = false;
            clear = true;
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
                scienceToolStripMenuItem.Checked = false;
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
                decRadioButton.Checked = true;
                decRadioButton.Visible = true;
                hexRadioButton.Visible = true;
                binRadioButton.Visible = true;
                octRadioButton.Visible = true;
                konwerterToolStripMenuItem.Visible = true;

            }
            else
            {
                scienceToolStripMenuItem.Checked = true;
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
                decRadioButton.Visible = false;
                hexRadioButton.Visible = false;
                binRadioButton.Visible = false;
                octRadioButton.Visible = false;
                konwerterToolStripMenuItem.Visible = false;
                konwerterToolStripMenuItem.Checked = false;
                closeConverter();
            }
            

        }

        private void andButton_Click(object sender, EventArgs e)
        {
            logicString = displayLabel.Text + ",";
            actionButton_Click(sender, e);
            logicOperation = true;
            logicOperator = "AND";
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            logicString = displayLabel.Text + ",";
            actionButton_Click(sender, e);
            logicOperation = true;
            logicOperator = "OR";
        }

        private void notButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = new Calculate().negate(displayLabel.Text, system);
        }

        private void xorButton_Click(object sender, EventArgs e)
        {
            logicString = displayLabel.Text + ",";
            actionButton_Click(sender, e);
            logicOperation = true;
            logicOperator = "XOR";
        }


        private void displayTextBox_TextChanged(object sender, EventArgs e)
        {
            if(displayTextBox.Text == string.Empty)
            {
                clear = false;
            }
        }
        private bool isDigit(char character)
        {
            switch (character)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                case ',':
                case ')':
                    return true;
                default:
                    return false;

            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(openInfoForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openInfoForm()
        {
            Application.Run(new InfoForm());
        }

        private void displayLabel_TextChanged(object sender, EventArgs e)
        {
            if (konwerterToolStripMenuItem.Checked){
                update(displayLabel.Text, system);
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History historyForm = new History(history);

            if (historyForm.ShowDialog() == DialogResult.OK)
            {
                backFromHistory = historyForm.model;
                displayLabel.Text = backFromHistory.result;
                displayTextBox.Text = backFromHistory.equation;
            }

        }

        private void konwerterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!konwerterToolStripMenuItem.Checked)
            {
                Converter converter = new Converter();
                this.update += new UpdateUI(converter.UpdateLabel);
                this.closeConverter += new CloseConverter(converter.CloseThis);
                converter.Show();
                konwerterToolStripMenuItem.Checked = true;
            }
        }

    }
   
}
