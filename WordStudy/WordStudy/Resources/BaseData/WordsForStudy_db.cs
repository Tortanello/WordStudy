using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordStudy.Resources.BaseData
{
    [Table("WordsForStudy")]
    public class WordsForStudy_db
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        //public string[] data { get; set; } = new string[int.MaxValue];
        public string Language { get; set; }
        public string Word { get; set; }
        public string Translated { get; set; }
        public string Transcription { get; set; }
        public string Language_Translated { get; set; }
        public string Name { get; set; }
    }
}
