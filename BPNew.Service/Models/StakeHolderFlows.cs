using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("StakeHolderFlows", Schema = "PreBoard")]
    public partial class StakeHolderFlows
    {
        public StakeHolderFlows()
        {
            AlternativeFlowsCurrentFlowNavigation = new HashSet<AlternativeFlows>();
            AlternativeFlowsNextFlowNavigation = new HashSet<AlternativeFlows>();
            DocFlowStakeHolders = new HashSet<DocFlowStakeHolders>();
            InversePrevFlow = new HashSet<StakeHolderFlows>();
        }

        [Key]
        [Column("SHFlowId")]
        public int ShflowId { get; set; }
        [Column("SHFlowName")]
        [StringLength(100)]
        public string ShflowName { get; set; }
        [StringLength(256)]
        public string Description { get; set; }
        public int? PrevFlowId { get; set; }
        public int? RefFlowId { get; set; }
        [StringLength(200)]
        public string Permissions { get; set; }
        public bool ShowInView { get; set; }
        public bool AllowMultipleUsers { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(500)]
        public string Info1 { get; set; }
        [StringLength(250)]
        public string Info2 { get; set; }
        public int? Info3 { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }

        [ForeignKey("CreatedBy")]
        [InverseProperty("StakeHolderFlowsCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("StakeHolderFlowsModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
        [ForeignKey("PrevFlowId")]
        [InverseProperty("InversePrevFlow")]
        public StakeHolderFlows PrevFlow { get; set; }
        [ForeignKey("ShflowId")]
        [InverseProperty("InverseShflow")]
        public StakeHolderFlows Shflow { get; set; }
        [InverseProperty("Shflow")]
        public StakeHolderFlows InverseShflow { get; set; }
        [InverseProperty("CurrentFlowNavigation")]
        public ICollection<AlternativeFlows> AlternativeFlowsCurrentFlowNavigation { get; set; }
        [InverseProperty("NextFlowNavigation")]
        public ICollection<AlternativeFlows> AlternativeFlowsNextFlowNavigation { get; set; }
        [InverseProperty("Shflow")]
        public ICollection<DocFlowStakeHolders> DocFlowStakeHolders { get; set; }
        [InverseProperty("PrevFlow")]
        public ICollection<StakeHolderFlows> InversePrevFlow { get; set; }
    }
}
