using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("DocumentStatuses", Schema = "PreBoard")]
    public partial class DocumentStatuses
    {
        public DocumentStatuses()
        {
            PbdocVersions = new HashSet<PbdocVersions>();
        }

        [Key]
        public byte DocumentStatusId { get; set; }
        [Required]
        [StringLength(30)]
        public string Status { get; set; }
        [StringLength(50)]
        public string PendingAction { get; set; }

        [InverseProperty("DocStatusNavigation")]
        public ICollection<PbdocVersions> PbdocVersions { get; set; }
    }
}
