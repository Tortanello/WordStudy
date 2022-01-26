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
    }
}
