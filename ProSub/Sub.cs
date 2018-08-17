using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSub
{
    public class Sub:ProOperation.Operation
    {
        public Sub(int n1, int n2) : base(n1, n2)
        {
        }

        public override string Type
        {
            get { return "-"; }
        }
        public override int GetResult()
        {
           return this.NumberOne - this.NumberTwo;
        }
    }
}
