using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class AgendaDetails
    {
        [Key]
        public int PaperId { get; set; }
        [StringLength(100)]
        public string PresenterName { get; set; }
        [StringLength(100)]
        public string PresenterEmail { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public bool IsCompleted { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }

        [ForeignKey("CreatedBy")]
        [InverseProperty("AgendaDetailsCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("AgendaDetailsModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
        [ForeignKey("PaperId")]
        [InverseProperty("AgendaDetails")]
        public Papers Paper { get; set; }
    }
}
