using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static KalkulatorZal.Form1;

namespace KalkulatorZal
{
    public class Calculate
    {
        string equation { get; set; }
        string tempEquation;
        int index;
       // StringBuilder stringBuilder;
        public Calculate(string equation)
        {
           // stringBuilder = new StringBuilder(equation);
            this.equation = equation;
            index = 0;
        }
    
        
        public string searchForBrackets()
        {
            /*
            int bracketOpenCount = 0;*/
            int indexOfLastOpenBracket = 0;
            for (int i = index; i < equation.Length; i++)
            {
                if (equation[i].Equals('('))
                {
/*                    bracketOpenCount++;
*/                    indexOfLastOpenBracket = i;
                }
                if (equation[i].Equals(')'))
                {
                    tempEquation = equation.Remove(0, indexOfLastOpenBracket);
                    tempEquation = tempEquation.Remove(i - (indexOfLastOpenBracket - 1), tempEquation.Length - (i - (indexOfLastOpenBracket - 1)));
                    Priority(0);
                    break;
                }

            }
            /*tempEquation = equation;*/
            Priority(0);
            return equation;
        }

        public void Priority(int start)
        {
            char symbol;
            int[] numbers = new int[2];
            int currentresult;
            for (int i = start; i < tempEquation.Length; i++)//Mnożenie
            {
                if (tempEquation[i] == '*')
                {
                    symbol = tempEquation[i];
                    numbers = FindNumbers(i, symbol);

                    equation = equation.Replace($"({numbers[0]}{symbol}{numbers[1]})", (numbers[0] * numbers[1]).ToString());
                    tempEquation = tempEquation.Replace($"({numbers[0]}{symbol}{numbers[1]})", (numbers[0] * numbers[1]).ToString());
                }
            }
            for (int i = 0; i < tempEquation.Length; i++)//Dzielenie
            {
                if (tempEquation[i] == '/')
                {
                    symbol = tempEquation[i];
                    numbers = FindNumbers(i, symbol);

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
                    numbers = FindNumbers(i, symbol);

                    currentresult = numbers[0] + numbers[1];

                    equation = equation.Replace($"({numbers[0]}{symbol}{numbers[1]})", currentresult.ToString()); // StackOverflowExeption...
                    tempEquation = tempEquation.Replace($"({numbers[0]}{symbol}{numbers[1]})", currentresult.ToString());

                }
            }
            for (int i = 0; i < tempEquation.Length; i++)//Odejmowanie
            {
                if (tempEquation[i] == '-')
                {
                    symbol = tempEquation[i];
                    numbers = FindNumbers(i, symbol);

                    currentresult = numbers[0] - numbers[1];

                    equation = equation.Replace($"({numbers[0]}{symbol}{numbers[1]})", currentresult.ToString());
                    tempEquation = tempEquation.Replace($"({numbers[0]}{symbol}{numbers[1]})", currentresult.ToString());
                }
            }
            searchForSymbols();
            searchForBrackets();

        }

        public int[] FindNumbers(int start, char symbol)
        {
            int[] numbers = new int[2];
            string number1String = string.Empty;
            string number2String = string.Empty;

            if (tempEquation[start] == symbol)
            {
                for (int j = start - 1; j >= 0; j--) // Liczba z lewej
                {
                    if (char.IsDigit(tempEquation[j]))
                    {
                        number1String = tempEquation[j] + number1String;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int j = start + 1; j < tempEquation.Length; j++) // Liczba z prawej
                {
                    if (char.IsDigit(tempEquation[j]))
                    {
                        number2String += tempEquation[j];
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

        public void searchForSymbols()
        {
            for (int i = 0; i < tempEquation.Length; i++)//Poszukiwanie kolejnych znaków.
            {
                if (char.IsSymbol(tempEquation[i]))
                {
                    Priority(0);
                }
            }
            searchForBrackets();
        }
    }
}
