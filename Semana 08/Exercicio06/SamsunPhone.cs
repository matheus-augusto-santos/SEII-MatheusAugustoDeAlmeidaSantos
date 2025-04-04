using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryPatternexample
{
    public class SamsungPhone : IMobile
    {
        public string GetCPU()
        {
            return "Samsung CPU";
        }

        public string GetRAM()
        {
            return "16 GB";
        }
    }
}