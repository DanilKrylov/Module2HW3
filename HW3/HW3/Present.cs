using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Present
    {
        public Sweet[] Sweets { get; private set; }

        public uint GetCountOfCalories()
        {
            uint calories = 0;
            foreach (Sweet sweet in Sweets)
            {
                calories += sweet.Calories;
            }
            return calories;
        }

        public Present(Sweet[] sweets)
        {
            Sweets = sweets;
        }
    }
}
