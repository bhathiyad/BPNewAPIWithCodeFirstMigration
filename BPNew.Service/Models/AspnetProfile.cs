using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("aspnet_Profile")]
    public partial class AspnetProfile
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string PropertyNames { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string PropertyValuesString { get; set; }
        [Required]
        [Column(TypeName = "image")]
        public byte[] PropertyValuesBinary { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUpdatedDate { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("AspnetProfile")]
        public AspnetUsers1 User { get; set; }
    }
}
