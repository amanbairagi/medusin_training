using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a C# Sharp program to accept two integers and check whether they are equal or not. 
            //Test Data :
            //Input 1st number: 5
            //Input 2nd number: 5
            //Expected Output :
            //5 and 5 are equal
            int a, b;
            Console.WriteLine("enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine($"{a} and {b} are equal");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are not equal");
            }




            //2.Write a C# Sharp program to check whether a given number is positive or negative. 
            // Test Data : 14
            // Expected Output :
            // 14 is a positive number
            Console.WriteLine("Enter the number ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            if (a1 > 0)
            {
                Console.WriteLine("{0} is positive", a1);
            }
            else
                Console.WriteLine("{0} is negative", a1);


            //3.Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,/) on them and displays the result of that operation. 

            //    Test Data
            //    Input first number: 20
            //    Input operation: -
            //    Input second number: 12
            //    Expected Output :
            //    20 - 12 = 8
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation");
            char opr = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the first number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (opr)
            {
                case '+':
                    Console.WriteLine($"{num1} {opr} {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} {opr} {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} {opr} {num2} = {num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"{num1} {opr} {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }


            //Write a  Program to assign integer to an array and then print the following
            //a.Average value of Array elements
            //b.Minimum and Maximum value in an array

            Console.WriteLine("Enter the length of array");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            int min = int.MinValue, max = int.MaxValue;
            int sum = 0;
            Console.WriteLine("enter the array elements");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
                if (arr[i] < max)
                {
                    max = arr[i];
                }
                if (arr[i] > min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("the average is " + (float)(sum / num));
            Console.WriteLine("the min value is {0} and max value is {1}", max, min);

            //2.Write a program in C# to accept ten marks and display the following
            //    a.Total
            //    b.Average
            //    c.Minimum marks
            //    d.Maximum marks
            //    e.Display marks in ascending order
            //    f.Display marks in descending order

            int[] marks = new int[10];
            int min_marks= int.MinValue, max_marks = int.MaxValue;
            int sum_marks = 0;
            Console.WriteLine("enter your marks : ");
            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum_marks += marks[i];
                if (marks[i] < max_marks)
                {
                    max_marks = marks[i];
                }
                if (marks[i] > min_marks)
                {
                    min_marks = marks[i];
                }
            }
            Console.WriteLine("total of marks is " + sum_marks);
            Console.WriteLine("the average is " + (float)(sum_marks/10));
            Console.WriteLine("the min value is {0} and max value is {1}", max_marks, min_marks);
            Array.Sort(marks);
            foreach(int mark in marks)
            {
                Console.Write(mark +" ");
            }
            Console.WriteLine();
            Array.Reverse(marks);
            foreach (int mark in marks)
            {
                Console.Write(mark +" ");
            }
            Console.ReadLine();
        }
    }
}
