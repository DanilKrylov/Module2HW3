using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3.Sweets.Chocolates
{
    class WhiteChocolate : Chocolate
    {
        public WhiteChocolate(string name, uint calories, bool isMelted = false) :
            base(name, calories, isMelted)
        {

        }
    }
}
