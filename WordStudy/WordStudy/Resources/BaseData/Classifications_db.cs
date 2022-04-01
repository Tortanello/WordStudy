using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordStudy.Resources.BaseData
{
    public class Classifications_db
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        public int Words { get; set; }
        public string Name_Tabels { get; set; }
    }
}
