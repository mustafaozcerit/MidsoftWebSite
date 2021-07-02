using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MİdsoftWebSite.Models;

#nullable disable

namespace MİdsoftWebSite.Data
{
    public partial class MidosftWebSiteDbContext : DbContext
    {
        public MidosftWebSiteDbContext()
        {
        }

        public MidosftWebSiteDbContext(DbContextOptions<MidosftWebSiteDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutU> AboutUs { get; set; }
        public virtual DbSet<Analysis> Analyses { get; set; }
        public virtual DbSet<AuditDataItemPersistent> AuditDataItemPersistents { get; set; }
        public virtual DbSet<AuditedObjectWeakReference> AuditedObjectWeakReferences { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<DashboardDatum> DashboardData { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<FileDatum> FileData { get; set; }
        public virtual DbSet<Hcategory> Hcategories { get; set; }
        public virtual DbSet<HomePage> HomePages { get; set; }
        public virtual DbSet<KpiDefinition> KpiDefinitions { get; set; }
        public virtual DbSet<KpiHistoryItem> KpiHistoryItems { get; set; }
        public virtual DbSet<KpiInstance> KpiInstances { get; set; }
        public virtual DbSet<KpiScorecard> KpiScorecards { get; set; }
        public virtual DbSet<KpiScorecardScorecardsKpiInstanceIndicator> KpiScorecardScorecardsKpiInstanceIndicators { get; set; }
        public virtual DbSet<MidsoftLogo> MidsoftLogos { get; set; }
        public virtual DbSet<ModelDifference> ModelDifferences { get; set; }
        public virtual DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
        public virtual DbSet<PermissionPolicyMemberPermissionsObject> PermissionPolicyMemberPermissionsObjects { get; set; }
        public virtual DbSet<PermissionPolicyNavigationPermissionsObject> PermissionPolicyNavigationPermissionsObjects { get; set; }
        public virtual DbSet<PermissionPolicyObjectPermissionsObject> PermissionPolicyObjectPermissionsObjects { get; set; }
        public virtual DbSet<PermissionPolicyRole> PermissionPolicyRoles { get; set; }
        public virtual DbSet<PermissionPolicyTypePermissionsObject> PermissionPolicyTypePermissionsObjects { get; set; }
        public virtual DbSet<PermissionPolicyUser> PermissionPolicyUsers { get; set; }
        public virtual DbSet<PermissionPolicyUserUsersPermissionPolicyRoleRole> PermissionPolicyUserUsersPermissionPolicyRoleRoles { get; set; }
        public virtual DbSet<Privacy> Privacies { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<Referance> Referances { get; set; }
        public virtual DbSet<ReportDataV2> ReportDataV2s { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<ResourceResourcesEventEvent> ResourceResourcesEventEvents { get; set; }
        public virtual DbSet<SocialMedium> SocialMedia { get; set; }
        public virtual DbSet<XpoInstanceKey> XpoInstanceKeys { get; set; }
        public virtual DbSet<XpoRunningWorkflowInstanceInfo> XpoRunningWorkflowInstanceInfos { get; set; }
        public virtual DbSet<XpoStartWorkflowRequest> XpoStartWorkflowRequests { get; set; }
        public virtual DbSet<XpoState> XpoStates { get; set; }
        public virtual DbSet<XpoStateAppearance> XpoStateAppearances { get; set; }
        public virtual DbSet<XpoStateMachine> XpoStateMachines { get; set; }
        public virtual DbSet<XpoTrackingRecord> XpoTrackingRecords { get; set; }
        public virtual DbSet<XpoTransition> XpoTransitions { get; set; }
        public virtual DbSet<XpoUserActivityVersion> XpoUserActivityVersions { get; set; }
        public virtual DbSet<XpoWorkflowDefinition> XpoWorkflowDefinitions { get; set; }
        public virtual DbSet<XpoWorkflowInstance> XpoWorkflowInstances { get; set; }
        public virtual DbSet<XpoWorkflowInstanceControlCommandRequest> XpoWorkflowInstanceControlCommandRequests { get; set; }
        public virtual DbSet<XpobjectType> XpobjectTypes { get; set; }
        public virtual DbSet<XpweakReference> XpweakReferences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.0.77;Database=MidsoftWebSite;User=sa;Password=Root64;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AboutU>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_AboutUs");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<Analysis>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Analysis");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_Analysis");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<AuditDataItemPersistent>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("AuditDataItemPersistent");

                entity.HasIndex(e => e.AuditedObject, "iAuditedObject_AuditDataItemPersistent");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_AuditDataItemPersistent");

                entity.HasIndex(e => e.ModifiedOn, "iModifiedOn_AuditDataItemPersistent");

                entity.HasIndex(e => e.NewObject, "iNewObject_AuditDataItemPersistent");

                entity.HasIndex(e => e.OldObject, "iOldObject_AuditDataItemPersistent");

                entity.HasIndex(e => e.OperationType, "iOperationType_AuditDataItemPersistent");

                entity.HasIndex(e => e.UserName, "iUserName_AuditDataItemPersistent");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(2048);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NewValue).HasMaxLength(1024);

                entity.Property(e => e.OldValue).HasMaxLength(1024);

                entity.Property(e => e.OperationType).HasMaxLength(100);

                entity.Property(e => e.PropertyName).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.AuditedObjectNavigation)
                    .WithMany(p => p.AuditDataItemPersistents)
                    .HasForeignKey(d => d.AuditedObject)
                    .HasConstraintName("FK_AuditDataItemPersistent_AuditedObject");

                entity.HasOne(d => d.NewObjectNavigation)
                    .WithMany(p => p.AuditDataItemPersistentNewObjectNavigations)
                    .HasForeignKey(d => d.NewObject)
                    .HasConstraintName("FK_AuditDataItemPersistent_NewObject");

                entity.HasOne(d => d.OldObjectNavigation)
                    .WithMany(p => p.AuditDataItemPersistentOldObjectNavigations)
                    .HasForeignKey(d => d.OldObject)
                    .HasConstraintName("FK_AuditDataItemPersistent_OldObject");
            });

            modelBuilder.Entity<AuditedObjectWeakReference>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("AuditedObjectWeakReference");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DisplayName).HasMaxLength(250);

                entity.HasOne(d => d.OidNavigation)
                    .WithOne(p => p.AuditedObjectWeakReference)
                    .HasForeignKey<AuditedObjectWeakReference>(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuditedObjectWeakReference_Oid");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Contact");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_Contact");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Konum).HasMaxLength(500);

                entity.Property(e => e.Mail).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(500);
            });

            modelBuilder.Entity<DashboardDatum>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_DashboardData");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Event");

                entity.HasIndex(e => e.EndOn, "iEndOn_Event");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_Event");

                entity.HasIndex(e => e.RecurrencePattern, "iRecurrencePattern_Event");

                entity.HasIndex(e => e.StartOn, "iStartOn_Event");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AlarmTime).HasColumnType("datetime");

                entity.Property(e => e.EndOn).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.ReminderInfoXml).HasMaxLength(200);

                entity.Property(e => e.StartOn).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(250);

                entity.HasOne(d => d.RecurrencePatternNavigation)
                    .WithMany(p => p.InverseRecurrencePatternNavigation)
                    .HasForeignKey(d => d.RecurrencePattern)
                    .HasConstraintName("FK_Event_RecurrencePattern");
            });

            modelBuilder.Entity<FileDatum>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_FileData");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.FileName).HasMaxLength(260);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Size).HasColumnName("size");
            });

            modelBuilder.Entity<Hcategory>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("HCategory");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_HCategory");

                entity.HasIndex(e => e.Parent, "iParent_HCategory");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ParentNavigation)
                    .WithMany(p => p.InverseParentNavigation)
                    .HasForeignKey(d => d.Parent)
                    .HasConstraintName("FK_HCategory_Parent");
            });

            modelBuilder.Entity<HomePage>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("HomePage");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_HomePage");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<KpiDefinition>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("KpiDefinition");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_KpiDefinition");

                entity.HasIndex(e => e.KpiInstance, "iKpiInstance_KpiDefinition");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Changed).HasColumnType("datetime");

                entity.Property(e => e.ChangedOn).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Range).HasMaxLength(100);

                entity.Property(e => e.RangeToCompare).HasMaxLength(100);

                entity.Property(e => e.SuppressedSeries).HasMaxLength(100);

                entity.HasOne(d => d.KpiInstanceNavigation)
                    .WithMany(p => p.KpiDefinitions)
                    .HasForeignKey(d => d.KpiInstance)
                    .HasConstraintName("FK_KpiDefinition_KpiInstance");
            });

            modelBuilder.Entity<KpiHistoryItem>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("KpiHistoryItem");

                entity.HasIndex(e => e.KpiInstance, "iKpiInstance_KpiHistoryItem");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.RangeEnd).HasColumnType("datetime");

                entity.Property(e => e.RangeStart).HasColumnType("datetime");

                entity.HasOne(d => d.KpiInstanceNavigation)
                    .WithMany(p => p.KpiHistoryItems)
                    .HasForeignKey(d => d.KpiInstance)
                    .HasConstraintName("FK_KpiHistoryItem_KpiInstance");
            });

            modelBuilder.Entity<KpiInstance>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("KpiInstance");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_KpiInstance");

                entity.HasIndex(e => e.KpiDefinition, "iKpiDefinition_KpiInstance");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.ForceMeasurementDateTime).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.KpiDefinitionNavigation)
                    .WithMany(p => p.KpiInstances)
                    .HasForeignKey(d => d.KpiDefinition)
                    .HasConstraintName("FK_KpiInstance_KpiDefinition");
            });

            modelBuilder.Entity<KpiScorecard>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("KpiScorecard");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_KpiScorecard");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<KpiScorecardScorecardsKpiInstanceIndicator>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("KpiScorecardScorecards_KpiInstanceIndicators");

                entity.HasIndex(e => new { e.Indicators, e.Scorecards }, "iIndicatorsScorecards_KpiScorecardScorecards_KpiInstanceIndicators")
                    .IsUnique();

                entity.HasIndex(e => e.Indicators, "iIndicators_KpiScorecardScorecards_KpiInstanceIndicators");

                entity.HasIndex(e => e.Scorecards, "iScorecards_KpiScorecardScorecards_KpiInstanceIndicators");

                entity.Property(e => e.Oid)
                    .ValueGeneratedNever()
                    .HasColumnName("OID");

                entity.HasOne(d => d.IndicatorsNavigation)
                    .WithMany(p => p.KpiScorecardScorecardsKpiInstanceIndicators)
                    .HasForeignKey(d => d.Indicators)
                    .HasConstraintName("FK_KpiScorecardScorecards_KpiInstanceIndicators_Indicators");

                entity.HasOne(d => d.ScorecardsNavigation)
                    .WithMany(p => p.KpiScorecardScorecardsKpiInstanceIndicators)
                    .HasForeignKey(d => d.Scorecards)
                    .HasConstraintName("FK_KpiScorecardScorecards_KpiInstanceIndicators_Scorecards");
            });

            modelBuilder.Entity<MidsoftLogo>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("MidsoftLogo");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_MidsoftLogo");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<ModelDifference>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ModelDifference");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_ModelDifference");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.ContextId).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.UserId).HasMaxLength(100);
            });

            modelBuilder.Entity<ModelDifferenceAspect>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ModelDifferenceAspect");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_ModelDifferenceAspect");

                entity.HasIndex(e => e.Owner, "iOwner_ModelDifferenceAspect");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.ModelDifferenceAspects)
                    .HasForeignKey(d => d.Owner)
                    .HasConstraintName("FK_ModelDifferenceAspect_Owner");
            });

            modelBuilder.Entity<PermissionPolicyMemberPermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PermissionPolicyMemberPermissionsObject");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_PermissionPolicyMemberPermissionsObject");

                entity.HasIndex(e => e.TypePermissionObject, "iTypePermissionObject_PermissionPolicyMemberPermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.TypePermissionObjectNavigation)
                    .WithMany(p => p.PermissionPolicyMemberPermissionsObjects)
                    .HasForeignKey(d => d.TypePermissionObject)
                    .HasConstraintName("FK_PermissionPolicyMemberPermissionsObject_TypePermissionObject");
            });

            modelBuilder.Entity<PermissionPolicyNavigationPermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PermissionPolicyNavigationPermissionsObject");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_PermissionPolicyNavigationPermissionsObject");

                entity.HasIndex(e => e.Role, "iRole_PermissionPolicyNavigationPermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.PermissionPolicyNavigationPermissionsObjects)
                    .HasForeignKey(d => d.Role)
                    .HasConstraintName("FK_PermissionPolicyNavigationPermissionsObject_Role");
            });

            modelBuilder.Entity<PermissionPolicyObjectPermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PermissionPolicyObjectPermissionsObject");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_PermissionPolicyObjectPermissionsObject");

                entity.HasIndex(e => e.TypePermissionObject, "iTypePermissionObject_PermissionPolicyObjectPermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.TypePermissionObjectNavigation)
                    .WithMany(p => p.PermissionPolicyObjectPermissionsObjects)
                    .HasForeignKey(d => d.TypePermissionObject)
                    .HasConstraintName("FK_PermissionPolicyObjectPermissionsObject_TypePermissionObject");
            });

            modelBuilder.Entity<PermissionPolicyRole>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PermissionPolicyRole");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_PermissionPolicyRole");

                entity.HasIndex(e => e.ObjectType, "iObjectType_PermissionPolicyRole");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.PermissionPolicyRoles)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_PermissionPolicyRole_ObjectType");
            });

            modelBuilder.Entity<PermissionPolicyTypePermissionsObject>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PermissionPolicyTypePermissionsObject");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_PermissionPolicyTypePermissionsObject");

                entity.HasIndex(e => e.Role, "iRole_PermissionPolicyTypePermissionsObject");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.PermissionPolicyTypePermissionsObjects)
                    .HasForeignKey(d => d.Role)
                    .HasConstraintName("FK_PermissionPolicyTypePermissionsObject_Role");
            });

            modelBuilder.Entity<PermissionPolicyUser>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PermissionPolicyUser");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_PermissionPolicyUser");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<PermissionPolicyUserUsersPermissionPolicyRoleRole>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PermissionPolicyUserUsers_PermissionPolicyRoleRoles");

                entity.HasIndex(e => new { e.Roles, e.Users }, "iRolesUsers_PermissionPolicyUserUsers_PermissionPolicyRoleRoles")
                    .IsUnique();

                entity.HasIndex(e => e.Roles, "iRoles_PermissionPolicyUserUsers_PermissionPolicyRoleRoles");

                entity.HasIndex(e => e.Users, "iUsers_PermissionPolicyUserUsers_PermissionPolicyRoleRoles");

                entity.Property(e => e.Oid)
                    .ValueGeneratedNever()
                    .HasColumnName("OID");

                entity.HasOne(d => d.RolesNavigation)
                    .WithMany(p => p.PermissionPolicyUserUsersPermissionPolicyRoleRoles)
                    .HasForeignKey(d => d.Roles)
                    .HasConstraintName("FK_PermissionPolicyUserUsers_PermissionPolicyRoleRoles_Roles");

                entity.HasOne(d => d.UsersNavigation)
                    .WithMany(p => p.PermissionPolicyUserUsersPermissionPolicyRoleRoles)
                    .HasForeignKey(d => d.Users)
                    .HasConstraintName("FK_PermissionPolicyUserUsers_PermissionPolicyRoleRoles_Users");
            });

            modelBuilder.Entity<Privacy>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Privacy");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_Privacy");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_Products");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<ProductDetail>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ProductDetail");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_ProductDetail");

                entity.HasIndex(e => e.Products1, "iProducts_ProductDetail");

                entity.HasIndex(e => e.Products, "i_products_ProductDetail");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Fotograf1).HasColumnName("fotograf1");

                entity.Property(e => e.Fotograf2).HasColumnName("fotograf2");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.PersistentProperty).HasMaxLength(100);

                entity.Property(e => e.Products).HasColumnName("_products");

                entity.Property(e => e.Products1).HasColumnName("Products");

                entity.HasOne(d => d.ProductsNavigation)
                    .WithMany(p => p.ProductDetailProductsNavigations)
                    .HasForeignKey(d => d.Products)
                    .HasConstraintName("FK_ProductDetail__products");

                entity.HasOne(d => d.Products1Navigation)
                    .WithMany(p => p.ProductDetailProducts1Navigations)
                    .HasForeignKey(d => d.Products1)
                    .HasConstraintName("FK_ProductDetail_Products");
            });

            modelBuilder.Entity<Referance>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Referance");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_Referance");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Index).HasMaxLength(500);

                entity.Property(e => e.Isim).HasMaxLength(500);
            });

            modelBuilder.Entity<ReportDataV2>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ReportDataV2");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_ReportDataV2");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ObjectTypeName).HasMaxLength(512);

                entity.Property(e => e.ParametersObjectTypeName).HasMaxLength(512);

                entity.Property(e => e.PredefinedReportType).HasMaxLength(512);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Resource");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_Resource");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<ResourceResourcesEventEvent>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ResourceResources_EventEvents");

                entity.HasIndex(e => new { e.Events, e.Resources }, "iEventsResources_ResourceResources_EventEvents")
                    .IsUnique();

                entity.HasIndex(e => e.Events, "iEvents_ResourceResources_EventEvents");

                entity.HasIndex(e => e.Resources, "iResources_ResourceResources_EventEvents");

                entity.Property(e => e.Oid)
                    .ValueGeneratedNever()
                    .HasColumnName("OID");

                entity.HasOne(d => d.EventsNavigation)
                    .WithMany(p => p.ResourceResourcesEventEvents)
                    .HasForeignKey(d => d.Events)
                    .HasConstraintName("FK_ResourceResources_EventEvents_Events");

                entity.HasOne(d => d.ResourcesNavigation)
                    .WithMany(p => p.ResourceResourcesEventEvents)
                    .HasForeignKey(d => d.Resources)
                    .HasConstraintName("FK_ResourceResources_EventEvents_Resources");
            });

            modelBuilder.Entity<SocialMedium>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_SocialMedia");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Fotograf).HasColumnName("fotograf");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Isim).HasMaxLength(500);

                entity.Property(e => e.Link).HasMaxLength(500);
            });

            modelBuilder.Entity<XpoInstanceKey>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XpoInstanceKey");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_XpoInstanceKey");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<XpoRunningWorkflowInstanceInfo>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XpoRunningWorkflowInstanceInfo");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_XpoRunningWorkflowInstanceInfo");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.State).HasMaxLength(100);

                entity.Property(e => e.TargetObjectHandle).HasMaxLength(255);

                entity.Property(e => e.WorkflowName).HasMaxLength(255);

                entity.Property(e => e.WorkflowUniqueId).HasMaxLength(255);
            });

            modelBuilder.Entity<XpoStartWorkflowRequest>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XpoStartWorkflowRequest");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_XpoStartWorkflowRequest");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.TargetObjectKey).HasMaxLength(100);

                entity.Property(e => e.TargetObjectType).HasMaxLength(100);

                entity.Property(e => e.TargetWorkflowUniqueId).HasMaxLength(100);
            });

            modelBuilder.Entity<XpoState>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XpoState");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_XpoState");

                entity.HasIndex(e => e.StateMachine, "iStateMachine_XpoState");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.StateMachineNavigation)
                    .WithMany(p => p.XpoStates)
                    .HasForeignKey(d => d.StateMachine)
                    .HasConstraintName("FK_XpoState_StateMachine");
            });

            modelBuilder.Entity<XpoStateAppearance>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XpoStateAppearance");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_XpoStateAppearance");

                entity.HasIndex(e => e.State, "iState_XpoStateAppearance");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AppearanceItemType).HasMaxLength(100);

                entity.Property(e => e.Context).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Method).HasMaxLength(100);

                entity.Property(e => e.TargetItems).HasMaxLength(100);

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.XpoStateAppearances)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK_XpoStateAppearance_State");
            });

            modelBuilder.Entity<XpoStateMachine>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XpoStateMachine");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_XpoStateMachine");

                entity.HasIndex(e => e.StartState, "iStartState_XpoStateMachine");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.StatePropertyName).HasMaxLength(100);

                entity.Property(e => e.TargetObjectType).HasMaxLength(100);

                entity.HasOne(d => d.StartStateNavigation)
                    .WithMany(p => p.XpoStateMachines)
                    .HasForeignKey(d => d.StartState)
                    .HasConstraintName("FK_XpoStateMachine_StartState");
            });

            modelBuilder.Entity<XpoTrackingRecord>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XpoTrackingRecord");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_XpoTrackingRecord");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.ActivityId).HasMaxLength(100);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");
            });

            modelBuilder.Entity<XpoTransition>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XpoTransition");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_XpoTransition");

                entity.HasIndex(e => e.SourceState, "iSourceState_XpoTransition");

                entity.HasIndex(e => e.TargetState, "iTargetState_XpoTransition");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption).HasMaxLength(100);

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.HasOne(d => d.SourceStateNavigation)
                    .WithMany(p => p.XpoTransitionSourceStateNavigations)
                    .HasForeignKey(d => d.SourceState)
                    .HasConstraintName("FK_XpoTransition_SourceState");

                entity.HasOne(d => d.TargetStateNavigation)
                    .WithMany(p => p.XpoTransitionTargetStateNavigations)
                    .HasForeignKey(d => d.TargetState)
                    .HasConstraintName("FK_XpoTransition_TargetState");
            });

            modelBuilder.Entity<XpoUserActivityVersion>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XpoUserActivityVersion");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_XpoUserActivityVersion");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.WorkflowUniqueId).HasMaxLength(100);
            });

            modelBuilder.Entity<XpoWorkflowDefinition>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XpoWorkflowDefinition");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_XpoWorkflowDefinition");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TargetObjectType).HasMaxLength(100);
            });

            modelBuilder.Entity<XpoWorkflowInstance>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XpoWorkflowInstance");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_XpoWorkflowInstance");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.ExpirationDateTime).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Owner).HasMaxLength(100);
            });

            modelBuilder.Entity<XpoWorkflowInstanceControlCommandRequest>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XpoWorkflowInstanceControlCommandRequest");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_XpoWorkflowInstanceControlCommandRequest");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.TargetWorkflowUniqueId).HasMaxLength(100);
            });

            modelBuilder.Entity<XpobjectType>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XPObjectType");

                entity.HasIndex(e => e.TypeName, "iTypeName_XPObjectType")
                    .IsUnique();

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.AssemblyName).HasMaxLength(254);

                entity.Property(e => e.TypeName).HasMaxLength(254);
            });

            modelBuilder.Entity<XpweakReference>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XPWeakReference");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_XPWeakReference");

                entity.HasIndex(e => e.ObjectType, "iObjectType_XPWeakReference");

                entity.HasIndex(e => e.TargetType, "iTargetType_XPWeakReference");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.TargetKey).HasMaxLength(100);

                entity.HasOne(d => d.ObjectTypeNavigation)
                    .WithMany(p => p.XpweakReferenceObjectTypeNavigations)
                    .HasForeignKey(d => d.ObjectType)
                    .HasConstraintName("FK_XPWeakReference_ObjectType");

                entity.HasOne(d => d.TargetTypeNavigation)
                    .WithMany(p => p.XpweakReferenceTargetTypeNavigations)
                    .HasForeignKey(d => d.TargetType)
                    .HasConstraintName("FK_XPWeakReference_TargetType");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
