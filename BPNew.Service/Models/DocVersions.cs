using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class DocVersions
    {
        public DocVersions()
        {
            AnnotationShares = new HashSet<AnnotationShares>();
            InversePreviousVersion = new HashSet<DocVersions>();
            Papers = new HashSet<Papers>();
        }

        [Key]
        public int VersionId { get; set; }
        public string FilePath { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public int? PreviousVersionId { get; set; }
        [StringLength(500)]
        public string Info1 { get; set; }
        [StringLength(250)]
        public string Info2 { get; set; }
        public int? Info3 { get; set; }

        [ForeignKey("CreatedBy")]
        [InverseProperty("DocVersionsCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("DocVersionsModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
        [ForeignKey("PreviousVersionId")]
        [InverseProperty("InversePreviousVersion")]
        public DocVersions PreviousVersion { get; set; }
        [InverseProperty("Version")]
        public ICollection<AnnotationShares> AnnotationShares { get; set; }
        [InverseProperty("PreviousVersion")]
        public ICollection<DocVersions> InversePreviousVersion { get; set; }
        [InverseProperty("Version")]
        public ICollection<Papers> Papers { get; set; }
    }
}
