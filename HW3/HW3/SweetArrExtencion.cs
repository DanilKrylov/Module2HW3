using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public static class SweetArrExtencion
    {
        public static Sweet Search(this Sweet[] sweets, string name, uint calories)
        {
            foreach (Sweet sweet in sweets)
            {
                if(sweet.Name == name && sweet.Calories == calories)
                {
                    return sweet;
                }
            }

            return null;
        }

        public static Sweet Search(this Sweet[] sweets, string name)
        {
            foreach (Sweet sweet in sweets)
            {
                if (sweet.Name == name)
                {
                    return sweet;
                }
            }

            return null;
        }

        public static Sweet Search(this Sweet[] sweets, uint calories)
        {
            foreach (Sweet sweet in sweets)
            {
                if (sweet.Calories == calories)
                {
                    return sweet;
                }
            }

            return null;
        }
    }
}
