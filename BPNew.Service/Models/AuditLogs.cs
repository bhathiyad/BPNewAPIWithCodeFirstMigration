using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class AuditLogs
    {
        [Key]
        public int LogId { get; set; }
        public int EventNumber { get; set; }
        [Required]
        [StringLength(250)]
        public string Event { get; set; }
        [StringLength(50)]
        public string EventStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [StringLength(250)]
        public string UserName { get; set; }
        [Required]
        [StringLength(250)]
        public string ControllerName { get; set; }
        [Required]
        [StringLength(250)]
        public string ActionName { get; set; }
        public string Parameters { get; set; }
    }
}
