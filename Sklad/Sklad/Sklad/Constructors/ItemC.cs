using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Constructors
{
    class ItemC
    {
        private int _id;
        private bool _edit;
        private string _name;
        private string _brench;
        private List<int> _contains;
        private bool _available;
        private string _description;

        public ItemC(string name, string brench, List<int> contains, bool available, string description)
        {
            _name = name;
            _brench = brench;
            _contains = contains;
            _available = available;
            _description = description;
        }

        public ItemC(int Id, string name, string brench, List<int> contains, bool available, string description, bool edit)
        {
            _id = Id;
            _name = name;
            _brench = brench;
            _contains = contains;
            _available = available;
            _description = description;
            _edit = edit;
        }

        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Brench { get { return _brench; } set { _brench = value; } }
        public List<int> Contains { get { return _contains; } set { _contains = value; } }
        public bool Available { get { return _available; } set { _available = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public bool Edit { get { return _edit; } set { _edit = value; } }
    } 
}
