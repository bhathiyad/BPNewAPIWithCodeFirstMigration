using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class ProductSettings
    {
        [Key]
        public int SettingId { get; set; }
        [Required]
        [StringLength(50)]
        public string Key { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(2048)]
        public string Value { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(300)]
        public string Info1 { get; set; }
        [StringLength(300)]
        public string Info2 { get; set; }
        [Required]
        public byte[] Timestamp { get; set; }
        [Column("IsIPAD")]
        public bool? IsIpad { get; set; }

        [ForeignKey("ModifiedBy")]
        [InverseProperty("ProductSettings")]
        public Users ModifiedByNavigation { get; set; }
    }
}
