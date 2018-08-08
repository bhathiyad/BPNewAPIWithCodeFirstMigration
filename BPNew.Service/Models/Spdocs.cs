using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("SPDocs")]
    public partial class Spdocs
    {
        [Key]
        [Column("SPDocId")]
        public int SpdocId { get; set; }
        public int SubCategoryId { get; set; }
        [Required]
        [StringLength(1000)]
        public string DocName { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("MovedToBP")]
        [StringLength(500)]
        public string MovedToBp { get; set; }
        public byte? VersionInfo { get; set; }
        public Guid? FileStructureId { get; set; }

        [ForeignKey("CreatedBy")]
        [InverseProperty("SpdocsCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("SpdocsModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
        [ForeignKey("SubCategoryId")]
        [InverseProperty("Spdocs")]
        public SubCategories SubCategory { get; set; }
    }
}
