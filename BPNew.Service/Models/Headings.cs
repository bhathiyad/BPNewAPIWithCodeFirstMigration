using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class Headings
    {
        public Headings()
        {
            HeadingAccesses = new HashSet<HeadingAccesses>();
            InversePreviousHeading = new HashSet<Headings>();
            Papers = new HashSet<Papers>();
        }

        [Key]
        public int HeadingId { get; set; }
        public int? PreviousHeadingId { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        public int MeetingId { get; set; }
        [Required]
        public byte[] Timestamp { get; set; }
        public int AgendaOrder { get; set; }
        [StringLength(500)]
        public string Info1 { get; set; }
        [StringLength(250)]
        public string Info2 { get; set; }
        public int? Info3 { get; set; }
        public byte IsRestricted { get; set; }

        [ForeignKey("MeetingId")]
        [InverseProperty("Headings")]
        public Meetings Meeting { get; set; }
        [ForeignKey("PreviousHeadingId")]
        [InverseProperty("InversePreviousHeading")]
        public Headings PreviousHeading { get; set; }
        [InverseProperty("Heading")]
        public ICollection<HeadingAccesses> HeadingAccesses { get; set; }
        [InverseProperty("PreviousHeading")]
        public ICollection<Headings> InversePreviousHeading { get; set; }
        [InverseProperty("Heading")]
        public ICollection<Papers> Papers { get; set; }
    }
}
