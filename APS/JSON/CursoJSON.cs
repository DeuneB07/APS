using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.JSON
{
    class CursoJSON
    {
        private String name;

        public CursoJSON()
        {

        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
