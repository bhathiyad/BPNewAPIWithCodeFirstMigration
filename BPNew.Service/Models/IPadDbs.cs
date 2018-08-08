using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("iPadDBs")]
    public partial class IPadDbs
    {
        public int Id { get; set; }
        [Column(TypeName = "ntext")]
        public string Script { get; set; }
        [Required]
        [StringLength(50)]
        public string Version { get; set; }
        public int ScriptOrder { get; set; }
    }
}
