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
                            if (tempEquation[j] == '*' || tempEquation[j] == '/' || tempEquation[j] == '+' || tempEquation[j] == '-') counter++; //obliczanie ilości działań
                            try
                            {
                                if ((tempEquation[j] == '*' || tempEquation[j] == '/' || tempEquation[j] == '+' || tempEquation[j] == '-') &&
                                    (tempEquation[j - 1] == '*' || tempEquation[j - 1] == '/' || tempEquation[j - 1] == '+' ||
                                     tempEquation[j - 1] == '-' || tempEquation[j - 1] == '(')) counter--; // liczba ujemna                                                                                                     
                            }
                            catch (IndexOutOfRangeException)
                            {

                            }
                            
                        }
                        for (int k = 0; k<counter; k++) 
                        {
                            if (counter == 1 && tempEquation[0] == '-')
                            {
                                break;
                            }
                            else
                            {
                                Priority(0); 
                                a = -1; 
                            }
                        }
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
                if (tempEquation[j] == '*' || tempEquation[j] == '/' || tempEquation[j] == '+' || tempEquation[j] == '-' || 
                    tempEquation[j] == Convert.ToChar(0x221A) || tempEquation[j] == '^' ) counter++;
                try
                {
                    if ((tempEquation[j] == '-') &&
                        (tempEquation[j - 1] == '*' || tempEquation[j - 1] == '/' || tempEquation[j - 1] == '+' ||
                         tempEquation[j - 1] == '-' || tempEquation[j - 1] == '(' || tempEquation[j] == Convert.ToChar(0x221A) || 
                         tempEquation[j] == '^')) counter--; // liczba ujemna
                }
                catch (IndexOutOfRangeException)
                {

                }
                
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
                for (int i = start; i < tempEquation.Length; i++)//potęga
                {
                    if (tempEquation[i] == '^')
                    {
                        symbol = tempEquation[i];
                        numbers = FindNumbers(i, symbol);

                        currentresult = (int)Math.Pow(numbers[0],numbers[1]);
                        oldPart = $"{numbers[0]}{symbol}{numbers[1]}";

                        tempEquation = tempEquation.Replace($"{numbers[0]}{symbol}{numbers[1]}", currentresult.ToString());
                        tester++;
                        if (tester == counter && parenthesisCount > 0)
                        {
                            equation = equation.Replace($"({oldPart})", tempEquation.Remove(0, 1).Remove(tempEquation.Length - 2, 1));
                            tester = 0;
                        }
                        else
                        {
                            equation = equation.Replace(oldPart, currentresult.ToString());
                        }
                        return;
                    }
                }
                for (int i = start; i < tempEquation.Length; i++)//sqrt
                {
                    if (tempEquation[i] == Convert.ToChar(0x221A))
                    {
                        symbol = tempEquation[i];
                        numbers = FindNumbers(i, symbol);

                        currentresult = (int)Math.Pow(numbers[1], 1.0 / numbers[0]);
                        oldPart = $"{numbers[0]}{symbol}{numbers[1]}";

                        tempEquation = tempEquation.Replace($"{numbers[0]}{symbol}{numbers[1]}", currentresult.ToString());
                        tester++;
                        if (tester == counter && parenthesisCount > 0)
                        {
                            equation = equation.Replace($"({oldPart})", tempEquation.Remove(0, 1).Remove(tempEquation.Length - 2, 1));
                            tester = 0;
                        }
                        else
                        {
                            equation = equation.Replace(oldPart, currentresult.ToString());
                        }
                        return;
                    }
                }
                for (int i = start; i < tempEquation.Length; i++)//Mnożenie
                {
                    if (tempEquation[i] == '*')
                    {
                        symbol = tempEquation[i];
                        numbers = FindNumbers(i, symbol);

                        currentresult = numbers[0] * numbers[1];
                        oldPart = $"{numbers[0]}{symbol}{numbers[1]}";

                        tempEquation = tempEquation.Replace($"{numbers[0]}{symbol}{numbers[1]}", currentresult.ToString());
                        tester++;
                        if (tester == counter && parenthesisCount > 0)
                        {
                            equation = equation.Replace($"({oldPart})", tempEquation.Remove(0, 1).Remove(tempEquation.Length - 2, 1));
                            tester = 0;
                        }
                        else
                        {
                            equation = equation.Replace(oldPart, currentresult.ToString());
                        }
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
                        oldPart = $"{numbers[0]}{symbol}{numbers[1]}";

                        tempEquation = tempEquation.Replace($"{numbers[0]}{symbol}{numbers[1]}", currentresult.ToString());
                        tester++;
                        if (tester == counter && parenthesisCount > 0)
                        {
                            equation = equation.Replace($"({oldPart})", tempEquation.Remove(0, 1).Remove(tempEquation.Length - 2, 1));
                            tester = 0;
                        }
                        else
                        {
                            equation = equation.Replace(oldPart, currentresult.ToString());
                        }
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
                        
                        tempEquation = tempEquation.Replace($"{numbers[0]}{symbol}{numbers[1]}", currentresult.ToString());
                        tester++;
                        if (tester == counter && parenthesisCount > 0)
                        {
                            equation = equation.Replace($"({oldPart})", tempEquation.Remove(0,1).Remove(tempEquation.Length-2,1));
                            tester = 0;
                        }
                        else
                        {
                            equation = equation.Replace(oldPart, currentresult.ToString()) ;
                        }
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
                        oldPart = $"{numbers[0]}{symbol}{numbers[1]}";

                        tempEquation = tempEquation.Replace($"{numbers[0]}{symbol}{numbers[1]}", currentresult.ToString());
                        tester++;
                        if (tester == counter && parenthesisCount > 0)
                        {
                            equation = equation.Replace($"({oldPart})", tempEquation.Remove(0, 1).Remove(tempEquation.Length - 2, 1));
                            tester = 0;
                        }
                        else
                        {
                            equation = equation.Replace(oldPart, currentresult.ToString());
                        }
                        return;
                    }
                }
            }
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
                    try
                    {
                        if (isDigit(tempEquation[j]) || (tempEquation[j] == '-' && !isDigit(tempEquation[j-1])))
                        {
                            if (tempEquation[j] == Convert.ToChar(0x221A))
                            {
                                try
                                {
                                    if (!isDigit(tempEquation[j - 1])) continue;
                                    else number1String = "2";
                                }
                                catch (IndexOutOfRangeException) { }
                            }
                            number1String = tempEquation[j] + number1String;
                        }
                        else
                        {
                            break;
                        }
                    }catch (IndexOutOfRangeException)
                    {
                        if (isDigit(tempEquation[j]))
                        {
                            number1String = tempEquation[j] + number1String;
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                }
                for (int j = start + 1; j < tempEquation.Length; j++) // Liczba z prawej
                {
                    if (isDigit(tempEquation[j]) || (tempEquation[j] == '-' && j == (start+1)))
                    {
                        number2String += tempEquation[j];
                    }
                    else
                    {
                        break;
                    }
                }
                if (number1String == string.Empty && symbol == Convert.ToChar(0x221A))
                {
                    number1String = "2";
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
                oldPart = tempEquation;
                tempEquation = tempEquation.Remove(0, 1).Remove(tempEquation.Length - 2, 1);
                equation = equation.Replace(oldPart, tempEquation);
                tempEquation = string.Empty;
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
                    return true;
                default:
                    return false;

            }
        }
    }
}
