using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class NumberFormatException : Exception
    {

        public NumberFormatException(string str) : base(str)
        {
        }

    }
}
