using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Constructors
{
    class ElementC
    {
        private string _name;
        private string _description;

        public ElementC(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
    }
}
