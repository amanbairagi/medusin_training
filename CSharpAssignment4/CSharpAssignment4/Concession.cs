using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment4
{
    public class Concession
    {
        public void  CalculateConcession(int age) {
            if (age<=5)
            {
                Console.WriteLine("Little Champs- Free Ticket ");
            }
            else if (age > 60)
            {
                Console.WriteLine("Senior Citizen " + 350);
            }
            else
                Console.WriteLine("Ticket Booked "+500);
        }
    }
}
