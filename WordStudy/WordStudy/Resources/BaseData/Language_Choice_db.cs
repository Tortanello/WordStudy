using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WordStudy.Resources.BaseData
{
    [Table("Lang_C")]
    public class Language_Choice_db
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }
        [Unique]
        public string Language_Choice { get; set; }
        [Unique]
        public string Language_Translated_Choice { get; set; }

    }
}
