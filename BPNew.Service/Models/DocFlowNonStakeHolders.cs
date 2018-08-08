using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    [Table("DocFlowNonStakeHolders", Schema = "PreBoard")]
    public partial class DocFlowNonStakeHolders
    {
        [Key]
        public int DocFlowNonStakeHolderId { get; set; }
        public int DocFlowStakeHolderId { get; set; }
        public int NonStakeHolderId { get; set; }
        public string StakeHolderRequest { get; set; }
        public string Response { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ResponseDate { get; set; }
        public byte Status { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedByDate { get; set; }
        [Required]
        public byte[] TimeStamp { get; set; }

        [ForeignKey("CreatedBy")]
        [InverseProperty("DocFlowNonStakeHoldersCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("DocFlowStakeHolderId")]
        [InverseProperty("DocFlowNonStakeHolders")]
        public DocFlowStakeHolders DocFlowStakeHolder { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("DocFlowNonStakeHoldersModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
        [ForeignKey("NonStakeHolderId")]
        [InverseProperty("DocFlowNonStakeHoldersNonStakeHolder")]
        public Users NonStakeHolder { get; set; }
    }
}
