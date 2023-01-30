using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    class doctor
    {
        int RegnNo, Feescharged;
        string name;
        public int regnNO
        {
            get { return RegnNo; }
            set { RegnNo = value; }
        }
        public  int feescharged
        {
            get { return Feescharged; }
            set { Feescharged = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class scholorship {
        int totalmarks;
        float fees;
        public float merit(int m , float f)
        {
            totalmarks = m;
            fees = f;
            if (m >= 70 && m <= 80)
            {
                return (0.2f * f);
            }
            else if (m > 80 && m <= 90)
            {
                return (0.3f * f);
            }
            else if (m > 90)
            {
                return (0.5f * f);
            }
            else
                return 0;
        }
    }

    class program {
        static string first_name;
        static string last_name;
        public program(string first_name1,string last_name2) {
            first_name = first_name1;
            last_name = last_name2;
        }
        public static void display()
        {
            Console.WriteLine($"{first_name.ToUpper()} \n{last_name.ToUpper()}");
        }
    }
    class count_letters {
        string str;
        int sum=0;
        public count_letters(string str)
        {
            this.str = str;
        }
        public void count_occ(char c)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==c)
                {
                    sum++;
                }
            }
            Console.WriteLine("total numbers of times {0} occured is {1}",c,sum);
        }
    }
    class saledetails {
        int Salesno, Productno, Price, Qty, TotalAmount;
        DateTime dateofsale;
        public saledetails(int Salesno,int Productno,int Price ,int Qty,DateTime dateofsale) {
            this.Salesno = Salesno;
            this.Productno = Productno;
            this.Price = Price;
            this.Qty = Qty;
            this.dateofsale = dateofsale;
        }
        public void sales(int Qty,int Price)
        {
            this.TotalAmount= Qty*Price;

        }
        public void show()
        {
            Console.WriteLine($"Salesno = {Salesno} \n Productno = {Productno} \n Price = {Price} \n " +
                $"Quantity = {Qty} \n DateOfSale = {dateofsale} \n TotalAmount = {TotalAmount}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create a Class Program which would be used to accepts two  Strings - 
            //FirstName and LastName and call the static method Display()
            //that displays the first name in one line and the LastName in the second line after converting the same to upper case.

            //2.Create a Program to count the no. of occurrences of a letter in a given string(for example in a string called “OOPS PROGRAMMING”, O appears 3 times)
            //            Hint: Accept a string and also the letter to be counted
            program name = new program("aman", "bairagi");
            program.display();

            count_letters c1 = new count_letters("hello world");
            c1.count_occ('l');


            //3.Create a class called Saledetails which has data members like Salesno,  Productno,  Price, dateofsale, Qty, TotalAmount
            //Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as Qty* Price
            //Pass the other information like SalesNo, Productno, Price, Qty and Dateof sale through constructor
            //call the show data method to display the values.
            //Hint : Use This pointer
            saledetails s1 = new saledetails(01,2009,500,10,DateTime.Now);
            s1.sales(2, 500);
            s1.show();

            //4.Create a class called Scholarship which has int Totalmarks and float fees as fields and
            //a function Public float Merit(int m, float f) that takes Totalmarks and fees as an input.

            scholorship student1 = new scholorship();
            Console.WriteLine(student1.merit(85, 50000));

            //5.Create a Class called Doctor with RegnNo, Name, Feescharged as Private members.
            //Allow values to be set and also to display the same. (Hint: Use Properties)
            doctor doc1 = new doctor();
            doc1.regnNO = 122;
            doc1.feescharged = 1000;
            doc1.Name = "aman";
            Console.WriteLine(doc1.regnNO);
            Console.WriteLine(doc1.feescharged);
            Console.WriteLine(doc1.Name);
            Console.ReadLine(); 
        }
    }
}
