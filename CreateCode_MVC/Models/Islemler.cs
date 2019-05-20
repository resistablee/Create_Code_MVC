using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CreateCode_MVC.Models
{
    public class Islemler
    {
        string HataKodu;
        public SqlConnection Baglanti()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost; Initial Catalog=Users; Intergrated security=true;");
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch (SqlException)
                {
                    HataKodu = "101";
                }
            }
            return con;

        }
    }
}