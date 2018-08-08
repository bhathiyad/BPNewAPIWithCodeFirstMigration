using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("DocFlowSHComments", Schema = "PreBoard")]
    public partial class DocFlowShcomments
    {
        [Key]
        public int CommentId { get; set; }
        public string Comment { get; set; }
        public int DocFlowStakeHolderId { get; set; }
        public bool IsCommentPublish { get; set; }
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

        [ForeignKey("CreatedBy")]
        [InverseProperty("DocFlowShcommentsCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("DocFlowStakeHolderId")]
        [InverseProperty("DocFlowShcomments")]
        public DocFlowStakeHolders DocFlowStakeHolder { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("DocFlowShcommentsModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
    }
}
