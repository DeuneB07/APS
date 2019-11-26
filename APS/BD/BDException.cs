using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.BD
{
    public class BDException : Exception
    {
        public BDException() : base()
        {
        }

        public BDException(string message):base(message)
        {
        }
    }
}
