using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CreateCode_MVC.Models
{
    public class FL_DatabaseConnection
    {
        public static readonly SqlConnection DataBaseConnect = new SqlConnection("data source=localhost; initial catalog=Users; integrated security=true");
    }
}