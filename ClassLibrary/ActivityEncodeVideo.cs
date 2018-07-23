using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ActivityEncodeVideo : IActivity
    {
        public bool Excecute()
        {
            Console.WriteLine("Video ready for encoding...");
            return true;
        }
    }
}
