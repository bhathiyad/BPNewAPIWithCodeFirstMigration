using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class AnnotationShares
    {
        public AnnotationShares()
        {
            AnnotationAccesses = new HashSet<AnnotationAccesses>();
        }

        [Key]
        public int AnnotationShareId { get; set; }
        public int CustomUserId { get; set; }
        public int PaperId { get; set; }
        public int VersionId { get; set; }
        [Required]
        public string FilePath { get; set; }
        [Column("iPadUniqueID")]
        [StringLength(100)]
        public string IPadUniqueId { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }
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
        public bool IsBackup { get; set; }

        [ForeignKey("CreatedBy")]
        [InverseProperty("AnnotationSharesCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("CustomUserId")]
        [InverseProperty("AnnotationSharesCustomUser")]
        public Users CustomUser { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("AnnotationSharesModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
        [ForeignKey("PaperId")]
        [InverseProperty("AnnotationShares")]
        public Papers Paper { get; set; }
        [ForeignKey("VersionId")]
        [InverseProperty("AnnotationShares")]
        public DocVersions Version { get; set; }
        [InverseProperty("AnnotationShare")]
        public ICollection<AnnotationAccesses> AnnotationAccesses { get; set; }
    }
}
