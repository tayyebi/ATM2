using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM2_Datawarehouse
{
    class SQL
    {
        public void Execute(string command)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=.\\SQLEXPRESS;initial catalog=ATM2_DW;integrated security=True;Connection Timeout=0";
            int a =con.ConnectionTimeout;
            con.Open();                                                                                                            
            SqlCommand com = new SqlCommand();                                                                                     
            com.Connection = con;                                                                                                  
            com.CommandText = command ;                                                                                            
            com.ExecuteNonQuery();                                                                                                 
        }                                                                                                                          
        public SqlDataReader Read(string command)                                                                                  
        {                                                                                                                          
            SqlConnection con = new SqlConnection();                                                                               
            con.ConnectionString = "data source=.\\SQLEXPRESS;initial catalog=ATM2_BIG;integrated security=True;Connection Timeout=0";
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = command;
            com.Connection = con;
            return com.ExecuteReader();
        }
    }
}
