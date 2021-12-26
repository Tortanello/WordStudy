using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WordStudy.Resources.BaseData
{

    public class Class_Lang
    {
        SQLiteConnection database_Lang;

        public Class_Lang(string databasePath)
        {
            database_Lang = new SQLiteConnection(databasePath);
            // database_Lang.CreateTable<Language_db>();
        }

        // Input Language
        public int input_Lang(Language_db item)
        {
            // Else word have to update or onater
            var data = database_Lang.Query<Language_db>("SELECT * FROM Lang WHERE Language = ?", item.Language);
            if (data.Count != 0)
            {
                return database_Lang.Update(item);
            }

            else
            {
                return database_Lang.Insert(item);
            }
        }

        /*public IEnumerable<Language_db> GetItems()
        {
            return database_Lang.Table<Language_db>().ToList();
        }*/
        public IEnumerable<Language_db> GetItems()
        {
            return database_Lang.Table<Language_db>().ToList();
        }
        public Language_db GetItem(int id)
        {
            return database_Lang.Get<Language_db>(id);
        }
        public string[] Read_Lang_db()
        {
            var data = database_Lang.TableMappings;
            string[]List_Lang = new string[data.ToArray().Length];
            for (int j = 0; j < data.ToArray().Length; j++)
            {
                var data_ = GetItem(j);
            }
            
            return List_Lang;
            
        }
    }
}
