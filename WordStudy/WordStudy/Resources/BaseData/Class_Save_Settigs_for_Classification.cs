using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WordStudy.Resources.BaseData
{
    public class Class_Save_Settigs_for_Classification
    {
        SQLiteConnection database_SSf_Classification;
        public Class_Save_Settigs_for_Classification(string databasePath)
        {
            database_SSf_Classification = new SQLiteConnection(databasePath);
            database_SSf_Classification.CreateTable<Save_Settigs_for_Classification_db>();
        }
    }
}
