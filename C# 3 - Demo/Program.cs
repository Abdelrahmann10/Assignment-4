using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fractions and Discards
            //// Fraction
            //float num1 = 4.5f;
            //double num2 = 4.34;
            //decimal num3 = 999.4m;
            //// Discard --> ( _ ) Just for Readability 
            //long num4 = 1_000_000_000;
            //Console.WriteLine(num4);
            #endregion
            #region Implicit Casting VS Explicit Casting
            #region Implicit Casting
            //int num1 = 5;
            //long num2 = num1; // Implicit Casting ("Safe Casting")
            //Console.WriteLine(num2);
            #endregion
            #region Explicit Casting
            //long num1 = 99999999999999;
            //int num2 = num1.GetType() == typeof(int) ? (int)num1 : 0;
            //Console.WriteLine(num2); 
            //checked
            //{
            //    int num2 = (int)num1; // ("Unsafe Casting")
            //    unchecked
            //    {
            //        Console.WriteLine(num2);
            //    }
            //}
            #endregion
            #endregion
            #region Try Parse
            //string name = "Abdelrahman";
            //int var;
            //bool flag = int.TryParse(name, out var);
            //Console.WriteLine(flag);
            //Console.WriteLine(var);
            #endregion
            #region Operators
            #region Unary Operators
            //// Works on one Operand or one Variable
            //int num = 10;
            //// ++
            //// Prefix -> increment then print
            //Console.WriteLine(++num);
            //// Postfix -> print then increment
            //Console.WriteLine(num++);
            //////////////////////////////
            //Console.WriteLine(num);
            //// --
            //// Prefix decrement then print
            //Console.WriteLine(--num);
            //// Postfix -> print then decrement
            //Console.WriteLine(num--);
            //////////////////////////////
            //Console.WriteLine(num);
            #endregion
            #region Binary Operators
            //// words with two operands
            //int Sum, Mul, Div, Sub, Mod;
            //int num1 = 5, num2 = 3;
            //Sum = num1 + num2;
            //Mul = num1 * num2;
            //Div = num1 / num2;
            //Sub = num1 - num2;
            //Mod = num1 % num2;
            //Console.WriteLine($"sum= {Sum} Mul= {Mul} Div= {Div} Sub= {Sub} Mod= {Mod}");
            #endregion
            #region Assidnmenr Operator
            //int num = 5;
            //num += 2; // num = num+2
            //num -= 2; // num = num-2
            //num *= 2; // num = num*2
            //num /= 2; // num = num/2
            //num %= 2; // num = num%2
            #endregion
            #region Realational Operators [Comparison]
            //int num1 = 5, num2 = 6;
            //Console.WriteLine(num1 == num2);// Equal
            //Console.WriteLine(num1 != num2);// Not Equal
            //Console.WriteLine(num1 > num2);// More Than
            //Console.WriteLine(num1 < num2);// Less Than
            //Console.WriteLine(num1 >= num2);// More Than Or Equal
            //Console.WriteLine(num1 <= num2);// Less Than Or Equal
            #endregion
            #region Logical Operators
            //Console.WriteLine(!false);
            //Console.WriteLine(false && false);
            //Console.WriteLine(false || false);
            #endregion
            #region Bitwise Operator
            //Console.WriteLine(false & false);
            //Console.WriteLine(true | false);
            #endregion
            #region Ternary Operator
            //int num1 = 10, num2 = 5;
            //string Message;
            #region If
            //if (num1 > num2)
            //    Message = "num1 is more than num2";
            //else if (num1 < num2)
            //    Message = "num1 is less than num2";
            //else
            //    Message = " num1 equals num2";
            //Console.WriteLine(Message);
            #endregion
            #region Ternary Operator
            //Message = num1 > num2 ? "num1 is more than num2" : num1 < num2 ? "num1 is less than num2" : "num1 equals num2";
            //Console.WriteLine(Message);
            #endregion
            #endregion
            #region Operator Priority [Precedence] // Associativity
            //// 1- Unary Operator (Prefix)
            //// 2- Round Braces ()
            //// 3- */%
            //// 4- + -
            //int Equation = 4 + 3 * 6 / 3;
            //Console.WriteLine(Equation); //26
            //int a = 20;
            //int b = 10;
            //int c = 15;
            //int d = 5;
            //int e;
            //e = (a + b) * c / d;   //30*15/5
            //e = ((a + b) * c) / d; //(30*15)/5
            #endregion
            #region String Formating
            //int num1 = 3, num2 = 4;
            //int sum = num1 + num2;
            //// Compoite formatting (Okay)
            //string Message = string.Format("Equation : {0}+{1}={2}", num1, num2, sum);
            //Console.WriteLine(Message);
            //// "$" Manpulation operator (Recommended)
            //string message = $"Equation is : {num1}+{num2}={sum}";
            //Console.WriteLine(message);
            #endregion
            #region Controll Statements [If-Switch]
            //Console.WriteLine("Please Enter A Month Number from 1 to 3");
            //int MonthNumber = int.Parse(Console.ReadLine());
            #region If
            //if(MonthNumber == 1)
            //    Console.WriteLine("Hello January");
            //else if (MonthNumber == 2)
            //    Console.WriteLine("Hello February");
            //else if (MonthNumber == 3)
            //    Console.WriteLine("Hello March");
            //else
            //    Console.WriteLine("The Number You Entered is not valid");
            #endregion
            #region Switch
            switch (MonthNumber)
            {
                case 1:
                    Console.WriteLine("Hello Januray");
                    break;
                case 2:
                    Console.WriteLine("Hello Febraury");
                    break;
                case 3:
                    Console.WriteLine("Hello March");
                    break;
                default:
                    Console.WriteLine("The Number You Entered is invalid");
                    break;

            }
            #endregion
            #region Features in C#7-C#8-C#9 [Switch]
            #region C#7
            //object input = new object();
            //input = 100;
            //switch (input)
            //{
            //    case int Number when Number > 1 && Number < 10:
            //        Console.WriteLine($"Integer Input : {Number}");
            //        break;
            //    case double Number:
            //        Console.WriteLine($"Double Input : {Number}");
            //        break;
            //    case string Name;
            //        Console.WriteLine($"String Input : {Name}");
            //        break;
            //}
            #endregion
            #region C#8
            //string option = "1";
            //string Message = "";
            //switch (option)
            //{
            //    case "1":
            //        Message = "Using option 1";
            //        break;
            //    case "2":
            //        Message = "Using option 2";
            //        break;
            //    case "3":
            //        Message = "Using option 3";
            //        break;
            //    default:
            //        Message = "No Options";
            //        break;
            //}
            //Message = option switch
            //{
            //    "1" => "Using option 1",
            //    "2" => "Using option 2",
            //    "3" => "Using option 3",
            //    _ => "No options"
            //};
            #endregion
            #endregion
            #endregion
            #endregion


        }
    }
}
