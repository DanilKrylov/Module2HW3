using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3.Sweets.Candies
{
    abstract class CandyWithChocolate : Candy, IChocolate
    {
        public bool IsMelted { get; protected set; }

        public CandyWithChocolate(string name, uint calories, bool isMelted = false) : base(name, calories)
        {
            IsMelted = isMelted; 
        }

        public void Melt()
        {
            IsMelted = true;
        }

        public void Freeze()
        {
            IsMelted = false;
        }
    }
}
