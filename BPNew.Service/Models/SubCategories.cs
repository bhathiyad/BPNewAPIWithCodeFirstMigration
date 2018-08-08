using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class SubCategories
    {
        public SubCategories()
        {
            Meetings = new HashSet<Meetings>();
            Spdocs = new HashSet<Spdocs>();
        }

        [Key]
        public int SubCategoryId { get; set; }
        [Required]
        [StringLength(500)]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public byte Status { get; set; }
        [StringLength(500)]
        public string Info1 { get; set; }
        [StringLength(250)]
        public string Info2 { get; set; }
        public int? Info3 { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }
        public int SubCategoryOrder { get; set; }
        [StringLength(50)]
        public string ShortName { get; set; }
        public bool? IsCustomSequence { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("SubCategories")]
        public Categories Category { get; set; }
        [InverseProperty("SubCategory")]
        public ICollection<Meetings> Meetings { get; set; }
        [InverseProperty("SubCategory")]
        public ICollection<Spdocs> Spdocs { get; set; }
    }
}
