using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Constructors
{
    public class EventC
    {
        private string _name;
        private string _company;
        private List<int> _contains;
        private DateTime _timeC;

        public EventC(string name, string company, List<int> contains, DateTime timeC)
        {
            _name = name;
            _company = company;
            _contains = contains;
            _timeC = timeC;

        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Company { get { return _company; } set { _company = value; } }
        public List<int> Contains { get { return _contains; } set { _contains = value; } }
        public DateTime TimeC { get { return _timeC; } set { _timeC = value; } }

    }
}
