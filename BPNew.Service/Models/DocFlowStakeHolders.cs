using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("DocFlowStakeHolders", Schema = "PreBoard")]
    public partial class DocFlowStakeHolders
    {
        public DocFlowStakeHolders()
        {
            DocFlowNonStakeHolders = new HashSet<DocFlowNonStakeHolders>();
            DocFlowShcomments = new HashSet<DocFlowShcomments>();
        }

        [Key]
        public int DocFlowStakeHolderId { get; set; }
        public int StakeHolderId { get; set; }
        public int VersionId { get; set; }
        [Column("SHFlowId")]
        public int ShflowId { get; set; }
        [Column("SHFlowPath")]
        public int ShflowPath { get; set; }
        public byte UserDocStatus { get; set; }
        public bool IsRead { get; set; }
        [Column("SHOrder")]
        public int Shorder { get; set; }
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
        [InverseProperty("DocFlowStakeHoldersCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("DocFlowStakeHoldersModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
        [ForeignKey("ShflowId")]
        [InverseProperty("DocFlowStakeHolders")]
        public StakeHolderFlows Shflow { get; set; }
        [ForeignKey("StakeHolderId")]
        [InverseProperty("DocFlowStakeHoldersStakeHolder")]
        public Users StakeHolder { get; set; }
        [ForeignKey("VersionId")]
        [InverseProperty("DocFlowStakeHolders")]
        public PbdocVersions Version { get; set; }
        [InverseProperty("DocFlowStakeHolder")]
        public ICollection<DocFlowNonStakeHolders> DocFlowNonStakeHolders { get; set; }
        [InverseProperty("DocFlowStakeHolder")]
        public ICollection<DocFlowShcomments> DocFlowShcomments { get; set; }
    }
}
