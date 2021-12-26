using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WordStudy.Resources.BaseData
{
    public class Class_Settings
    {
        SQLiteConnection database_Settings;
        public Class_Settings(string databasePath)
        {
            database_Settings = new SQLiteConnection(databasePath);
            database_Settings.CreateTable<Settings_db>();
        }
        public int Update_Settings(Settings_db item)
        {
            // Else word have to update or onater
            // var data = database_Settings.Get<Settings_db>(1);
            return database_Settings.Update(item);
        }
        public Settings_db GetItem(int id)
        {
            return database_Settings.Get<Settings_db>(id);
        }
    }
}
