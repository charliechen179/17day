using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lynda.Interface
{
    class GetRamdonNumber : IRandomizable
    {
        
        public double GetRandomNum(double input)
        {
            Random r = new Random();
           return r.NextDouble() * input;
        }
    }
}
