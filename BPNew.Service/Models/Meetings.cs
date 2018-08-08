using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class Meetings
    {
        public Meetings()
        {
            Documents = new HashSet<Documents>();
            Headings = new HashSet<Headings>();
            MeetingPresences = new HashSet<MeetingPresences>();
        }

        [Key]
        public int MeetingId { get; set; }
        public int SubCategoryId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        [StringLength(256)]
        public string Subject { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Description2 { get; set; }
        public byte Status { get; set; }
        public bool IsTentative { get; set; }
        public byte MeetingType { get; set; }
        public string Address { get; set; }
        [StringLength(255)]
        public string Venue { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int? OrganizerId { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(500)]
        public string Info1 { get; set; }
        [StringLength(250)]
        public string Info2 { get; set; }
        public int? Info3 { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }
        public string MeetingNote { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocumentsDeadline { get; set; }

        [ForeignKey("CreatedBy")]
        [InverseProperty("MeetingsCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("MeetingsModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
        [ForeignKey("OrganizerId")]
        [InverseProperty("MeetingsOrganizer")]
        public Users Organizer { get; set; }
        [ForeignKey("SubCategoryId")]
        [InverseProperty("Meetings")]
        public SubCategories SubCategory { get; set; }
        [InverseProperty("Meeting")]
        public ICollection<Documents> Documents { get; set; }
        [InverseProperty("Meeting")]
        public ICollection<Headings> Headings { get; set; }
        [InverseProperty("Meeting")]
        public ICollection<MeetingPresences> MeetingPresences { get; set; }
    }
}
