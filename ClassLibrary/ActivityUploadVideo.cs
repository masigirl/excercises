using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ActivityUploadVideo : IActivity
    {
        public bool Excecute()
        {
            Console.WriteLine("Video uploaded...");
            return true;
        }
    }
}
