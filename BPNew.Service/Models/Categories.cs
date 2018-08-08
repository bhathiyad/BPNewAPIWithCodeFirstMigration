using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class Categories
    {
        public Categories()
        {
            SubCategories = new HashSet<SubCategories>();
        }

        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(500)]
        public string Name { get; set; }
        public byte Status { get; set; }
        [StringLength(500)]
        public string Info1 { get; set; }
        [StringLength(250)]
        public string Info2 { get; set; }
        public int? Info3 { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }
        public int CategoryOrder { get; set; }
        [StringLength(50)]
        public string ShortName { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Description2 { get; set; }

        [InverseProperty("Category")]
        public ICollection<SubCategories> SubCategories { get; set; }
    }
}
