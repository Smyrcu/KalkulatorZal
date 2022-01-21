using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KalkulatorZal.Form1;

namespace KalkulatorZal
{
    public class Calculate
    {
        Label displayLabel = new Label();
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
                    tempEquation = tempEquation.Remove(i - (indexOfLastOpenBracket - 1), tempEquation.Length - (i - (indexOfLastOpenBracket - 1)));
                    Priority(equation, tempEquation, 0);
                    break;
                }

            }
            Priority(equation, equation, 0);
            displayLabel.Text = equation.ToString();
        }

        public void Priority(string equation, string tempEquation, int start)
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

        public static int[] FindNumbers(string equation, int start, char symbol)
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

        public void searchForSymbols(string tempEquation, string equation)
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
