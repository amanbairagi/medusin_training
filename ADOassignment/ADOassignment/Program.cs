using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ADOassignment
{
    internal class Program
    {

        static void connection()
        {
            SqlConnection conn = null;
            string cs = @"Data Source = LAPTOP-E9FA2ML0\SQLEXPRESS; Initial Catalog = Employee; Integrated Security = True; ";
            try
            {
               using(conn = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("Enter_Record", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    Console.WriteLine("ENTER EMPNO ");
                    string EMPNO = Console.ReadLine();
                    Console.WriteLine("ENTER EMPNAME ");
                    string EMPNAME = Console.ReadLine();
                    Console.WriteLine("ENTER EMPSAL ");
                    string EMPSAL = Console.ReadLine();
                    Console.WriteLine("ENTER EMPTYPE ");
                    string EMPTYPE = Console.ReadLine();
                    cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
                    cmd.Parameters.AddWithValue("@EMPNAME", EMPNAME);
                    cmd.Parameters.AddWithValue("@EMPSAL", EMPSAL);
                    cmd.Parameters.AddWithValue("@EMPTYPE", EMPTYPE);

                    conn.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        Console.WriteLine("execution successfull ");
                    }
                    else
                        Console.WriteLine("execution failed ");
                    SqlCommand sqlCommand = new SqlCommand("select * from Code_Employee",conn);

                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine($" {dr[0]} {dr[1]} {dr[2]} {dr[3]}");
                    }
                }
            }
            catch (SqlException e)
            {

                Console.WriteLine(e);
            }
            
        }
        static void Main()
        {
            Program.connection();
            
            Console.ReadLine();
        }
    }
}
