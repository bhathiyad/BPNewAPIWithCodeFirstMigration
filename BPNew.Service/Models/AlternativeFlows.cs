using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("AlternativeFlows", Schema = "PreBoard")]
    public partial class AlternativeFlows
    {
        [Key]
        public int FlowId { get; set; }
        [StringLength(50)]
        public string FlowName { get; set; }
        public int CurrentFlow { get; set; }
        public int? CurrentOrder { get; set; }
        public int NextFlow { get; set; }
        public int? NextOrder { get; set; }
        public bool CreateNewVersion { get; set; }

        [ForeignKey("CurrentFlow")]
        [InverseProperty("AlternativeFlowsCurrentFlowNavigation")]
        public StakeHolderFlows CurrentFlowNavigation { get; set; }
        [ForeignKey("NextFlow")]
        [InverseProperty("AlternativeFlowsNextFlowNavigation")]
        public StakeHolderFlows NextFlowNavigation { get; set; }
    }
}
