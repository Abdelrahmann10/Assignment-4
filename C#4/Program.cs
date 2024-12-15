using System.Text;

namespace C_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String
            // string is a class [references typy], internally is an array of characters
            //string Name;
            // Declare for reference type "String"
            // This reference id refering to the default value of reference "NULL"
            // CLR will allocate 4 bytes in stack
            // CLR will allocate 0 bytes in Heap
            // ---------------------------------
            //Name = "Abdelrahman";
            //Console.WriteLine(Name);
            //string Name01 = "Ahmed";
            //string Name02 = "Omar";
            //Console.WriteLine($"Name01: {Name01}");
            //Console.WriteLine($"The HashCode is: {Name01.GetHashCode()}");
            //Console.WriteLine($"Name02: {Name02}");
            //Console.WriteLine($"The HashCode is: {Name02.GetHashCode()}");
            //Name02 = Name01;
            //Console.WriteLine("After Name01 = Name02");
            //Console.WriteLine($"Name01: {Name01}");
            //Console.WriteLine($"The HashCode is: {Name01.GetHashCode()}");
            //Console.WriteLine($"Name02: {Name02}");
            //Console.WriteLine($"The HashCode is: {Name02.GetHashCode()}");
            //Name01 = "Abdelrahman";
            //Console.WriteLine($"Name01: {Name01}");
            //Console.WriteLine($"The HashCode is: {Name01.GetHashCode()}");
            //Console.WriteLine($"Name02: {Name02}");
            //Console.WriteLine($"The HashCode is: {Name02.GetHashCode()}");
            //string Message = "Hello";
            //Console.WriteLine($"Message: {Message}");
            //Console.WriteLine($"The HashCode is: {Message.GetHashCode()}");
            //Message += " Abdelrahman"; // Message = Message + Abdelrahman
            //Console.WriteLine($"Message: {Message}");
            //Console.WriteLine($"The HashCode is: {Message.GetHashCode()}");
            // object
            // value type (struct - enum)
            // Reference type (Class - interface)

            #endregion
            #region String Builder
            //StringBuilder Message;
            //Message = new StringBuilder("Hello");
            //Console.WriteLine($"Message: {Message}");
            //Console.WriteLine($"The HashCode is: {Message.GetHashCode()}");
            //Message.Append(" Abdelrahman");
            //Console.WriteLine($"Message: {Message}");
            //Console.WriteLine($"The HashCode is: {Message.GetHashCode()}");
            #endregion
            #region 1 D Array
            //int[] Numbers01 = new int[3] { 1, 2, 3 };
            //int[] Numbers02 = new int[] { 1, 2, 3 };
            //int[] Numbers03 = { 1, 2, 3 };
            //Console.WriteLine(Numbers01[0]);
            //Console.WriteLine(Numbers01[1]);
            //Console.WriteLine(Numbers01[2]);
            //Console.WriteLine($"The Length of the Array {Numbers01.Length}:");
            ////-------------------------
            //foreach(int number )
            #endregion
            #region 2 D Array
            //int[,] Marks = new int[3,5] /*{ { 1,2,3,4,5}, {1,2,3,4,5 }, { 1,2,3,4,5} }*/; 
            //for(int i=0;i<3;i++)
            //{
            //    Console.WriteLine($"Please Enter The Grades For Student {i+1}");
            //    for(int j =0;j<5;j++)
            //    {
            //        Console.WriteLine($"Please Enter The Grades For Subject {j + 1}");
            //        Marks[i,j] = int.Parse( Console.ReadLine() );
            //    }
            //}
            #endregion
     


        }
    }
}
