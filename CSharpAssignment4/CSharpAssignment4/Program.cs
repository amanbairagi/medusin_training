using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment4
{
    abstract class Student {
        
        public string Name;
        public int StudentId;
         public   double Grade;
        public abstract bool IsPassed(double grade);
    }
    class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            if(grade > 70.0) { return true; }
            else return false;
        }
    }
    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            if (grade > 80.0) { return true; }
            else return false;
        }
    }
    // USERDEFINED EXCEPTION
    public class TicketBookingException : Exception
    {
        public TicketBookingException(string message) : base(message) { }
    }
    class Passanger
    {
        public string name;
        public int age;
        public void ticket_booking(int noOFtickets)
        {
            if (noOFtickets > 2)
            {
                throw new TicketBookingException("cannot book more than 2 tickets");
            }
            else
            {
                Console.WriteLine("NAME"+name);
                Console.WriteLine("AGE"+age);
                Console.WriteLine("Ticket Booked Successfully");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // FIRST Q
            Undergraduate u1 = new Undergraduate();
            u1.Name = "aman";
            u1.StudentId = 12;
            u1.Grade = 75;
            Console.WriteLine($"Name: {u1.Name} StudentID: {u1.StudentId}");
            Console.WriteLine(u1.IsPassed(u1.Grade));
            Graduate g1 = new Graduate();
            g1.Name = "aman";
            g1.StudentId = 12;
            g1.Grade = 75;
            Console.WriteLine($"Name: {g1.Name} StudentID: {g1.StudentId}");
            Console.WriteLine(g1.IsPassed(g1.Grade));
            // SECOND Q
            Passanger p1 = new Passanger();
            Console.WriteLine("ENTER YOUR NAME");
            p1.name= Console.ReadLine();
            Console.WriteLine("ENTER YOUR AGE");
            p1.age = Convert.ToInt32(Console.ReadLine());
            try
            {
                p1.ticket_booking(1);
            }
            catch(TicketBookingException e)
            {
                Console.WriteLine(e);
            }

            // THIRD 
            Concession C1 = new Concession();
            C1.CalculateConcession(20);

            // FOURTH 
            dayscholar d1 = new dayscholar();
            d1.Studentid = 12;
            d1.name = "aman";
            d1.show();
            resident r1 = new resident();
            r1.Studentid = 13;
            r1.name = "nishant";
            r1.show();
            Console.ReadLine();
        }
    }
}
