using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace WordStudy.Resources.BaseData
{
    public class Class_Lang_C
    {
        SQLiteConnection database_Lang_C;
        public Class_Lang_C(string databasePath)
        {
            database_Lang_C = new SQLiteConnection(databasePath);
            // database_Lang_C.CreateTable<Language_Choice_db>();
        }

        // Input Language

        public int input_Lang_onli(Language_Choice_db item)
        {
            // Else word have to update or onater
            return App.database_Lang_C.update_item(item);
        }
        public int update_item (Language_Choice_db item)
        {
            // database_Lang_C.CreateTable<Language_Choice_db>();
            if (item.Language_Translated_Choice == null)
            {
                var item_date = database_Lang_C.Table<Language_Choice_db>().ToList().First();
                var item_date_C = item_date.Language_Translated_Choice;
                item.Language_Translated_Choice = item_date_C;
                if (item.Language_Choice == item.Language_Translated_Choice)
                {
                    item.Language_Translated_Choice = "Language";
                }
                Language_Choice_db class_Lang_C = new Language_Choice_db();
                class_Lang_C.Id = item.Id;
                class_Lang_C.Language_Choice = item.Language_Choice;
                class_Lang_C.Language_Translated_Choice = item.Language_Translated_Choice;
                return database_Lang_C.Update(class_Lang_C);
            }
            else {
                var item_date = database_Lang_C.Table<Language_Choice_db>().ToList().First();
                var item_date_C = item_date.Language_Choice;
                item.Language_Choice = item_date_C;
                if (item.Language_Translated_Choice == item.Language_Choice)
                {
                    item.Language_Choice = "Language";
                }
                Language_Choice_db class_Lang_C = new Language_Choice_db();
                class_Lang_C.Id = item.Id;
                class_Lang_C.Language_Choice = item.Language_Choice;
                class_Lang_C.Language_Translated_Choice = item.Language_Translated_Choice;
                return database_Lang_C.Update(class_Lang_C);
            }
            
        }
        public IEnumerable<Language_Choice_db> GetItems()
        {
            return database_Lang_C.Table<Language_Choice_db>();
        }
        public IEnumerable<Language_Choice_db> GetItems_to_List()
        {
            return database_Lang_C.Table<Language_Choice_db>().ToList();
        }
        public Language_Choice_db GetItem(int id)
        {
            return database_Lang_C.Get<Language_Choice_db>(id);
        }
        public string[] Read_Lang_db()
        {
            var data = database_Lang_C.TableMappings;
            string[] List_Lang = new string[data.ToArray().Length];
            for (int j = 0; j < data.ToArray().Length; j++)
            {
                var data_ = GetItem(j);
            }
            return List_Lang;

        }
        public int input_Lang_one(Language_Choice_db item)
        {
            // Else word have to update or onater
            var data = database_Lang_C.Query<Language_Choice_db>("SELECT * FROM Language WHERE Language = ?", item.Language_Choice);
            if (data.Count != 0)
            {
                return database_Lang_C.Update(item);
            }

            else
            {
                return database_Lang_C.Insert(item, "SELECT * FROM Language_Choice WHERE ");
            }
        }
    }
}
