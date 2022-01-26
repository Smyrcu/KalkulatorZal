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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
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

        private void dotButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text += ((Button)sender).Text;
            add = true;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
                displayTextBox.Text += displayLabel.Text;
                displayTextBox.Text += ((Button)sender).Text;
                add = false;
                positive = true;
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
            /*MessageBox.Show(tempEquation);*/
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
    }
}
