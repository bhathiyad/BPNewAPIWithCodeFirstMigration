using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("ArchivedPBAuditLogs", Schema = "PreBoard")]
    public partial class ArchivedPbauditLogs
    {
        [Key]
        [Column("LogID")]
        public int LogId { get; set; }
        [Required]
        [StringLength(50)]
        public string Event { get; set; }
        [Required]
        [StringLength(256)]
        public string EventStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LogDateTime { get; set; }
        [Column("MeetingID")]
        public int MeetingId { get; set; }
        [Column("DocumentID")]
        public int DocumentId { get; set; }
        [Column("VersionID")]
        public int VersionId { get; set; }
        [StringLength(500)]
        public string DocumentName { get; set; }
        [Required]
        [StringLength(100)]
        public string ActionName { get; set; }
        public int? ActionBy { get; set; }
        [StringLength(500)]
        public string Parameter { get; set; }
    }
}
