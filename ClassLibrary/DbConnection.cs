using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class DbConnection
    {
        public readonly string _connectionString;
        public readonly TimeSpan _timeOut;

        public DbConnection(string connectionString, TimeSpan timeOut)
        {
            if (connectionString == null)
                throw new InvalidOperationException("Connection string cannot be null");

            _connectionString = connectionString;
            _timeOut = timeOut;
        }

        public abstract bool Open();

        public abstract bool Close();

    }
}
