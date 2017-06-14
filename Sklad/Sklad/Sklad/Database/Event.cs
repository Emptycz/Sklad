using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Sklad.Database
{
    public class Event
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public List<string> Contains { get; set; }
        public DateTime TimeC { get; set; }
        public Event()
        {
        }
        public override string ToString()
        {
            return "Name: " + Name + " Přidáno: " + TimeC;
        }
    }

}