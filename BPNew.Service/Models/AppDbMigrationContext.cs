using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BPNew.Service.Models
{
    public partial class AppDbMigrationContext : DbContext
    {
        public AppDbMigrationContext()
        {
        }

        public AppDbMigrationContext(DbContextOptions<AppDbMigrationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accesses> Accesses { get; set; }
        public virtual DbSet<AgendaDetails> AgendaDetails { get; set; }
        public virtual DbSet<AgendaTemplates> AgendaTemplates { get; set; }
        public virtual DbSet<AlternativeFlows> AlternativeFlows { get; set; }
        public virtual DbSet<AnnotationAccesses> AnnotationAccesses { get; set; }
        public virtual DbSet<AnnotationShares> AnnotationShares { get; set; }
        public virtual DbSet<ArchivedAuditLogs> ArchivedAuditLogs { get; set; }
        public virtual DbSet<ArchivedPbauditLogs> ArchivedPbauditLogs { get; set; }
        public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMembership { get; set; }
        public virtual DbSet<AspnetPaths> AspnetPaths { get; set; }
        public virtual DbSet<AspnetPersonalizationAllUsers> AspnetPersonalizationAllUsers { get; set; }
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfile { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspnetRoles1> AspnetRoles1 { get; set; }
        public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspnetUsers1> AspnetUsers1 { get; set; }
        public virtual DbSet<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspnetWebEventEvents> AspnetWebEventEvents { get; set; }
        public virtual DbSet<AuditLogs> AuditLogs { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CommentAccesses> CommentAccesses { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Devices> Devices { get; set; }
        public virtual DbSet<DigitalSignatureLogs> DigitalSignatureLogs { get; set; }
        public virtual DbSet<DocFlowNonStakeHolders> DocFlowNonStakeHolders { get; set; }
        public virtual DbSet<DocFlowShcomments> DocFlowShcomments { get; set; }
        public virtual DbSet<DocFlowStakeHolders> DocFlowStakeHolders { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<DocumentStatuses> DocumentStatuses { get; set; }
        public virtual DbSet<DocVersions> DocVersions { get; set; }
        public virtual DbSet<FileStructures> FileStructures { get; set; }
        public virtual DbSet<HeadingAccesses> HeadingAccesses { get; set; }
        public virtual DbSet<Headings> Headings { get; set; }
        public virtual DbSet<IPadDbs> IPadDbs { get; set; }
        public virtual DbSet<Keywords> Keywords { get; set; }
        public virtual DbSet<MeetingPresences> MeetingPresences { get; set; }
        public virtual DbSet<Meetings> Meetings { get; set; }
        public virtual DbSet<MeetingTemplates> MeetingTemplates { get; set; }
        public virtual DbSet<PaperDecisionViews> PaperDecisionViews { get; set; }
        public virtual DbSet<PaperKeywordTags> PaperKeywordTags { get; set; }
        public virtual DbSet<Papers> Papers { get; set; }
        public virtual DbSet<PasswordHistory> PasswordHistory { get; set; }
        public virtual DbSet<PbauditLogs> PbauditLogs { get; set; }
        public virtual DbSet<PbdocVersions> PbdocVersions { get; set; }
        public virtual DbSet<ProductSettings> ProductSettings { get; set; }
        public virtual DbSet<Salutations> Salutations { get; set; }
        public virtual DbSet<Spdocs> Spdocs { get; set; }
        public virtual DbSet<StakeHolderFlows> StakeHolderFlows { get; set; }
        public virtual DbSet<SubCategories> SubCategories { get; set; }
        public virtual DbSet<TrackingEvents> TrackingEvents { get; set; }
        public virtual DbSet<UserDetails> UserDetails { get; set; }
        public virtual DbSet<UserDevices> UserDevices { get; set; }
        public virtual DbSet<UserDsdetails> UserDsdetails { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(local);Database=AzureBoardPAC;User ID=sa;Password=sysdba123;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accesses>(entity =>
            {
                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CustomUser)
                    .WithMany(p => p.Accesses)
                    .HasForeignKey(d => d.CustomUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accesses_Users");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accesses)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accesses_aspnet_Roles");
            });

            modelBuilder.Entity<AgendaDetails>(entity =>
            {
                entity.Property(e => e.PaperId).ValueGeneratedNever();

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AgendaDetailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgendaDetails_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AgendaDetailsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_AgendaDetails_Users1");

                entity.HasOne(d => d.Paper)
                    .WithOne(p => p.AgendaDetails)
                    .HasForeignKey<AgendaDetails>(d => d.PaperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgendaDetails_Papers");
            });

            modelBuilder.Entity<AgendaTemplates>(entity =>
            {
                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AgendaTemplatesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgendaTemplates_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AgendaTemplatesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgendaTemplates_Users1");
            });

            modelBuilder.Entity<AlternativeFlows>(entity =>
            {
                entity.Property(e => e.FlowName).IsUnicode(false);

                entity.HasOne(d => d.CurrentFlowNavigation)
                    .WithMany(p => p.AlternativeFlowsCurrentFlowNavigation)
                    .HasForeignKey(d => d.CurrentFlow)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlternativeFlows_StakeHolderFlows");

                entity.HasOne(d => d.NextFlowNavigation)
                    .WithMany(p => p.AlternativeFlowsNextFlowNavigation)
                    .HasForeignKey(d => d.NextFlow)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlternativeFlows_StakeHolderFlows1");
            });

            modelBuilder.Entity<AnnotationAccesses>(entity =>
            {
                entity.HasKey(e => new { e.AnnotationShareId, e.CustomUserId });

                entity.HasOne(d => d.AnnotationShare)
                    .WithMany(p => p.AnnotationAccesses)
                    .HasForeignKey(d => d.AnnotationShareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnnotationAccesses_AnnotationShares");

                entity.HasOne(d => d.CustomUser)
                    .WithMany(p => p.AnnotationAccesses)
                    .HasForeignKey(d => d.CustomUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnnotationAccesses_Users");
            });

            modelBuilder.Entity<AnnotationShares>(entity =>
            {
                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.IPadUniqueId).IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AnnotationSharesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnnotationShares_Users1");

                entity.HasOne(d => d.CustomUser)
                    .WithMany(p => p.AnnotationSharesCustomUser)
                    .HasForeignKey(d => d.CustomUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnnotationShares_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AnnotationSharesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_AnnotationShares_Users2");

                entity.HasOne(d => d.Paper)
                    .WithMany(p => p.AnnotationShares)
                    .HasForeignKey(d => d.PaperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnnotationShares_Papers");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.AnnotationShares)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnnotationShares_DocVersions");
            });

            modelBuilder.Entity<ArchivedPbauditLogs>(entity =>
            {
                entity.Property(e => e.Event).IsUnicode(false);
            });

            modelBuilder.Entity<AspnetApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.ApplicationName)
                    .HasName("UQ__aspnet_A__309103310EA330E9")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName)
                    .HasName("aspnet_Applications_Index")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail })
                    .HasName("aspnet_Membership_index")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMembership)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__11158940");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__1209AD79");
            });

            modelBuilder.Entity<AspnetPaths>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath })
                    .HasName("aspnet_Paths_index")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__0880433F");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUsers>(entity =>
            {
                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUsers)
                    .HasForeignKey<AspnetPersonalizationAllUsers>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__0E391C95");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => new { e.PathId, e.UserId })
                    .HasName("aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.UserId, e.PathId })
                    .HasName("aspnet_PersonalizationPerUser_ncindex2")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__0F2D40CE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__10216507");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__0D44F85C");
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AspnetRoles1>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName })
                    .HasName("aspnet_Roles_index1")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasDefaultValueSql("('ChangePassword_HTML,ChangePassword_XML')");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles1)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__440B1D61");
            });

            modelBuilder.Entity<AspnetSchemaVersions>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion });
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AspnetUsers1>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate })
                    .HasName("aspnet_Users_Index2");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName })
                    .HasName("aspnet_Users_Index")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers1)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__09746778");
            });

            modelBuilder.Entity<AspnetUsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId)
                    .HasName("aspnet_UsersInRoles_index");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__RoleI__4AB81AF0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__UserI__0C50D423");
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<AspnetWebEventEvents>(entity =>
            {
                entity.Property(e => e.EventId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<CommentAccesses>(entity =>
            {
                entity.HasKey(e => new { e.CommentId, e.CustomUserId });

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CommentAccesses)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentViews_Comments");

                entity.HasOne(d => d.CustomUser)
                    .WithMany(p => p.CommentAccesses)
                    .HasForeignKey(d => d.CustomUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentViews_Users");
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CommentsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comments_Users_AddBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CommentsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Comments_Users_ModBy");
            });

            modelBuilder.Entity<DocFlowNonStakeHolders>(entity =>
            {
                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DocFlowNonStakeHoldersCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocFlowNonStakeHolders_Users");

                entity.HasOne(d => d.DocFlowStakeHolder)
                    .WithMany(p => p.DocFlowNonStakeHolders)
                    .HasForeignKey(d => d.DocFlowStakeHolderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocFlowNonStakeHolders_DocFlowNonStakeHolders");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DocFlowNonStakeHoldersModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_DocFlowNonStakeHolders_Users1");

                entity.HasOne(d => d.NonStakeHolder)
                    .WithMany(p => p.DocFlowNonStakeHoldersNonStakeHolder)
                    .HasForeignKey(d => d.NonStakeHolderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocFlowNonStakeHolders_Users2");
            });

            modelBuilder.Entity<DocFlowShcomments>(entity =>
            {
                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DocFlowShcommentsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocFlowSHComments_Users");

                entity.HasOne(d => d.DocFlowStakeHolder)
                    .WithMany(p => p.DocFlowShcomments)
                    .HasForeignKey(d => d.DocFlowStakeHolderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocFlowSHComments_DocFlowStakeHolders");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DocFlowShcommentsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_DocFlowSHComments_Users1");
            });

            modelBuilder.Entity<DocFlowStakeHolders>(entity =>
            {
                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DocFlowStakeHoldersCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocFlowStakeHolders_Users1");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DocFlowStakeHoldersModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_DocFlowStakeHolders_Users2");

                entity.HasOne(d => d.Shflow)
                    .WithMany(p => p.DocFlowStakeHolders)
                    .HasForeignKey(d => d.ShflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocFlowStakeHolders_StakeHolderFlows");

                entity.HasOne(d => d.StakeHolder)
                    .WithMany(p => p.DocFlowStakeHoldersStakeHolder)
                    .HasForeignKey(d => d.StakeHolderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocFlowStakeHolders_Users");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.DocFlowStakeHolders)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocFlowStakeHolders_PBDocVersions");
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DocumentsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documents_Users");

                entity.HasOne(d => d.Meeting)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.MeetingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documents_Meetings");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DocumentsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Documents_Users1");
            });

            modelBuilder.Entity<DocumentStatuses>(entity =>
            {
                entity.Property(e => e.DocumentStatusId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DocVersions>(entity =>
            {
                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DocVersionsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocVersions_Users_AddBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DocVersionsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_DocVersions_Users_ModBy");

                entity.HasOne(d => d.PreviousVersion)
                    .WithMany(p => p.InversePreviousVersion)
                    .HasForeignKey(d => d.PreviousVersionId)
                    .HasConstraintName("FK_DocVersions_DocVersions");
            });

            modelBuilder.Entity<FileStructures>(entity =>
            {
                entity.HasKey(e => e.DocumentId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.CreatedDate);

                entity.Property(e => e.DocumentId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<HeadingAccesses>(entity =>
            {
                entity.HasKey(e => new { e.HeadingId, e.CustomUserId });

                entity.HasIndex(e => e.CustomUserId)
                    .HasName("IX_Table_CustomUserId");

                entity.Property(e => e.IsAllowed).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CustomUser)
                    .WithMany(p => p.HeadingAccesses)
                    .HasForeignKey(d => d.CustomUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeadingAccesses_Users");

                entity.HasOne(d => d.Heading)
                    .WithMany(p => p.HeadingAccesses)
                    .HasForeignKey(d => d.HeadingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeadingAccesses_Headings");
            });

            modelBuilder.Entity<Headings>(entity =>
            {
                entity.Property(e => e.Timestamp).IsRowVersion();

                entity.HasOne(d => d.Meeting)
                    .WithMany(p => p.Headings)
                    .HasForeignKey(d => d.MeetingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Headings_Meetings");

                entity.HasOne(d => d.PreviousHeading)
                    .WithMany(p => p.InversePreviousHeading)
                    .HasForeignKey(d => d.PreviousHeadingId)
                    .HasConstraintName("FK_Headings_PreviousHeadings");
            });

            modelBuilder.Entity<IPadDbs>(entity =>
            {
                entity.Property(e => e.Version).IsUnicode(false);
            });

            modelBuilder.Entity<MeetingPresences>(entity =>
            {
                entity.HasKey(e => new { e.MeetingId, e.CustomUserId });

                entity.Property(e => e.AttendenceReason).IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CustomUser)
                    .WithMany(p => p.MeetingPresences)
                    .HasForeignKey(d => d.CustomUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeetingPresences_Users");

                entity.HasOne(d => d.Meeting)
                    .WithMany(p => p.MeetingPresences)
                    .HasForeignKey(d => d.MeetingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeetingPresences_Meetings");
            });

            modelBuilder.Entity<Meetings>(entity =>
            {
                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MeetingsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Meetings_Users_AddBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.MeetingsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Meetings_Users_ModBy");

                entity.HasOne(d => d.Organizer)
                    .WithMany(p => p.MeetingsOrganizer)
                    .HasForeignKey(d => d.OrganizerId)
                    .HasConstraintName("FK_Meetings_Users");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.Meetings)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Meetings_SubCategories");
            });

            modelBuilder.Entity<PaperDecisionViews>(entity =>
            {
                entity.HasKey(e => new { e.PaperId, e.CustomUserId });

                entity.HasIndex(e => new { e.PaperId, e.CustomUserId, e.DecisionStatus, e.NotificationStatus, e.ApprovalComment, e.TimeStamp, e.IsAllowed })
                    .HasName("IX_PaperDecisionViews_CI");

                entity.Property(e => e.DsprivateComment).IsUnicode(false);

                entity.Property(e => e.DspublicComment).IsUnicode(false);

                entity.Property(e => e.IsAllowed).HasDefaultValueSql("((1))");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CustomUser)
                    .WithMany(p => p.PaperDecisionViews)
                    .HasForeignKey(d => d.CustomUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaperDecisionViews_Users");

                entity.HasOne(d => d.Paper)
                    .WithMany(p => p.PaperDecisionViews)
                    .HasForeignKey(d => d.PaperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaperDecisionViews_Papers");
            });

            modelBuilder.Entity<PaperKeywordTags>(entity =>
            {
                entity.HasKey(e => new { e.PaperId, e.KeywordId });

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.PaperKeywordTags)
                    .HasForeignKey(d => d.KeywordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaperKeywordTags_Keywords");

                entity.HasOne(d => d.Paper)
                    .WithMany(p => p.PaperKeywordTags)
                    .HasForeignKey(d => d.PaperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaperKeywordTags_Papers");
            });

            modelBuilder.Entity<Papers>(entity =>
            {
                entity.Property(e => e.PaperColor).IsUnicode(false);

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.VersionInfo).HasDefaultValueSql("((214))");

                entity.HasOne(d => d.Heading)
                    .WithMany(p => p.Papers)
                    .HasForeignKey(d => d.HeadingId)
                    .HasConstraintName("FK_Papers_Headings");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.Papers)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Papers_DocVersions");
            });

            modelBuilder.Entity<PasswordHistory>(entity =>
            {
                entity.Property(e => e.TimeStamp).IsRowVersion();
            });

            modelBuilder.Entity<PbauditLogs>(entity =>
            {
                entity.Property(e => e.Event).IsUnicode(false);
            });

            modelBuilder.Entity<PbdocVersions>(entity =>
            {
                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PbdocVersionsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PBDocVersions_Users");

                entity.HasOne(d => d.DocStatusNavigation)
                    .WithMany(p => p.PbdocVersions)
                    .HasForeignKey(d => d.DocStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PBDocVersions_DocumentStatuses");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.PbdocVersions)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PBDocVersions_Documents");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PbdocVersionsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_PBDocVersions_Users1");
            });

            modelBuilder.Entity<ProductSettings>(entity =>
            {
                entity.HasIndex(e => e.Key)
                    .HasName("UNQ_Key_ProductSettings")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Key).IsUnicode(false);

                entity.Property(e => e.Timestamp).IsRowVersion();

                entity.Property(e => e.Value).IsUnicode(false);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProductSettings)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_ProductSettings_Users");
            });

            modelBuilder.Entity<Salutations>(entity =>
            {
                entity.HasIndex(e => e.Salutation)
                    .HasName("UQ__Salutati__ED1ECA726CA31EA0")
                    .IsUnique();

                entity.Property(e => e.IsOn).HasDefaultValueSql("('1')");

                entity.Property(e => e.Salutation).IsUnicode(false);
            });

            modelBuilder.Entity<Spdocs>(entity =>
            {
                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SpdocsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPDocs_Users1");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SpdocsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_SPDocs_Users");

                entity.HasOne(d => d.SubCategory)
                    .WithMany(p => p.Spdocs)
                    .HasForeignKey(d => d.SubCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPDocs_SubCategories");
            });

            modelBuilder.Entity<StakeHolderFlows>(entity =>
            {
                entity.Property(e => e.ShflowId).ValueGeneratedOnAdd();

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StakeHolderFlowsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StakeHolderFlows_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StakeHolderFlowsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_StakeHolderFlows_Users1");

                entity.HasOne(d => d.PrevFlow)
                    .WithMany(p => p.InversePrevFlow)
                    .HasForeignKey(d => d.PrevFlowId)
                    .HasConstraintName("FK_StakeHolderFlows_StakeHolderFlows");

                entity.HasOne(d => d.Shflow)
                    .WithOne(p => p.InverseShflow)
                    .HasForeignKey<StakeHolderFlows>(d => d.ShflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StakeHolderFlows_StakeHolderFlows1");
            });

            modelBuilder.Entity<SubCategories>(entity =>
            {
                entity.Property(e => e.IsCustomSequence).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCategories_Categories");
            });

            modelBuilder.Entity<UserDetails>(entity =>
            {
                entity.Property(e => e.CustomUserId).ValueGeneratedNever();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.UserDetailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDetails_Users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.UserDetailsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_UserDetails_Users1");
            });

            modelBuilder.Entity<UserDevices>(entity =>
            {
                entity.HasKey(e => new { e.CustomUserId, e.DeviceId });

                entity.Property(e => e.Dsstatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.HasOne(d => d.CustomUser)
                    .WithMany(p => p.UserDevices)
                    .HasForeignKey(d => d.CustomUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDevices_Users");
            });

            modelBuilder.Entity<UserDsdetails>(entity =>
            {
                entity.Property(e => e.CustomUserId).ValueGeneratedNever();

                entity.Property(e => e.IdentityNumber).IsUnicode(false);

                entity.HasOne(d => d.CustomUser)
                    .WithOne(p => p.UserDsdetails)
                    .HasForeignKey<UserDsdetails>(d => d.CustomUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDSDetails_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.TimeStamp).IsRowVersion();

                entity.Property(e => e.ViewType).HasDefaultValueSql("((255))");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InverseCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Users_AddedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InverseModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Users_Users_ModBy");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_aspnet_Users");
            });
        }
    }
}
