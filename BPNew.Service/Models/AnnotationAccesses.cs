using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class AnnotationAccesses
    {
        public int AnnotationShareId { get; set; }
        public int CustomUserId { get; set; }
        public bool IsDownloaded { get; set; }

        [ForeignKey("AnnotationShareId")]
        [InverseProperty("AnnotationAccesses")]
        public AnnotationShares AnnotationShare { get; set; }
        [ForeignKey("CustomUserId")]
        [InverseProperty("AnnotationAccesses")]
        public Users CustomUser { get; set; }
    }
}
