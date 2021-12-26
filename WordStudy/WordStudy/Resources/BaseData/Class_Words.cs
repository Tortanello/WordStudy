using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WordStudy.Resources.BaseData
{
    public class Class_Words
    {

        SQLiteConnection database;

        public Class_Words(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Words_db>();
        }
        // Input word
        public int input_World(Words_db item)
        {
            // Else word have to update or onater
            var data = database.Query<Words_db>("SELECT * FROM Words WHERE Word = ?", item.Word);
            if (data.Count != 0)
            {
                return database.Update(item);
            }

            else
            {
                return database.Insert(item);
            }
            /*item.Language != 
            database.Update(item);
            return item.Id;
            // Input word
            return database.Insert(item);*/
        }
        public Words_db GetItem(int id)
        {
            return database.Get<Words_db>(id);
        }
        public IEnumerable<Words_db> GetItems()
        {
            return database.Table<Words_db>().ToList();
        }

        public int Update_sattings (Words_db item)
        {
            return database.Update(item);
        }

        public int DeleteItem(int id)
        {
            return database.Delete<Words_db>(id);
        }
    }
}
