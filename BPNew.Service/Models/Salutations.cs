using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class Salutations
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Salutation { get; set; }
        [Required]
        public bool? IsOn { get; set; }
    }
}
