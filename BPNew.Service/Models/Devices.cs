using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class Devices
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string DeviceId { get; set; }
        [StringLength(100)]
        public string MacAddress { get; set; }
        public byte? Status { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Info1 { get; set; }
        [StringLength(250)]
        public string Info2 { get; set; }
        public int? Info3 { get; set; }
        [Column("IsAllocatedForDS")]
        public byte IsAllocatedForDs { get; set; }
    }
}
