using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public abstract class Sweet
    {
        public string Name { get; }

        public uint Calories { get; }

        protected Sweet(string name, uint calories)
        {
            Name = name;

            Calories = calories;
        }
    }
}
