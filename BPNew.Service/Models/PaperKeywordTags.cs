using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class PaperKeywordTags
    {
        public int PaperId { get; set; }
        public int KeywordId { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }

        [ForeignKey("KeywordId")]
        [InverseProperty("PaperKeywordTags")]
        public Keywords Keyword { get; set; }
        [ForeignKey("PaperId")]
        [InverseProperty("PaperKeywordTags")]
        public Papers Paper { get; set; }
    }
}
