using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class HeadingAccesses
    {
        public int HeadingId { get; set; }
        public int CustomUserId { get; set; }
        public byte IsAllowed { get; set; }

        [ForeignKey("CustomUserId")]
        [InverseProperty("HeadingAccesses")]
        public Users CustomUser { get; set; }
        [ForeignKey("HeadingId")]
        [InverseProperty("HeadingAccesses")]
        public Headings Heading { get; set; }
    }
}
