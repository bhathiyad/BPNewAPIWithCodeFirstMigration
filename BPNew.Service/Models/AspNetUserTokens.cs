﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class AspNetUserTokens
    {
        public string UserId { get; set; }
        [StringLength(128)]
        public string LoginProvider { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        public string Value { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("AspNetUserTokens")]
        public AspNetUsers User { get; set; }
    }
}
