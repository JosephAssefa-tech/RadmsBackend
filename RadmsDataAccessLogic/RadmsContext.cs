using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RadmsDataAccessLogic.Models;

namespace RadmsDataAccessLogic
{
    public partial class RadmsContext : DbContext
    {
        public RadmsContext()
        {
        }

        public RadmsContext(DbContextOptions<RadmsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccidentCauseLookup> AccidentCauseLookups { get; set; } = null!;
        public virtual DbSet<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; } = null!;
        public virtual DbSet<AccidentTypeLookup> AccidentTypeLookups { get; set; } = null!;
        public virtual DbSet<ActivityTypeLookup> ActivityTypeLookups { get; set; } = null!;
        public virtual DbSet<AirConditionTypeLookup> AirConditionTypeLookups { get; set; } = null!;
        public virtual DbSet<AuditTrailTransaction> AuditTrailTransactions { get; set; } = null!;
        public virtual DbSet<CityMaster> CityMasters { get; set; } = null!;
        public virtual DbSet<CollisionTypeLookup> CollisionTypeLookups { get; set; } = null!;
        public virtual DbSet<DriverExperienceLookup> DriverExperienceLookups { get; set; } = null!;
        public virtual DbSet<DrivingLicenceCatagoryLookup> DrivingLicenceCatagoryLookups { get; set; } = null!;
        public virtual DbSet<EducationLevelLookup> EducationLevelLookups { get; set; } = null!;
        public virtual DbSet<EmploymentStatusLookup> EmploymentStatusLookups { get; set; } = null!;
        public virtual DbSet<FormMaster> FormMasters { get; set; } = null!;
        public virtual DbSet<HealthConditionLookup> HealthConditionLookups { get; set; } = null!;
        public virtual DbSet<HighwayMaster> HighwayMasters { get; set; } = null!;
        public virtual DbSet<HighwayOwnerMaster> HighwayOwnerMasters { get; set; } = null!;
        public virtual DbSet<HighwayTypeLookup> HighwayTypeLookups { get; set; } = null!;
        public virtual DbSet<ImpactTypeLookup> ImpactTypeLookups { get; set; } = null!;
        public virtual DbSet<JunctionTypeLookup> JunctionTypeLookups { get; set; } = null!;
        public virtual DbSet<KebeleMaster> KebeleMasters { get; set; } = null!;
        public virtual DbSet<LandmarkTypeLookup> LandmarkTypeLookups { get; set; } = null!;
        public virtual DbSet<LegalMeasurementDetailsTransaction> LegalMeasurementDetailsTransactions { get; set; } = null!;
        public virtual DbSet<LicenceLevelLookup> LicenceLevelLookups { get; set; } = null!;
        public virtual DbSet<LightConditionLookup> LightConditionLookups { get; set; } = null!;
        public virtual DbSet<OrganizationMaster> OrganizationMasters { get; set; } = null!;
        public virtual DbSet<PavementTypeLookup> PavementTypeLookups { get; set; } = null!;
        public virtual DbSet<PedestrianMovementLookup> PedestrianMovementLookups { get; set; } = null!;
        public virtual DbSet<PoliceStationMaster> PoliceStationMasters { get; set; } = null!;
        public virtual DbSet<RegionMaster> RegionMasters { get; set; } = null!;
        public virtual DbSet<RoadCarriagewayTypeLookup> RoadCarriagewayTypeLookups { get; set; } = null!;
        public virtual DbSet<RoadSurfaceConditionLookup> RoadSurfaceConditionLookups { get; set; } = null!;
        public virtual DbSet<RoadsInvolvedDetailsTransaction> RoadsInvolvedDetailsTransactions { get; set; } = null!;
        public virtual DbSet<SeatingTypeLookup> SeatingTypeLookups { get; set; } = null!;
        public virtual DbSet<SeverityLevelLookup> SeverityLevelLookups { get; set; } = null!;
        public virtual DbSet<SpeedLimitLookup> SpeedLimitLookups { get; set; } = null!;
        public virtual DbSet<SubCityMaster> SubCityMasters { get; set; } = null!;
        public virtual DbSet<TerrainTypeLookup> TerrainTypeLookups { get; set; } = null!;
        public virtual DbSet<UserMaster> UserMasters { get; set; } = null!;
        public virtual DbSet<UserRoleTransaction> UserRoleTransactions { get; set; } = null!;
        public virtual DbSet<UserTypeLookup> UserTypeLookups { get; set; } = null!;
        public virtual DbSet<VechicleMaster> VechicleMasters { get; set; } = null!;
        public virtual DbSet<VehicleDefectLookup> VehicleDefectLookups { get; set; } = null!;
        public virtual DbSet<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; } = null!;
        public virtual DbSet<VehicleMovementMaster> VehicleMovementMasters { get; set; } = null!;
        public virtual DbSet<VehicleOwnershipLookup> VehicleOwnershipLookups { get; set; } = null!;
        public virtual DbSet<VehicleRelationLookup> VehicleRelationLookups { get; set; } = null!;
        public virtual DbSet<VehicleServiceAgeLookup> VehicleServiceAgeLookups { get; set; } = null!;
        public virtual DbSet<VictimDetailsTransaction> VictimDetailsTransactions { get; set; } = null!;
        public virtual DbSet<VictimMovementMaster> VictimMovementMasters { get; set; } = null!;
        public virtual DbSet<VictimTypeLookup> VictimTypeLookups { get; set; } = null!;
        public virtual DbSet<WeatherConditionTypeLookup> WeatherConditionTypeLookups { get; set; } = null!;
        public virtual DbSet<WoredaMaster> WoredaMasters { get; set; } = null!;
        public virtual DbSet<ZoneMaster> ZoneMasters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-LMG59KKQ;Database=Radms;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccidentCauseLookup>(entity =>
            {
                entity.HasKey(e => e.AccidentCauseId)
                    .HasName("PK__Accident__76AD461699F953E1");
            });

            modelBuilder.Entity<AccidentDetailsTransaction>(entity =>
            {
                entity.HasKey(e => e.AccidentId)
                    .HasName("PK__Accident__8133DE8FB656F985");

                entity.HasOne(d => d.AccidentType)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.AccidentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__Accid__02FC7413");

                entity.HasOne(d => d.AirCondition)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.AirConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__AirCo__02084FDA");

                entity.HasOne(d => d.CauseofAccident)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.CauseofAccidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__Cause__7F2BE32F");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__AccidentD__CityI__05D8E0BE");

                entity.HasOne(d => d.CollisionType)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.CollisionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__Colli__7C4F7684");

                entity.HasOne(d => d.HidNavigation)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.Hid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentDet__HID__01142BA1");

                entity.HasOne(d => d.HighwayType)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.HighwayTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__Highw__73BA3083");

                entity.HasOne(d => d.ImpactType)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.ImpactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__Impac__7A672E12");

                entity.HasOne(d => d.JunctionType)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.JunctionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__Junct__7B5B524B");

                entity.HasOne(d => d.LandmarkType)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.LandmarkTypeId)
                    .HasConstraintName("FK__AccidentD__Landm__76969D2E");

                entity.HasOne(d => d.LightCondtion)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.LightCondtionId)
                    .HasConstraintName("FK__AccidentD__Light__00200768");

                entity.HasOne(d => d.PavementType)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.PavementTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__Pavem__778AC167");

                entity.HasOne(d => d.Ps)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.Psid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentDe__PSID__71D1E811");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK__AccidentD__Regio__06CD04F7");

                entity.HasOne(d => d.RoadCarriageway)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.RoadCarriagewayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__RoadC__74AE54BC");

                entity.HasOne(d => d.RoadSurface)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.RoadSurfaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__RoadS__797309D9");

                entity.HasOne(d => d.Severity)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.SeverityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__Sever__7E37BEF6");

                entity.HasOne(d => d.SpeedLimit)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.SpeedLimitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__Speed__75A278F5");

                entity.HasOne(d => d.SubCity)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.SubCityId)
                    .HasConstraintName("FK__AccidentD__SubCi__04E4BC85");

                entity.HasOne(d => d.TerrianType)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.TerrianTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__Terri__787EE5A0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__UserI__72C60C4A");

                entity.HasOne(d => d.WeatherCond)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.WeatherCondId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccidentD__Weath__7D439ABD");

                entity.HasOne(d => d.Woreda)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.WoredaId)
                    .HasConstraintName("FK__AccidentD__Wored__03F0984C");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.AccidentDetailsTransactions)
                    .HasForeignKey(d => d.ZoneId)
                    .HasConstraintName("FK__AccidentD__ZoneI__07C12930");
            });

            modelBuilder.Entity<AccidentTypeLookup>(entity =>
            {
                entity.HasKey(e => e.AccidentTypeId)
                    .HasName("PK__Accident__DF01314A392FCF47");
            });

            modelBuilder.Entity<ActivityTypeLookup>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK__Activity__45F4A7F1ECD74D26");
            });

            modelBuilder.Entity<AirConditionTypeLookup>(entity =>
            {
                entity.HasKey(e => e.AirConditionId)
                    .HasName("PK__AirCondi__39576F6E24D22195");
            });

            modelBuilder.Entity<AuditTrailTransaction>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__AuditTra__FBDF78C98A0CE5D0");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.AuditTrailTransactions)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK__AuditTrai__Activ__339FAB6E");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.AuditTrailTransactions)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK__AuditTrai__FormI__3493CFA7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuditTrailTransactions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__AuditTrai__UserI__32AB8735");
            });

            modelBuilder.Entity<CityMaster>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK__CityMast__F2D21A960FB2C196");

                entity.HasOne(d => d.Woreda)
                    .WithMany(p => p.CityMasters)
                    .HasForeignKey(d => d.WoredaId)
                    .HasConstraintName("FK__CityMaste__Wored__2C3393D0");
            });

            modelBuilder.Entity<CollisionTypeLookup>(entity =>
            {
                entity.HasKey(e => e.CollisionTypeId)
                    .HasName("PK__Collisio__B13F64FE96953ED4");
            });

            modelBuilder.Entity<DriverExperienceLookup>(entity =>
            {
                entity.HasKey(e => e.DriverExperienceId)
                    .HasName("PK__DriverEx__37A7814D7CF3F67A");
            });

            modelBuilder.Entity<DrivingLicenceCatagoryLookup>(entity =>
            {
                entity.HasKey(e => e.DrivingLicenceCatagoryId)
                    .HasName("PK__DrivingL__7E920413237A9A4A");
            });

            modelBuilder.Entity<EducationLevelLookup>(entity =>
            {
                entity.HasKey(e => e.EducationLevelId)
                    .HasName("PK__Educatio__6F6237ADF3281411");
            });

            modelBuilder.Entity<EmploymentStatusLookup>(entity =>
            {
                entity.HasKey(e => e.EmploymentStatusId)
                    .HasName("PK__Employme__CF794BCF482FB102");
            });

            modelBuilder.Entity<FormMaster>(entity =>
            {
                entity.HasKey(e => e.FormId)
                    .HasName("PK__FormMast__FB05B7BD96930BAE");
            });

            modelBuilder.Entity<HealthConditionLookup>(entity =>
            {
                entity.HasKey(e => e.HealthConditionId)
                    .HasName("PK__HealthCo__B7616A51A15C38AB");
            });

            modelBuilder.Entity<HighwayMaster>(entity =>
            {
                entity.HasKey(e => e.Hid)
                    .HasName("PK__HighwayM__C755152780E6EA6E");

                entity.HasOne(d => d.Howner)
                    .WithMany(p => p.HighwayMasters)
                    .HasForeignKey(d => d.HownerId)
                    .HasConstraintName("FK__HighwayMa__HOwne__3C69FB99");

                entity.HasOne(d => d.Htype)
                    .WithMany(p => p.HighwayMasters)
                    .HasForeignKey(d => d.HtypeId)
                    .HasConstraintName("FK__HighwayMa__HType__3B75D760");
            });

            modelBuilder.Entity<HighwayOwnerMaster>(entity =>
            {
                entity.HasKey(e => e.HownerId)
                    .HasName("PK__HighwayO__A8D5F1151069EE0C");
            });

            modelBuilder.Entity<HighwayTypeLookup>(entity =>
            {
                entity.HasKey(e => e.HtypeId)
                    .HasName("PK__HighwayT__DE2C074AD9573E4F");
            });

            modelBuilder.Entity<ImpactTypeLookup>(entity =>
            {
                entity.HasKey(e => e.ImpactTypeId)
                    .HasName("PK__ImpactTy__674B9D6C979D041B");
            });

            modelBuilder.Entity<JunctionTypeLookup>(entity =>
            {
                entity.HasKey(e => e.JunctionTypeId)
                    .HasName("PK__Junction__D5D18236FBD265DD");
            });

            modelBuilder.Entity<KebeleMaster>(entity =>
            {
                entity.HasKey(e => e.KebeleId)
                    .HasName("PK__KebeleMa__BAE69047ADC406FA");
            });

            modelBuilder.Entity<LandmarkTypeLookup>(entity =>
            {
                entity.HasKey(e => e.LandmarkTypeId)
                    .HasName("PK__Landmark__A5900FC0E0236F4E");
            });

            modelBuilder.Entity<LegalMeasurementDetailsTransaction>(entity =>
            {
                entity.HasOne(d => d.Accident)
                    .WithMany()
                    .HasForeignKey(d => d.AccidentId)
                    .HasConstraintName("FK__LegalMeas__Accid__3A4CA8FD");

                entity.HasOne(d => d.Victim)
                    .WithMany()
                    .HasForeignKey(d => d.VictimId)
                    .HasConstraintName("FK__LegalMeas__Victi__3B40CD36");
            });

            modelBuilder.Entity<LicenceLevelLookup>(entity =>
            {
                entity.HasKey(e => e.LeveloflicenceId)
                    .HasName("PK__LicenceL__E6A26B51AEFE463F");
            });

            modelBuilder.Entity<LightConditionLookup>(entity =>
            {
                entity.HasKey(e => e.LightConditionId)
                    .HasName("PK__LightCon__D3BCC66CE50ECA6F");
            });

            modelBuilder.Entity<OrganizationMaster>(entity =>
            {
                entity.HasKey(e => e.OrganizationId)
                    .HasName("PK__Organiza__CADB0B721F6EFDC0");
            });

            modelBuilder.Entity<PavementTypeLookup>(entity =>
            {
                entity.HasKey(e => e.PavementTypeId)
                    .HasName("PK__Pavement__13F54EF94D362B79");
            });

            modelBuilder.Entity<PedestrianMovementLookup>(entity =>
            {
                entity.HasKey(e => e.PedestrianMovementId)
                    .HasName("PK__Pedestri__6141EC3D1C9D954C");
            });

            modelBuilder.Entity<PoliceStationMaster>(entity =>
            {
                entity.HasKey(e => e.Psid)
                    .HasName("PK__PoliceSt__BC000976CAB3C4ED");

                entity.HasOne(d => d.SubCity)
                    .WithMany(p => p.PoliceStationMasters)
                    .HasForeignKey(d => d.SubCityId)
                    .HasConstraintName("FK__PoliceSta__SubCi__33D4B598");

                entity.HasOne(d => d.Woreda)
                    .WithMany(p => p.PoliceStationMasters)
                    .HasForeignKey(d => d.WoredaId)
                    .HasConstraintName("FK__PoliceSta__Wored__34C8D9D1");
            });

            modelBuilder.Entity<RegionMaster>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("PK__RegionMa__ACD8444338DFC3C1");
            });

            modelBuilder.Entity<RoadCarriagewayTypeLookup>(entity =>
            {
                entity.HasKey(e => e.RoadCarriagewayId)
                    .HasName("PK__RoadCarr__C83870D9E952EC19");
            });

            modelBuilder.Entity<RoadSurfaceConditionLookup>(entity =>
            {
                entity.HasKey(e => e.RoadSurfaceId)
                    .HasName("PK__RoadSurf__E5E0D7DE559A8A63");
            });

            modelBuilder.Entity<RoadsInvolvedDetailsTransaction>(entity =>
            {
                entity.HasOne(d => d.Accident)
                    .WithMany()
                    .HasForeignKey(d => d.AccidentId)
                    .HasConstraintName("FK__RoadsInvo__Accid__3D2915A8");

                entity.HasOne(d => d.HidNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Hid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RoadsInvolv__HID__3E1D39E1");

                entity.HasOne(d => d.PavementType)
                    .WithMany()
                    .HasForeignKey(d => d.PavementTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RoadsInvo__Pavem__3F115E1A");

                entity.HasOne(d => d.RoadCarriageway)
                    .WithMany()
                    .HasForeignKey(d => d.RoadCarriagewayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RoadsInvo__RoadC__40F9A68C");

                entity.HasOne(d => d.RoadSurface)
                    .WithMany()
                    .HasForeignKey(d => d.RoadSurfaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RoadsInvo__RoadS__40058253");
            });

            modelBuilder.Entity<SeatingTypeLookup>(entity =>
            {
                entity.HasKey(e => e.SeatingTypeId)
                    .HasName("PK__SeatingT__78708CC628029B79");
            });

            modelBuilder.Entity<SeverityLevelLookup>(entity =>
            {
                entity.HasKey(e => e.SeverityId)
                    .HasName("PK__Severity__C618A9512676A4D7");
            });

            modelBuilder.Entity<SpeedLimitLookup>(entity =>
            {
                entity.HasKey(e => e.SpeedLimitId)
                    .HasName("PK__SpeedLim__10D3A264481C235E");
            });

            modelBuilder.Entity<SubCityMaster>(entity =>
            {
                entity.HasKey(e => e.SubCityId)
                    .HasName("PK__SubCityM__1942189725CBBC34");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.SubCityMasters)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__SubCityMa__CityI__2F10007B");
            });

            modelBuilder.Entity<TerrainTypeLookup>(entity =>
            {
                entity.HasKey(e => e.TerrianTypeId)
                    .HasName("PK__TerrainT__FE8BDBAD0146CDB2");
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserMast__1788CCAC44EA95B5");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.UserMasters)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK__UserMaste__Organ__656C112C");
            });

            modelBuilder.Entity<UserRoleTransaction>(entity =>
            {
                entity.HasKey(e => e.DepartmentTypeId)
                    .HasName("PK__UserRole__FC33D077B5D3A70A");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.UserRoleTransactions)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK__UserRoleT__FormI__3864608B");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.UserRoleTransactions)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK__UserRoleT__UserT__37703C52");
            });

            modelBuilder.Entity<UserTypeLookup>(entity =>
            {
                entity.HasKey(e => e.UserTypeId)
                    .HasName("PK__UserType__40D2D8F6DC326479");
            });

            modelBuilder.Entity<VechicleMaster>(entity =>
            {
                entity.HasKey(e => e.VehicleId)
                    .HasName("PK__Vechicle__476B54B2E787BAC3");
            });

            modelBuilder.Entity<VehicleDefectLookup>(entity =>
            {
                entity.HasKey(e => e.VehicleDefectId)
                    .HasName("PK__VehicleD__9C5FBEEAB0BECB6D");
            });

            modelBuilder.Entity<VehicleDetailsTransaction>(entity =>
            {
                entity.HasKey(e => e.VehicleInvolvedId)
                    .HasName("PK__VehicleD__761E7F70EB051DB5");

                entity.HasOne(d => d.Accident)
                    .WithMany(p => p.VehicleDetailsTransactions)
                    .HasForeignKey(d => d.AccidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VehicleDe__Accid__17F790F9");

                entity.HasOne(d => d.Dlcatagory)
                    .WithMany(p => p.VehicleDetailsTransactions)
                    .HasForeignKey(d => d.DlcatagoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VehicleDe__DLCat__1BC821DD");

                entity.HasOne(d => d.Dllevel)
                    .WithMany(p => p.VehicleDetailsTransactions)
                    .HasForeignKey(d => d.DllevelId)
                    .HasConstraintName("FK__VehicleDe__DLLev__1F98B2C1");

                entity.HasOne(d => d.DriverExperience)
                    .WithMany(p => p.VehicleDetailsTransactions)
                    .HasForeignKey(d => d.DriverExperienceId)
                    .HasConstraintName("FK__VehicleDe__Drive__1DB06A4F");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.VehicleDetailsTransactions)
                    .HasForeignKey(d => d.EducationLevelId)
                    .HasConstraintName("FK__VehicleDe__Educa__1CBC4616");

                entity.HasOne(d => d.VehicleAge)
                    .WithMany(p => p.VehicleDetailsTransactions)
                    .HasForeignKey(d => d.VehicleAgeId)
                    .HasConstraintName("FK__VehicleDe__Vehic__19DFD96B");

                entity.HasOne(d => d.VehicleDefect)
                    .WithMany(p => p.VehicleDetailsTransactions)
                    .HasForeignKey(d => d.VehicleDefectId)
                    .HasConstraintName("FK__VehicleDe__Vehic__1AD3FDA4");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.VehicleDetailsTransactions)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VehicleDe__Vehic__18EBB532");

                entity.HasOne(d => d.VehicleMovement)
                    .WithMany(p => p.VehicleDetailsTransactions)
                    .HasForeignKey(d => d.VehicleMovementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VehicleDe__Vehic__2180FB33");

                entity.HasOne(d => d.VehicleOwnership)
                    .WithMany(p => p.VehicleDetailsTransactions)
                    .HasForeignKey(d => d.VehicleOwnershipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VehicleDe__Vehic__1EA48E88");

                entity.HasOne(d => d.VehicleRelation)
                    .WithMany(p => p.VehicleDetailsTransactions)
                    .HasForeignKey(d => d.VehicleRelationId)
                    .HasConstraintName("FK__VehicleDe__Vehic__208CD6FA");
            });

            modelBuilder.Entity<VehicleMovementMaster>(entity =>
            {
                entity.HasKey(e => e.VehicleMovementId)
                    .HasName("PK__VehicleM__63F2ECDC75C1DFC4");
            });

            modelBuilder.Entity<VehicleOwnershipLookup>(entity =>
            {
                entity.HasKey(e => e.VehicleOwnershipId)
                    .HasName("PK__VehicleO__90406EB49E721F97");
            });

            modelBuilder.Entity<VehicleRelationLookup>(entity =>
            {
                entity.HasKey(e => e.VehicleRelationId)
                    .HasName("PK__VehicleR__33D8CB75EDBF2FB5");
            });

            modelBuilder.Entity<VehicleServiceAgeLookup>(entity =>
            {
                entity.HasKey(e => e.VehicleServiceAgeId)
                    .HasName("PK__VehicleS__5F12DCE6C5450F7E");
            });

            modelBuilder.Entity<VictimDetailsTransaction>(entity =>
            {
                entity.HasKey(e => e.VictimId)
                    .HasName("PK__VictimDe__1ABDABABFDCF9B86");

                entity.HasOne(d => d.Accident)
                    .WithMany(p => p.VictimDetailsTransactions)
                    .HasForeignKey(d => d.AccidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VictimDet__Accid__2A164134");

                entity.HasOne(d => d.EmploymentStatus)
                    .WithMany(p => p.VictimDetailsTransactions)
                    .HasForeignKey(d => d.EmploymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VictimDet__Emplo__2CF2ADDF");

                entity.HasOne(d => d.HealthCondition)
                    .WithMany(p => p.VictimDetailsTransactions)
                    .HasForeignKey(d => d.HealthConditionId)
                    .HasConstraintName("FK__VictimDet__Healt__2DE6D218");

                entity.HasOne(d => d.PedestrianMovement)
                    .WithMany(p => p.VictimDetailsTransactions)
                    .HasForeignKey(d => d.PedestrianMovementId)
                    .HasConstraintName("FK__VictimDet__Pedes__2EDAF651");

                entity.HasOne(d => d.SeatingType)
                    .WithMany(p => p.VictimDetailsTransactions)
                    .HasForeignKey(d => d.SeatingTypeId)
                    .HasConstraintName("FK__VictimDet__Seati__2FCF1A8A");

                entity.HasOne(d => d.VictimMovement)
                    .WithMany(p => p.VictimDetailsTransactions)
                    .HasForeignKey(d => d.VictimMovementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VictimDet__Victi__2B0A656D");

                entity.HasOne(d => d.VictimType)
                    .WithMany(p => p.VictimDetailsTransactions)
                    .HasForeignKey(d => d.VictimTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VictimDet__Victi__2BFE89A6");
            });

            modelBuilder.Entity<VictimMovementMaster>(entity =>
            {
                entity.HasKey(e => e.VictimMovementId)
                    .HasName("PK__VictimMo__0F126498A3D8D078");
            });

            modelBuilder.Entity<VictimTypeLookup>(entity =>
            {
                entity.HasKey(e => e.VictimTypeId)
                    .HasName("PK__VictimTy__683028A42C3EC925");
            });

            modelBuilder.Entity<WeatherConditionTypeLookup>(entity =>
            {
                entity.HasKey(e => e.WeatherCondId)
                    .HasName("PK__WeatherC__C11BEEC42D7D7159");
            });

            modelBuilder.Entity<WoredaMaster>(entity =>
            {
                entity.HasKey(e => e.WoredaId)
                    .HasName("PK__WoredaMa__5C15D5B2EE7E31D6");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.WoredaMasters)
                    .HasForeignKey(d => d.ZoneId)
                    .HasConstraintName("FK__WoredaMas__ZoneI__29572725");
            });

            modelBuilder.Entity<ZoneMaster>(entity =>
            {
                entity.HasKey(e => e.ZoneId)
                    .HasName("PK__ZoneMast__6016679540C8D639");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.ZoneMasters)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK__ZoneMaste__Regio__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
