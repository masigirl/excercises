using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeOut) : base(connectionString, timeOut)
        {
            Console.WriteLine("Oracle connection initialized");
        }

        public override bool Close()
        {
            Console.WriteLine("Oracle connection closed");
            return true;
        }

        public override bool Open()
        {
            Console.WriteLine("Oracle connection open");
            return true;
        }
    }
}
