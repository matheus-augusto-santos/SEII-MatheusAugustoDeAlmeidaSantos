using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryPatternexample
{
    public class ApplePhone : IMobile
    {
        public string GetCPU()
        {
            return "Apple CPU";
        }

        public string GetRAM()
        {
            return "8GB";
        }
    }
}