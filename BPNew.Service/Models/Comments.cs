using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class Comments
    {
        public Comments()
        {
            CommentAccesses = new HashSet<CommentAccesses>();
        }

        [Key]
        public int CommentId { get; set; }
        public int RefId { get; set; }
        public byte RefType { get; set; }
        [Required]
        public string Comment { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(500)]
        public string Info1 { get; set; }
        [StringLength(250)]
        public string Info2 { get; set; }
        public int? Info3 { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }
        [Column("iPadUniqueID")]
        [StringLength(100)]
        public string IPadUniqueId { get; set; }

        [ForeignKey("CreatedBy")]
        [InverseProperty("CommentsCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("CommentsModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
        [InverseProperty("Comment")]
        public ICollection<CommentAccesses> CommentAccesses { get; set; }
    }
}
