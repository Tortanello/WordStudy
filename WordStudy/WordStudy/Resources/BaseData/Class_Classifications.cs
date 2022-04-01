using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordStudy.Resources.BaseData
{
    public class Class_Classifications
    {
        SQLiteConnection database_Classifications;

        public Class_Classifications(string databasePath)
        {
            database_Classifications = new SQLiteConnection(databasePath);
            database_Classifications.CreateTable<Classifications_db>();
        }
        public IEnumerable<Classifications_db> GetItems()
        {
            return database_Classifications.Table<Classifications_db>().ToList();
        }
    }
}
