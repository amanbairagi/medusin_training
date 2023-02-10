using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ASSIGNMENT2
{
    struct books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;
        public void GetValues(string title,string author,string subject,int book_id)
        {
            this.title = title; 
            this.author = author;
            this.subject = subject;
            this.book_id = book_id;
        }
        public void ShowValues()
        {
            Console.WriteLine($" TITLE : {title}, AUTHOR : {author}, SUBJECT : {subject}, BOOK_ID : {book_id}");
        }
    };

    public class products
    {
        public int productID;
        public string productname;
        public int price;
    } 
    internal class TestStructures
    {
        static void Main(string[] args)
        {
            //struct one
            books b1 =new books();
            b1.GetValues("NCERT PHYSICS", "HC VERMA", "PHYSICS", 12);
            b1.ShowValues();
            //products sorting
            List<products> p1 = new List<products>() { 
                new products(){productID=1,productname = "ball",price=900},
                new products(){productID=2,productname = "bat",price=4000},
                new products(){productID=3,productname = "stumps",price=1000},
                new products(){productID=4,productname = "bails",price=300},
                new products(){productID=5,productname = "helmet",price=1500},
                new products(){productID=6,productname = "gloves",price=1100},
                new products(){productID=7,productname = "gaurd",price=350},
                new products(){productID=8,productname = "shoes",price=2000},
                new products(){productID=9,productname = "sunglasses",price=1200},
                new products(){productID=10,productname = "grip",price=120},
            };

            var sortedList = p1.OrderBy(p => p.price).ToList(); 
            foreach (var item in sortedList)
            {
                Console.WriteLine("PRODUCT ID "+item.productID +" PRODUCT NAME "+ item.productname +" PRICE " + item.price);
            }

            // stationary item
            List<string> l1 = new List<string>();
            l1.Add("rubber");
            l1.Add("pencil");
            l1.Add("sharpner");
            l1.Add("pen");
            l1.Add("scale");
            l1.Add("marker");
            foreach (var item in l1)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
