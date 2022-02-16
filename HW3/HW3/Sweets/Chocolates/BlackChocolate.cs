using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3.Sweets.Chocolates
{
    class BlackChocolate : Chocolate
    {
        public BlackChocolate(string name, uint calories, bool isMelted = false) :
            base(name, calories, isMelted)
        {
        }
    }
}
