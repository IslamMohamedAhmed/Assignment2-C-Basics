using System.ComponentModel;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-	Write a program that allows the user to enter a number then print it.
            #region assignment2.1
            //Console.WriteLine("Enter your Number!");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"your number is {x}!");
            #endregion

            //2-	Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

            #region assignment2.2
            //string str = "islam";
            //int x = Convert.ToInt32(str);
            // it will print an unhandled exception error as convert issues
            #endregion

            //3-	Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen


            #region assignment2.3
            //float x = 2.7f, y = 2.89f;
            //Console.WriteLine(x+y);
            // it will result into another floating number
            #endregion

            //4-	Write C# program that Extract a substring from a given string.

            #region assignment2.4
            //string str = "qodeara";
            //Console.WriteLine(str.Substring(0,5)); //qodea
            #endregion

            //5-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            #region assignment2.5
            //int x = 7, y = 14;
            //y = x;
            //x++;
            //Console.WriteLine($"y = {y} & x = {x}"); //7 8
            // variable y value will be 7 but it won't change when we increase variable x by 1  
            #endregion

            //6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen


            #region assignment2.6
            //Test t1 = new Test();
            //t1.name = "Test";
            //t1.age = 5000;
            //Test t2 = new Test();
            //t2 = t1;
            //Console.WriteLine(t2.age); // 5000

            // it will allocate bytes for reference t1 and assign it to null
            // it will create all the variables inside t1 and assign t1 address to them
            // it will create all the variables inside t1 and assign t1 address to them
            // when creating reference t2
            // a new object with the same type of test class
            //after assigning reference t2 to t1 then t2 will have the same address of t1 so when a value in t1 changes it has its effect too in t2
            // the new object created according to t2 will be considered an unreachable object as bno reference to it

            #endregion

            //7 - Write C# program that take two string variables and print them as one variable 
            #region assignment2.7
            //string str1 = "islam ",str2 = "mohamed";
            //str1 = string.Concat(str1,str2);
            //Console.WriteLine(str1);

            #endregion
            int num = 1, z = 5;

            //8 - Which of the following statements is correct about the C#.NET code snippet given below?
            //b)	A value 1 will be assigned to d.


            //9 - Which of the following is the correct output for the C# code given below?
            //d)	6 1

            //10 - What will be the output of the C# code given below?
            //d)	7 7

        }
    }
}
