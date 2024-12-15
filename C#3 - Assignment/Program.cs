namespace C_3___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 01

            /*
             1- Write a program that takes a number from the user then print yes if that number 
                can be divided by 3 nd 4 otherwise print no.
             */
            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());
            //if(num % 3 == 0&& num % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region 02
            /*
             2- Write a program that allows the user to insert an integer then print negative 
                if it is negative number otherwise print positive.
             */
            //int num = 0;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter Number");
            //    flag = int.TryParse(Console.ReadLine(),out num);
            //}while (!flag);
            //if (num > 0)
            //{
            //    Console.WriteLine("Positive");
            //}
            //else
            //{
            //    Console.WriteLine("Negative");
            //}

            #endregion

            #region 03
            /*
             3- Write a program that takes 3 integers from the user then prints the max element and the min element.
             */
            //Console.WriteLine("Enter Number 01");
            //int Num01 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Number 02");
            //int Num02 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Number 03");
            //int Num03 = int.Parse(Console.ReadLine());

            //if(Num01>Num02 && Num01 > Num03)
            //{
            //    Console.WriteLine($"Num01 is Max {Num01}");
            //    if (Num02 > Num03)
            //    {
            //        Console.WriteLine($"Num03 is Min {Num03}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Num02 is Min {Num02}");

            //    }
            //}
            //if (Num02 > Num01 && Num02 > Num03)
            //{
            //    Console.WriteLine($"Num02 is Max {Num02}");
            //    if (Num01 > Num03)
            //    {
            //        Console.WriteLine($"Num03 is Min {Num03}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Num01 is Min {Num01}");

            //    }
            //}
            //if (Num03 > Num02 && Num03 > Num01)
            //{
            //    Console.WriteLine($"Num03 is Max {Num03}");
            //    if (Num01 > Num02)
            //    {
            //        Console.WriteLine($"Num02 is Min {Num02}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Num01 is Min {Num01}");

            //    }
            //}
            #endregion

            #region 04
            /*
             4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
             */
            // 2 4 6 8
            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());
            //if(num % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}
            #endregion

            #region 05
            /*
             5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u)
                then print (vowel) otherwise print (consonant).
                Vowel => حرف متحرك
                consonant => حرف ساكن
             */
            //Console.WriteLine("Enter a Character");
            //char c = char.Parse(Console.ReadLine());
            //switch(c)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("Vowel");
            //    break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;
            //}
            #endregion

            #region 06
            /*
             6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
             */
            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 07
            /*
             7- Write a program that allows the user to insert an integer then 
                print a multiplication table up to 12.
            */
            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{num} * {i} = {num *i}");
            //}

            #endregion

            #region 08
            /*
             8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
             */
            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 09
            //9- Write a program that takes two integers then prints the power.
            // 4 3 (4*4*4) => 64
            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Power");
            //int Power = int.Parse(Console.ReadLine());

            //int Result = 1;
            //for(int  i = 1; i <= Power; i++)
            //{
            //    Result *= num;
            //}
            //Console.WriteLine(Result);
            #endregion

            #region 10
            //10- Write a program to enter marks of five subjects and calculate total, average and percentage.

            ////Input: -Enter Marks of five subjects: 95 76 58 90 89
            ////Output: Total marks = 408
            ////Average Marks = 81
            ////Percentage = 81
            //double num, sum = 0, avg = 0, Precent = 0;
            //int Count = 0;
            //while (Count < 5)
            //{
            //    Console.WriteLine($"Enter Marks of five subject {Count + 1}");
            //    num = int.Parse( Console.ReadLine() );
            //    if( num >= 0 && num <=100) {
            //        sum += num;
            //        Count++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid");
            //    }
            //}
            //avg = sum / 5;
            //Precent = (sum * 100) / 500;
            //Console.WriteLine($"Total Marks {sum}");
            //Console.WriteLine($"Average Marks {avg}");
            //Console.WriteLine($"Percentage {Precent}");




            #endregion

            #region 11
            //11- Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());
            //switch(num)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Number Of Days 31");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Number Of Days 30");
            //        break;
            //    case 2:
            //        Console.WriteLine("Number Of Days 28");
            //        break;
            //    default: Console.WriteLine("Invalid");
            //        break;
            //}
            #endregion

            #region 12
            //12- Write a program to create a Simple Calculator.
            //Console.WriteLine("Enter Number01 ");
            //int Num01 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Number02 ");
            //int Num02 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Operation ");
            //char Op = char.Parse(Console.ReadLine());
            //int Result = 0;
            //switch (Op)
            //{
            //    case '+':
            //        Result = Num01 + Num02; break;
            //    case'-':
            //        Result = Num01 - Num02; break;
            //    case '*':
            //        Result = Num01 * Num02; break;
            //    case'/':
            //        if (Num02 == 0)
            //        {
            //            Console.WriteLine("Cannot Divid by Zero");
            //        }
            //        else
            //            Result = Num01 / Num02;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Operation");
            //        break;

            //}
            //        Console.WriteLine($"{Num01} {Op} {Num02} = {Result}");
            #endregion

            #region 13
            //13- Write a program to allow the user to enter a string and print the REVERSE of it.
            // sara => aras
            //Console.WriteLine("Enter String");
            //string STR = Console.ReadLine();
            //for(int i = STR.Length-1; i>=0; i--)
            //{
            //    Console.Write(STR[i]);
            //}
            #endregion

            #region 14
            /*
             14- Write a program to allow the user to enter int and print the REVERSED of it.
            */
            // 123 => 321
            Console.WriteLine("Enter Number01 ");
            int Num01 = int.Parse(Console.ReadLine());
            int Result = 0;
            while (Num01 != 0)//12
            {
                int R = Num01 % 10;//3 //2 //1
                Result = (Result * 10) + R;//3 //32 //321
                Num01 /= 10;//0
            }
            Console.WriteLine(Result);
            #endregion

            #region 15
            //15- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.WriteLine("Enter Start");
            //int Start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter End");
            //int End = int.Parse(Console.ReadLine());
            //// 1  2  3  4  5  6
            //for(int i = Start; i <= End; i++)
            //{
            //    bool Isprime = true;
            //    for(int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            Isprime = false; 
            //            break;
            //        }
            //    }
            //    if (Isprime)
            //    {
            //        Console.WriteLine($"{i} is Prime");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i} is Not Prime");

            //    }
            //}
            #endregion

            #region 16
            /*
             16-  Write a program in C# Sharp to convert a decimal number into binary without using an array.
             */

            //Console.WriteLine("Enter Number ");
            //int num = int.Parse(Console.ReadLine());

            //int Binary = 0;
            //int x = 1;
            //for(int i = num; i > 0; i = i / 2)
            //{ //           1001    +     1     *  10000 
            //    Binary = Binary + (num % 2) * x;
            //    x *= 10;
            //    num /= 2;
            //}
            //Console.WriteLine(Binary);


            #endregion

            Console.WriteLine("Enter number");
           string name = Console.ReadLine();
            Console.WriteLine(name);











































































        }
    }
}
