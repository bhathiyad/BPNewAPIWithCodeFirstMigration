using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BPNew.Service.Data.Migrations
{
    public partial class InitialCreateBPEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.EnsureSchema(
            //    name: "PreBoard");

            //migrationBuilder.CreateTable(
            //    name: "ArchivedAuditLogs",
            //    columns: table => new
            //    {
            //        LogId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        EventNumber = table.Column<int>(nullable: false),
            //        Event = table.Column<string>(maxLength: 250, nullable: false),
            //        EventStatus = table.Column<string>(maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        UserName = table.Column<string>(maxLength: 250, nullable: true),
            //        ControllerName = table.Column<string>(maxLength: 250, nullable: false),
            //        ActionName = table.Column<string>(maxLength: 250, nullable: false),
            //        Parameters = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ArchivedAuditLogs", x => x.LogId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnet_Applications",
            //    columns: table => new
            //    {
            //        ApplicationName = table.Column<string>(maxLength: 256, nullable: false),
            //        LoweredApplicationName = table.Column<string>(maxLength: 256, nullable: false),
            //        ApplicationId = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        Description = table.Column<string>(maxLength: 256, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnet_Applications", x => x.ApplicationId)
            //            .Annotation("SqlServer:Clustered", false);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnet_SchemaVersions",
            //    columns: table => new
            //    {
            //        Feature = table.Column<string>(maxLength: 128, nullable: false),
            //        CompatibleSchemaVersion = table.Column<string>(maxLength: 128, nullable: false),
            //        IsCurrentVersion = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnet_SchemaVersions", x => new { x.Feature, x.CompatibleSchemaVersion });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnet_WebEvent_Events",
            //    columns: table => new
            //    {
            //        EventId = table.Column<string>(unicode: false, maxLength: 32, nullable: false),
            //        EventTimeUtc = table.Column<DateTime>(type: "datetime", nullable: false),
            //        EventTime = table.Column<DateTime>(type: "datetime", nullable: false),
            //        EventType = table.Column<string>(maxLength: 256, nullable: false),
            //        EventSequence = table.Column<decimal>(type: "decimal(19, 0)", nullable: false),
            //        EventOccurrence = table.Column<decimal>(type: "decimal(19, 0)", nullable: false),
            //        EventCode = table.Column<int>(nullable: false),
            //        EventDetailCode = table.Column<int>(nullable: false),
            //        Message = table.Column<string>(maxLength: 1024, nullable: true),
            //        ApplicationPath = table.Column<string>(maxLength: 256, nullable: true),
            //        ApplicationVirtualPath = table.Column<string>(maxLength: 256, nullable: true),
            //        MachineName = table.Column<string>(maxLength: 256, nullable: false),
            //        RequestUrl = table.Column<string>(maxLength: 1024, nullable: true),
            //        ExceptionType = table.Column<string>(maxLength: 256, nullable: true),
            //        Details = table.Column<string>(type: "ntext", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnet_WebEvent_Events", x => x.EventId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetRoles",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(nullable: false),
            //        Name = table.Column<string>(maxLength: 256, nullable: true),
            //        NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
            //        ConcurrencyStamp = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUsers",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(nullable: false),
            //        UserName = table.Column<string>(maxLength: 256, nullable: true),
            //        NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
            //        Email = table.Column<string>(maxLength: 256, nullable: true),
            //        NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
            //        EmailConfirmed = table.Column<bool>(nullable: false),
            //        PasswordHash = table.Column<string>(nullable: true),
            //        SecurityStamp = table.Column<string>(nullable: true),
            //        ConcurrencyStamp = table.Column<string>(nullable: true),
            //        PhoneNumber = table.Column<string>(nullable: true),
            //        PhoneNumberConfirmed = table.Column<bool>(nullable: false),
            //        TwoFactorEnabled = table.Column<bool>(nullable: false),
            //        LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
            //        LockoutEnabled = table.Column<bool>(nullable: false),
            //        AccessFailedCount = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AuditLogs",
            //    columns: table => new
            //    {
            //        LogId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        EventNumber = table.Column<int>(nullable: false),
            //        Event = table.Column<string>(maxLength: 250, nullable: false),
            //        EventStatus = table.Column<string>(maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        UserName = table.Column<string>(maxLength: 250, nullable: true),
            //        ControllerName = table.Column<string>(maxLength: 250, nullable: false),
            //        ActionName = table.Column<string>(maxLength: 250, nullable: false),
            //        Parameters = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AuditLogs", x => x.LogId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Categories",
            //    columns: table => new
            //    {
            //        CategoryId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(maxLength: 500, nullable: false),
            //        Status = table.Column<byte>(nullable: false),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        CategoryOrder = table.Column<int>(nullable: false),
            //        ShortName = table.Column<string>(maxLength: 50, nullable: true),
            //        Description = table.Column<string>(maxLength: 1000, nullable: true),
            //        Description2 = table.Column<string>(maxLength: 1000, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Categories", x => x.CategoryId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Devices",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        DeviceId = table.Column<string>(maxLength: 100, nullable: true),
            //        MacAddress = table.Column<string>(maxLength: 100, nullable: true),
            //        Status = table.Column<byte>(nullable: true),
            //        Description = table.Column<string>(maxLength: 200, nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        IsAllocatedForDS = table.Column<byte>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Devices", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DigitalSignatureLogs",
            //    columns: table => new
            //    {
            //        LogId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        CustomUserId = table.Column<int>(nullable: false),
            //        UserName = table.Column<string>(maxLength: 256, nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Parameters = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DigitalSignatureLogs", x => x.LogId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FileStructures",
            //    columns: table => new
            //    {
            //        DocumentID = table.Column<Guid>(nullable: false, defaultValueSql: "(newsequentialid())"),
            //        RefID = table.Column<int>(nullable: false),
            //        RefType = table.Column<int>(nullable: false),
            //        Content = table.Column<byte[]>(nullable: true),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DSRefId = table.Column<string>(maxLength: 500, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FileStructures", x => x.DocumentID)
            //            .Annotation("SqlServer:Clustered", false);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iPadDBs",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Script = table.Column<string>(type: "ntext", nullable: true),
            //        Version = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        ScriptOrder = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_iPadDBs", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Keywords",
            //    columns: table => new
            //    {
            //        KeywordId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Keyword = table.Column<string>(maxLength: 150, nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Keywords", x => x.KeywordId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MeetingTemplates",
            //    columns: table => new
            //    {
            //        MeetingTemplateId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        TemplateName = table.Column<string>(maxLength: 256, nullable: false),
            //        Address = table.Column<string>(nullable: true),
            //        Venue = table.Column<string>(maxLength: 255, nullable: true),
            //        Latitude = table.Column<double>(nullable: false),
            //        Longitude = table.Column<double>(nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        Status = table.Column<byte>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MeetingTemplates", x => x.MeetingTemplateId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PasswordHistory",
            //    columns: table => new
            //    {
            //        HistoryId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        UserId = table.Column<int>(nullable: false),
            //        PasswordHash = table.Column<byte[]>(maxLength: 50, nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PasswordHistory", x => x.HistoryId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Salutations",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Salutation = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
            //        IsOn = table.Column<bool>(nullable: false, defaultValueSql: "('1')")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Salutations", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ArchivedPBAuditLogs",
            //    schema: "PreBoard",
            //    columns: table => new
            //    {
            //        LogID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Event = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        EventStatus = table.Column<string>(maxLength: 256, nullable: false),
            //        LogDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
            //        MeetingID = table.Column<int>(nullable: false),
            //        DocumentID = table.Column<int>(nullable: false),
            //        VersionID = table.Column<int>(nullable: false),
            //        DocumentName = table.Column<string>(maxLength: 500, nullable: true),
            //        ActionName = table.Column<string>(maxLength: 100, nullable: false),
            //        ActionBy = table.Column<int>(nullable: true),
            //        Parameter = table.Column<string>(maxLength: 500, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ArchivedPBAuditLogs", x => x.LogID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DocumentStatuses",
            //    schema: "PreBoard",
            //    columns: table => new
            //    {
            //        DocumentStatusId = table.Column<byte>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Status = table.Column<string>(maxLength: 30, nullable: false),
            //        PendingAction = table.Column<string>(maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DocumentStatuses", x => x.DocumentStatusId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PBAuditLogs",
            //    schema: "PreBoard",
            //    columns: table => new
            //    {
            //        LogID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Event = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        EventStatus = table.Column<string>(maxLength: 256, nullable: false),
            //        LogDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
            //        MeetingID = table.Column<int>(nullable: false),
            //        DocumentID = table.Column<int>(nullable: false),
            //        VersionID = table.Column<int>(nullable: false),
            //        DocumentName = table.Column<string>(maxLength: 500, nullable: true),
            //        ActionName = table.Column<string>(maxLength: 100, nullable: false),
            //        ActionBy = table.Column<int>(nullable: true),
            //        Parameter = table.Column<string>(maxLength: 500, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PBAuditLogs", x => x.LogID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TrackingEvents",
            //    schema: "PreBoard",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        WorkflowInstanceId = table.Column<Guid>(nullable: false),
            //        RecordNumber = table.Column<long>(nullable: true),
            //        TraceLevelId = table.Column<byte>(nullable: true),
            //        ActivityName = table.Column<string>(maxLength: 2048, nullable: true),
            //        Status = table.Column<string>(maxLength: 20, nullable: true),
            //        TrackingData = table.Column<string>(nullable: true),
            //        EventTime = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TrackingEvents", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnet_Paths",
            //    columns: table => new
            //    {
            //        ApplicationId = table.Column<Guid>(nullable: false),
            //        PathId = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        Path = table.Column<string>(maxLength: 256, nullable: false),
            //        LoweredPath = table.Column<string>(maxLength: 256, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnet_Paths", x => x.PathId)
            //            .Annotation("SqlServer:Clustered", false);
            //        table.ForeignKey(
            //            name: "FK__aspnet_Pa__Appli__0880433F",
            //            column: x => x.ApplicationId,
            //            principalTable: "aspnet_Applications",
            //            principalColumn: "ApplicationId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnet_Roles",
            //    columns: table => new
            //    {
            //        ApplicationId = table.Column<Guid>(nullable: false),
            //        RoleId = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        RoleName = table.Column<string>(maxLength: 256, nullable: false),
            //        LoweredRoleName = table.Column<string>(maxLength: 256, nullable: false),
            //        IpadActions = table.Column<string>(nullable: true),
            //        Description = table.Column<string>(nullable: false, defaultValueSql: "('ChangePassword_HTML,ChangePassword_XML')"),
            //        ShortDescription = table.Column<string>(maxLength: 250, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnet_Roles", x => x.RoleId)
            //            .Annotation("SqlServer:Clustered", false);
            //        table.ForeignKey(
            //            name: "FK__aspnet_Ro__Appli__440B1D61",
            //            column: x => x.ApplicationId,
            //            principalTable: "aspnet_Applications",
            //            principalColumn: "ApplicationId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnet_Users",
            //    columns: table => new
            //    {
            //        ApplicationId = table.Column<Guid>(nullable: false),
            //        UserId = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        UserName = table.Column<string>(maxLength: 256, nullable: false),
            //        LoweredUserName = table.Column<string>(maxLength: 256, nullable: false),
            //        MobileAlias = table.Column<string>(maxLength: 16, nullable: true),
            //        IsAnonymous = table.Column<bool>(nullable: false),
            //        LastActivityDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnet_Users", x => x.UserId)
            //            .Annotation("SqlServer:Clustered", false);
            //        table.ForeignKey(
            //            name: "FK__aspnet_Us__Appli__09746778",
            //            column: x => x.ApplicationId,
            //            principalTable: "aspnet_Applications",
            //            principalColumn: "ApplicationId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetRoleClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        RoleId = table.Column<string>(nullable: false),
            //        ClaimType = table.Column<string>(nullable: true),
            //        ClaimValue = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        UserId = table.Column<string>(nullable: false),
            //        ClaimType = table.Column<string>(nullable: true),
            //        ClaimValue = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserClaims_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserLogins",
            //    columns: table => new
            //    {
            //        LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
            //        ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
            //        ProviderDisplayName = table.Column<string>(nullable: true),
            //        UserId = table.Column<string>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserRoles",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(nullable: false),
            //        RoleId = table.Column<string>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserTokens",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(nullable: false),
            //        LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
            //        Name = table.Column<string>(maxLength: 128, nullable: false),
            //        Value = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SubCategories",
            //    columns: table => new
            //    {
            //        SubCategoryId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(maxLength: 500, nullable: false),
            //        CategoryId = table.Column<int>(nullable: false),
            //        Status = table.Column<byte>(nullable: false),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        SubCategoryOrder = table.Column<int>(nullable: false),
            //        ShortName = table.Column<string>(maxLength: 50, nullable: true),
            //        IsCustomSequence = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SubCategories", x => x.SubCategoryId);
            //        table.ForeignKey(
            //            name: "FK_SubCategories_Categories",
            //            column: x => x.CategoryId,
            //            principalTable: "Categories",
            //            principalColumn: "CategoryId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnet_PersonalizationAllUsers",
            //    columns: table => new
            //    {
            //        PathId = table.Column<Guid>(nullable: false),
            //        PageSettings = table.Column<byte[]>(type: "image", nullable: false),
            //        LastUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnet_PersonalizationAllUsers", x => x.PathId);
            //        table.ForeignKey(
            //            name: "FK__aspnet_Pe__PathI__0E391C95",
            //            column: x => x.PathId,
            //            principalTable: "aspnet_Paths",
            //            principalColumn: "PathId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnet_Membership",
            //    columns: table => new
            //    {
            //        ApplicationId = table.Column<Guid>(nullable: false),
            //        UserId = table.Column<Guid>(nullable: false),
            //        Password = table.Column<string>(maxLength: 128, nullable: false),
            //        PasswordFormat = table.Column<int>(nullable: false),
            //        PasswordSalt = table.Column<string>(maxLength: 128, nullable: false),
            //        MobilePIN = table.Column<string>(maxLength: 16, nullable: true),
            //        Email = table.Column<string>(maxLength: 256, nullable: true),
            //        LoweredEmail = table.Column<string>(maxLength: 256, nullable: true),
            //        PasswordQuestion = table.Column<string>(maxLength: 256, nullable: true),
            //        PasswordAnswer = table.Column<string>(maxLength: 128, nullable: true),
            //        IsApproved = table.Column<bool>(nullable: false),
            //        IsLockedOut = table.Column<bool>(nullable: false),
            //        CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        LastLoginDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        LastPasswordChangedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        LastLockoutDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        FailedPasswordAttemptCount = table.Column<int>(nullable: false),
            //        FailedPasswordAttemptWindowStart = table.Column<DateTime>(type: "datetime", nullable: false),
            //        FailedPasswordAnswerAttemptCount = table.Column<int>(nullable: false),
            //        FailedPasswordAnswerAttemptWindowStart = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Comment = table.Column<string>(type: "ntext", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnet_Membership", x => x.UserId)
            //            .Annotation("SqlServer:Clustered", false);
            //        table.ForeignKey(
            //            name: "FK__aspnet_Me__Appli__11158940",
            //            column: x => x.ApplicationId,
            //            principalTable: "aspnet_Applications",
            //            principalColumn: "ApplicationId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK__aspnet_Me__UserI__1209AD79",
            //            column: x => x.UserId,
            //            principalTable: "aspnet_Users",
            //            principalColumn: "UserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnet_PersonalizationPerUser",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
            //        PathId = table.Column<Guid>(nullable: true),
            //        UserId = table.Column<Guid>(nullable: true),
            //        PageSettings = table.Column<byte[]>(type: "image", nullable: false),
            //        LastUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnet_PersonalizationPerUser", x => x.Id)
            //            .Annotation("SqlServer:Clustered", false);
            //        table.ForeignKey(
            //            name: "FK__aspnet_Pe__PathI__0F2D40CE",
            //            column: x => x.PathId,
            //            principalTable: "aspnet_Paths",
            //            principalColumn: "PathId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK__aspnet_Pe__UserI__10216507",
            //            column: x => x.UserId,
            //            principalTable: "aspnet_Users",
            //            principalColumn: "UserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnet_Profile",
            //    columns: table => new
            //    {
            //        UserId = table.Column<Guid>(nullable: false),
            //        PropertyNames = table.Column<string>(type: "ntext", nullable: false),
            //        PropertyValuesString = table.Column<string>(type: "ntext", nullable: false),
            //        PropertyValuesBinary = table.Column<byte[]>(type: "image", nullable: false),
            //        LastUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnet_Profile", x => x.UserId);
            //        table.ForeignKey(
            //            name: "FK__aspnet_Pr__UserI__0D44F85C",
            //            column: x => x.UserId,
            //            principalTable: "aspnet_Users",
            //            principalColumn: "UserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnet_UsersInRoles",
            //    columns: table => new
            //    {
            //        UserId = table.Column<Guid>(nullable: false),
            //        RoleId = table.Column<Guid>(nullable: false),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnet_UsersInRoles", x => new { x.UserId, x.RoleId });
            //        table.ForeignKey(
            //            name: "FK__aspnet_Us__RoleI__4AB81AF0",
            //            column: x => x.RoleId,
            //            principalTable: "aspnet_Roles",
            //            principalColumn: "RoleId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK__aspnet_Us__UserI__0C50D423",
            //            column: x => x.UserId,
            //            principalTable: "aspnet_Users",
            //            principalColumn: "UserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        CustomUserId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        UserId = table.Column<Guid>(nullable: false),
            //        FirstName = table.Column<string>(maxLength: 256, nullable: false),
            //        LastName = table.Column<string>(maxLength: 256, nullable: false),
            //        UserName = table.Column<string>(maxLength: 256, nullable: false),
            //        Status = table.Column<byte>(nullable: false),
            //        BoardEmail = table.Column<string>(maxLength: 100, nullable: false),
            //        MobileNumber = table.Column<string>(maxLength: 15, nullable: true),
            //        PersonalEmail = table.Column<string>(maxLength: 100, nullable: true),
            //        OfficePhone = table.Column<string>(maxLength: 15, nullable: true),
            //        OfficeEmail = table.Column<string>(maxLength: 100, nullable: true),
            //        JobTitle = table.Column<string>(maxLength: 100, nullable: true),
            //        CompanyName = table.Column<string>(maxLength: 150, nullable: true),
            //        CompanyAddress = table.Column<string>(maxLength: 500, nullable: true),
            //        SkypeId = table.Column<string>(maxLength: 100, nullable: true),
            //        Facebook = table.Column<string>(maxLength: 250, nullable: true),
            //        LinkedIn = table.Column<string>(maxLength: 250, nullable: true),
            //        Image = table.Column<byte[]>(nullable: true),
            //        Description = table.Column<string>(maxLength: 500, nullable: true),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        Title = table.Column<string>(maxLength: 50, nullable: true),
            //        PasswordReseted = table.Column<bool>(nullable: false),
            //        ImageModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DisplayName = table.Column<string>(maxLength: 50, nullable: true),
            //        LastActivatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Signature = table.Column<byte[]>(nullable: true),
            //        IsDisclaimerViewed = table.Column<bool>(nullable: false),
            //        ViewType = table.Column<byte>(nullable: true, defaultValueSql: "((255))"),
            //        DigitalSignStatus = table.Column<byte>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.CustomUserId);
            //        table.ForeignKey(
            //            name: "FK_Users_Users_AddedBy",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Users_Users_ModBy",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Users_aspnet_Users",
            //            column: x => x.UserId,
            //            principalTable: "aspnet_Users",
            //            principalColumn: "UserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Accesses",
            //    columns: table => new
            //    {
            //        AccessId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Type = table.Column<int>(nullable: false),
            //        RefId = table.Column<int>(nullable: false),
            //        RoleId = table.Column<Guid>(nullable: false),
            //        CustomUserId = table.Column<int>(nullable: false),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        IpadDisplayOrder = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Accesses", x => x.AccessId);
            //        table.ForeignKey(
            //            name: "FK_Accesses_Users",
            //            column: x => x.CustomUserId,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Accesses_aspnet_Roles",
            //            column: x => x.RoleId,
            //            principalTable: "aspnet_Roles",
            //            principalColumn: "RoleId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AgendaTemplates",
            //    columns: table => new
            //    {
            //        AgendaTemplateId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(maxLength: 100, nullable: false),
            //        FilePath = table.Column<string>(nullable: true),
            //        RefId = table.Column<int>(nullable: false),
            //        RefType = table.Column<byte>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: false),
            //        IsAssigned = table.Column<bool>(nullable: false),
            //        Content = table.Column<string>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AgendaTemplates", x => x.AgendaTemplateId);
            //        table.ForeignKey(
            //            name: "FK_AgendaTemplates_Users",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_AgendaTemplates_Users1",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Comments",
            //    columns: table => new
            //    {
            //        CommentId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        RefId = table.Column<int>(nullable: false),
            //        RefType = table.Column<byte>(nullable: false),
            //        Comment = table.Column<string>(nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        iPadUniqueID = table.Column<string>(maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Comments", x => x.CommentId);
            //        table.ForeignKey(
            //            name: "FK_Comments_Users_AddBy",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Comments_Users_ModBy",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DocVersions",
            //    columns: table => new
            //    {
            //        VersionId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        FilePath = table.Column<string>(unicode: false, nullable: true),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        PreviousVersionId = table.Column<int>(nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DocVersions", x => x.VersionId);
            //        table.ForeignKey(
            //            name: "FK_DocVersions_Users_AddBy",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DocVersions_Users_ModBy",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DocVersions_DocVersions",
            //            column: x => x.PreviousVersionId,
            //            principalTable: "DocVersions",
            //            principalColumn: "VersionId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Meetings",
            //    columns: table => new
            //    {
            //        MeetingId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        SubCategoryId = table.Column<int>(nullable: false),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        StartTime = table.Column<TimeSpan>(nullable: true),
            //        EndTime = table.Column<TimeSpan>(nullable: true),
            //        Subject = table.Column<string>(maxLength: 256, nullable: true),
            //        Description = table.Column<string>(maxLength: 500, nullable: true),
            //        Status = table.Column<byte>(nullable: false),
            //        IsTentative = table.Column<bool>(nullable: false),
            //        MeetingType = table.Column<byte>(nullable: false),
            //        Address = table.Column<string>(nullable: true),
            //        Venue = table.Column<string>(maxLength: 255, nullable: true),
            //        Latitude = table.Column<double>(nullable: false),
            //        Longitude = table.Column<double>(nullable: false),
            //        OrganizerId = table.Column<int>(nullable: true),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        IsDeleted = table.Column<bool>(nullable: false),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        MeetingNote = table.Column<string>(nullable: true),
            //        DocumentsDeadline = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Meetings", x => x.MeetingId);
            //        table.ForeignKey(
            //            name: "FK_Meetings_Users_AddBy",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Meetings_Users_ModBy",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Meetings_Users",
            //            column: x => x.OrganizerId,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Meetings_SubCategories",
            //            column: x => x.SubCategoryId,
            //            principalTable: "SubCategories",
            //            principalColumn: "SubCategoryId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductSettings",
            //    columns: table => new
            //    {
            //        SettingId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Key = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
            //        Name = table.Column<string>(maxLength: 50, nullable: false),
            //        Value = table.Column<string>(unicode: false, maxLength: 2048, nullable: true),
            //        Description = table.Column<string>(maxLength: 500, nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 300, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 300, nullable: true),
            //        Timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        IsIPAD = table.Column<bool>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductSettings", x => x.SettingId);
            //        table.ForeignKey(
            //            name: "FK_ProductSettings_Users",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SPDocs",
            //    columns: table => new
            //    {
            //        SPDocId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        SubCategoryId = table.Column<int>(nullable: false),
            //        DocName = table.Column<string>(maxLength: 1000, nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        MovedToBP = table.Column<string>(maxLength: 500, nullable: true),
            //        VersionInfo = table.Column<byte>(nullable: true),
            //        FileStructureId = table.Column<Guid>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SPDocs", x => x.SPDocId);
            //        table.ForeignKey(
            //            name: "FK_SPDocs_Users1",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_SPDocs_Users",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_SPDocs_SubCategories",
            //            column: x => x.SubCategoryId,
            //            principalTable: "SubCategories",
            //            principalColumn: "SubCategoryId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserDetails",
            //    columns: table => new
            //    {
            //        CustomUserId = table.Column<int>(nullable: false),
            //        PastDataAllowedFrom = table.Column<DateTime>(type: "date", nullable: true),
            //        PastDataAllowedFor = table.Column<int>(nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        RefId = table.Column<string>(maxLength: 3000, nullable: true),
            //        PIN = table.Column<string>(maxLength: 512, nullable: true),
            //        PINSalt = table.Column<string>(maxLength: 512, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserDetails", x => x.CustomUserId);
            //        table.ForeignKey(
            //            name: "FK_UserDetails_Users",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_UserDetails_Users1",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserDevices",
            //    columns: table => new
            //    {
            //        CustomUserId = table.Column<int>(nullable: false),
            //        DeviceId = table.Column<string>(maxLength: 100, nullable: false),
            //        Status = table.Column<bool>(nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        DSStatus = table.Column<byte>(nullable: true, defaultValueSql: "((0))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserDevices", x => new { x.CustomUserId, x.DeviceId });
            //        table.ForeignKey(
            //            name: "FK_UserDevices_Users",
            //            column: x => x.CustomUserId,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserDSDetails",
            //    columns: table => new
            //    {
            //        CustomUserId = table.Column<int>(nullable: false),
            //        IdentityNumber = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        IdType = table.Column<byte>(nullable: false),
            //        IdentityStatusComment = table.Column<string>(maxLength: 255, nullable: true),
            //        CertificateExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CertificateStatus = table.Column<byte>(nullable: true),
            //        SecretWord = table.Column<string>(maxLength: 255, nullable: true),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Country = table.Column<string>(maxLength: 250, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserDSDetails", x => x.CustomUserId);
            //        table.ForeignKey(
            //            name: "FK_UserDSDetails_Users",
            //            column: x => x.CustomUserId,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "StakeHolderFlows",
            //    schema: "PreBoard",
            //    columns: table => new
            //    {
            //        SHFlowId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        SHFlowName = table.Column<string>(maxLength: 100, nullable: true),
            //        Description = table.Column<string>(maxLength: 256, nullable: true),
            //        PrevFlowId = table.Column<int>(nullable: true),
            //        RefFlowId = table.Column<int>(nullable: true),
            //        Permissions = table.Column<string>(maxLength: 200, nullable: true),
            //        ShowInView = table.Column<bool>(nullable: false),
            //        AllowMultipleUsers = table.Column<bool>(nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_StakeHolderFlows", x => x.SHFlowId);
            //        table.ForeignKey(
            //            name: "FK_StakeHolderFlows_Users",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_StakeHolderFlows_Users1",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_StakeHolderFlows_StakeHolderFlows",
            //            column: x => x.PrevFlowId,
            //            principalSchema: "PreBoard",
            //            principalTable: "StakeHolderFlows",
            //            principalColumn: "SHFlowId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CommentAccesses",
            //    columns: table => new
            //    {
            //        CommentId = table.Column<int>(nullable: false),
            //        CustomUserId = table.Column<int>(nullable: false),
            //        isViewed = table.Column<bool>(nullable: false),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CommentAccesses", x => new { x.CommentId, x.CustomUserId });
            //        table.ForeignKey(
            //            name: "FK_CommentViews_Comments",
            //            column: x => x.CommentId,
            //            principalTable: "Comments",
            //            principalColumn: "CommentId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_CommentViews_Users",
            //            column: x => x.CustomUserId,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Headings",
            //    columns: table => new
            //    {
            //        HeadingId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        PreviousHeadingId = table.Column<int>(nullable: true),
            //        Description = table.Column<string>(maxLength: 255, nullable: false),
            //        MeetingId = table.Column<int>(nullable: false),
            //        Timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        AgendaOrder = table.Column<int>(nullable: false),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        IsRestricted = table.Column<byte>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Headings", x => x.HeadingId);
            //        table.ForeignKey(
            //            name: "FK_Headings_Meetings",
            //            column: x => x.MeetingId,
            //            principalTable: "Meetings",
            //            principalColumn: "MeetingId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Headings_PreviousHeadings",
            //            column: x => x.PreviousHeadingId,
            //            principalTable: "Headings",
            //            principalColumn: "HeadingId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "MeetingPresences",
            //    columns: table => new
            //    {
            //        MeetingId = table.Column<int>(nullable: false),
            //        CustomUserId = table.Column<int>(nullable: false),
            //        IsPresent = table.Column<byte>(nullable: false),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        IsAttending = table.Column<byte>(nullable: false),
            //        MeetingNote = table.Column<string>(nullable: true),
            //        AttendenceReason = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_MeetingPresences", x => new { x.MeetingId, x.CustomUserId });
            //        table.ForeignKey(
            //            name: "FK_MeetingPresences_Users",
            //            column: x => x.CustomUserId,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_MeetingPresences_Meetings",
            //            column: x => x.MeetingId,
            //            principalTable: "Meetings",
            //            principalColumn: "MeetingId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Documents",
            //    schema: "PreBoard",
            //    columns: table => new
            //    {
            //        DocumentId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        MeetingId = table.Column<int>(nullable: false),
            //        WorkflowId = table.Column<Guid>(nullable: false),
            //        WorkflowType = table.Column<byte>(nullable: false),
            //        DocumentName = table.Column<string>(maxLength: 500, nullable: false),
            //        Description = table.Column<string>(maxLength: 500, nullable: true),
            //        Keywords = table.Column<string>(maxLength: 500, nullable: true),
            //        PBDocType = table.Column<byte>(nullable: false),
            //        ParentDocId = table.Column<int>(nullable: true),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        IsDeleted = table.Column<bool>(nullable: false),
            //        DocumentFrom = table.Column<string>(maxLength: 250, nullable: true),
            //        DocumentTo = table.Column<string>(maxLength: 250, nullable: true),
            //        DocumentSubject = table.Column<string>(maxLength: 250, nullable: true),
            //        DocumentRefNo = table.Column<string>(maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Documents", x => x.DocumentId);
            //        table.ForeignKey(
            //            name: "FK_Documents_Users",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Documents_Meetings",
            //            column: x => x.MeetingId,
            //            principalTable: "Meetings",
            //            principalColumn: "MeetingId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Documents_Users1",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AlternativeFlows",
            //    schema: "PreBoard",
            //    columns: table => new
            //    {
            //        FlowId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        FlowName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
            //        CurrentFlow = table.Column<int>(nullable: false),
            //        CurrentOrder = table.Column<int>(nullable: true),
            //        NextFlow = table.Column<int>(nullable: false),
            //        NextOrder = table.Column<int>(nullable: true),
            //        CreateNewVersion = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AlternativeFlows", x => x.FlowId);
            //        table.ForeignKey(
            //            name: "FK_AlternativeFlows_StakeHolderFlows",
            //            column: x => x.CurrentFlow,
            //            principalSchema: "PreBoard",
            //            principalTable: "StakeHolderFlows",
            //            principalColumn: "SHFlowId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_AlternativeFlows_StakeHolderFlows1",
            //            column: x => x.NextFlow,
            //            principalSchema: "PreBoard",
            //            principalTable: "StakeHolderFlows",
            //            principalColumn: "SHFlowId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HeadingAccesses",
            //    columns: table => new
            //    {
            //        HeadingId = table.Column<int>(nullable: false),
            //        CustomUserId = table.Column<int>(nullable: false),
            //        IsAllowed = table.Column<byte>(nullable: false, defaultValueSql: "((1))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_HeadingAccesses", x => new { x.HeadingId, x.CustomUserId });
            //        table.ForeignKey(
            //            name: "FK_HeadingAccesses_Users",
            //            column: x => x.CustomUserId,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_HeadingAccesses_Headings",
            //            column: x => x.HeadingId,
            //            principalTable: "Headings",
            //            principalColumn: "HeadingId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Papers",
            //    columns: table => new
            //    {
            //        PaperId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(maxLength: 500, nullable: false),
            //        DocType = table.Column<byte>(nullable: false),
            //        HeadingId = table.Column<int>(nullable: true),
            //        Description = table.Column<string>(maxLength: 500, nullable: true),
            //        PaperRefNo = table.Column<string>(maxLength: 50, nullable: true),
            //        PaperStatus = table.Column<byte>(nullable: true),
            //        PaperColor = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
            //        VersionId = table.Column<int>(nullable: false),
            //        AgendaOrder = table.Column<int>(nullable: false),
            //        IsCarryFWDfromLastMeeting = table.Column<bool>(nullable: false),
            //        CarryFWDinfo = table.Column<string>(maxLength: 255, nullable: true),
            //        StatusComment = table.Column<string>(maxLength: 500, nullable: true),
            //        Keyword = table.Column<string>(nullable: true),
            //        IsDeleted = table.Column<bool>(nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        AdditionalRefId = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        ScrollDirection = table.Column<byte>(nullable: true),
            //        IsPwdProtected = table.Column<bool>(nullable: false),
            //        IsRestricted = table.Column<byte>(nullable: false),
            //        VersionInfo = table.Column<byte>(nullable: false, defaultValueSql: "((214))"),
            //        IsDigitallySignable = table.Column<byte>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Papers", x => x.PaperId);
            //        table.ForeignKey(
            //            name: "FK_Papers_Headings",
            //            column: x => x.HeadingId,
            //            principalTable: "Headings",
            //            principalColumn: "HeadingId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Papers_DocVersions",
            //            column: x => x.VersionId,
            //            principalTable: "DocVersions",
            //            principalColumn: "VersionId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PBDocVersions",
            //    schema: "PreBoard",
            //    columns: table => new
            //    {
            //        VersionId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        DocumentId = table.Column<int>(nullable: false),
            //        Content = table.Column<string>(nullable: true),
            //        FinalizedDoc = table.Column<byte[]>(nullable: true),
            //        DocStatus = table.Column<byte>(nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PBDocVersions", x => x.VersionId);
            //        table.ForeignKey(
            //            name: "FK_PBDocVersions_Users",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_PBDocVersions_DocumentStatuses",
            //            column: x => x.DocStatus,
            //            principalSchema: "PreBoard",
            //            principalTable: "DocumentStatuses",
            //            principalColumn: "DocumentStatusId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_PBDocVersions_Documents",
            //            column: x => x.DocumentId,
            //            principalSchema: "PreBoard",
            //            principalTable: "Documents",
            //            principalColumn: "DocumentId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_PBDocVersions_Users1",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AgendaDetails",
            //    columns: table => new
            //    {
            //        PaperId = table.Column<int>(nullable: false),
            //        PresenterName = table.Column<string>(maxLength: 100, nullable: true),
            //        PresenterEmail = table.Column<string>(maxLength: 100, nullable: true),
            //        StartTime = table.Column<TimeSpan>(nullable: true),
            //        EndTime = table.Column<TimeSpan>(nullable: true),
            //        IsCompleted = table.Column<bool>(nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AgendaDetails", x => x.PaperId);
            //        table.ForeignKey(
            //            name: "FK_AgendaDetails_Users",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_AgendaDetails_Users1",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_AgendaDetails_Papers",
            //            column: x => x.PaperId,
            //            principalTable: "Papers",
            //            principalColumn: "PaperId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AnnotationShares",
            //    columns: table => new
            //    {
            //        AnnotationShareId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        CustomUserId = table.Column<int>(nullable: false),
            //        PaperId = table.Column<int>(nullable: false),
            //        VersionId = table.Column<int>(nullable: false),
            //        FilePath = table.Column<string>(unicode: false, nullable: false),
            //        iPadUniqueID = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        IsBackup = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AnnotationShares", x => x.AnnotationShareId);
            //        table.ForeignKey(
            //            name: "FK_AnnotationShares_Users1",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_AnnotationShares_Users",
            //            column: x => x.CustomUserId,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_AnnotationShares_Users2",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_AnnotationShares_Papers",
            //            column: x => x.PaperId,
            //            principalTable: "Papers",
            //            principalColumn: "PaperId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_AnnotationShares_DocVersions",
            //            column: x => x.VersionId,
            //            principalTable: "DocVersions",
            //            principalColumn: "VersionId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PaperDecisionViews",
            //    columns: table => new
            //    {
            //        PaperId = table.Column<int>(nullable: false),
            //        CustomUserId = table.Column<int>(nullable: false),
            //        DecisionStatus = table.Column<byte>(nullable: false),
            //        NotificationStatus = table.Column<byte>(nullable: false),
            //        NotificationDescription = table.Column<string>(maxLength: 255, nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false),
            //        ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ApprovalComment = table.Column<string>(maxLength: 500, nullable: true),
            //        IsAllowed = table.Column<byte>(nullable: false, defaultValueSql: "((1))"),
            //        IsAllowDigitalSign = table.Column<byte>(nullable: false),
            //        DSApprovalStatus = table.Column<byte>(nullable: false),
            //        DSPrivateComment = table.Column<string>(unicode: false, nullable: true),
            //        DSPublicComment = table.Column<string>(unicode: false, nullable: true),
            //        DSApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ViewedDate = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PaperDecisionViews", x => new { x.PaperId, x.CustomUserId });
            //        table.ForeignKey(
            //            name: "FK_PaperDecisionViews_Users",
            //            column: x => x.CustomUserId,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_PaperDecisionViews_Papers",
            //            column: x => x.PaperId,
            //            principalTable: "Papers",
            //            principalColumn: "PaperId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PaperKeywordTags",
            //    columns: table => new
            //    {
            //        PaperId = table.Column<int>(nullable: false),
            //        KeywordId = table.Column<int>(nullable: false),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PaperKeywordTags", x => new { x.PaperId, x.KeywordId });
            //        table.ForeignKey(
            //            name: "FK_PaperKeywordTags_Keywords",
            //            column: x => x.KeywordId,
            //            principalTable: "Keywords",
            //            principalColumn: "KeywordId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_PaperKeywordTags_Papers",
            //            column: x => x.PaperId,
            //            principalTable: "Papers",
            //            principalColumn: "PaperId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DocFlowStakeHolders",
            //    schema: "PreBoard",
            //    columns: table => new
            //    {
            //        DocFlowStakeHolderId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        StakeHolderId = table.Column<int>(nullable: false),
            //        VersionId = table.Column<int>(nullable: false),
            //        SHFlowId = table.Column<int>(nullable: false),
            //        SHFlowPath = table.Column<int>(nullable: false),
            //        UserDocStatus = table.Column<byte>(nullable: false),
            //        IsRead = table.Column<bool>(nullable: false),
            //        SHOrder = table.Column<int>(nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DocFlowStakeHolders", x => x.DocFlowStakeHolderId);
            //        table.ForeignKey(
            //            name: "FK_DocFlowStakeHolders_Users1",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DocFlowStakeHolders_Users2",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DocFlowStakeHolders_StakeHolderFlows",
            //            column: x => x.SHFlowId,
            //            principalSchema: "PreBoard",
            //            principalTable: "StakeHolderFlows",
            //            principalColumn: "SHFlowId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DocFlowStakeHolders_Users",
            //            column: x => x.StakeHolderId,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DocFlowStakeHolders_PBDocVersions",
            //            column: x => x.VersionId,
            //            principalSchema: "PreBoard",
            //            principalTable: "PBDocVersions",
            //            principalColumn: "VersionId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AnnotationAccesses",
            //    columns: table => new
            //    {
            //        AnnotationShareId = table.Column<int>(nullable: false),
            //        CustomUserId = table.Column<int>(nullable: false),
            //        IsDownloaded = table.Column<bool>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AnnotationAccesses", x => new { x.AnnotationShareId, x.CustomUserId });
            //        table.ForeignKey(
            //            name: "FK_AnnotationAccesses_AnnotationShares",
            //            column: x => x.AnnotationShareId,
            //            principalTable: "AnnotationShares",
            //            principalColumn: "AnnotationShareId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_AnnotationAccesses_Users",
            //            column: x => x.CustomUserId,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DocFlowNonStakeHolders",
            //    schema: "PreBoard",
            //    columns: table => new
            //    {
            //        DocFlowNonStakeHolderId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        DocFlowStakeHolderId = table.Column<int>(nullable: false),
            //        NonStakeHolderId = table.Column<int>(nullable: false),
            //        StakeHolderRequest = table.Column<string>(nullable: true),
            //        Response = table.Column<string>(nullable: true),
            //        ResponseDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Status = table.Column<byte>(nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedByDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DocFlowNonStakeHolders", x => x.DocFlowNonStakeHolderId);
            //        table.ForeignKey(
            //            name: "FK_DocFlowNonStakeHolders_Users",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DocFlowNonStakeHolders_DocFlowNonStakeHolders",
            //            column: x => x.DocFlowStakeHolderId,
            //            principalSchema: "PreBoard",
            //            principalTable: "DocFlowStakeHolders",
            //            principalColumn: "DocFlowStakeHolderId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DocFlowNonStakeHolders_Users1",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DocFlowNonStakeHolders_Users2",
            //            column: x => x.NonStakeHolderId,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DocFlowSHComments",
            //    schema: "PreBoard",
            //    columns: table => new
            //    {
            //        CommentId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Comment = table.Column<string>(nullable: true),
            //        DocFlowStakeHolderId = table.Column<int>(nullable: false),
            //        IsCommentPublish = table.Column<bool>(nullable: false),
            //        CreatedBy = table.Column<int>(nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ModifiedBy = table.Column<int>(nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Info1 = table.Column<string>(maxLength: 500, nullable: true),
            //        Info2 = table.Column<string>(maxLength: 250, nullable: true),
            //        Info3 = table.Column<int>(nullable: true),
            //        TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DocFlowSHComments", x => x.CommentId);
            //        table.ForeignKey(
            //            name: "FK_DocFlowSHComments_Users",
            //            column: x => x.CreatedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DocFlowSHComments_DocFlowStakeHolders",
            //            column: x => x.DocFlowStakeHolderId,
            //            principalSchema: "PreBoard",
            //            principalTable: "DocFlowStakeHolders",
            //            principalColumn: "DocFlowStakeHolderId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DocFlowSHComments_Users1",
            //            column: x => x.ModifiedBy,
            //            principalTable: "Users",
            //            principalColumn: "CustomUserId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Accesses_CustomUserId",
            //    table: "Accesses",
            //    column: "CustomUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Accesses_RoleId",
            //    table: "Accesses",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AgendaDetails_CreatedBy",
            //    table: "AgendaDetails",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AgendaDetails_ModifiedBy",
            //    table: "AgendaDetails",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AgendaTemplates_CreatedBy",
            //    table: "AgendaTemplates",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AgendaTemplates_ModifiedBy",
            //    table: "AgendaTemplates",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AnnotationAccesses_CustomUserId",
            //    table: "AnnotationAccesses",
            //    column: "CustomUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AnnotationShares_CreatedBy",
            //    table: "AnnotationShares",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AnnotationShares_CustomUserId",
            //    table: "AnnotationShares",
            //    column: "CustomUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AnnotationShares_ModifiedBy",
            //    table: "AnnotationShares",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AnnotationShares_PaperId",
            //    table: "AnnotationShares",
            //    column: "PaperId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AnnotationShares_VersionId",
            //    table: "AnnotationShares",
            //    column: "VersionId");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__aspnet_A__309103310EA330E9",
            //    table: "aspnet_Applications",
            //    column: "ApplicationName",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "aspnet_Applications_Index",
            //    table: "aspnet_Applications",
            //    column: "LoweredApplicationName")
            //    .Annotation("SqlServer:Clustered", true);

            //migrationBuilder.CreateIndex(
            //    name: "aspnet_Membership_index",
            //    table: "aspnet_Membership",
            //    columns: new[] { "ApplicationId", "LoweredEmail" })
            //    .Annotation("SqlServer:Clustered", true);

            //migrationBuilder.CreateIndex(
            //    name: "aspnet_Paths_index",
            //    table: "aspnet_Paths",
            //    columns: new[] { "ApplicationId", "LoweredPath" },
            //    unique: true)
            //    .Annotation("SqlServer:Clustered", true);

            //migrationBuilder.CreateIndex(
            //    name: "aspnet_PersonalizationPerUser_index1",
            //    table: "aspnet_PersonalizationPerUser",
            //    columns: new[] { "PathId", "UserId" },
            //    unique: true)
            //    .Annotation("SqlServer:Clustered", true);

            //migrationBuilder.CreateIndex(
            //    name: "aspnet_PersonalizationPerUser_ncindex2",
            //    table: "aspnet_PersonalizationPerUser",
            //    columns: new[] { "UserId", "PathId" },
            //    unique: true,
            //    filter: "[UserId] IS NOT NULL AND [PathId] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "aspnet_Roles_index1",
            //    table: "aspnet_Roles",
            //    columns: new[] { "ApplicationId", "LoweredRoleName" },
            //    unique: true)
            //    .Annotation("SqlServer:Clustered", true);

            //migrationBuilder.CreateIndex(
            //    name: "aspnet_Users_Index2",
            //    table: "aspnet_Users",
            //    columns: new[] { "ApplicationId", "LastActivityDate" });

            //migrationBuilder.CreateIndex(
            //    name: "aspnet_Users_Index",
            //    table: "aspnet_Users",
            //    columns: new[] { "ApplicationId", "LoweredUserName" },
            //    unique: true)
            //    .Annotation("SqlServer:Clustered", true);

            //migrationBuilder.CreateIndex(
            //    name: "aspnet_UsersInRoles_index",
            //    table: "aspnet_UsersInRoles",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetRoleClaims_RoleId",
            //    table: "AspNetRoleClaims",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "RoleNameIndex",
            //    table: "AspNetRoles",
            //    column: "NormalizedName",
            //    unique: true,
            //    filter: "([NormalizedName] IS NOT NULL)");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserClaims_UserId",
            //    table: "AspNetUserClaims",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserLogins_UserId",
            //    table: "AspNetUserLogins",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserRoles_RoleId",
            //    table: "AspNetUserRoles",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "EmailIndex",
            //    table: "AspNetUsers",
            //    column: "NormalizedEmail");

            //migrationBuilder.CreateIndex(
            //    name: "UserNameIndex",
            //    table: "AspNetUsers",
            //    column: "NormalizedUserName",
            //    unique: true,
            //    filter: "([NormalizedUserName] IS NOT NULL)");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CommentAccesses_CustomUserId",
            //    table: "CommentAccesses",
            //    column: "CustomUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Comments_CreatedBy",
            //    table: "Comments",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Comments_ModifiedBy",
            //    table: "Comments",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocVersions_CreatedBy",
            //    table: "DocVersions",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocVersions_ModifiedBy",
            //    table: "DocVersions",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocVersions_PreviousVersionId",
            //    table: "DocVersions",
            //    column: "PreviousVersionId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_FileStructures_CreatedDate",
            //    table: "FileStructures",
            //    column: "CreatedDate");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Table_CustomUserId",
            //    table: "HeadingAccesses",
            //    column: "CustomUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Headings_MeetingId",
            //    table: "Headings",
            //    column: "MeetingId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Headings_PreviousHeadingId",
            //    table: "Headings",
            //    column: "PreviousHeadingId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MeetingPresences_CustomUserId",
            //    table: "MeetingPresences",
            //    column: "CustomUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Meetings_CreatedBy",
            //    table: "Meetings",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Meetings_ModifiedBy",
            //    table: "Meetings",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Meetings_OrganizerId",
            //    table: "Meetings",
            //    column: "OrganizerId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Meetings_SubCategoryId",
            //    table: "Meetings",
            //    column: "SubCategoryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PaperDecisionViews_CustomUserId",
            //    table: "PaperDecisionViews",
            //    column: "CustomUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PaperDecisionViews_CI",
            //    table: "PaperDecisionViews",
            //    columns: new[] { "PaperId", "CustomUserId", "DecisionStatus", "NotificationStatus", "ApprovalComment", "TimeStamp", "IsAllowed" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_PaperKeywordTags_KeywordId",
            //    table: "PaperKeywordTags",
            //    column: "KeywordId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Papers_HeadingId",
            //    table: "Papers",
            //    column: "HeadingId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Papers_VersionId",
            //    table: "Papers",
            //    column: "VersionId");

            //migrationBuilder.CreateIndex(
            //    name: "UNQ_Key_ProductSettings",
            //    table: "ProductSettings",
            //    column: "Key",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductSettings_ModifiedBy",
            //    table: "ProductSettings",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Salutati__ED1ECA726CA31EA0",
            //    table: "Salutations",
            //    column: "Salutation",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_SPDocs_CreatedBy",
            //    table: "SPDocs",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SPDocs_ModifiedBy",
            //    table: "SPDocs",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SPDocs_SubCategoryId",
            //    table: "SPDocs",
            //    column: "SubCategoryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SubCategories_CategoryId",
            //    table: "SubCategories",
            //    column: "CategoryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserDetails_CreatedBy",
            //    table: "UserDetails",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserDetails_ModifiedBy",
            //    table: "UserDetails",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_CreatedBy",
            //    table: "Users",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_ModifiedBy",
            //    table: "Users",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_UserId",
            //    table: "Users",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AlternativeFlows_CurrentFlow",
            //    schema: "PreBoard",
            //    table: "AlternativeFlows",
            //    column: "CurrentFlow");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AlternativeFlows_NextFlow",
            //    schema: "PreBoard",
            //    table: "AlternativeFlows",
            //    column: "NextFlow");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocFlowNonStakeHolders_CreatedBy",
            //    schema: "PreBoard",
            //    table: "DocFlowNonStakeHolders",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocFlowNonStakeHolders_DocFlowStakeHolderId",
            //    schema: "PreBoard",
            //    table: "DocFlowNonStakeHolders",
            //    column: "DocFlowStakeHolderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocFlowNonStakeHolders_ModifiedBy",
            //    schema: "PreBoard",
            //    table: "DocFlowNonStakeHolders",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocFlowNonStakeHolders_NonStakeHolderId",
            //    schema: "PreBoard",
            //    table: "DocFlowNonStakeHolders",
            //    column: "NonStakeHolderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocFlowSHComments_CreatedBy",
            //    schema: "PreBoard",
            //    table: "DocFlowSHComments",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocFlowSHComments_DocFlowStakeHolderId",
            //    schema: "PreBoard",
            //    table: "DocFlowSHComments",
            //    column: "DocFlowStakeHolderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocFlowSHComments_ModifiedBy",
            //    schema: "PreBoard",
            //    table: "DocFlowSHComments",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocFlowStakeHolders_CreatedBy",
            //    schema: "PreBoard",
            //    table: "DocFlowStakeHolders",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocFlowStakeHolders_ModifiedBy",
            //    schema: "PreBoard",
            //    table: "DocFlowStakeHolders",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocFlowStakeHolders_SHFlowId",
            //    schema: "PreBoard",
            //    table: "DocFlowStakeHolders",
            //    column: "SHFlowId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocFlowStakeHolders_StakeHolderId",
            //    schema: "PreBoard",
            //    table: "DocFlowStakeHolders",
            //    column: "StakeHolderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DocFlowStakeHolders_VersionId",
            //    schema: "PreBoard",
            //    table: "DocFlowStakeHolders",
            //    column: "VersionId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Documents_CreatedBy",
            //    schema: "PreBoard",
            //    table: "Documents",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Documents_MeetingId",
            //    schema: "PreBoard",
            //    table: "Documents",
            //    column: "MeetingId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Documents_ModifiedBy",
            //    schema: "PreBoard",
            //    table: "Documents",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PBDocVersions_CreatedBy",
            //    schema: "PreBoard",
            //    table: "PBDocVersions",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PBDocVersions_DocStatus",
            //    schema: "PreBoard",
            //    table: "PBDocVersions",
            //    column: "DocStatus");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PBDocVersions_DocumentId",
            //    schema: "PreBoard",
            //    table: "PBDocVersions",
            //    column: "DocumentId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PBDocVersions_ModifiedBy",
            //    schema: "PreBoard",
            //    table: "PBDocVersions",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StakeHolderFlows_CreatedBy",
            //    schema: "PreBoard",
            //    table: "StakeHolderFlows",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StakeHolderFlows_ModifiedBy",
            //    schema: "PreBoard",
            //    table: "StakeHolderFlows",
            //    column: "ModifiedBy");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StakeHolderFlows_PrevFlowId",
            //    schema: "PreBoard",
            //    table: "StakeHolderFlows",
            //    column: "PrevFlowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accesses");

            migrationBuilder.DropTable(
                name: "AgendaDetails");

            migrationBuilder.DropTable(
                name: "AgendaTemplates");

            migrationBuilder.DropTable(
                name: "AnnotationAccesses");

            migrationBuilder.DropTable(
                name: "ArchivedAuditLogs");

            migrationBuilder.DropTable(
                name: "aspnet_Membership");

            migrationBuilder.DropTable(
                name: "aspnet_PersonalizationAllUsers");

            migrationBuilder.DropTable(
                name: "aspnet_PersonalizationPerUser");

            migrationBuilder.DropTable(
                name: "aspnet_Profile");

            migrationBuilder.DropTable(
                name: "aspnet_SchemaVersions");

            migrationBuilder.DropTable(
                name: "aspnet_UsersInRoles");

            migrationBuilder.DropTable(
                name: "aspnet_WebEvent_Events");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "CommentAccesses");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "DigitalSignatureLogs");

            migrationBuilder.DropTable(
                name: "FileStructures");

            migrationBuilder.DropTable(
                name: "HeadingAccesses");

            migrationBuilder.DropTable(
                name: "iPadDBs");

            migrationBuilder.DropTable(
                name: "MeetingPresences");

            migrationBuilder.DropTable(
                name: "MeetingTemplates");

            migrationBuilder.DropTable(
                name: "PaperDecisionViews");

            migrationBuilder.DropTable(
                name: "PaperKeywordTags");

            migrationBuilder.DropTable(
                name: "PasswordHistory");

            migrationBuilder.DropTable(
                name: "ProductSettings");

            migrationBuilder.DropTable(
                name: "Salutations");

            migrationBuilder.DropTable(
                name: "SPDocs");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "UserDevices");

            migrationBuilder.DropTable(
                name: "UserDSDetails");

            migrationBuilder.DropTable(
                name: "AlternativeFlows",
                schema: "PreBoard");

            migrationBuilder.DropTable(
                name: "ArchivedPBAuditLogs",
                schema: "PreBoard");

            migrationBuilder.DropTable(
                name: "DocFlowNonStakeHolders",
                schema: "PreBoard");

            migrationBuilder.DropTable(
                name: "DocFlowSHComments",
                schema: "PreBoard");

            migrationBuilder.DropTable(
                name: "PBAuditLogs",
                schema: "PreBoard");

            migrationBuilder.DropTable(
                name: "TrackingEvents",
                schema: "PreBoard");

            migrationBuilder.DropTable(
                name: "AnnotationShares");

            migrationBuilder.DropTable(
                name: "aspnet_Paths");

            migrationBuilder.DropTable(
                name: "aspnet_Roles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropTable(
                name: "DocFlowStakeHolders",
                schema: "PreBoard");

            migrationBuilder.DropTable(
                name: "Papers");

            migrationBuilder.DropTable(
                name: "StakeHolderFlows",
                schema: "PreBoard");

            migrationBuilder.DropTable(
                name: "PBDocVersions",
                schema: "PreBoard");

            migrationBuilder.DropTable(
                name: "Headings");

            migrationBuilder.DropTable(
                name: "DocVersions");

            migrationBuilder.DropTable(
                name: "DocumentStatuses",
                schema: "PreBoard");

            migrationBuilder.DropTable(
                name: "Documents",
                schema: "PreBoard");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "aspnet_Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "aspnet_Applications");
        }
    }
}
