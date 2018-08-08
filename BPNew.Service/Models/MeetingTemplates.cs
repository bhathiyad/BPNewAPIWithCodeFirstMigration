using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class MeetingTemplates
    {
        [Key]
        public int MeetingTemplateId { get; set; }
        [Required]
        [StringLength(256)]
        public string TemplateName { get; set; }
        public string Address { get; set; }
        [StringLength(255)]
        public string Venue { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(500)]
        public string Info1 { get; set; }
        [StringLength(250)]
        public string Info2 { get; set; }
        public int? Info3 { get; set; }
        public byte Status { get; set; }
    }
}
