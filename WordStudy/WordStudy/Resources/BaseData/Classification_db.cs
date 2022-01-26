using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WordStudy.Resources.BaseData
{
    [Table("Classification")]
    public class Classification_db
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        public string Language { get; set; }
        public string Language_Translated { get; set; }
        public string First_Letter { get; set; }
        public string My_List { get; set; }
        // Сохранённые настройки храняться в виде интового айди для другой бд
        public int Save_Settings { get; set; }
    }
}
