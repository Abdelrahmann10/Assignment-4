namespace C_4_Assignment
{
    internal class Program
    {


        #region Q 1

        // By Value
        //static void Swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        // By Reference

        //static void Swap( ref int x,ref int y )
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}
        #endregion


        #region Q 2


        //  By Value

        //static int SumArray(int[] arr)
        //{
        //    int sum = 0;

        //    if (arr is not null)
        //    {
        //        arr =new int[] { 7,8,9 } ;
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}



        // By Reference

        //static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;

        //    if (arr is not null)
        //    {
        //        arr = new int[] { 7, 8, 9 };
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}



        #endregion


        #region Q 3

        //static double GetNumber()
        //{
        //    double number;

        //    if (!double.TryParse(Console.ReadLine(), out number))
        //    {
        //        Console.WriteLine("Please enter valid number: ");
        //    }
        //    return number;
        //}

        //static double sum(double num1, double num2)
        //{
        //    return num1 + num2;
        //}

        //static double sub(double num1, double num2)
        //{
        //    return num1 - num2;
        //}

        #endregion

        static void Main(string[] args)
        {
            #region 01
            //int x1, y1, x2, y2, x3, y3;
            //Console.WriteLine("Enter the 3 Points");
            //x1 = Convert.ToInt32(Console.ReadLine());
            //y1 = Convert.ToInt32(Console.ReadLine());
            //x2 = Convert.ToInt32(Console.ReadLine());
            //y2 = Convert.ToInt32(Console.ReadLine());
            //x3 = Convert.ToInt32(Console.ReadLine());
            //y3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"({x1},{y1}) , ({x2},{y2}) , ({x3},{y3})");
            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //    Console.WriteLine("Points are on the same line");
            //else 
            //    Console.WriteLine("Points are Not on the same line");
            #endregion
            #region 02
            //Console.WriteLine("Enter time taken for the task");
            //Double Time = Convert.ToDouble(Console.ReadLine());
            //if (Time >= 2 && Time <= 3)
            //    Console.WriteLine("Highly Efficient");
            //else if (Time > 3 && Time <= 4)
            //    Console.WriteLine("instructed to increase their speed.");
            //else if (Time > 4 || Time <= 5)
            //    Console.WriteLine("provided with training to enhance their speed.");
            //else if (Time > 5)
            //    Console.WriteLine("required to leave the company.");
            #endregion
            #region 03
            //Console.WriteLine("Enter Size");
            //int Num = int.Parse(Console.ReadLine());

            //for (int i = 0; i < Num; i++)
            //{
            //    for (int j = 0; j < Num; j++)
            //    {
            //        if (i == j)
            //            Console.Write(1);
            //        else
            //            Console.Write(0);
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region 20
            //int[] my_arrary = { 1, 2, 3 };
            //int sum = my_arrary.Sum();
            //Console.WriteLine(sum);
            #endregion
            #region 21
            //int[] Arr01 = { 3, 5, 7 };
            //int[] Arr02 = { 2, 4, 6 };
            //int size = Arr01.Length + Arr02.Length;
            //int[] Arr03 = new int[size];
            //int i;
            //for (i = 0; i < Arr01.Length; i++)
            //{
            //    Arr03[i] = Arr01[i];
            //}
            //for (int j = 0; j < Arr02.Length; j++)
            //{
            //    Arr03[i] = Arr02[j];
            //    i++;
            //}
            //int Temp = 0;
            //for (int k = 0; k < Arr03.Length - 1; k++)
            //{
            //    for (int m = k + 1; m < Arr03.Length; m++)
            //    {
            //        if (Arr03[k] > Arr03[m])
            //        {
            //            Temp = Arr03[k];
            //            Arr03[k] = Arr03[m];
            //            Arr03[m] = Temp;
            //        }
            //    }
            //}
            //for (int l = 0; l < Arr03.Length; l++)
            //{
            //    Console.WriteLine(Arr03[l]);
            //}
            #endregion
            #region 22
            //int[] arr = { 1, 2, 4, 2, 1, 2, 3, 2, 1, 5 };
            //int[] Freq = new int[10];
            //foreach (int i in arr)
            //{
            //    Freq[i]++;
            //}
            //for (int i = 0; i < Freq.Length; i++)
            //{
            //    if (Freq[i] > 0)
            //        Console.WriteLine($"{i}: {Freq[i]}");
            //}
            #endregion
            #region 23
            //int[] arr = { 2, 10, 5, 8 };

            //int Max = arr[0];
            //int Min = arr[0];

            //for(int i = 0; i<arr.Length; i++)
            //{
            //    if (arr[i] > Max)
            //        Max = arr[i];
            //    if (arr[i] < Min) 
            //        Min = arr[i];
            //}
            //Console.WriteLine(Max);
            //Console.WriteLine(Min);
            #endregion
            #region 24
            //int[] arr = { 2, 10, 5, 8 };

            //int Max = arr[0];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > Max)
            //        Max = arr[i];
            //}
            //int Max02 = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > Max02&& Max > arr[i])
            //        Max02 = arr[i];
            //}
            //Console.WriteLine(Max02);
            #endregion
            #region 25
            //int[] arr = new int[] { 7 ,0 ,0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

            //int Dist = 0;
            //for(int i = 0 ; i < arr.Length; i++)
            //{
            //    for(int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //            if (Dist < j - i - 1)
            //                Dist = j - i - 1;
            //    }
            //}
            //Console.WriteLine(Dist);
            #endregion
            #region 26
            //Console.WriteLine("Enter Sentanse");
            //string Sent = Console.ReadLine();
            //string Result = "";
            //string[] Words = Sent.Split(" ");
            //for(int i = Words.Length - 1; i >= 0; i--)
            //{
            //    Result += Words[i] + " ";
            //}
            //Console.WriteLine(Result);
            #endregion
            #region 27
            //int[,] arr1 = new int[3,3];
            //int[,] arr2 = new int[3,3];

            //for(int i =0; i < 3; i++)
            //{
            //    for(int j =0; j < 3; j++)
            //    {
            //        Console.WriteLine("Enter Arry Value");
            //        arr1[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region 28
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Array.Reverse(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion
        }
    }
}
