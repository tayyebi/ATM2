using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{



    class Program
    {
        static void Main(string[] args)
        {

            Random r;
            Random r2;
            r = new Random();
            r2 = new Random();
            using (var db = new MainModel())
            {
                Console.WriteLine("Procedure Started. Hopin' success En Sha ALLAH\nbesmeLLAHerahmanerahim");

                var tars = db.Transactions.Select(x => x.Id).ToList();
                int[] casste = { 500, 1000, 2000, 5000, 10000, 50000, 100000 };


                //for (int i = 0; i < 50000000; i++)              
                //foreach (int i in Enumerable.Range(110000 + 1, 50000000))

                List<StringBuilder> sbs = new List<StringBuilder>();


                int theCount = 4000;


                Parallel.For(0, theCount, j =>
                //Parallel.For(0, 50000, j =>
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(" INSERT [Package] ([Count], [Value], [TransactionId]) VALUES ");

                    Parallel.For(1, 1000, i =>
                    {
                        int flip = r.Next(10, 2000 + 1);
                        int index = r.Next(0, 18514493);
                        int val = r.Next(0, 5);

                        int tranId = tars[index];
                        int valll = casste[val];


                        lock (sb)
                        {

                            sb.Append($" ({flip}, {valll}, {tranId}) ");
                            if (i != 1000)
                                sb.Append(" ,");
                        }
                    });

                    sb.Length--;
                    sb.Append(";");

                    sbs.Add(sb);
                });




                Parallel.For(0, theCount, q =>
                {
                    using (SqlConnection con = new SqlConnection())
                    {
                        if (sbs.Count() > q )
                        {
                            con.ConnectionString = @"data source=.\SQLEXPRESS;initial catalog=ATM2;integrated security=True;";
                            con.Open();
                            SqlCommand com = new SqlCommand();
                            com.Connection = con;

                            com.CommandText = sbs[q] == null ? "SELECT 1" : sbs[q].ToString();
                            com.ExecuteNonQuery();

                            con.Close();
                        }
                        Console.Write(q + ", ");
                    }
                }
                );


                db.SaveChanges();
            }
        }
    }
}
