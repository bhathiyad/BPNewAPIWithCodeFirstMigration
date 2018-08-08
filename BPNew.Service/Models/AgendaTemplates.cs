using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class AgendaTemplates
    {
        [Key]
        public int AgendaTemplateId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string FilePath { get; set; }
        public int RefId { get; set; }
        public byte RefType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsAssigned { get; set; }
        [Required]
        public string Content { get; set; }

        [ForeignKey("CreatedBy")]
        [InverseProperty("AgendaTemplatesCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("AgendaTemplatesModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
    }
}
