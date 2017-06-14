using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Sklad.Database
{
    public class Elements
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Elements()
        {
        }
        public override string ToString()
        {
            return "Name: " + Name + " Přidáno: " + TimeStamp;
        }
    }

}
