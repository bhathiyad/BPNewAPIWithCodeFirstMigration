using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class DigitalSignatureLogs
    {
        [Key]
        public int LogId { get; set; }
        public int CustomUserId { get; set; }
        [Required]
        [StringLength(256)]
        public string UserName { get; set; }
        public int ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        public string Parameters { get; set; }
    }
}
