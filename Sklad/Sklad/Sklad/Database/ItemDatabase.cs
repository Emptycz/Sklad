using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Sklad;

namespace Sklad.Database
{
    public class ItemDatabase
    {
        // SQLite connection
        private SQLiteAsyncConnection database;

        public ItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Item>().Wait();
            database.CreateTableAsync<Elements>().Wait();
            database.CreateTableAsync<Event>().Wait();
            database.CreateTableAsync<ItemElement>().Wait();
            database.CreateTableAsync<ItemEvent>().Wait();
        }

        // Query
        public Task<List<Item>> GetItemsAsync()
        {
            return database.Table<Item>().ToListAsync();
        }

        // Query using SQL query string
        public Task<List<Item>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Item>("SELECT * FROM [Item] WHERE [Done] = 0");
        }

        // Query using LINQ
        public Task<Item> GetItemAsync(int id)
        {
            return database.Table<Item>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<List<Item>> GetItemsBy()
        {
            return database.QueryAsync<Item>("SELECT * FROM [Item] ORDER BY `ID` DESC LIMIT 10");
        }

        public Task<List<Item>> GetLastItemID()
        {
            return database.QueryAsync<Item>("SELECT ID FROM Item ORDER BY ID DESC LIMIT 1");
        }
        public Task<List<Item>> GetSpecificITem(int id)
        {
            return database.QueryAsync<Item>("SELECT *FROM Item WHERE ID =" + id);
        }


        public Task<List<Event>> GetLastEventID()
        {
            return database.QueryAsync<Event>("SELECT ID FROM Event ORDER BY ID DESC LIMIT 1");
        }
        public Task<List<Elements>> GetLastElementsID()
        {
            return database.QueryAsync<Elements>("SELECT ID FROM Elements ORDER BY ID DESC LIMIT 1");
        }

        public Task<List<Elements>> GetCountElements()
        {
            return database.QueryAsync<Elements>("SELECT COUNT(ID) AS NumberOfProducts FROM Elements");             
        }

        public Task<int> SaveItemAsync(Item item)
        {
            item.TimeStamp = DateTime.Now;

            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> SaveElementsAsync(Elements item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> SaveEventAsync(Event item)
        {
            item.TimeStamp = DateTime.Now;

            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> SaveItemElementAsync(ItemElement item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> SaveItemEventAsync(ItemEvent item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        public Task<int> DeleteItemAsync(Item item)
        {
            return database.DeleteAsync(item);
        }

        public Task<int> FindByNO(int no_b, int no_id)
        {
            //return database.
            return null;
        }
    }
}