using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class Papers
    {
        public Papers()
        {
            AnnotationShares = new HashSet<AnnotationShares>();
            PaperDecisionViews = new HashSet<PaperDecisionViews>();
            PaperKeywordTags = new HashSet<PaperKeywordTags>();
        }

        [Key]
        public int PaperId { get; set; }
        [Required]
        [StringLength(500)]
        public string Name { get; set; }
        public byte DocType { get; set; }
        public int? HeadingId { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(50)]
        public string PaperRefNo { get; set; }
        public byte? PaperStatus { get; set; }
        [StringLength(10)]
        public string PaperColor { get; set; }
        public int VersionId { get; set; }
        public int AgendaOrder { get; set; }
        [Column("IsCarryFWDfromLastMeeting")]
        public bool IsCarryFwdfromLastMeeting { get; set; }
        [Column("CarryFWDinfo")]
        [StringLength(255)]
        public string CarryFwdinfo { get; set; }
        [StringLength(500)]
        public string StatusComment { get; set; }
        public string Keyword { get; set; }
        public bool IsDeleted { get; set; }
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
        public int? AdditionalRefId { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }
        public byte? ScrollDirection { get; set; }
        public bool IsPwdProtected { get; set; }
        public byte IsRestricted { get; set; }
        public byte VersionInfo { get; set; }
        public byte IsDigitallySignable { get; set; }

        [ForeignKey("HeadingId")]
        [InverseProperty("Papers")]
        public Headings Heading { get; set; }
        [ForeignKey("VersionId")]
        [InverseProperty("Papers")]
        public DocVersions Version { get; set; }
        [InverseProperty("Paper")]
        public AgendaDetails AgendaDetails { get; set; }
        [InverseProperty("Paper")]
        public ICollection<AnnotationShares> AnnotationShares { get; set; }
        [InverseProperty("Paper")]
        public ICollection<PaperDecisionViews> PaperDecisionViews { get; set; }
        [InverseProperty("Paper")]
        public ICollection<PaperKeywordTags> PaperKeywordTags { get; set; }
    }
}
