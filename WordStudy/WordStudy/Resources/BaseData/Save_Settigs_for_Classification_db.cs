using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WordStudy.Resources.BaseData
{
    [Table("SSf_Classification_db")]
    public class Save_Settigs_for_Classification_db
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        public string Language { get; set; }
        public string Language_Translated { get; set; }
        public string First_Letter { get; set; }
        public string My_List { get; set; }
    }
}
