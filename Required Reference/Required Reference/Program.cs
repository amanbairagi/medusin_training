using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAssignment4;
namespace Required_Reference
{
    
    public class Program
    {
        const int TotalFair=500;
        static string name;
        static int age;

        static void Main(string[] args)
        {
            Concession c1 = new Concession();
            Console.WriteLine("ENTER YOUR NAME ");
            Program.name = Console.ReadLine();
            Console.WriteLine("ENTER YOUR AGE ");
            Program.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"NAME {Program.name} AGE {Program.age}");
            c1.CalculateConcession(Program.age);
            Console.Read();

        }
    }
}
