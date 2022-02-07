using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3.Sweets
{
    public abstract class Chocolate : Sweet, IChocolate
    {
        public bool IsMelted { get; protected set; }

        public Chocolate(string name, uint calories, bool isMelted = false) : base(name, calories)
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

        void IChocolate.Melt()
        {
            throw new NotImplementedException();
        }

        void IChocolate.Freeze()
        {
            throw new NotImplementedException();
        }
    }
}
