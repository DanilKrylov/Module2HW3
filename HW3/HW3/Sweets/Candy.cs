using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3.Sweets
{
    abstract class Candy : Sweet
    {
        protected Candy(string name, uint calories) : base(name, calories)
        {
            
        }
    }
}
