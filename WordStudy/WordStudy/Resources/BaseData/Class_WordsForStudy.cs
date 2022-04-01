using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordStudy.Resources.BaseData
{
    public class Class_WordsForStudy
    {
        SQLiteConnection database_WordsForStudy;

        public Class_WordsForStudy(string databasePath)
        {
            database_WordsForStudy = new SQLiteConnection(databasePath);
            database_WordsForStudy.CreateTable<WordsForStudy_db>();
        }
        public IEnumerable<WordsForStudy_db> GetItems()
        {
            return database_WordsForStudy.Table<WordsForStudy_db>().ToList();
        }
        public int input_World(WordsForStudy_db[] item)
        {
            return database_WordsForStudy.Insert(item);
        }
    }
}
