using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryPatternexample
{
    public interface IMobile
    {
        string GetCPU();
        string GetRAM();
    }
}