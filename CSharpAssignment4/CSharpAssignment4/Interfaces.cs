using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment4
{
    interface IStudent {
        int Studentid { get; set; }
        string name{ get; set; }
        void show();
    }

    public class dayscholar : IStudent
    {
        public int Studentid { get; set; }
        public string name { get; set; }

        public void show()
        {
            Console.WriteLine("DAY SCHOLAR STUDENT ID : " + Studentid);
            Console.WriteLine("DAY SCHOLAR NAME : " + name);
        }
    }
    public class resident : IStudent
    {
        public int Studentid { get; set; }
        public string name { get; set; }

        public void show()
        {
            Console.WriteLine("DAY RESIDENT STUDENT ID : " + Studentid);
            Console.WriteLine("DAY RESIDENT NAME : " + name);
        }
    }
}
