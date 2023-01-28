using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Accounts {
        int account_no,amount,balance;
        string customer_name,account_type,transaction_type;
        public Accounts(int account_no, int balance, string customer_name, string account_type)
        {
            this.account_no = account_no;
            this.balance = balance;
            this.customer_name = customer_name;
            this.account_type = account_type;
        }

        public void transaction(char type,int amount)
        {
            if(type== 'd') {
                balance += amount;
            }
            else if(type== 'w')
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Wrong Input !!");
            }
        }
        public void show()
        {
            Console.WriteLine($"Account Number : {account_no} \nCustomer Name : {customer_name} \n" +
                $"Balance : {balance} \nAccount Type : {account_type}");
        }

    }

    class Student {
        int rollno,class_name , semester,sum=0; 
        string name, branch;
        int[] marks = new int[5];
        public Student(int rollno, string name, int class_name, int semester,  string branch)
        {
            this.rollno = rollno;
            this.class_name = class_name;
            this.semester = semester;
            this.name = name;
            this.branch = branch;
        }
        public void getMarks(params int[] marks1)
        {
            int j = 0;
            foreach(int i in marks1) {
                marks[j] = i;
                sum += marks[j];
                j++;
            }
        }
        public void displayresult()
        {
            Console.WriteLine("the average of marks is " + sum / 5);
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("FAILED!! marks are less than 35");
                    goto aman1;
                }

            }
            if ((sum / 5) < 50)
            {
                Console.WriteLine("FAILED!! average is less than 50");
               
            }
            else
            {
                Console.WriteLine("PASSES!! ");
            }
            aman1:
                Console.WriteLine();
                
        }
        public void display()
        {
            Console.WriteLine($" YOUR ROLL NO IS {rollno}\n NAME : {name}\n" +
                $" CLASS : {class_name}\n SEMESTER : {semester}\n BRANCH : {branch}" +
                $"\n AVERAGE : {sum/5}");
            foreach (int item in marks)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Strings Assignment:

            //1.Write a program in C# to accept a word from the user and display the length of it.
            //2.Write a program in C# to accept a word from the user and display the reverse of it. 
            //3.Write a program in C# to accept two words from user and find out if they are same.
            Console.WriteLine("enter the string name");
            string name = Console.ReadLine();
            Console.WriteLine("the length of string is "+name.Length);
            char[] REverseString = name.ToCharArray();
            Array.Reverse(REverseString);
            string new_string = new string(REverseString);
            Console.WriteLine("the reverse of string is " + new_string);
            Console.WriteLine("enter the first string");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter the second string");
            string s2 = Console.ReadLine();
            if (s1 == s2)
                Console.WriteLine("true! they are same strings");
            else
                Console.WriteLine("false! they are not same string");

            //1.Create a class called Accounts which has data members(fields) like Account no, Customer name, Account type, Transaction type(d/w), amount, balance
            //D->Deposit
            //W->Withdrawal

            //-write a function that updates the balance depending upon the transaction type

            // -If transaction type is deposit call the credit(int amount) function and update balance
            // -If transaction type is withdraw call debit(int amt)function and update balance
            //-Pass the other information like Acount no,name,acc type through constructor
            //-call the show data method to display the values.

            Accounts acc1 = new Accounts(121212,12000,"AMAN DAS","Saving");
            acc1.transaction('d', 1200);
            acc1.show();



            //-Pass the details of student like rollno, name, class, SEM, branch in constructor
            //    -For marks write a method called GetMarks() and give marks for all 5 subjects
            //    -Write a method called displayresult, which should calculate the average marks
            //    -If marks of any one subject is less than 35 print result as failed
            //    -If marks of all subject is >35 but average is < 50 then also print result as failed
            //    -If avg > 50 then print result as passed.
            //       -Write a DisplayData() method to display all values.
            Student student1 = new Student(02,"AMAN",4,2,"CSE");
            student1.getMarks(45, 36, 36,36, 37);
            student1.displayresult();
            student1.display();
            Console.ReadLine();
        }
    }
}
