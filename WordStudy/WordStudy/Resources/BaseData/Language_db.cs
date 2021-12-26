using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WordStudy.Resources.BaseData
{
    [Table("Lang")]
    public class Language_db
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }

        public string Language { get; set; }
        // [Unique]
        // public string Language_Translated { get; set; }
    }
}
