using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ActivityNotify : IActivity
    {
        public bool Excecute()
        {
            Console.WriteLine("User has been notified.");
            return true;
        }
    }
}
