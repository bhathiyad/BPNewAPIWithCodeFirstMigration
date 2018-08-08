using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BPNew.Service.Models
{
    public partial class Users
    {
        public Users()
        {
            Accesses = new HashSet<Accesses>();
            AgendaDetailsCreatedByNavigation = new HashSet<AgendaDetails>();
            AgendaDetailsModifiedByNavigation = new HashSet<AgendaDetails>();
            AgendaTemplatesCreatedByNavigation = new HashSet<AgendaTemplates>();
            AgendaTemplatesModifiedByNavigation = new HashSet<AgendaTemplates>();
            AnnotationAccesses = new HashSet<AnnotationAccesses>();
            AnnotationSharesCreatedByNavigation = new HashSet<AnnotationShares>();
            AnnotationSharesCustomUser = new HashSet<AnnotationShares>();
            AnnotationSharesModifiedByNavigation = new HashSet<AnnotationShares>();
            CommentAccesses = new HashSet<CommentAccesses>();
            CommentsCreatedByNavigation = new HashSet<Comments>();
            CommentsModifiedByNavigation = new HashSet<Comments>();
            DocFlowNonStakeHoldersCreatedByNavigation = new HashSet<DocFlowNonStakeHolders>();
            DocFlowNonStakeHoldersModifiedByNavigation = new HashSet<DocFlowNonStakeHolders>();
            DocFlowNonStakeHoldersNonStakeHolder = new HashSet<DocFlowNonStakeHolders>();
            DocFlowShcommentsCreatedByNavigation = new HashSet<DocFlowShcomments>();
            DocFlowShcommentsModifiedByNavigation = new HashSet<DocFlowShcomments>();
            DocFlowStakeHoldersCreatedByNavigation = new HashSet<DocFlowStakeHolders>();
            DocFlowStakeHoldersModifiedByNavigation = new HashSet<DocFlowStakeHolders>();
            DocFlowStakeHoldersStakeHolder = new HashSet<DocFlowStakeHolders>();
            DocVersionsCreatedByNavigation = new HashSet<DocVersions>();
            DocVersionsModifiedByNavigation = new HashSet<DocVersions>();
            DocumentsCreatedByNavigation = new HashSet<Documents>();
            DocumentsModifiedByNavigation = new HashSet<Documents>();
            HeadingAccesses = new HashSet<HeadingAccesses>();
            InverseCreatedByNavigation = new HashSet<Users>();
            InverseModifiedByNavigation = new HashSet<Users>();
            MeetingPresences = new HashSet<MeetingPresences>();
            MeetingsCreatedByNavigation = new HashSet<Meetings>();
            MeetingsModifiedByNavigation = new HashSet<Meetings>();
            MeetingsOrganizer = new HashSet<Meetings>();
            PaperDecisionViews = new HashSet<PaperDecisionViews>();
            PbdocVersionsCreatedByNavigation = new HashSet<PbdocVersions>();
            PbdocVersionsModifiedByNavigation = new HashSet<PbdocVersions>();
            ProductSettings = new HashSet<ProductSettings>();
            SpdocsCreatedByNavigation = new HashSet<Spdocs>();
            SpdocsModifiedByNavigation = new HashSet<Spdocs>();
            StakeHolderFlowsCreatedByNavigation = new HashSet<StakeHolderFlows>();
            StakeHolderFlowsModifiedByNavigation = new HashSet<StakeHolderFlows>();
            UserDetailsCreatedByNavigation = new HashSet<UserDetails>();
            UserDetailsModifiedByNavigation = new HashSet<UserDetails>();
            UserDevices = new HashSet<UserDevices>();
        }

        [Key]
        public int CustomUserId { get; set; }
        public Guid UserId { get; set; }
        [Required]
        [StringLength(256)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(256)]
        public string LastName { get; set; }
        [Required]
        [StringLength(256)]
        public string UserName { get; set; }
        public byte Status { get; set; }
        [Required]
        [StringLength(100)]
        public string BoardEmail { get; set; }
        [StringLength(15)]
        public string MobileNumber { get; set; }
        [StringLength(100)]
        public string PersonalEmail { get; set; }
        [StringLength(15)]
        public string OfficePhone { get; set; }
        [StringLength(100)]
        public string OfficeEmail { get; set; }
        [StringLength(100)]
        public string JobTitle { get; set; }
        [StringLength(150)]
        public string CompanyName { get; set; }
        [StringLength(500)]
        public string CompanyAddress { get; set; }
        [StringLength(100)]
        public string SkypeId { get; set; }
        [StringLength(250)]
        public string Facebook { get; set; }
        [StringLength(250)]
        public string LinkedIn { get; set; }
        public byte[] Image { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
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
        [StringLength(50)]
        public string Title { get; set; }
        public bool PasswordReseted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ImageModifiedDate { get; set; }
        [StringLength(50)]
        public string DisplayName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastActivatedDate { get; set; }
        public byte[] Signature { get; set; }
        public bool IsDisclaimerViewed { get; set; }
        public byte? ViewType { get; set; }
        public byte DigitalSignStatus { get; set; }

        [ForeignKey("CreatedBy")]
        [InverseProperty("InverseCreatedByNavigation")]
        public Users CreatedByNavigation { get; set; }
        [ForeignKey("ModifiedBy")]
        [InverseProperty("InverseModifiedByNavigation")]
        public Users ModifiedByNavigation { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("Users")]
        public AspnetUsers1 User { get; set; }
        [InverseProperty("CustomUser")]
        public UserDsdetails UserDsdetails { get; set; }
        [InverseProperty("CustomUser")]
        public ICollection<Accesses> Accesses { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<AgendaDetails> AgendaDetailsCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<AgendaDetails> AgendaDetailsModifiedByNavigation { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<AgendaTemplates> AgendaTemplatesCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<AgendaTemplates> AgendaTemplatesModifiedByNavigation { get; set; }
        [InverseProperty("CustomUser")]
        public ICollection<AnnotationAccesses> AnnotationAccesses { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<AnnotationShares> AnnotationSharesCreatedByNavigation { get; set; }
        [InverseProperty("CustomUser")]
        public ICollection<AnnotationShares> AnnotationSharesCustomUser { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<AnnotationShares> AnnotationSharesModifiedByNavigation { get; set; }
        [InverseProperty("CustomUser")]
        public ICollection<CommentAccesses> CommentAccesses { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<Comments> CommentsCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<Comments> CommentsModifiedByNavigation { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<DocFlowNonStakeHolders> DocFlowNonStakeHoldersCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<DocFlowNonStakeHolders> DocFlowNonStakeHoldersModifiedByNavigation { get; set; }
        [InverseProperty("NonStakeHolder")]
        public ICollection<DocFlowNonStakeHolders> DocFlowNonStakeHoldersNonStakeHolder { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<DocFlowShcomments> DocFlowShcommentsCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<DocFlowShcomments> DocFlowShcommentsModifiedByNavigation { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<DocFlowStakeHolders> DocFlowStakeHoldersCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<DocFlowStakeHolders> DocFlowStakeHoldersModifiedByNavigation { get; set; }
        [InverseProperty("StakeHolder")]
        public ICollection<DocFlowStakeHolders> DocFlowStakeHoldersStakeHolder { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<DocVersions> DocVersionsCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<DocVersions> DocVersionsModifiedByNavigation { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<Documents> DocumentsCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<Documents> DocumentsModifiedByNavigation { get; set; }
        [InverseProperty("CustomUser")]
        public ICollection<HeadingAccesses> HeadingAccesses { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<Users> InverseCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<Users> InverseModifiedByNavigation { get; set; }
        [InverseProperty("CustomUser")]
        public ICollection<MeetingPresences> MeetingPresences { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<Meetings> MeetingsCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<Meetings> MeetingsModifiedByNavigation { get; set; }
        [InverseProperty("Organizer")]
        public ICollection<Meetings> MeetingsOrganizer { get; set; }
        [InverseProperty("CustomUser")]
        public ICollection<PaperDecisionViews> PaperDecisionViews { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<PbdocVersions> PbdocVersionsCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<PbdocVersions> PbdocVersionsModifiedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<ProductSettings> ProductSettings { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<Spdocs> SpdocsCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<Spdocs> SpdocsModifiedByNavigation { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<StakeHolderFlows> StakeHolderFlowsCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<StakeHolderFlows> StakeHolderFlowsModifiedByNavigation { get; set; }
        [InverseProperty("CreatedByNavigation")]
        public ICollection<UserDetails> UserDetailsCreatedByNavigation { get; set; }
        [InverseProperty("ModifiedByNavigation")]
        public ICollection<UserDetails> UserDetailsModifiedByNavigation { get; set; }
        [InverseProperty("CustomUser")]
        public ICollection<UserDevices> UserDevices { get; set; }
    }
}
