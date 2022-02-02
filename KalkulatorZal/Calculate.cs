using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static KalkulatorZal.Kalkulator;

namespace KalkulatorZal
{
    public class Calculate
    {
        public bool divisionBy0 = false;
        public string equation { get; set; }

        private string system;
        public string oldPart;
        public string tempEquation;
        public int index;
        public int parenthesisCount;
        int counter = 0;
        int tester = 0;
        string result;
        public Calculate()
        {

        }
        public Calculate(string equation, string system)
        {
            this.equation = equation;
            this.system = system;
            index = 0;
        }

        public string negate(string numberToNegate, string system)
        {
            result = string.Empty;
            switch (system) // na binarny
            {
                case "DEC":
                    numberToNegate = Convert.ToString(Convert.ToInt32(numberToNegate, 10), 2);
                    break;
                case "HEX":
                    numberToNegate = Convert.ToString(Convert.ToInt32(numberToNegate, 16), 2);
                    break;
                case "BIN":
                    break;
                case "OCT":
                    numberToNegate = Convert.ToString(Convert.ToInt32(numberToNegate, 8), 2);
                    break;

            }

            for (int k = 0; k < numberToNegate.Length; k++)
            {
                if (numberToNegate[k] == '1')
                {
                    result += "0";
                }
                else if (numberToNegate[k] == '0')
                {
                    result += "1";
                }
            }
            for (int k = result.Length; k<64; k++)
            {
                result = "1" + result; 
            }
            switch (system) // z binarnego
            {
                case "DEC":
                    result = Convert.ToString(Convert.ToInt64(result, 2), 10);
                    break;
                case "HEX":
                    result = Convert.ToString(Convert.ToInt64(result, 2), 16);
                    break;
                case "BIN":
                    break;
                case "OCT":
                    result = Convert.ToString(Convert.ToInt64(result, 2), 8);
                    break;

            }
            return result;
        }

        public string logicOperation(string operation, string operatoor, string system) 
        {
            string[] numbers = operation.Split(',');
            result = string.Empty;

            switch (system) // na binarny
            {
                case "DEC":
                    numbers[0] = Convert.ToString(Convert.ToInt32(numbers[0], 10), 2);
                    numbers[1] = Convert.ToString(Convert.ToInt32(numbers[1], 10), 2);
                    break;
                case "HEX" :
                    numbers[0] = Convert.ToString(Convert.ToInt32(numbers[0], 16), 2);
                    numbers[1] = Convert.ToString(Convert.ToInt32(numbers[1], 16), 2);
                    break;
                case "BIN" :
                    break;
                case "OCT" :
                    numbers[0] = Convert.ToString(Convert.ToInt32(numbers[0], 8), 2);
                    numbers[1] = Convert.ToString(Convert.ToInt32(numbers[1], 8), 2);
                    break;

            }
            if (numbers[0].Length > numbers[1].Length)  // Wyrównanie długości bitowej
            {
                for (int j = 0; j < numbers[0].Length - numbers[1].Length; j++)
                {
                    numbers[1] = "0" + numbers[1];
                }
            }
            else if (numbers[0].Length < numbers[1].Length)
            {
                for (int j = 0; j < numbers[1].Length - numbers[0].Length; j++)
                {
                    numbers[0] = "0" + numbers[0];
                }
            }

            switch (operatoor)
            {
                case "AND":
                    for (int k = 0; k < numbers[0].Length; k++)
                    {
                        result += (int.Parse(numbers[1][k].ToString()) & int.Parse(numbers[0][k].ToString())).ToString();
                    }
                    break;
                case "OR":
                    for (int k = 0; k < numbers[0].Length; k++)
                    {
                        result += (int.Parse(numbers[1][k].ToString()) | int.Parse(numbers[0][k].ToString())).ToString();
                    }
                    break;
                case "XOR":
                    for (int k = 0; k < numbers[0].Length; k++)
                    {
                        result += (int.Parse(numbers[1][k].ToString()) ^ int.Parse(numbers[0][k].ToString())).ToString();
                    }
                    break;
            }
           switch (system)
            {
                case "DEC":
                    result = Convert.ToString(Convert.ToInt32(result, 2), 10);
                    break;
                case "HEX":
                    result = Convert.ToString(Convert.ToInt32(result, 2), 16);
                    break;
                case "BIN":
                    break;
                case "OCT":
                    result = Convert.ToString(Convert.ToInt32(result, 2), 8);
                    break;
            }

            return result.ToUpper();
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
                string tempResult = searchForBrackets();
                switch (system)
                {
                    case "DEC":
                        return tempResult;
                    case "HEX":
                        try
                        {
                            return Convert.ToString(Convert.ToInt32(tempResult, 10), 16);
                        }
                        catch (FormatException)
                        {
                            return tempResult;
                        }
                    case "BIN":
                        try
                        {
                            return Convert.ToString(Convert.ToInt32(tempResult, 10), 2);
                        }
                        catch (FormatException)
                        {
                            return tempResult;
                        }
                    case "OCT":
                        try
                        {
                            return Convert.ToString(Convert.ToInt32(tempResult, 10), 8);
                        }
                        catch (FormatException)
                        {
                            return tempResult;
                        }
                }

                return tempResult;
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
                        if (tempEquation[0] == '(' && tempEquation[tempEquation.Length-1] == ')' && counter == 0)
                        {
                            tempEquation = tempEquation.Remove(0, 1).Remove(tempEquation.Length - 2, 1);
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
            double[] numbers = new double[2];
            double currentresult;
         
            for (int r = 0; r < counter; r++)
            {
                for (int i = start; i < tempEquation.Length; i++)//potęga
                {
                    if (tempEquation[i] == '^')
                    {
                        symbol = tempEquation[i];
                        numbers = FindNumbers(i, symbol);

                        currentresult = (double)Math.Pow(numbers[0],numbers[1]);
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

                        currentresult = (double)Math.Pow(numbers[1], 1.0 / numbers[0]);
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
                        //oldPart = $"{numbers[0]}{symbol}{numbers[1]}";
                        switch (system)
                        {
                            case "DEC":
                                oldPart = $"{numbers[0]}{symbol}{numbers[1]}";
                                tempEquation = tempEquation.Replace($"{numbers[0]}{symbol}{numbers[1]}", currentresult.ToString());
                                break;
                            case "HEX":
                                oldPart = $"{Convert.ToString(Convert.ToInt32(numbers[0]),16)}{symbol}{Convert.ToString(Convert.ToInt32(numbers[1]), 16)}";

                                tempEquation = tempEquation.Replace($"{Convert.ToString(Convert.ToInt32(numbers[0]), 16).ToUpper()}" +
                                    $"{symbol}{Convert.ToString(Convert.ToInt32(numbers[1]), 16).ToUpper()}", currentresult.ToString());
                                break;
                            case "BIN":
                                oldPart = $"{Convert.ToString(Convert.ToInt32(numbers[0]), 2)}{symbol}{Convert.ToString(Convert.ToInt32(numbers[1]), 2)}";

                                tempEquation = tempEquation.Replace($"{Convert.ToString(Convert.ToInt32(numbers[0]), 2)}" +
                                    $"{symbol}{Convert.ToString(Convert.ToInt32(numbers[1]), 2)}", currentresult.ToString());
                                break;
                            case "OCT":
                                oldPart = $"{Convert.ToString(Convert.ToInt32(numbers[0]), 8)}{symbol}{Convert.ToString(Convert.ToInt32(numbers[1]), 8)}";

                                tempEquation = tempEquation.Replace($"{Convert.ToString(Convert.ToInt32(numbers[0]), 8)}" +
                                    $"{symbol}{Convert.ToString(Convert.ToInt32(numbers[1]), 8)}", currentresult.ToString());
                                break;
                        }

                        
                        tester++;
                        if (tester == counter && parenthesisCount > 0)
                        {
                            equation = equation.Replace($"({oldPart})", tempEquation.Remove(0,1).Remove(tempEquation.Length-2,1));
                            tester = 0;
                        }
                        else
                        {
                            equation = equation.Replace(oldPart.ToUpper(), currentresult.ToString()) ;
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

        public double[] FindNumbers(int start, char symbol)
        {
            double[] numbers = new double[2];
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

                switch (system) // na dziesietny
                {
                    case "DEC":
                        numbers[0] = Convert.ToDouble(number1String);
                        numbers[1] = Convert.ToDouble(number2String);
                        break;
                    case "HEX":
                        numbers[0] = Convert.ToDouble(Convert.ToString(Convert.ToInt32(number1String, 16), 10));
                        numbers[1] = Convert.ToDouble(Convert.ToString(Convert.ToInt32(number2String, 16), 10));
                        break;
                    case "BIN":
                        numbers[0] = Convert.ToDouble(Convert.ToString(Convert.ToInt32(number1String, 2), 10));
                        numbers[1] = Convert.ToDouble(Convert.ToString(Convert.ToInt32(number2String, 2), 10));
                        break;
                    case "OCT":
                        numbers[0] = Convert.ToDouble(Convert.ToString(Convert.ToInt32(number1String, 8), 10));
                        numbers[1] = Convert.ToDouble(Convert.ToString(Convert.ToInt32(number2String, 8), 10));
                        break;

                }
                
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
                case ',':
                    return true;
                default:
                    return false;

            }
        }
    }
}
