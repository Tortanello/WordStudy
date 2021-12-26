using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WordStudy.Resources.BaseData
{
    [Table("Settings")]
    public class Settings_db
    {
        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        public string First_Word_Is_Big_Lettar { get; set; }

        public string De_Activetion_Transcription { get; set; }

        public string De_Activetion_Language { get; set; }
    }
}
