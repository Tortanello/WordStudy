using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WordStudy.Resources.BaseData
{
    public class Class_Classification
    {
        SQLiteConnection database_Classification;

        public Class_Classification(string databasePath)
        {
            database_Classification = new SQLiteConnection(databasePath);
            database_Classification.CreateTable<Classification_db>();
        }

        public IEnumerable<Classification_db> GetItems_to_List()
        {
            return database_Classification.Table<Classification_db>().ToList();
        }

        public int input_or_Update(Classification_db item)
        {
            // Else word have to update or onater
            var data = database_Classification.Query<Classification_db>("SELECT * FROM Id WHERE Id = ?", item.Id);
            if (data.Count != 0)
            {
                return database_Classification.Update(item);
            }

            else
            {
                return database_Classification.Insert(item);
            }
        }
    }
}
