using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EspressorProject
{
    public class StartButton
    {
        public void Start()
        {
            Console.WriteLine("Press 'Enter' to start brewing.");
            Console.ReadKey();
        }
    }
}
