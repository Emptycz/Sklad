using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Sklad.Database
{
    public class ItemEvent
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int EventID { get; set; }
        public int ItemID { get; set; }
        
        public ItemEvent()
        {
        }
      
    }
}
