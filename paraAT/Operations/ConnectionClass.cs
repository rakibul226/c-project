using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.Operations
{
    public class Class1
    {
        public static SqlConnection connection = new SqlConnection("Data Source=ROG-531GT\\SQLEXPRESS;Initial Catalog=paraAT;Integrated Security=True;");
    }
}
