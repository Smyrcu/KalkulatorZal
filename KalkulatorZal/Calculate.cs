using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static KalkulatorZal.Form1;
using System.Text.RegularExpressions;
using System.Reflection;

namespace KalkulatorZal
{
    public class Calculate
    {
        public bool divisionBy0 = false;
        public string equation { get; set; }
        public string oldPart;
        public string tempEquation;
        public int index;
        public int parenthesisCount;
        int counter = 0;
        int tester = 0;
        public Calculate(string equation)
        {
           // stringBuilder = new StringBuilder(equation);
            this.equation = equation;
            index = 0;
        }

        public string check()
        {
            int open = 0, close = 0;
            for (int i = index; i < equation.Length; i++)
            {
                if (equation[i].Equals('(')) open++;
                if (equation[i].Equals(')')) close++;
            }
            if (open != close)
            {
                MessageBox.Show("Popraw nawiasy!");
                return equation;
            }
            else
            {
                parenthesisCount = open;
                return searchForBrackets();
            }
        }
    
        
        public string searchForBrackets()
        {

            /*
            int bracketOpenCount = 0;*/
            int indexOfLastOpenBracket = 0;
            for (int a = 0; a < parenthesisCount; a++) {
                for (int i = index; i < equation.Length; i++)
                {
                    if (equation[i].Equals('('))
                    {
                        /*                    bracketOpenCount++;
                        */
                        indexOfLastOpenBracket = i;
                    }
                    if (equation[i].Equals(')'))
                    {
                        tempEquation = equation.Remove(0, indexOfLastOpenBracket);
                        tempEquation = tempEquation.Remove(i - (indexOfLastOpenBracket - 1), tempEquation.Length - (i - (indexOfLastOpenBracket - 1)));
                        for (int j = 0; j < tempEquation.Length; j++)
{
                            if (tempEquation[j] == '*' || tempEquation[j] == '/' || tempEquation[j] == '+' || tempEquation[j] == '-') counter++;
                            //obliczanie ilości działań
                        }
                        for (int k = 0; k<counter; k++) {Priority(0); a = -1; }
                        counter = 0;
                        if (divisionBy0)
                        {
                            return "Nie można dzielić przez 0";
                        }
                        break;
                    }
                } 
            }
            tempEquation = equation;
            for (int j = 0; j < tempEquation.Length; j++)
            {
                if (tempEquation[j] == '*' || tempEquation[j] == '/' || tempEquation[j] == '+' || tempEquation[j] == '-') counter++;
                //obliczanie ilości działań
            }
            for (int l = 0; l < counter; l++) { Priority(0); }
            if (divisionBy0)
            {
                return "Nie można dzielić przez 0";
            }
            equation = tempEquation;
            return equation;
        }

        public void Priority(int start)
        {
            char symbol;
            int[] numbers = new int[2];
            int currentresult;
            
            
            
            

            for (int r = 0; r < counter; r++)
            {

                for (int i = start; i < tempEquation.Length; i++)//Mnożenie
                {
                    if (tempEquation[i] == '*')
                    {
                        symbol = tempEquation[i];
                        numbers = FindNumbers(i, symbol);
                        oldPart = tempEquation;
                        /* equation = equation.Replace($"{numbers[0]}{symbol}{numbers[1]}", (numbers[0] * numbers[1]).ToString());*/
                        tempEquation = tempEquation.Replace($"{numbers[0]}{symbol}{numbers[1]}", (numbers[0] * numbers[1]).ToString());
                        searchForSymbols();
                        return;
                    }
                }
                for (int i = 0; i < tempEquation.Length; i++)//Dzielenie
                {
                    if (tempEquation[i] == '/')
                    {
                        symbol = tempEquation[i];
                        numbers = FindNumbers(i, symbol);
                        if (numbers[1] == 0)
                        {
                            divisionBy0 = true;
                            return;
                        }
                        currentresult = numbers[0] / numbers[1];
                        oldPart = tempEquation;
                        /* equation = equation.Replace($"{numbers[0]}{symbol}{numbers[1]}", currentresult.ToString());*/
                        tempEquation = tempEquation.Replace($"{numbers[0]}{symbol}{numbers[1]}", currentresult.ToString());
                        searchForSymbols();
                        return;
                    }
                }
                for (int i = start; i < tempEquation.Length; i++)//Dodawanie
                {
                    if (tempEquation[i] == '+')
                    {
                        symbol = tempEquation[i];
                        numbers = FindNumbers(i, symbol);

                        currentresult = numbers[0] + numbers[1];
                        oldPart = $"{numbers[0]}{symbol}{numbers[1]}";
                        /* equation = equation.Replace($"{numbers[0]}{symbol}{numbers[1]}", currentresult.ToString());*/
                        tempEquation = tempEquation.Replace($"{numbers[0]}{symbol}{numbers[1]}", currentresult.ToString());
                        tester++;
                        if (tester == counter)
                        {
                            equation = equation.Replace($"({oldPart})", tempEquation.Remove(0,1).Remove(tempEquation.Length-2,1));
                            tester = 0;
                        }
                        else
                        {
                            equation = equation.Replace(oldPart, currentresult.ToString()) ;
                        }
                       
                        /*searchForSymbols();*/
                        return;

                    }
                }
                for (int i = 0; i < tempEquation.Length; i++)//Odejmowanie
                {
                    if (tempEquation[i] == '-')
                    {
                        symbol = tempEquation[i];
                        numbers = FindNumbers(i, symbol);

                        currentresult = numbers[0] - numbers[1];
                        oldPart = tempEquation;
                        /*equation = equation.Replace($"{numbers[0]}{symbol}{numbers[1]}", currentresult.ToString());*/
                        tempEquation = tempEquation.Replace($"{numbers[0]}{symbol}{numbers[1]}", currentresult.ToString());
                        searchForSymbols();
                        return;
                    }
                }
            }
            /*searchForSymbols();
            searchForBrackets();*/

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
                    if (tempEquation[i] == '(' || tempEquation[i] == ')')
                    {
                        continue;
                    }
                    Priority(0);
                }
            }

            try
            {
                Convert.ToDouble(tempEquation);
                return;
            }
            catch
            {



                /*searchForBrackets();*/
                oldPart = tempEquation;
                tempEquation = tempEquation.Remove(0, 1).Remove(tempEquation.Length - 2, 1);
                equation = equation.Replace(oldPart, tempEquation);
                tempEquation = string.Empty;
            }
        }
    }
}
