using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ActivityChangeStatus : IActivity
    {
        public bool Excecute()
        {
            Console.WriteLine("Status of video changed to PROCESSING.");
            return true;
        }
    }
}
