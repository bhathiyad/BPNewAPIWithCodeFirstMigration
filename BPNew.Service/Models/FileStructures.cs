using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class FileStructures
    {
        [Key]
        [Column("DocumentID")]
        public Guid DocumentId { get; set; }
        [Column("RefID")]
        public int RefId { get; set; }
        public int RefType { get; set; }
        public byte[] Content { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("DSRefId")]
        [StringLength(500)]
        public string DsrefId { get; set; }
    }
}
