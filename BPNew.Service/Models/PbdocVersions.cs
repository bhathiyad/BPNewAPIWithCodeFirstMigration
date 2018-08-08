using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("PBDocVersions", Schema = "PreBoard")]
    public partial class PbdocVersions
    {
        public PbdocVersions()
        {
            DocFlowStakeHolders = new HashSet<DocFlowStakeHolders>();
        }

        [Key]
        public int VersionId { get; set; }
        public int DocumentId { get; set; }
        public string Content { get; set; }
        public byte[] FinalizedDoc { get; set; }
        public byte DocStatus { get; set; }
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
        [InverseProperty("PbdocVersionsCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("DocStatus")]
        [InverseProperty("PbdocVersions")]
        public DocumentStatuses DocStatusNavigation { get; set; }
        [ForeignKey("DocumentId")]
        [InverseProperty("PbdocVersions")]
        public Documents Document { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("PbdocVersionsModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
        [InverseProperty("Version")]
        public ICollection<DocFlowStakeHolders> DocFlowStakeHolders { get; set; }
    }
}
