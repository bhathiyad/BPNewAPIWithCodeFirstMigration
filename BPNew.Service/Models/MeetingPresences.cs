using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class MeetingPresences
    {
        public int MeetingId { get; set; }
        public int CustomUserId { get; set; }
        public byte IsPresent { get; set; }
        [StringLength(500)]
        public string Info1 { get; set; }
        [StringLength(250)]
        public string Info2 { get; set; }
        public int? Info3 { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }
        public byte IsAttending { get; set; }
        public string MeetingNote { get; set; }
        [StringLength(255)]
        public string AttendenceReason { get; set; }

        [ForeignKey("CustomUserId")]
        [InverseProperty("MeetingPresences")]
        public Users CustomUser { get; set; }
        [ForeignKey("MeetingId")]
        [InverseProperty("MeetingPresences")]
        public Meetings Meeting { get; set; }
    }
}
