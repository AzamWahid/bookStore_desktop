using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookStore
{
    internal class clsGeneral
    {
        public static string getConnectionString()
        {
            string ConnectionString = @"Data Source=azam-lt\sql19;Initial Catalog=bookstore;User ID=sa;Password=sasasa-1;MultipleActiveResultSets=True";

            return ConnectionString;
        }
     
    }
}
