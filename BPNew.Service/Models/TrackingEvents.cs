using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("TrackingEvents", Schema = "PreBoard")]
    public partial class TrackingEvents
    {
        public int Id { get; set; }
        public Guid WorkflowInstanceId { get; set; }
        public long? RecordNumber { get; set; }
        public byte? TraceLevelId { get; set; }
        [StringLength(2048)]
        public string ActivityName { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        public string TrackingData { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EventTime { get; set; }
    }
}
