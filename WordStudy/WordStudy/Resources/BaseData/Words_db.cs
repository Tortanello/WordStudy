using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WordStudy.Resources.BaseData
{
    [Table("Words")]
    public class Words_db
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        public string Language { get; set; }
        public string Word { get; set; }
        public string Translated { get; set; }
        public string Transcription { get; set; }
        public string Language_Translated { get; set; }
    }
}
