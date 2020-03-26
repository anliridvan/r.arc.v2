using Microsoft.EntityFrameworkCore;
using R.ARC.Core.Entity.Models;

namespace R.ARC.Core.DataLayer.Context
{
    public partial class PostgreSContext : DbContext
    {
        public PostgreSContext()
        {
        }

        public PostgreSContext(DbContextOptions<PostgreSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApiResources> ApiResources { get; set; }
        public virtual DbSet<AwsdmsDdlAudit> AwsdmsDdlAudit { get; set; }
        public virtual DbSet<BackendConfig> BackendConfig { get; set; }
        public virtual DbSet<BackendErrors> BackendErrors { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<Batteries> Batteries { get; set; }
        public virtual DbSet<BatteryActionLogs> BatteryActionLogs { get; set; }
        public virtual DbSet<CallCenterUsers> CallCenterUsers { get; set; }
        public virtual DbSet<Campaigns> Campaigns { get; set; }
        public virtual DbSet<CampaignsCustomers> CampaignsCustomers { get; set; }
        public virtual DbSet<CancellationRequests> CancellationRequests { get; set; }
        public virtual DbSet<CarDeliveries> CarDeliveries { get; set; }
        public virtual DbSet<CardAddStatus> CardAddStatus { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<ChargeStations> ChargeStations { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Claims> Claims { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Coupons> Coupons { get; set; }
        public virtual DbSet<CreditCards> CreditCards { get; set; }
        public virtual DbSet<CustomerCallRecords> CustomerCallRecords { get; set; }
        public virtual DbSet<CustomerCheckmobiPins> CustomerCheckmobiPins { get; set; }
        public virtual DbSet<CustomerDemands> CustomerDemands { get; set; }
        public virtual DbSet<CustomerPhoneNumberHolder> CustomerPhoneNumberHolder { get; set; }
        public virtual DbSet<CustomerPopups> CustomerPopups { get; set; }
        public virtual DbSet<CustomerReservationDebts> CustomerReservationDebts { get; set; }
        public virtual DbSet<CustomerRideDebts> CustomerRideDebts { get; set; }
        public virtual DbSet<CustomerScooterRequests> CustomerScooterRequests { get; set; }
        public virtual DbSet<CustomerSentNotifications> CustomerSentNotifications { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<DailyCurrencies> DailyCurrencies { get; set; }
        public virtual DbSet<Decisions> Decisions { get; set; }
        public virtual DbSet<DeviceCodes> DeviceCodes { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<Expenses> Expenses { get; set; }
        public virtual DbSet<GeofenceBorderPoints> GeofenceBorderPoints { get; set; }
        public virtual DbSet<GeofenceKeys> GeofenceKeys { get; set; }
        public virtual DbSet<GeofenceOfficePoints> GeofenceOfficePoints { get; set; }
        public virtual DbSet<GeofenceParkBorders> GeofenceParkBorders { get; set; }
        public virtual DbSet<GeofenceParkPoints> GeofenceParkPoints { get; set; }
        public virtual DbSet<GeofencePoints> GeofencePoints { get; set; }
        public virtual DbSet<GeofenceRegionPoints> GeofenceRegionPoints { get; set; }
        public virtual DbSet<GeofenceRestrictedPoints> GeofenceRestrictedPoints { get; set; }
        public virtual DbSet<Geofences> Geofences { get; set; }
        public virtual DbSet<GovernmentUsers> GovernmentUsers { get; set; }
        public virtual DbSet<InventoryCategories> InventoryCategories { get; set; }
        public virtual DbSet<InventoryComponentCounts> InventoryComponentCounts { get; set; }
        public virtual DbSet<InventoryComponents> InventoryComponents { get; set; }
        public virtual DbSet<InventoryModel> InventoryModel { get; set; }
        public virtual DbSet<InventoryPartCounts> InventoryPartCounts { get; set; }
        public virtual DbSet<InventoryParts> InventoryParts { get; set; }
        public virtual DbSet<InventoryStatus> InventoryStatus { get; set; }
        public virtual DbSet<InvestorData> InvestorData { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<IotBoxInventoryHistory> IotBoxInventoryHistory { get; set; }
        public virtual DbSet<IotBoxes> IotBoxes { get; set; }
        public virtual DbSet<IotLockInventoryHistory> IotLockInventoryHistory { get; set; }
        public virtual DbSet<IotLocks> IotLocks { get; set; }
        public virtual DbSet<IssueSolutionTypes> IssueSolutionTypes { get; set; }
        public virtual DbSet<IssueTypes> IssueTypes { get; set; }
        public virtual DbSet<Issues> Issues { get; set; }
        public virtual DbSet<KpiReports> KpiReports { get; set; }
        public virtual DbSet<KpiValues> KpiValues { get; set; }
        public virtual DbSet<MartiHealthChecks> MartiHealthChecks { get; set; }
        public virtual DbSet<MotorDriverInventoryHistory> MotorDriverInventoryHistory { get; set; }
        public virtual DbSet<MotorDrivers> MotorDrivers { get; set; }
        public virtual DbSet<MotorInventoryHistory> MotorInventoryHistory { get; set; }
        public virtual DbSet<Motors> Motors { get; set; }
        public virtual DbSet<OperatingHours> OperatingHours { get; set; }
        public virtual DbSet<OperatingHoursMessages> OperatingHoursMessages { get; set; }
        public virtual DbSet<OperationWorkOrderStatuses> OperationWorkOrderStatuses { get; set; }
        public virtual DbSet<OperationWorkOrders> OperationWorkOrders { get; set; }
        public virtual DbSet<OperatorActionLog> OperatorActionLog { get; set; }
        public virtual DbSet<OperatorLocationLogs> OperatorLocationLogs { get; set; }
        public virtual DbSet<OutOfOrderRequest> OutOfOrderRequest { get; set; }
        public virtual DbSet<PbLocations> PbLocations { get; set; }
        public virtual DbSet<PbPowerbanks> PbPowerbanks { get; set; }
        public virtual DbSet<PbRentReviewCategories> PbRentReviewCategories { get; set; }
        public virtual DbSet<PbRentReviews> PbRentReviews { get; set; }
        public virtual DbSet<PbRents> PbRents { get; set; }
        public virtual DbSet<PbStations> PbStations { get; set; }
        public virtual DbSet<PersistedGrants> PersistedGrants { get; set; }
        public virtual DbSet<Popups> Popups { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<RepairActionLogReasons> RepairActionLogReasons { get; set; }
        public virtual DbSet<RepairActionLogs> RepairActionLogs { get; set; }
        public virtual DbSet<RepairControlStatus> RepairControlStatus { get; set; }
        public virtual DbSet<RepairResultMaterials> RepairResultMaterials { get; set; }
        public virtual DbSet<RepairResultMaterialsUsage> RepairResultMaterialsUsage { get; set; }
        public virtual DbSet<ReservationPaymentStatus> ReservationPaymentStatus { get; set; }
        public virtual DbSet<ReservationRefunds> ReservationRefunds { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
        public virtual DbSet<RideAccidents> RideAccidents { get; set; }
        public virtual DbSet<RideFines> RideFines { get; set; }
        public virtual DbSet<RideRefundRequestHistory> RideRefundRequestHistory { get; set; }
        public virtual DbSet<RideRefundRequests> RideRefundRequests { get; set; }
        public virtual DbSet<RideRefunds> RideRefunds { get; set; }
        public virtual DbSet<RideRejectOperation> RideRejectOperation { get; set; }
        public virtual DbSet<RideRejectReasons> RideRejectReasons { get; set; }
        public virtual DbSet<RideReviewCategories> RideReviewCategories { get; set; }
        public virtual DbSet<RideReviews> RideReviews { get; set; }
        public virtual DbSet<Rides> Rides { get; set; }
        public virtual DbSet<RidesOverFiveMins> RidesOverFiveMins { get; set; }
        public virtual DbSet<RidingPaymentErrors> RidingPaymentErrors { get; set; }
        public virtual DbSet<RoleClaims> RoleClaims { get; set; }
        public virtual DbSet<RoleRights> RoleRights { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<ScooterAlertDetail> ScooterAlertDetail { get; set; }
        public virtual DbSet<ScooterBodies> ScooterBodies { get; set; }
        public virtual DbSet<ScooterBodyHistory> ScooterBodyHistory { get; set; }
        public virtual DbSet<ScooterBodyVersions> ScooterBodyVersions { get; set; }
        public virtual DbSet<ScooterErrorMessages> ScooterErrorMessages { get; set; }
        public virtual DbSet<ScooterErrors> ScooterErrors { get; set; }
        public virtual DbSet<ScooterErrorsBacklog> ScooterErrorsBacklog { get; set; }
        public virtual DbSet<ScooterLockCodeHistory> ScooterLockCodeHistory { get; set; }
        public virtual DbSet<ScooterPrices> ScooterPrices { get; set; }
        public virtual DbSet<ScooterRepairCategories> ScooterRepairCategories { get; set; }
        public virtual DbSet<ScooterRepairLogs> ScooterRepairLogs { get; set; }
        public virtual DbSet<ScooterRepairRecords> ScooterRepairRecords { get; set; }
        public virtual DbSet<ScooterRepairResultCategories> ScooterRepairResultCategories { get; set; }
        public virtual DbSet<ScooterRepairTypes> ScooterRepairTypes { get; set; }
        public virtual DbSet<ScooterStatus> ScooterStatus { get; set; }
        public virtual DbSet<ScooterSubstatus> ScooterSubstatus { get; set; }
        public virtual DbSet<ScooterUnavailableReasons> ScooterUnavailableReasons { get; set; }
        public virtual DbSet<ScooterUpdateLog> ScooterUpdateLog { get; set; }
        public virtual DbSet<ScooterVersions> ScooterVersions { get; set; }
        public virtual DbSet<Scooters> Scooters { get; set; }
        public virtual DbSet<SecurityRights> SecurityRights { get; set; }
        public virtual DbSet<SwappableBatteryStatus> SwappableBatteryStatus { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<TaxOffices> TaxOffices { get; set; }
        public virtual DbSet<UserActionReasons> UserActionReasons { get; set; }
        public virtual DbSet<UserBreaks> UserBreaks { get; set; }
        public virtual DbSet<UserClaims> UserClaims { get; set; }
        public virtual DbSet<UserGeofences> UserGeofences { get; set; }
        public virtual DbSet<UserLogins> UserLogins { get; set; }
        public virtual DbSet<UserRights> UserRights { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<UserShifts> UserShifts { get; set; }
        public virtual DbSet<UserTokens> UserTokens { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Warehouses> Warehouses { get; set; }
        public virtual DbSet<WorkOrders> WorkOrders { get; set; }
        public virtual DbSet<Zones> Zones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost:5342;Database=r_arc;Username=postgres;Password=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<ApiResources>(entity =>
            {
                entity.ToTable("api_resources");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DisplayName).HasColumnName("display_name");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<AwsdmsDdlAudit>(entity =>
            {
                entity.HasKey(e => e.CKey)
                    .HasName("awsdms_ddl_audit_pkey");

                entity.ToTable("awsdms_ddl_audit");

                entity.Property(e => e.CKey).HasColumnName("c_key");

                entity.Property(e => e.CDdlqry).HasColumnName("c_ddlqry");

                entity.Property(e => e.CName)
                    .HasColumnName("c_name")
                    .HasMaxLength(64);

                entity.Property(e => e.COid).HasColumnName("c_oid");

                entity.Property(e => e.CSchema)
                    .HasColumnName("c_schema")
                    .HasMaxLength(64);

                entity.Property(e => e.CTag)
                    .HasColumnName("c_tag")
                    .HasMaxLength(24);

                entity.Property(e => e.CTime).HasColumnName("c_time");

                entity.Property(e => e.CTxn)
                    .HasColumnName("c_txn")
                    .HasMaxLength(16);

                entity.Property(e => e.CUser)
                    .HasColumnName("c_user")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<BackendConfig>(entity =>
            {
                entity.ToTable("backend_config");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AndroidOperatorUrl)
                    .HasColumnName("android_operator_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.AndroidOperatorVer)
                    .HasColumnName("android_operator_ver")
                    .HasMaxLength(25);

                entity.Property(e => e.AndroidServiceUrl)
                    .HasColumnName("android_service_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.AndroidServiceVer)
                    .HasColumnName("android_service_ver")
                    .HasMaxLength(25);

                entity.Property(e => e.AndroidVer)
                    .HasColumnName("android_ver")
                    .HasMaxLength(25);

                entity.Property(e => e.BgColor)
                    .HasColumnName("bg_color")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrentFwVersion)
                    .HasColumnName("current_fw_version")
                    .HasMaxLength(50);

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasMaxLength(10);

                entity.Property(e => e.FineAmount).HasColumnName("fine_amount");

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasMaxLength(255);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("img_url")
                    .HasMaxLength(255);

                entity.Property(e => e.IosOperatorUrl)
                    .HasColumnName("ios_operator_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.IosOperatorVer)
                    .HasColumnName("ios_operator_ver")
                    .HasMaxLength(25);

                entity.Property(e => e.IosServiceUrl)
                    .HasColumnName("ios_service_url")
                    .HasColumnType("character varying");

                entity.Property(e => e.IosServiceVer)
                    .HasColumnName("ios_service_ver")
                    .HasMaxLength(25);

                entity.Property(e => e.IosVer)
                    .HasColumnName("ios_ver")
                    .HasMaxLength(25);

                entity.Property(e => e.ListAvailablesZoomLevel).HasColumnName("list_availables_zoom_level");

                entity.Property(e => e.MaxRideDebtValue)
                    .HasColumnName("max_ride_debt_value")
                    .HasDefaultValueSql("15");

                entity.Property(e => e.MsgEn)
                    .HasColumnName("msg_en")
                    .HasMaxLength(255);

                entity.Property(e => e.MsgTr)
                    .HasColumnName("msg_tr")
                    .HasMaxLength(255);

                entity.Property(e => e.PbProvisionPrice)
                    .HasColumnName("pb_provision_price")
                    .HasColumnType("character varying");

                entity.Property(e => e.PbRentPrice)
                    .HasColumnName("pb_rent_price")
                    .HasColumnType("character varying");

                entity.Property(e => e.PricePerMinute)
                    .HasColumnName("price_per_minute")
                    .HasMaxLength(10);

                entity.Property(e => e.ProvisionPrice)
                    .HasColumnName("provision_price")
                    .HasMaxLength(10);

                entity.Property(e => e.RateUsPeriod).HasColumnName("rate_us_period");

                entity.Property(e => e.RateUsRideCount).HasColumnName("rate_us_ride_count");

                entity.Property(e => e.ReservationNotificationMinutes)
                    .HasColumnName("reservation_notification_minutes")
                    .HasDefaultValueSql("15");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasMaxLength(10);

                entity.Property(e => e.StartingPrice)
                    .HasColumnName("starting_price")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<BackendErrors>(entity =>
            {
                entity.ToTable("backend_errors");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("access_token")
                    .HasMaxLength(255);

                entity.Property(e => e.DateOccurred)
                    .HasColumnName("date_occurred")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ErrorString)
                    .IsRequired()
                    .HasColumnName("error_string")
                    .HasMaxLength(255);

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'0.0.0.0'::character varying");

                entity.Property(e => e.UrlPath)
                    .IsRequired()
                    .HasColumnName("url_path")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Banks>(entity =>
            {
                entity.ToTable("banks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.EftCode)
                    .HasColumnName("eft_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsEnabled).HasColumnName("is_enabled");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Batteries>(entity =>
            {
                entity.ToTable("batteries");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BodyVersionId).HasColumnName("body_version_id");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ScooterId)
                    .HasColumnName("scooter_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("serial_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StockCode)
                    .HasColumnName("stock_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.SwappableBatteryStatus).HasColumnName("swappable_battery_status");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<BatteryActionLogs>(entity =>
            {
                entity.ToTable("battery_action_logs");

                entity.HasIndex(e => e.BatteryId)
                    .HasName("battery_action_logs_battery_id_idx");

                entity.HasIndex(e => e.ToScooterId)
                    .HasName("battery_action_logs_to_scooter_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionTime).HasColumnName("action_time");

                entity.Property(e => e.BatteryId).HasColumnName("battery_id");

                entity.Property(e => e.FromScooterId).HasColumnName("from_scooter_id");

                entity.Property(e => e.FromStatus).HasColumnName("from_status");

                entity.Property(e => e.GeofenceGroup).HasColumnName("geofence_group");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("character varying");

                entity.Property(e => e.ToScooterId).HasColumnName("to_scooter_id");

                entity.Property(e => e.ToStatus).HasColumnName("to_status");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<CallCenterUsers>(entity =>
            {
                entity.ToTable("call_center_users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentId)
                    .IsRequired()
                    .HasColumnName("agent_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("character varying");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Campaigns>(entity =>
            {
                entity.ToTable("campaigns");

                entity.HasIndex(e => new { e.StartTime, e.EndTime })
                    .HasName("campaigns_start_time_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasColumnName("campaign_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CampaignType).HasColumnName("campaign_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.DetailFilePath)
                    .HasColumnName("detail_file_path")
                    .HasColumnType("character varying");

                entity.Property(e => e.DiscountMaxUsableTime)
                    .HasColumnName("discount_max_usable_time")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.DiscountOn).HasColumnName("discount_on");

                entity.Property(e => e.DiscountType).HasColumnName("discount_type");

                entity.Property(e => e.DiscountValue).HasColumnName("discount_value");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<CampaignsCustomers>(entity =>
            {
                entity.ToTable("campaigns_customers");

                entity.HasIndex(e => e.CampaignId)
                    .HasName("campaigns_customers_campaign_id_idx");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("campaigns_customers_customer_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            });

            modelBuilder.Entity<CancellationRequests>(entity =>
            {
                entity.ToTable("cancellation_requests");

                entity.HasIndex(e => e.RideId)
                    .HasName("cancellation_requests_ride_id_idx");

                entity.HasIndex(e => new { e.CustomerId, e.Status })
                    .HasName("cancellation_requests_customer_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.IsReported)
                    .HasColumnName("is_reported")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ProcessedAt).HasColumnName("processed_at");

                entity.Property(e => e.ProcessedBy).HasColumnName("processed_by");

                entity.Property(e => e.ProviderType).HasColumnName("provider_type");

                entity.Property(e => e.RejectReason)
                    .HasColumnName("reject_reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.ReportedAt).HasColumnName("reported_at");

                entity.Property(e => e.RequestReason)
                    .HasColumnName("request_reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.RequestedAt).HasColumnName("requested_at");

                entity.Property(e => e.RequestedBy).HasColumnName("requested_by");

                entity.Property(e => e.RideId).HasColumnName("ride_id");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<CarDeliveries>(entity =>
            {
                entity.ToTable("car_deliveries");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssistantUserId).HasColumnName("assistant_user_id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.DeliverKm).HasColumnName("deliver_km");

                entity.Property(e => e.DeliveredAt).HasColumnName("delivered_at");

                entity.Property(e => e.DeliveringPhotos).HasColumnName("delivering_photos");

                entity.Property(e => e.HasIssue).HasColumnName("has_issue");

                entity.Property(e => e.Issue)
                    .HasColumnName("issue")
                    .HasColumnType("character varying");

                entity.Property(e => e.PickKm).HasColumnName("pick_km");

                entity.Property(e => e.PickedAt)
                    .HasColumnName("picked_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.PickingPhotos).HasColumnName("picking_photos");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<CardAddStatus>(entity =>
            {
                entity.ToTable("card_add_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BankName)
                    .HasColumnName("bank_name")
                    .HasMaxLength(50);

                entity.Property(e => e.BinNumber)
                    .HasColumnName("bin_number")
                    .HasMaxLength(25);

                entity.Property(e => e.CardAssociation)
                    .HasColumnName("card_association")
                    .HasMaxLength(25);

                entity.Property(e => e.CardFamilyName)
                    .HasColumnName("card_family_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CardType)
                    .HasColumnName("card_type")
                    .HasMaxLength(25);

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Force3ds).HasColumnName("force3ds");

                entity.Property(e => e.Success).HasColumnName("success");

                entity.Property(e => e.Ts).HasColumnName("ts");

                entity.Property(e => e.VendorErrorCode)
                    .HasColumnName("vendor_error_code")
                    .HasMaxLength(25);

                entity.Property(e => e.VendorErrorGroup)
                    .HasColumnName("vendor_error_group")
                    .HasMaxLength(50);

                entity.Property(e => e.VendorErrorMessage)
                    .HasColumnName("vendor_error_message")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Cars>(entity =>
            {
                entity.ToTable("cars");

                entity.HasIndex(e => e.Id)
                    .HasName("cars_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => new { e.Driver1, e.Driver2 })
                    .HasName("drivers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Driver1).HasColumnName("driver_1");

                entity.Property(e => e.Driver2).HasColumnName("driver_2");

                entity.Property(e => e.Drivers).HasColumnName("drivers");

                entity.Property(e => e.FenceGroup).HasColumnName("fence_group");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneMac)
                    .HasColumnName("phone_mac")
                    .HasMaxLength(25);

                entity.Property(e => e.Plate)
                    .HasColumnName("plate")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ChargeStations>(entity =>
            {
                entity.ToTable("charge_stations");

                entity.HasIndex(e => e.Id)
                    .HasName("charge_stations_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GeofenceId).HasColumnName("geofence_id");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasMaxLength(20);

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cities");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.GeohashList)
                    .HasColumnName("geohash_list")
                    .HasColumnType("character varying[]");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Claims>(entity =>
            {
                entity.ToTable("claims");

                entity.HasIndex(e => e.Id)
                    .HasName("user_claims_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('user_claims_id_seq'::regclass)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.ToTable("clients");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessTokenLifeTime).HasColumnName("access_token_life_time");

                entity.Property(e => e.AllowedScopes).HasColumnName("allowed_scopes");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.IsEnabled).HasColumnName("is_enabled");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Secret).HasColumnName("secret");

                entity.Property(e => e.Uri).HasColumnName("uri");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.ToTable("countries");

                entity.HasIndex(e => e.Id)
                    .HasName("countries_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(10);

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasMaxLength(6);

                entity.Property(e => e.IsoCode)
                    .HasColumnName("iso_code")
                    .HasMaxLength(2);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Order).HasColumnName("order");
            });

            modelBuilder.Entity<Coupons>(entity =>
            {
                entity.ToTable("coupons");

                entity.HasIndex(e => e.Code)
                    .HasName("coupons_code_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.BatchKey)
                    .HasColumnName("batch_key")
                    .HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CustomerExpiresAt).HasColumnName("customer_expires_at");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.ExpiresAt).HasColumnName("expires_at");

                entity.Property(e => e.IsUsed).HasColumnName("is_used");

                entity.Property(e => e.RideId).HasColumnName("ride_id");

                entity.Property(e => e.UsedAt).HasColumnName("used_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<CreditCards>(entity =>
            {
                entity.ToTable("credit_cards");

                entity.HasIndex(e => e.Id)
                    .HasName("\"CreditCards\"_\"ID\"_uindex")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerId, e.IsDefault, e.IsActive })
                    .HasName("credit_cards_customer_id_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('\"CreditCards_ID_seq\"'::regclass)");

                entity.Property(e => e.CcAssociation)
                    .HasColumnName("cc_association")
                    .HasMaxLength(20);

                entity.Property(e => e.CcType)
                    .HasColumnName("cc_type")
                    .HasMaxLength(15);

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.Last4Digits)
                    .HasColumnName("last_4_digits")
                    .HasMaxLength(4);

                entity.Property(e => e.NameOnCard)
                    .HasColumnName("name_on_card")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentServiceToken)
                    .HasColumnName("payment_service_token")
                    .HasMaxLength(50);

                entity.Property(e => e.UserToken)
                    .HasColumnName("user_token")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerCallRecords>(entity =>
            {
                entity.ToTable("customer_call_records");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Calldate).HasColumnName("calldate");

                entity.Property(e => e.Dst).HasColumnName("dst");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Src)
                    .HasColumnName("src")
                    .HasColumnType("character varying");

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasColumnType("character varying");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("uniqueid")
                    .HasColumnType("character varying");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<CustomerCheckmobiPins>(entity =>
            {
                entity.ToTable("customer_checkmobi_pins");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CheckmobiId)
                    .HasColumnName("checkmobi_id")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.IsVerified).HasColumnName("is_verified");
            });

            modelBuilder.Entity<CustomerDemands>(entity =>
            {
                entity.ToTable("customer_demands");

                entity.HasIndex(e => e.Ts)
                    .HasName("customer_demands_ts_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("numeric");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("numeric");

                entity.Property(e => e.Ts).HasColumnName("ts");
            });

            modelBuilder.Entity<CustomerPhoneNumberHolder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customer_phone_number_holder");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.TempPhoneCountryCode)
                    .HasColumnName("temp_phone_country_code")
                    .HasMaxLength(10);

                entity.Property(e => e.TempPhoneNumber)
                    .HasColumnName("temp_phone_number")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerPopups>(entity =>
            {
                entity.ToTable("customer_popups");

                entity.HasIndex(e => e.Id)
                    .HasName("customer_popups_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.PopupId).HasColumnName("popup_id");

                entity.Property(e => e.ReadDate).HasColumnName("read_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomerReservationDebts>(entity =>
            {
                entity.ToTable("customer_reservation_debts");

                entity.HasIndex(e => new { e.CustomerId, e.ReservationId })
                    .HasName("customer_reservation_debts_customer_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.IsSuccess).HasColumnName("is_success");

                entity.Property(e => e.ReservationId).HasColumnName("reservation_id");

                entity.Property(e => e.UpdateDate).HasColumnName("update_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomerRideDebts>(entity =>
            {
                entity.ToTable("customer_ride_debts");

                entity.HasIndex(e => new { e.CustomerId, e.RideId })
                    .HasName("customer_ride_debts_customer_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.IsSuccess).HasColumnName("is_success");

                entity.Property(e => e.PaymentToken)
                    .HasColumnName("payment_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.RideId).HasColumnName("ride_id");

                entity.Property(e => e.TransactionToken)
                    .HasColumnName("transaction_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdateDate).HasColumnName("update_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomerScooterRequests>(entity =>
            {
                entity.ToTable("customer_scooter_requests");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_scooter_requests_customer_id_idx");

                entity.HasIndex(e => e.Ts)
                    .HasName("customer_scooter_requests_ts_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Latitude)
                    .IsRequired()
                    .HasColumnName("latitude")
                    .HasMaxLength(50);

                entity.Property(e => e.Longitude)
                    .IsRequired()
                    .HasColumnName("longitude")
                    .HasMaxLength(50);

                entity.Property(e => e.Ts).HasColumnName("ts");
            });

            modelBuilder.Entity<CustomerSentNotifications>(entity =>
            {
                entity.ToTable("customer_sent_notifications");

                entity.HasIndex(e => e.Id)
                    .HasName("customer_sent_notifications_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerId, e.IsRead })
                    .HasName("customer_sent_notifications_customer_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.IsRead).HasColumnName("is_read");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(500);

                entity.Property(e => e.ReadDate).HasColumnName("read_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.ToTable("customers");

                entity.HasIndex(e => e.AccessToken)
                    .HasName("customers_access_token_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("\"Customers\"_\"ID\"_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Tckn)
                    .HasName("customers_tckn_idx");

                entity.HasIndex(e => new { e.Id, e.FreeTier })
                    .HasName("customers_id_idx");

                entity.HasIndex(e => new { e.MobilePhone, e.Name })
                    .HasName("customers_mobile_phone_idx");

                entity.HasIndex(e => new { e.MobilePhoneCountryCode, e.MobilePhone })
                    .HasName("customers_mobile_phone_country_code_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('\"Customers_ID_seq\"'::regclass)");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("access_token")
                    .HasMaxLength(100);

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.FreeTier).HasColumnName("free_tier");

                entity.Property(e => e.IdPhoto)
                    .HasColumnName("id_photo")
                    .HasMaxLength(500);

                entity.Property(e => e.IsEnabled)
                    .HasColumnName("is_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.IsKvkkRead).HasColumnName("is_kvkk_read");

                entity.Property(e => e.KvkkDate).HasColumnName("kvkk_date");

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasMaxLength(5);

                entity.Property(e => e.LastSignedinAt)
                    .HasColumnName("last_signedin_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("mobile_phone")
                    .HasMaxLength(50);

                entity.Property(e => e.MobilePhoneCountryCode)
                    .HasColumnName("mobile_phone_country_code")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(1000);

                entity.Property(e => e.OneSignalId)
                    .HasColumnName("one_signal_id")
                    .HasMaxLength(50);

                entity.Property(e => e.SkipVerification)
                    .HasColumnName("skip_verification")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SmsCode)
                    .HasColumnName("sms_code")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Tckn)
                    .HasColumnName("tckn")
                    .HasMaxLength(11);

                entity.Property(e => e.TcknValidated).HasColumnName("tckn_validated");
            });

            modelBuilder.Entity<DailyCurrencies>(entity =>
            {
                entity.ToTable("daily_currencies");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(now())::date");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Decisions>(entity =>
            {
                entity.ToTable("decisions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("character varying");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("decisions_fk");
            });

            modelBuilder.Entity<DeviceCodes>(entity =>
            {
                entity.HasKey(e => e.UserCode);

                entity.HasIndex(e => e.DeviceCode)
                    .IsUnique();

                entity.HasIndex(e => e.Expiration);

                entity.Property(e => e.UserCode).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasMaxLength(50000);

                entity.Property(e => e.DeviceCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SubjectId).HasMaxLength(200);
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.ToTable("districts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Expenses>(entity =>
            {
                entity.ToTable("expenses");

                entity.HasIndex(e => e.Id)
                    .HasName("expenses_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<GeofenceBorderPoints>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("geofence_border_points");

                entity.HasIndex(e => e.Hash)
                    .HasName("fence_id_idx");

                entity.Property(e => e.FenceId).HasColumnName("fence_id");

                entity.Property(e => e.Hash)
                    .HasColumnName("hash")
                    .HasMaxLength(10);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasMaxLength(25);

                entity.Property(e => e.Lon)
                    .HasColumnName("lon")
                    .HasMaxLength(25);

                entity.Property(e => e.PointOrder).HasColumnName("point_order");
            });

            modelBuilder.Entity<GeofenceKeys>(entity =>
            {
                entity.ToTable("geofence_keys");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FenceId).HasColumnName("fence_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PointIndex)
                    .HasColumnName("point_index")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<GeofenceOfficePoints>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("geofence_office_points");

                entity.Property(e => e.GeofenceId).HasColumnName("geofence_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PlaceName)
                    .HasColumnName("place_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasColumnType("character varying(10)[]");
            });

            modelBuilder.Entity<GeofenceParkBorders>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("geofence_park_borders");

                entity.Property(e => e.GeofenceGroup).HasColumnName("geofence_group");

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasColumnName("hash")
                    .HasMaxLength(25);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Lat)
                    .IsRequired()
                    .HasColumnName("lat")
                    .HasMaxLength(25);

                entity.Property(e => e.Lon)
                    .IsRequired()
                    .HasColumnName("lon")
                    .HasMaxLength(25);

                entity.Property(e => e.PointIndex)
                    .IsRequired()
                    .HasColumnName("point_index")
                    .HasMaxLength(50);

                entity.Property(e => e.PointOrder).HasColumnName("point_order");
            });

            modelBuilder.Entity<GeofenceParkPoints>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("geofence_park_points");

                entity.Property(e => e.GeofenceGroup).HasColumnName("geofence_group");

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasColumnName("hash")
                    .HasMaxLength(25);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Lat)
                    .IsRequired()
                    .HasColumnName("lat")
                    .HasMaxLength(25);

                entity.Property(e => e.Lon)
                    .IsRequired()
                    .HasColumnName("lon")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<GeofencePoints>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("geofence_points");

                entity.HasIndex(e => e.Hash)
                    .HasName("hash_idx");

                entity.Property(e => e.FenceId).HasColumnName("fence_id");

                entity.Property(e => e.Hash)
                    .HasColumnName("hash")
                    .HasMaxLength(10);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasMaxLength(25);

                entity.Property(e => e.Lon)
                    .HasColumnName("lon")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<GeofenceRegionPoints>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("geofence_region_points");

                entity.Property(e => e.FenceId).HasColumnName("fence_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MapData).HasColumnName("map_data");
            });

            modelBuilder.Entity<GeofenceRestrictedPoints>(entity =>
            {
                entity.ToTable("geofence_restricted_points");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FenceGroup).HasColumnName("fence_group");

                entity.Property(e => e.IsEnabled).HasColumnName("is_enabled");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasColumnType("json");
            });

            modelBuilder.Entity<Geofences>(entity =>
            {
                entity.ToTable("geofences");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AlwaysOn).HasColumnName("always_on");

                entity.Property(e => e.Center)
                    .HasColumnName("center")
                    .HasMaxLength(7)
                    .IsFixedLength();

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");

                entity.Property(e => e.EnableReservation)
                    .HasColumnName("enable_reservation")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EnableStartPrice)
                    .HasColumnName("enable_start_price")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasMaxLength(10);

                entity.Property(e => e.GeofenceGroup).HasColumnName("geofence_group");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasColumnName("is_visible")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.MsgEn)
                    .HasColumnName("msg_en")
                    .HasMaxLength(255);

                entity.Property(e => e.MsgTr)
                    .HasColumnName("msg_tr")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.RequireCreditCard)
                    .HasColumnName("require_credit_card")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxApplied)
                    .HasColumnName("tax_applied")
                    .HasDefaultValueSql("18");
            });

            modelBuilder.Entity<GovernmentUsers>(entity =>
            {
                entity.ToTable("government_users");

                entity.HasIndex(e => e.Id)
                    .HasName("government_users_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.IsEnabled)
                    .HasColumnName("is_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(32);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(32);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("role")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<InventoryCategories>(entity =>
            {
                entity.ToTable("inventory_categories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("category_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ModelId).HasColumnName("model_id");
            });

            modelBuilder.Entity<InventoryComponentCounts>(entity =>
            {
                entity.ToTable("inventory_component_counts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComponentStockCode)
                    .HasColumnName("component_stock_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.StockCount).HasColumnName("stock_count");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<InventoryComponents>(entity =>
            {
                entity.ToTable("inventory_components");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComponentName)
                    .HasColumnName("component_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ComponentStockCode)
                    .HasColumnName("component_stock_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.ManufacturerPartNumber)
                    .HasColumnName("manufacturer_part_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.PartId).HasColumnName("part_id");

                entity.Property(e => e.QuantityPerScooter).HasColumnName("quantity_per_scooter");
            });

            modelBuilder.Entity<InventoryModel>(entity =>
            {
                entity.ToTable("inventory_model");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BomVersion).HasColumnName("bom_version");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.ModelName)
                    .HasColumnName("model_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ScooterBodyVersionId).HasColumnName("scooter_body_version_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<InventoryPartCounts>(entity =>
            {
                entity.ToTable("inventory_part_counts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetKey)
                    .HasColumnName("asset_key")
                    .HasMaxLength(2);

                entity.Property(e => e.PartStockCode)
                    .HasColumnName("part_stock_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.StockCount).HasColumnName("stock_count");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<InventoryParts>(entity =>
            {
                entity.ToTable("inventory_parts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetKey)
                    .HasColumnName("asset_key")
                    .HasColumnType("character varying");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.ManufacturerPartNumber)
                    .HasColumnName("manufacturer_part_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.PartName)
                    .HasColumnName("part_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.StockCode)
                    .HasColumnName("stock_code")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<InventoryStatus>(entity =>
            {
                entity.ToTable("inventory_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<InvestorData>(entity =>
            {
                entity.ToTable("investor_data");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsEnabled).HasColumnName("is_enabled");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("last_update_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(25);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.ToTable("invoices");

                entity.HasIndex(e => e.InvoiceDate)
                    .HasName("invoices_invoice_date_idx");

                entity.HasIndex(e => e.ProviderType)
                    .HasName("invoices_provider_type_idx");

                entity.HasIndex(e => e.RefId)
                    .HasName("invoices_ref_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CancelledDate).HasColumnName("cancelled_date");

                entity.Property(e => e.ChargedPrice)
                    .HasColumnName("charged_price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("invoice_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.IsCancelled)
                    .HasColumnName("is_cancelled")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IsProcessed).HasColumnName("is_processed");

                entity.Property(e => e.PdfReady)
                    .HasColumnName("pdf_ready")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ProcessedDate).HasColumnName("processed_date");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.ProviderType)
                    .HasColumnName("provider_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.RealInvoiceId)
                    .HasColumnName("real_invoice_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.RefId)
                    .HasColumnName("ref_id")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<IotBoxInventoryHistory>(entity =>
            {
                entity.ToTable("iot_box_inventory_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.IotBoxId).HasColumnName("iot_box_id");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");
            });

            modelBuilder.Entity<IotBoxes>(entity =>
            {
                entity.ToTable("iot_boxes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BodyVersionId).HasColumnName("body_version_id");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ScooterId)
                    .HasColumnName("scooter_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("serial_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StockCode)
                    .HasColumnName("stock_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<IotLockInventoryHistory>(entity =>
            {
                entity.ToTable("iot_lock_inventory_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.IotLockId).HasColumnName("iot_lock_id");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");
            });

            modelBuilder.Entity<IotLocks>(entity =>
            {
                entity.ToTable("iot_locks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BodyVersionId).HasColumnName("body_version_id");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ScooterId)
                    .HasColumnName("scooter_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("serial_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StockCode)
                    .HasColumnName("stock_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<IssueSolutionTypes>(entity =>
            {
                entity.ToTable("issue_solution_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<IssueTypes>(entity =>
            {
                entity.ToTable("issue_types");

                entity.HasIndex(e => e.Id)
                    .HasName("issue_types_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Issues>(entity =>
            {
                entity.ToTable("issues");

                entity.HasIndex(e => e.Id)
                    .HasName("issues_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CallDuration).HasColumnName("call_duration");

                entity.Property(e => e.CaseEndTime).HasColumnName("case_end_time");

                entity.Property(e => e.CaseStartTime).HasColumnName("case_start_time");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(750);

                entity.Property(e => e.CosmicRoomNote)
                    .HasColumnName("cosmic_room_note")
                    .HasColumnType("character varying");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.FinalDecisionId).HasColumnName("final_decision_id");

                entity.Property(e => e.FixedDate).HasColumnName("fixed_date");

                entity.Property(e => e.GeofenceGroup)
                    .HasColumnName("geofence_group")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.IsFixed)
                    .HasColumnName("is_fixed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IssueTypeId).HasColumnName("issue_type_id");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasMaxLength(20);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(500);

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasMaxLength(20);

                entity.Property(e => e.OriginalIssueId).HasColumnName("original_issue_id");

                entity.Property(e => e.OtherText)
                    .HasColumnName("other_text")
                    .HasColumnType("character varying");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousIssueId).HasColumnName("previous_issue_id");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.RedialTime).HasColumnName("redial_time");

                entity.Property(e => e.ReportDate).HasColumnName("report_date");

                entity.Property(e => e.ScooterId)
                    .HasColumnName("scooter_id")
                    .HasMaxLength(50);

                entity.Property(e => e.SolutionDetail)
                    .HasColumnName("solution_detail")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdateUserId).HasColumnName("update_user_id");
            });

            modelBuilder.Entity<KpiReports>(entity =>
            {
                entity.ToTable("kpi_reports");

                entity.HasIndex(e => e.Id)
                    .HasName("kpi_reports_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvgRideTime)
                    .HasColumnName("avg_ride_time")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DiscountsDollar)
                    .HasColumnName("discounts_dollar")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.DiscountsPercent)
                    .HasColumnName("discounts_percent")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.DiscountsTl)
                    .HasColumnName("discounts_tl")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.DollarTl)
                    .HasColumnName("dollar_tl")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.GeofenceGroup)
                    .HasColumnName("geofence_group")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.GrossRevenueDollar)
                    .HasColumnName("gross_revenue_dollar")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.GrossRevenuePerRideDollar)
                    .HasColumnName("gross_revenue_per_ride_dollar")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.GrossRevenuePerRideTl)
                    .HasColumnName("gross_revenue_per_ride_tl")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.GrossRevenuePerScooterDollar)
                    .HasColumnName("gross_revenue_per_scooter_dollar")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.GrossRevenuePerScooterTl)
                    .HasColumnName("gross_revenue_per_scooter_tl")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.GrossRevenueTl)
                    .HasColumnName("gross_revenue_tl")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.GrossScootersAvailableHours)
                    .HasColumnName("gross_scooters_available_hours")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.KmPerRide)
                    .HasColumnName("km_per_ride")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.NetRevenueDollar)
                    .HasColumnName("net_revenue_dollar")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.NetRevenuePerRideDollar)
                    .HasColumnName("net_revenue_per_ride_dollar")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.NetRevenuePerRideTl)
                    .HasColumnName("net_revenue_per_ride_tl")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.NetRevenuePerScooterDollar)
                    .HasColumnName("net_revenue_per_scooter_dollar")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.NetRevenuePerScooterTl)
                    .HasColumnName("net_revenue_per_scooter_tl")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.NetRevenueTl)
                    .HasColumnName("net_revenue_tl")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.NetScooterHoursAvailable)
                    .HasColumnName("net_scooter_hours_available")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.OperationalHours)
                    .HasColumnName("operational_hours")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.Registrations).HasColumnName("registrations");

                entity.Property(e => e.RepairCount).HasColumnName("repair_count");

                entity.Property(e => e.RidesPerScooter)
                    .HasColumnName("rides_per_scooter")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.RidesPerScooterPerHour)
                    .HasColumnName("rides_per_scooter_per_hour")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.RidesPerUniqueUser)
                    .HasColumnName("rides_per_unique_user")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.RollingWeeklyUniqueRiders).HasColumnName("rolling_weekly_unique_riders");

                entity.Property(e => e.ScooterAvailabilityPercent)
                    .HasColumnName("scooter_availability_percent")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ScooterRecovered).HasColumnName("scooter_recovered");

                entity.Property(e => e.ScootersDamagedNotRecoverable).HasColumnName("scooters_damaged_not_recoverable");

                entity.Property(e => e.ScootersDamagedNotRecoverablePercent)
                    .HasColumnName("scooters_damaged_not_recoverable_percent")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ScootersDamagedRecoverable).HasColumnName("scooters_damaged_recoverable");

                entity.Property(e => e.ScootersDamagedRecoverablePercent)
                    .HasColumnName("scooters_damaged_recoverable_percent")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ScootersDeployed).HasColumnName("scooters_deployed");

                entity.Property(e => e.ScootersLost).HasColumnName("scooters_lost");

                entity.Property(e => e.ScootersLostPercent)
                    .HasColumnName("scooters_lost_percent")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ShareOfRepeatUsersAmongUniqueUsers)
                    .HasColumnName("share_of_repeat_users_among_unique_users")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.TotalRegistrations).HasColumnName("total_registrations");

                entity.Property(e => e.TotalRegistrationsUniqueUsersCompletedRidesConversion)
                    .HasColumnName("total_registrations_unique_users_completed_rides_conversion")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.TotalRideKm)
                    .HasColumnName("total_ride_km")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.TotalRideMinutes).HasColumnName("total_ride_minutes");

                entity.Property(e => e.TotalRides).HasColumnName("total_rides");

                entity.Property(e => e.TotalUniqueUsersWhoCompletedRides).HasColumnName("total_unique_users_who_completed_rides");

                entity.Property(e => e.UniqueUsersWhoCompletedRides).HasColumnName("unique_users_who_completed_rides");

                entity.Property(e => e.UnrecoverableRatePercent)
                    .HasColumnName("unrecoverable_rate_percent")
                    .HasColumnType("numeric(10,2)");
            });

            modelBuilder.Entity<KpiValues>(entity =>
            {
                entity.ToTable("kpi_values");

                entity.HasIndex(e => e.KpiDate)
                    .HasName("kpi_values_kpi_date_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvgAvailableSeconds)
                    .HasColumnName("avg_available_seconds")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.AvgRideSeconds)
                    .HasColumnName("avg_ride_seconds")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.FenceGroup).HasColumnName("fence_group");

                entity.Property(e => e.KpiDate)
                    .HasColumnName("kpi_date")
                    .HasColumnType("date");

                entity.Property(e => e.RideCount).HasColumnName("ride_count");

                entity.Property(e => e.TotalCount).HasColumnName("total_count");

                entity.Property(e => e.TotalDeployed).HasColumnName("total_deployed");
            });

            modelBuilder.Entity<MartiHealthChecks>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("marti_health_checks");

                entity.HasIndex(e => e.Id)
                    .HasName("marti_health_checks_id_idx");

                entity.Property(e => e.CcStatus)
                    .HasColumnName("cc_status")
                    .HasMaxLength(25);

                entity.Property(e => e.FotaStatus)
                    .HasColumnName("fota_status")
                    .HasMaxLength(25);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LambdaStatus)
                    .HasColumnName("lambda_status")
                    .HasMaxLength(25);

                entity.Property(e => e.MqttHelperStatus)
                    .HasColumnName("mqtt_helper_status")
                    .HasMaxLength(25);

                entity.Property(e => e.MqttStatus)
                    .HasColumnName("mqtt_status")
                    .HasMaxLength(25);

                entity.Property(e => e.Ts).HasColumnName("ts");
            });

            modelBuilder.Entity<MotorDriverInventoryHistory>(entity =>
            {
                entity.ToTable("motor_driver_inventory_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.MotorDriverId).HasColumnName("motor_driver_id");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");
            });

            modelBuilder.Entity<MotorDrivers>(entity =>
            {
                entity.ToTable("motor_drivers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BodyVersionId).HasColumnName("body_version_id");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ScooterId)
                    .HasColumnName("scooter_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("serial_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StockCode)
                    .HasColumnName("stock_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<MotorInventoryHistory>(entity =>
            {
                entity.ToTable("motor_inventory_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.MotorId).HasColumnName("motor_id");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");
            });

            modelBuilder.Entity<Motors>(entity =>
            {
                entity.ToTable("motors");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BodyVersionId).HasColumnName("body_version_id");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ScooterId)
                    .HasColumnName("scooter_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("serial_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StockCode)
                    .HasColumnName("stock_code")
                    .HasColumnType("character varying");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<OperatingHours>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("operating_hours");

                entity.Property(e => e.Trunc).HasColumnName("trunc");
            });

            modelBuilder.Entity<OperatingHoursMessages>(entity =>
            {
                entity.ToTable("operating_hours_messages");

                entity.HasIndex(e => e.Id)
                    .HasName("operating_hours_messages_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bgcolor)
                    .HasColumnName("bgcolor")
                    .HasMaxLength(10);

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasMaxLength(254);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(254);

                entity.Property(e => e.MessageEn)
                    .HasColumnName("message_en")
                    .HasMaxLength(254);

                entity.Property(e => e.MessageTr)
                    .HasColumnName("message_tr")
                    .HasMaxLength(254);
            });

            modelBuilder.Entity<OperationWorkOrderStatuses>(entity =>
            {
                entity.ToTable("operation_work_order_statuses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.OrderNo).HasColumnName("order_no");
            });

            modelBuilder.Entity<OperationWorkOrders>(entity =>
            {
                entity.ToTable("operation_work_orders");

                entity.HasIndex(e => new { e.Status, e.UserId })
                    .HasName("operation_work_orders_status_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompletedAt).HasColumnName("completed_at");

                entity.Property(e => e.IssuedAt)
                    .HasColumnName("issued_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.IssuedBy).HasColumnName("issued_by");

                entity.Property(e => e.Regions).HasColumnName("regions");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<OperatorActionLog>(entity =>
            {
                entity.ToTable("operator_action_log");

                entity.HasIndex(e => e.CarId)
                    .HasName("operator_action_log_car_id_idx");

                entity.HasIndex(e => e.ScooterId)
                    .HasName("operator_action_log_scooter_id_idx");

                entity.HasIndex(e => e.ToStatusId)
                    .HasName("operator_action_log_to_status_id_idx");

                entity.HasIndex(e => e.WorkOrderId)
                    .HasName("operator_action_log_work_order_id_idx");

                entity.HasIndex(e => new { e.ActionTime, e.CarId })
                    .HasName("operator_action_log_action_time_idx");

                entity.HasIndex(e => new { e.UserId, e.ScooterId })
                    .HasName("operator_action_log_user_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionTime).HasColumnName("action_time");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.FromStatusId).HasColumnName("from_status_id");

                entity.Property(e => e.IsValidated).HasColumnName("is_validated");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(100);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(50);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(50);

                entity.Property(e => e.RepairRecordId).HasColumnName("repair_record_id");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");

                entity.Property(e => e.ToStatusId).HasColumnName("to_status_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.ValidatedBy).HasColumnName("validated_by");

                entity.Property(e => e.ValidationDate).HasColumnName("validation_date");

                entity.Property(e => e.WorkOrderId).HasColumnName("work_order_id");
            });

            modelBuilder.Entity<OperatorLocationLogs>(entity =>
            {
                entity.ToTable("operator_location_logs");

                entity.HasIndex(e => e.Id)
                    .HasName("operator_location_logs_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(16);

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<OutOfOrderRequest>(entity =>
            {
                entity.ToTable("out_of_order_request");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('out_of_use_id_seq'::regclass)");

                entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedNote)
                    .HasColumnName("created_note")
                    .HasColumnType("character varying");

                entity.Property(e => e.IsApproved).HasColumnName("is_approved");

                entity.Property(e => e.RepairId).HasColumnName("repair_id");
            });

            modelBuilder.Entity<PbLocations>(entity =>
            {
                entity.ToTable("pb_locations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("character varying");

                entity.Property(e => e.BankId).HasColumnName("bank_id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.ClockList)
                    .HasColumnName("clock_list")
                    .HasColumnType("character varying[]");

                entity.Property(e => e.CompanyTitle)
                    .HasColumnName("company_title")
                    .HasColumnType("character varying");

                entity.Property(e => e.Iban)
                    .HasColumnName("iban")
                    .HasColumnType("character varying");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasColumnName("is_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(9);

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.OfficialInvoiceAddress)
                    .HasColumnName("official_invoice_address")
                    .HasColumnType("character varying");

                entity.Property(e => e.Photos)
                    .HasColumnName("photos")
                    .HasColumnType("character varying[]");

                entity.Property(e => e.ResponsibleEmail)
                    .HasColumnName("responsible_email")
                    .HasColumnType("character varying");

                entity.Property(e => e.ResponsibleName)
                    .HasColumnName("responsible_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ResponsiblePhone)
                    .HasColumnName("responsible_phone")
                    .HasColumnType("character varying");

                entity.Property(e => e.TaxNumber)
                    .HasColumnName("tax_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.TaxOfficeId)
                    .HasColumnName("tax_office_id")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<PbPowerbanks>(entity =>
            {
                entity.ToTable("pb_powerbanks");

                entity.HasIndex(e => e.Code)
                    .HasName("pb_powerbanks_code_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BatteryLevel).HasColumnName("battery_level");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CurrentSlot).HasColumnName("current_slot");

                entity.Property(e => e.IsInside).HasColumnName("is_inside");

                entity.Property(e => e.LastRentId).HasColumnName("last_rent_id");

                entity.Property(e => e.LastSeenAt)
                    .HasColumnName("last_seen_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.LastSeenStationId).HasColumnName("last_seen_station_id");

                entity.Property(e => e.NeedRepair).HasColumnName("need_repair");

                entity.Property(e => e.RecurringPrice)
                    .HasColumnName("recurring_price")
                    .HasColumnType("numeric(10,2)")
                    .HasDefaultValueSql("5");

                entity.Property(e => e.RepairNote)
                    .HasColumnName("repair_note")
                    .HasColumnType("character varying");

                entity.Property(e => e.StartingPrice)
                    .HasColumnName("starting_price")
                    .HasColumnType("numeric(10,2)")
                    .HasDefaultValueSql("30");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("15");
            });

            modelBuilder.Entity<PbRentReviewCategories>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("pb_rent_review_categories_pk");

                entity.ToTable("pb_rent_review_categories");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ShowNote).HasColumnName("show_note");

                entity.Property(e => e.Stars).HasColumnName("stars");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<PbRentReviews>(entity =>
            {
                entity.ToTable("pb_rent_reviews");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PointsGiven).HasColumnName("points_given");

                entity.Property(e => e.RentId).HasColumnName("rent_id");

                entity.Property(e => e.Review)
                    .HasColumnName("review")
                    .HasMaxLength(255);

                entity.Property(e => e.TagList).HasColumnName("tag_list");
            });

            modelBuilder.Entity<PbRents>(entity =>
            {
                entity.ToTable("pb_rents");

                entity.HasIndex(e => e.IsSuccess)
                    .HasName("pb_rents_is_success_idx");

                entity.HasIndex(e => e.PowerbankId)
                    .HasName("pb_rents_powerbank_id_idx");

                entity.HasIndex(e => e.StartTime)
                    .HasName("pb_rents_start_time_idx");

                entity.HasIndex(e => e.StationId)
                    .HasName("pb_rents_station_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActualPrice)
                    .HasColumnName("actual_price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.AdditionalPaymentToken)
                    .HasColumnName("additional_payment_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.AdditionalTransactionToken)
                    .HasColumnName("additional_transaction_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");

                entity.Property(e => e.ApprovedDate).HasColumnName("approved_date");

                entity.Property(e => e.ChargedPrice)
                    .HasColumnName("charged_price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.FromSlot).HasColumnName("from_slot");

                entity.Property(e => e.IsApproved).HasColumnName("is_approved");

                entity.Property(e => e.IsSuccess).HasColumnName("is_success");

                entity.Property(e => e.PowerbankId).HasColumnName("powerbank_id");

                entity.Property(e => e.ProvisionToken)
                    .HasColumnName("provision_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.ProvisionTransactionToken)
                    .HasColumnName("provision_transaction_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.ReturnStationId).HasColumnName("return_station_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StationId).HasColumnName("station_id");

                entity.Property(e => e.ToSlot).HasColumnName("to_slot");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("total_price")
                    .HasColumnType("numeric(10,2)");
            });

            modelBuilder.Entity<PbStations>(entity =>
            {
                entity.ToTable("pb_stations");

                entity.HasIndex(e => e.Code)
                    .HasName("pb_stations_code_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.LastSeenAt).HasColumnName("last_seen_at");

                entity.Property(e => e.LocationId).HasColumnName("location_id");
            });

            modelBuilder.Entity<PersistedGrants>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.HasIndex(e => e.Expiration);

                entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type });

                entity.Property(e => e.Key).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasMaxLength(50000);

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Popups>(entity =>
            {
                entity.ToTable("popups");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("character varying");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.ToTable("regions");

                entity.HasIndex(e => e.Id)
                    .HasName("regions_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FenceId).HasColumnName("fence_id");

                entity.Property(e => e.IsEnabled)
                    .HasColumnName("is_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.MapData)
                    .HasColumnName("map_data")
                    .HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RepairActionLogReasons>(entity =>
            {
                entity.ToTable("repair_action_log_reasons");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<RepairActionLogs>(entity =>
            {
                entity.ToTable("repair_action_logs");

                entity.HasIndex(e => e.ActionTime)
                    .HasName("repair_action_logs_action_time_idx");

                entity.HasIndex(e => e.RepairRecordId)
                    .HasName("repair_action_logs_repair_record_id_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("repair_action_logs_user_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionTime).HasColumnName("action_time");

                entity.Property(e => e.ActionType).HasColumnName("action_type");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.RepairRecordId).HasColumnName("repair_record_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<RepairControlStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("repair_control_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<RepairResultMaterials>(entity =>
            {
                entity.ToTable("repair_result_materials");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('repair_result_body_material_id_seq'::regclass)");

                entity.Property(e => e.BodyVersion).HasColumnName("body_version");

                entity.Property(e => e.HasQuantity)
                    .HasColumnName("has_quantity")
                    .HasComment("Ekrandan Miktar girilip girilmeyeceğini kontrol eder");

                entity.Property(e => e.HasStockEffect)
                    .HasColumnName("has_stock_effect")
                    .HasComment("Stok miktarından düşülüp düşümeyeceğini kontrol eder / stock_code ve is_part girilmiş has_quantity true olmalı");

                entity.Property(e => e.IsPart)
                    .HasColumnName("is_part")
                    .HasComment("Stok tarafından düşerken hangi tabloya gideceğini belirler / Inventory_Part_Stock_Count - Inventory_Component_Stock_Count");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying")
                    .HasComment("Stoktaki isimle eşleştirilmedi / Stoktan eritilmeyecek materyeller bulunduğundan / UYapıştırıcı kablo vs ");

                entity.Property(e => e.ResultCode)
                    .HasColumnName("result_code")
                    .HasComment("scooter_repair_result_category de vbulunan Result kod alanıyla eşleşmede kullanılır");

                entity.Property(e => e.StockCode)
                    .HasColumnName("stock_code")
                    .HasColumnType("character varying")
                    .HasComment("Stok tarafından düşerken ilgili tabloya gidildikten sonra hangi stoktan düşüleceğini belirler (Id gibi tekildir)");
            });

            modelBuilder.Entity<RepairResultMaterialsUsage>(entity =>
            {
                entity.ToTable("repair_result_materials_usage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NewSerialNo)
                    .HasColumnName("new_serial_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.OldSerialNo)
                    .HasColumnName("old_serial_no")
                    .HasColumnType("character varying");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RepairId).HasColumnName("repair_id");

                entity.Property(e => e.ResultMaterialId)
                    .HasColumnName("result_material_id")
                    .HasComment("repair_result_material tablosundaki id");
            });

            modelBuilder.Entity<ReservationPaymentStatus>(entity =>
            {
                entity.ToTable("reservation_payment_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('reservation_status_id_seq'::regclass)");

                entity.Property(e => e.Order).HasColumnName("order_");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ReservationRefunds>(entity =>
            {
                entity.ToTable("reservation_refunds");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ConversationId)
                    .HasColumnName("conversation_id")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.IsSuccess)
                    .HasColumnName("is_success")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessedDate).HasColumnName("processed_date");

                entity.Property(e => e.ReservationId).HasColumnName("reservation_id");

                entity.Property(e => e.Response)
                    .HasColumnName("response")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Reservations>(entity =>
            {
                entity.ToTable("reservations");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("reservations_customer_id_idx");

                entity.HasIndex(e => e.ScooterId)
                    .HasName("reservations_scooter_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.PaymentServicePaymentToken)
                    .HasColumnName("payment_service_payment_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentServiceTransactionId)
                    .HasColumnName("payment_service_transaction_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.PaymentStatus).HasColumnName("payment_status");

                entity.Property(e => e.PaymentTime).HasColumnName("payment_time");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reservations_fk");

                entity.HasOne(d => d.Scooter)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.ScooterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reservations_fk_1");
            });

            modelBuilder.Entity<RideAccidents>(entity =>
            {
                entity.ToTable("ride_accidents");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccidentDate).HasColumnName("accident_date");

                entity.Property(e => e.AccidentReason).HasColumnName("accident_reason");

                entity.Property(e => e.AccidentType).HasColumnName("accident_type");

                entity.Property(e => e.AccidentTypeNote)
                    .IsRequired()
                    .HasColumnName("accident_type_note")
                    .HasMaxLength(255);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.ExternalSourcesExist).HasColumnName("external_sources_exist");

                entity.Property(e => e.ResponseUserId).HasColumnName("response_user_id");

                entity.Property(e => e.RideId).HasColumnName("ride_id");

                entity.Property(e => e.SeenOnMedia).HasColumnName("seen_on_media");
            });

            modelBuilder.Entity<RideFines>(entity =>
            {
                entity.ToTable("ride_fines");

                entity.HasIndex(e => e.Id)
                    .HasName("ride_fees_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('ride_fees_id_seq'::regclass)");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(500);

                entity.Property(e => e.RideId).HasColumnName("ride_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<RideRefundRequestHistory>(entity =>
            {
                entity.ToTable("ride_refund_request_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.RefundId).HasColumnName("refund_id");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Refund)
                    .WithMany(p => p.RideRefundRequestHistory)
                    .HasForeignKey(d => d.RefundId)
                    .HasConstraintName("ride_refund_request_history_refund_fk");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RideRefundRequestHistory)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ride_refund_request_history_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RideRefundRequestHistory)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ride_refund_request_history_user_fk");
            });

            modelBuilder.Entity<RideRefundRequests>(entity =>
            {
                entity.ToTable("ride_refund_requests");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnName("reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.RideId).HasColumnName("ride_id");

                entity.Property(e => e.Source).HasColumnName("source");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<RideRefunds>(entity =>
            {
                entity.ToTable("ride_refunds");

                entity.HasIndex(e => e.RideId)
                    .HasName("ride_refunds_ride_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ConversationId)
                    .HasColumnName("conversation_id")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.IsSuccess)
                    .HasColumnName("is_success")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessedDate).HasColumnName("processed_date");

                entity.Property(e => e.Response)
                    .HasColumnName("response")
                    .HasMaxLength(50);

                entity.Property(e => e.RideId).HasColumnName("ride_id");
            });

            modelBuilder.Entity<RideRejectOperation>(entity =>
            {
                entity.ToTable("ride_reject_operation");

                entity.HasIndex(e => e.RideId)
                    .HasName("ride_reject_operation_ride_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.IsBlackListAdded).HasColumnName("is_black_list_added");

                entity.Property(e => e.IsNotified).HasColumnName("is_notified");

                entity.Property(e => e.IsPenaltyFeeAdded).HasColumnName("is_penalty_fee_added");

                entity.Property(e => e.NotificationId).HasColumnName("notification_id");

                entity.Property(e => e.PenaltyFee)
                    .HasColumnName("penalty_fee")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.RideId).HasColumnName("ride_id");
            });

            modelBuilder.Entity<RideRejectReasons>(entity =>
            {
                entity.ToTable("ride_reject_reasons");

                entity.HasIndex(e => e.Id)
                    .HasName("ride_reject_reasons_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MessageEn)
                    .HasColumnName("message_en")
                    .HasMaxLength(500);

                entity.Property(e => e.MessageTr)
                    .HasColumnName("message_tr")
                    .HasMaxLength(500);

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RideReviewCategories>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("ride_review_categories_pk");

                entity.ToTable("ride_review_categories");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ShowNote).HasColumnName("show_note");

                entity.Property(e => e.Stars).HasColumnName("stars");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<RideReviews>(entity =>
            {
                entity.ToTable("ride_reviews");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PointsGiven).HasColumnName("points_given");

                entity.Property(e => e.Review)
                    .HasColumnName("review")
                    .HasMaxLength(255);

                entity.Property(e => e.RideId).HasColumnName("ride_id");

                entity.Property(e => e.TagList).HasColumnName("tag_list");
            });

            modelBuilder.Entity<Rides>(entity =>
            {
                entity.ToTable("rides");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("rides_customer_id_idx");

                entity.HasIndex(e => e.GeofenceGroup)
                    .HasName("rides_geofence_group_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("\"CustomerRideHistory\"_\"ID\"_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Photo)
                    .HasName("rides_photo_idx");

                entity.HasIndex(e => e.ScooterId)
                    .HasName("rides_scooter_id_idx");

                entity.HasIndex(e => e.StartTime)
                    .HasName("rides_start_time_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('\"CustomerRideHistory_ID_seq\"'::regclass)");

                entity.Property(e => e.ActualPrice)
                    .HasColumnName("actual_price")
                    .HasColumnType("numeric");

                entity.Property(e => e.AdditionalPaymentTransaction)
                    .HasColumnName("additional_payment_transaction")
                    .HasMaxLength(255);

                entity.Property(e => e.ApprovedDate).HasColumnName("approved_date");

                entity.Property(e => e.ApprovedNote)
                    .HasColumnName("approved_note")
                    .HasMaxLength(500);

                entity.Property(e => e.ApprovedUserId).HasColumnName("approved_user_id");

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.ChargedPrice)
                    .HasColumnName("charged_price")
                    .HasColumnType("numeric");

                entity.Property(e => e.CreditCardId).HasColumnName("credit_card_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Distance).HasColumnName("distance");

                entity.Property(e => e.EndMileage).HasColumnName("end_mileage");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.GeofenceGroup).HasColumnName("geofence_group");

                entity.Property(e => e.IsApproved).HasColumnName("is_approved");

                entity.Property(e => e.LastRidePoint)
                    .HasColumnName("last_ride_point")
                    .HasMaxLength(20);

                entity.Property(e => e.MapData).HasColumnName("map_data");

                entity.Property(e => e.PaymentServicePaymentToken)
                    .HasColumnName("payment_service_payment_token")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentServiceTransactionId)
                    .HasColumnName("payment_service_transaction_id")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentSuccessful).HasColumnName("payment_successful");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvisionTransaction)
                    .HasColumnName("provision_transaction")
                    .HasMaxLength(255);

                entity.Property(e => e.ReservationId).HasColumnName("reservation_id");

                entity.Property(e => e.ReservationPrice)
                    .HasColumnName("reservation_price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.RideRefundedByMileage).HasColumnName("ride_refunded_by_mileage");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");

                entity.Property(e => e.StartMileage).HasColumnName("start_mileage");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("total_price")
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Rides)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("rides_customers_fk");

                entity.HasOne(d => d.Scooter)
                    .WithMany(p => p.Rides)
                    .HasForeignKey(d => d.ScooterId)
                    .HasConstraintName("rides_scooters_fk");
            });

            modelBuilder.Entity<RidesOverFiveMins>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rides_over_five_mins");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsFixed).HasColumnName("is_fixed");

                entity.Property(e => e.RideId).HasColumnName("ride_id");
            });

            modelBuilder.Entity<RidingPaymentErrors>(entity =>
            {
                entity.ToTable("riding_payment_errors");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreditCardId).HasColumnName("credit_card_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.ErrorTime).HasColumnName("error_time");

                entity.Property(e => e.IsFixed)
                    .HasColumnName("is_fixed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(255);

                entity.Property(e => e.RideId).HasColumnName("ride_id");
            });

            modelBuilder.Entity<RoleClaims>(entity =>
            {
                entity.ToTable("role_claims");

                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClaimType).HasColumnName("claim_type");

                entity.Property(e => e.ClaimValue).HasColumnName("claim_value");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<RoleRights>(entity =>
            {
                entity.ToTable("role_rights");

                entity.HasIndex(e => e.Id)
                    .HasName("role_rights_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.SecurityKey)
                    .HasColumnName("security_key")
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasDefaultValueSql("true");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.HasIndex(e => e.Id)
                    .HasName("roles_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250);

                entity.Property(e => e.IsEnabled)
                    .HasColumnName("is_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.IsSystemRole)
                    .HasColumnName("is_system_role")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ScooterAlertDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("scooter_alert_detail");

                entity.Property(e => e.GpsError).HasColumnName("gps_error");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsFixed).HasColumnName("is_fixed");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<ScooterBodies>(entity =>
            {
                entity.ToTable("scooter_bodies");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.ScooterBodyVersionId).HasColumnName("scooter_body_version_id");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");
            });

            modelBuilder.Entity<ScooterBodyHistory>(entity =>
            {
                entity.ToTable("scooter_body_history");

                entity.HasIndex(e => e.BodyId)
                    .HasName("scooter_body_history_body_id_idx");

                entity.HasIndex(e => e.CreatedAt)
                    .HasName("scooter_body_history_created_at_idx");

                entity.HasIndex(e => e.ScooterId)
                    .HasName("scooter_body_history_scooter_id_idx2");

                entity.HasIndex(e => new { e.ScooterId, e.BodyId })
                    .HasName("scooter_body_history_scooter_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BatteryId).HasColumnName("battery_id");

                entity.Property(e => e.BodyId).HasColumnName("body_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.MotorDriverId).HasColumnName("motor_driver_id");

                entity.Property(e => e.MotorId).HasColumnName("motor_id");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");
            });

            modelBuilder.Entity<ScooterBodyVersions>(entity =>
            {
                entity.ToTable("scooter_body_versions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ScooterErrorMessages>(entity =>
            {
                entity.ToTable("scooter_error_messages");

                entity.HasIndex(e => e.Code)
                    .HasName("scooter_error_messages_code_idx");

                entity.HasIndex(e => e.Ts)
                    .HasName("scooter_error_messages_ts_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(4);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(255);

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Ts).HasColumnName("ts");
            });

            modelBuilder.Entity<ScooterErrors>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("scooter_errors");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(4);

                entity.Property(e => e.ErrorCode).HasColumnName("error_code");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<ScooterErrorsBacklog>(entity =>
            {
                entity.ToTable("scooter_errors_backlog");

                entity.HasIndex(e => e.Code)
                    .HasName("scooter_errors_backlog_code_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('scooter_errors_backlog_aydi_seq'::regclass)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(4);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(255);

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Ts).HasColumnName("ts");
            });

            modelBuilder.Entity<ScooterLockCodeHistory>(entity =>
            {
                entity.ToTable("scooter_lock_code_history");

                entity.HasIndex(e => e.ScooterId)
                    .HasName("scooter_lock_code_history_scooter_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<ScooterPrices>(entity =>
            {
                entity.ToTable("scooter_prices");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GeofenceGroup).HasColumnName("geofence_group");

                entity.Property(e => e.RecurringPrice)
                    .HasColumnName("recurring_price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ReservationPrice)
                    .HasColumnName("reservation_price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ScooterBodyVersionId).HasColumnName("scooter_body_version_id");

                entity.Property(e => e.StartingPrice)
                    .HasColumnName("starting_price")
                    .HasColumnType("numeric(10,2)");
            });

            modelBuilder.Entity<ScooterRepairCategories>(entity =>
            {
                entity.ToTable("scooter_repair_categories");

                entity.HasIndex(e => e.Id)
                    .HasName("scooter_repair_categories_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupName)
                    .HasColumnName("group_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.ResultCodes).HasColumnName("result_codes");
            });

            modelBuilder.Entity<ScooterRepairLogs>(entity =>
            {
                entity.ToTable("scooter_repair_logs");

                entity.HasIndex(e => e.Id)
                    .HasName("scooter_repair_logs_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(500);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(50);

                entity.Property(e => e.RepairLogId).HasColumnName("repair_log_id");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");

                entity.Property(e => e.ScooterRepairCategoryId).HasColumnName("scooter_repair_category_id");

                entity.Property(e => e.ScooterRepairResultCategoryId).HasColumnName("scooter_repair_result_category_id");

                entity.Property(e => e.ScooterRepairTypeId).HasColumnName("scooter_repair_type_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<ScooterRepairRecords>(entity =>
            {
                entity.ToTable("scooter_repair_records");

                entity.HasIndex(e => e.CreatedDate)
                    .HasName("scooter_repair_records_created_date_idx");

                entity.HasIndex(e => e.IsFixed)
                    .HasName("scooter_repair_records_is_fixed_idx");

                entity.HasIndex(e => e.ScooterId)
                    .HasName("scooter_repair_records_scooter_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CloseDate).HasColumnName("close_date");

                entity.Property(e => e.CloseUser).HasColumnName("close_user");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedUser).HasColumnName("created_user");

                entity.Property(e => e.IsCanceled).HasColumnName("is_canceled");

                entity.Property(e => e.IsChecked).HasColumnName("is_checked");

                entity.Property(e => e.IsFixed).HasColumnName("is_fixed");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("character varying");

                entity.Property(e => e.RepairCategoryId).HasColumnName("repair_category_id");

                entity.Property(e => e.RepairNote)
                    .IsRequired()
                    .HasColumnName("repair_note")
                    .HasMaxLength(255);

                entity.Property(e => e.RepairResultCategoryId).HasColumnName("repair_result_category_id");

                entity.Property(e => e.RepairTypeId).HasColumnName("repair_type_id");

                entity.Property(e => e.RepairUserId).HasColumnName("repair_user_id");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<ScooterRepairResultCategories>(entity =>
            {
                entity.ToTable("scooter_repair_result_categories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ResultCode).HasColumnName("result_code");
            });

            modelBuilder.Entity<ScooterRepairTypes>(entity =>
            {
                entity.ToTable("scooter_repair_types");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('scooter_repair_type_id_seq'::regclass)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ScooterStatus>(entity =>
            {
                entity.ToTable("scooter_status");

                entity.HasIndex(e => e.Id)
                    .HasName("\"ScooterStatus\"_\"ID\"_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('\"ScooterStatus_ID_seq\"'::regclass)");

                entity.Property(e => e.GroupName)
                    .HasColumnName("group_name")
                    .HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");
            });

            modelBuilder.Entity<ScooterSubstatus>(entity =>
            {
                entity.ToTable("scooter_substatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderNo).HasColumnName("order_no");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ScooterSubstatus)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("scooter_substatus_fk");
            });

            modelBuilder.Entity<ScooterUnavailableReasons>(entity =>
            {
                entity.ToTable("scooter_unavailable_reasons");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(10);

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");
            });

            modelBuilder.Entity<ScooterUpdateLog>(entity =>
            {
                entity.ToTable("scooter_update_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ErrorCount).HasColumnName("error_count");

                entity.Property(e => e.OkCount).HasColumnName("ok_count");

                entity.Property(e => e.Ts).HasColumnName("ts");
            });

            modelBuilder.Entity<ScooterVersions>(entity =>
            {
                entity.ToTable("scooter_versions");

                entity.HasIndex(e => e.Id)
                    .HasName("table_name_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('table_name_id_seq'::regclass)");

                entity.Property(e => e.CurrentFirmwareVersion)
                    .HasColumnName("current_firmware_version")
                    .HasMaxLength(25);

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Scooters>(entity =>
            {
                entity.ToTable("scooters");

                entity.HasIndex(e => e.Code)
                    .HasName("scooters_code_idx");

                entity.HasIndex(e => e.GeofenceGroup)
                    .HasName("scooters_geofence_id_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("Scooters_\"ID\"_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.StatusId)
                    .HasName("scooters_status_id2_idx");

                entity.HasIndex(e => new { e.StatusId, e.GeofenceGroup })
                    .HasName("scooters_status_id3_idx");

                entity.HasIndex(e => new { e.StatusId, e.Version })
                    .HasName("scooters_status_id_idx");

                entity.HasIndex(e => new { e.StatusId, e.Version, e.IsAvailable })
                    .HasName("scooters_status_id5_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('\"scooters_ID_seq\"'::regclass)");

                entity.Property(e => e.Attention).HasColumnName("attention");

                entity.Property(e => e.BatteryStatus).HasColumnName("battery_status");

                entity.Property(e => e.BtMac)
                    .HasColumnName("bt_mac")
                    .HasMaxLength(25);

                entity.Property(e => e.ChargingStationId).HasColumnName("charging_station_id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.FirmwareVersion)
                    .IsRequired()
                    .HasColumnName("firmware_version")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GeofenceGroup)
                    .HasColumnName("geofence_group")
                    .HasDefaultValueSql("10");

                entity.Property(e => e.GsmAvailable)
                    .IsRequired()
                    .HasColumnName("gsm_available")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.GsmLocation)
                    .HasColumnName("gsm_location")
                    .HasMaxLength(10);

                entity.Property(e => e.Hdop)
                    .HasColumnName("hdop")
                    .HasDefaultValueSql("4.0");

                entity.Property(e => e.IotLocked).HasColumnName("iot_locked");

                entity.Property(e => e.IsAvailable)
                    .IsRequired()
                    .HasColumnName("is_available")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.LastFotaTime)
                    .HasColumnName("last_fota_time")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.LastKnownPoint)
                    .IsRequired()
                    .HasColumnName("last_known_point")
                    .HasMaxLength(16)
                    .HasDefaultValueSql("'sxk9hu93p'::character varying");

                entity.Property(e => e.LastLockedTime).HasColumnName("last_locked_time");

                entity.Property(e => e.LastRideId)
                    .HasColumnName("last_ride_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastStolenTime).HasColumnName("last_stolen_time");

                entity.Property(e => e.LastUpdateTime).HasColumnName("last_update_time");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.LockCode)
                    .HasColumnName("lock_code")
                    .HasMaxLength(4);

                entity.Property(e => e.MobilePhoneNumber)
                    .HasColumnName("mobile_phone_number")
                    .HasMaxLength(15);

                entity.Property(e => e.ModuleBatteryStatus).HasColumnName("module_battery_status");

                entity.Property(e => e.MqttPassword)
                    .HasColumnName("mqtt_password")
                    .HasMaxLength(50);

                entity.Property(e => e.NeedRepair)
                    .HasColumnName("need_repair")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.NeedRepairNote)
                    .HasColumnName("need_repair_note")
                    .HasMaxLength(200);

                entity.Property(e => e.RecurringPrice)
                    .HasColumnName("recurring_price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.ReservationPrice)
                    .HasColumnName("reservation_price")
                    .HasColumnType("numeric(10,2)")
                    .HasDefaultValueSql("0.05");

                entity.Property(e => e.ScooterBodyVersionId).HasColumnName("scooter_body_version_id");

                entity.Property(e => e.SimCardNo)
                    .HasColumnName("sim_card_no")
                    .HasMaxLength(50);

                entity.Property(e => e.StartingPrice)
                    .HasColumnName("starting_price")
                    .HasColumnType("numeric(10,2)");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.SubStatus).HasColumnName("sub_status");

                entity.Property(e => e.Timezone)
                    .HasColumnName("timezone")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.TotalKm)
                    .HasColumnName("total_km")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<SecurityRights>(entity =>
            {
                entity.ToTable("security_rights");

                entity.HasIndex(e => e.Key)
                    .HasName("security_rights_key_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    ; //.HasDefaultValueSql("nextval('security_rights_id_seq1'::regclass)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasMaxLength(50)
                    ; //.HasDefaultValueSql("nextval('security_rights_id_seq'::regclass)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SwappableBatteryStatus>(entity =>
            {
                entity.ToTable("swappable_battery_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.Order).HasColumnName("order_");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.ToTable("tasks");

                entity.HasIndex(e => new { e.TaskType, e.Status })
                    .HasName("tasks_task_type_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BatteryId).HasColumnName("battery_id");

                entity.Property(e => e.BlockedBy).HasColumnName("blocked_by");

                entity.Property(e => e.BlockedReason)
                    .HasColumnName("blocked_reason")
                    .HasColumnType("character varying");

                entity.Property(e => e.CancelledBy).HasColumnName("cancelled_by");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ScooterId).HasColumnName("scooter_id");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TaskCount).HasColumnName("task_count");

                entity.Property(e => e.TaskLocation)
                    .HasColumnName("task_location")
                    .HasColumnType("character varying");

                entity.Property(e => e.TaskOwner).HasColumnName("task_owner");

                entity.Property(e => e.TaskType).HasColumnName("task_type");

                entity.Property(e => e.ToLocation)
                    .HasColumnName("to_location")
                    .HasColumnType("character varying");

                entity.Property(e => e.ValidUntil).HasColumnName("valid_until");
            });

            modelBuilder.Entity<TaxOffices>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tax_offices");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("character varying");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<UserActionReasons>(entity =>
            {
                entity.ToTable("user_action_reasons");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionType)
                    .IsRequired()
                    .HasColumnName("action_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnName("reason")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<UserBreaks>(entity =>
            {
                entity.ToTable("user_breaks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BreakReasonId).HasColumnName("break_reason_id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.OtherText)
                    .HasColumnName("other_text")
                    .HasColumnType("character varying");

                entity.Property(e => e.ShiftNo).HasColumnName("shift_no");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UserClaims>(entity =>
            {
                entity.ToTable("user_claims");

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClaimType).HasColumnName("claim_type");

                entity.Property(e => e.ClaimValue).HasColumnName("claim_value");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserGeofences>(entity =>
            {
                entity.ToTable("user_geofences");

                entity.HasIndex(e => e.Id)
                    .HasName("user_geofences_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GeofenceGroup).HasColumnName("geofence_group");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.ToTable("user_logins");

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasColumnName("login_provider");

                entity.Property(e => e.ProviderKey).HasColumnName("provider_key");

                entity.Property(e => e.ProviderDisplayName).HasColumnName("provider_display_name");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserRights>(entity =>
            {
                entity.ToTable("user_rights");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RightId).HasColumnName("right_id");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("user_roles");

                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserShifts>(entity =>
            {
                entity.ToTable("user_shifts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.FenceGroup).HasColumnName("fence_group");

                entity.Property(e => e.ShiftDate).HasColumnName("shift_date");

                entity.Property(e => e.ShiftNo).HasColumnName("shift_no");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");
            });

            modelBuilder.Entity<UserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.ToTable("user_tokens");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.LoginProvider).HasColumnName("login_provider");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.AccessToken)
                    .HasName("users_access_token_idx");

                entity.HasIndex(e => e.Id)
                    .HasName("users_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("access_token")
                    .HasMaxLength(64);

                entity.Property(e => e.AgentId)
                    .HasColumnName("agent_id")
                    .HasColumnType("character varying");

                entity.Property(e => e.ClaimIds).HasColumnName("claim_ids");

                entity.Property(e => e.ControlcenterLogin)
                    .HasColumnName("controlcenter_login")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.GeofenceIdList).HasColumnName("geofence_id_list");

                entity.Property(e => e.IsEnabled)
                    .HasColumnName("is_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.LastSignedInAt).HasColumnName("last_signed_in_at");

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("mobile_phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.OneSignalId)
                    .HasColumnName("one_signal_id")
                    .HasMaxLength(100);

                entity.Property(e => e.OtpToken)
                    .HasColumnName("otp_token")
                    .HasMaxLength(4);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Warehouses>(entity =>
            {
                entity.ToTable("warehouses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.GeofenceGroup).HasColumnName("geofence_group");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.WarehouseName)
                    .HasColumnName("warehouse_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<WorkOrders>(entity =>
            {
                entity.ToTable("work_orders");

                entity.HasIndex(e => e.Id)
                    .HasName("work_orders_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Personel)
                    .HasName("idx_personel")
                    .HasMethod("gin");

                entity.HasIndex(e => new { e.CompletedDate, e.Date, e.CarId, e.PersonelId })
                    .HasName("find_work_order_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.CompletedDate).HasColumnName("completed_date");

                entity.Property(e => e.CompletedUserId).HasColumnName("completed_user_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.IsCompleted)
                    .HasColumnName("is_completed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(500);

                entity.Property(e => e.Personel).HasColumnName("personel");

                entity.Property(e => e.PersonelId).HasColumnName("personel_id");

                entity.Property(e => e.Regions).HasColumnName("regions");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<Zones>(entity =>
            {
                entity.ToTable("zones");

                entity.HasIndex(e => e.Id)
                    .HasName("zones_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.RegionId)
                    .HasName("zones_region_id_idx");

                entity.HasIndex(e => new { e.IsEnabled, e.RegionId })
                    .HasName("regions_is_enabled");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsEnabled)
                    .HasColumnName("is_enabled")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasMaxLength(50);

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.ScooterCount).HasColumnName("scooter_count");
            });

            modelBuilder.HasSequence("security_rights_id_seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
