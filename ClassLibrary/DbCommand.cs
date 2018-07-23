using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _command;
        public DbCommand(DbConnection dbConnection, string command)
        {
            if (dbConnection == null)
                throw new InvalidOperationException("Connection cannot be null.");
            if (command == null)
                throw new InvalidOperationException("Command cannot be null.");
            _dbConnection = dbConnection;
            _command = command;
        }

        public bool Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Executing command "+_command);
            _dbConnection.Close();
            return true;
        }
        
    }
}
