using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("aspnet_Applications")]
    public partial class AspnetApplications
    {
        public AspnetApplications()
        {
            AspnetMembership = new HashSet<AspnetMembership>();
            AspnetPaths = new HashSet<AspnetPaths>();
            AspnetRoles1 = new HashSet<AspnetRoles1>();
            AspnetUsers1 = new HashSet<AspnetUsers1>();
        }

        [Required]
        [StringLength(256)]
        public string ApplicationName { get; set; }
        [Required]
        [StringLength(256)]
        public string LoweredApplicationName { get; set; }
        [Key]
        public Guid ApplicationId { get; set; }
        [StringLength(256)]
        public string Description { get; set; }

        [InverseProperty("Application")]
        public ICollection<AspnetMembership> AspnetMembership { get; set; }
        [InverseProperty("Application")]
        public ICollection<AspnetPaths> AspnetPaths { get; set; }
        [InverseProperty("Application")]
        public ICollection<AspnetRoles1> AspnetRoles1 { get; set; }
        [InverseProperty("Application")]
        public ICollection<AspnetUsers1> AspnetUsers1 { get; set; }
    }
}
