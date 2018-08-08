using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class CommentAccesses
    {
        public int CommentId { get; set; }
        public int CustomUserId { get; set; }
        [Column("isViewed")]
        public bool IsViewed { get; set; }
        [StringLength(500)]
        public string Info1 { get; set; }
        [StringLength(250)]
        public string Info2 { get; set; }
        public int? Info3 { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }

        [ForeignKey("CommentId")]
        [InverseProperty("CommentAccesses")]
        public Comments Comment { get; set; }
        [ForeignKey("CustomUserId")]
        [InverseProperty("CommentAccesses")]
        public Users CustomUser { get; set; }
    }
}
