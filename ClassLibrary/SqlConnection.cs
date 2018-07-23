using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
        {
            Console.WriteLine("Initializing SQL connection");
        }

        public override bool Close()
        {
            Console.WriteLine("SQL Connection closed");
            return true;
        }

        public override bool Open()
        {
            Console.WriteLine("SQL Connection open");
            return true;
        }
    }
}
