using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class Keywords
    {
        public Keywords()
        {
            PaperKeywordTags = new HashSet<PaperKeywordTags>();
        }

        [Key]
        public int KeywordId { get; set; }
        [Required]
        [StringLength(150)]
        public string Keyword { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [StringLength(500)]
        public string Info1 { get; set; }
        [StringLength(250)]
        public string Info2 { get; set; }
        public int? Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }
        public string Info6 { get; set; }

        [InverseProperty("Keyword")]
        public ICollection<PaperKeywordTags> PaperKeywordTags { get; set; }
    }
}
