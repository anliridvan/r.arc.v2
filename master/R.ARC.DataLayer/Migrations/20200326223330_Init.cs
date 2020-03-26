using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace R.ARC.Core.DataLayer.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "security_rights_id_seq");

            migrationBuilder.CreateTable(
                name: "api_resources",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(nullable: true),
                    display_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_api_resources", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "awsdms_ddl_audit",
                columns: table => new
                {
                    c_key = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    c_time = table.Column<DateTime>(nullable: true),
                    c_user = table.Column<string>(maxLength: 64, nullable: true),
                    c_txn = table.Column<string>(maxLength: 16, nullable: true),
                    c_tag = table.Column<string>(maxLength: 24, nullable: true),
                    c_oid = table.Column<int>(nullable: true),
                    c_name = table.Column<string>(maxLength: 64, nullable: true),
                    c_schema = table.Column<string>(maxLength: 64, nullable: true),
                    c_ddlqry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("awsdms_ddl_audit_pkey", x => x.c_key);
                });

            migrationBuilder.CreateTable(
                name: "backend_config",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    android_ver = table.Column<string>(maxLength: 25, nullable: true),
                    ios_ver = table.Column<string>(maxLength: 25, nullable: true),
                    current_fw_version = table.Column<string>(maxLength: 50, nullable: true),
                    start_time = table.Column<string>(maxLength: 10, nullable: true),
                    end_time = table.Column<string>(maxLength: 10, nullable: true),
                    msg_en = table.Column<string>(maxLength: 255, nullable: true),
                    msg_tr = table.Column<string>(maxLength: 255, nullable: true),
                    bg_color = table.Column<string>(maxLength: 10, nullable: true),
                    img_url = table.Column<string>(maxLength: 255, nullable: true),
                    icon = table.Column<string>(maxLength: 255, nullable: true),
                    starting_price = table.Column<string>(maxLength: 10, nullable: true),
                    price_per_minute = table.Column<string>(maxLength: 10, nullable: true),
                    fine_amount = table.Column<int>(nullable: true),
                    provision_price = table.Column<string>(maxLength: 10, nullable: true),
                    rate_us_ride_count = table.Column<int>(nullable: true),
                    rate_us_period = table.Column<int>(nullable: true),
                    android_operator_ver = table.Column<string>(maxLength: 25, nullable: true),
                    android_service_ver = table.Column<string>(maxLength: 25, nullable: true),
                    ios_operator_ver = table.Column<string>(maxLength: 25, nullable: true),
                    ios_service_ver = table.Column<string>(maxLength: 25, nullable: true),
                    max_ride_debt_value = table.Column<int>(nullable: false, defaultValueSql: "15"),
                    android_service_url = table.Column<string>(type: "character varying", nullable: true),
                    android_operator_url = table.Column<string>(type: "character varying", nullable: true),
                    ios_service_url = table.Column<string>(type: "character varying", nullable: true),
                    ios_operator_url = table.Column<string>(type: "character varying", nullable: true),
                    reservation_notification_minutes = table.Column<int>(nullable: false, defaultValueSql: "15"),
                    list_availables_zoom_level = table.Column<int>(nullable: true),
                    pb_rent_price = table.Column<string>(type: "character varying", nullable: true),
                    pb_provision_price = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_backend_config", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "backend_errors",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date_occurred = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    error_string = table.Column<string>(maxLength: 255, nullable: false),
                    url_path = table.Column<string>(maxLength: 255, nullable: false),
                    access_token = table.Column<string>(maxLength: 255, nullable: true),
                    ip = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "'0.0.0.0'::character varying")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_backend_errors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "banks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", nullable: false),
                    country_id = table.Column<int>(nullable: false),
                    is_active = table.Column<bool>(nullable: false),
                    is_enabled = table.Column<bool>(nullable: false),
                    eft_code = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "batteries",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    serial_no = table.Column<string>(type: "character varying", nullable: true),
                    life = table.Column<int>(nullable: false),
                    scooter_id = table.Column<int>(nullable: true, defaultValueSql: "0"),
                    status = table.Column<int>(nullable: true),
                    body_version_id = table.Column<int>(nullable: true),
                    warehouse_id = table.Column<int>(nullable: false),
                    price = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    swappable_battery_status = table.Column<int>(nullable: false),
                    stock_code = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_batteries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "battery_action_logs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    battery_id = table.Column<int>(nullable: false),
                    to_scooter_id = table.Column<int>(nullable: true),
                    from_scooter_id = table.Column<int>(nullable: true),
                    user_id = table.Column<int>(nullable: false),
                    from_status = table.Column<int>(nullable: false),
                    to_status = table.Column<int>(nullable: false),
                    action_time = table.Column<DateTime>(nullable: false),
                    geofence_group = table.Column<int>(nullable: true),
                    location = table.Column<string>(type: "character varying", nullable: true),
                    warehouse_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_battery_action_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "call_center_users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(nullable: false),
                    agent_id = table.Column<string>(type: "character varying", nullable: false),
                    username = table.Column<string>(type: "character varying", nullable: false),
                    password = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_call_center_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "campaigns",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    campaign_name = table.Column<string>(maxLength: 255, nullable: false),
                    description = table.Column<string>(maxLength: 255, nullable: false),
                    start_time = table.Column<DateTime>(nullable: false),
                    end_time = table.Column<DateTime>(nullable: false),
                    discount_value = table.Column<int>(nullable: false),
                    discount_type = table.Column<int>(nullable: false),
                    discount_on = table.Column<int>(nullable: false),
                    campaign_type = table.Column<int>(nullable: false),
                    created_by = table.Column<int>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    is_active = table.Column<bool>(nullable: false),
                    discount_max_usable_time = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    detail_file_path = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_campaigns", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "campaigns_customers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    campaign_id = table.Column<int>(nullable: false),
                    customer_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_campaigns_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cancellation_requests",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(nullable: false),
                    provider_type = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: true),
                    requested_by = table.Column<int>(nullable: false),
                    requested_at = table.Column<DateTime>(nullable: false),
                    processed_by = table.Column<int>(nullable: true),
                    processed_at = table.Column<DateTime>(nullable: true),
                    reject_reason = table.Column<string>(type: "character varying", nullable: true),
                    request_reason = table.Column<string>(type: "character varying", nullable: true),
                    is_reported = table.Column<bool>(nullable: true, defaultValueSql: "false"),
                    reported_at = table.Column<DateTime>(nullable: true),
                    ride_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cancellation_requests", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "car_deliveries",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    car_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: false),
                    picked_at = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    delivered_at = table.Column<DateTime>(nullable: true),
                    pick_km = table.Column<int>(nullable: true),
                    picking_photos = table.Column<string[]>(nullable: true),
                    delivering_photos = table.Column<string[]>(nullable: true),
                    has_issue = table.Column<bool>(nullable: true),
                    issue = table.Column<string>(type: "character varying", nullable: true),
                    deliver_km = table.Column<int>(nullable: true),
                    assistant_user_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car_deliveries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "card_add_status",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(nullable: false),
                    bin_number = table.Column<string>(maxLength: 25, nullable: true),
                    ts = table.Column<DateTime>(nullable: true),
                    card_type = table.Column<string>(maxLength: 25, nullable: true),
                    card_association = table.Column<string>(maxLength: 25, nullable: true),
                    card_family_name = table.Column<string>(maxLength: 50, nullable: true),
                    force3ds = table.Column<bool>(nullable: true),
                    vendor_error_code = table.Column<string>(maxLength: 25, nullable: true),
                    vendor_error_message = table.Column<string>(maxLength: 25, nullable: true),
                    success = table.Column<bool>(nullable: true),
                    bank_name = table.Column<string>(maxLength: 50, nullable: true),
                    vendor_error_group = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_card_add_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    plate = table.Column<string>(maxLength: 10, nullable: true),
                    name = table.Column<string>(maxLength: 20, nullable: true),
                    driver_1 = table.Column<int>(nullable: true),
                    driver_2 = table.Column<int>(nullable: true),
                    phone_mac = table.Column<string>(maxLength: 25, nullable: true),
                    fence_group = table.Column<int>(nullable: true),
                    drivers = table.Column<int[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "charge_stations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    latitude = table.Column<string>(maxLength: 20, nullable: true),
                    longitude = table.Column<string>(maxLength: 20, nullable: true),
                    geofence_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_charge_stations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", nullable: true),
                    code = table.Column<string>(type: "character varying", nullable: true),
                    country_id = table.Column<int>(nullable: true),
                    geohash_list = table.Column<string[]>(type: "character varying[]", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "claims",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    description = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_claims", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    client_id = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    uri = table.Column<string>(nullable: true),
                    secret = table.Column<string>(nullable: true),
                    allowed_scopes = table.Column<string[]>(nullable: true),
                    is_enabled = table.Column<bool>(nullable: false),
                    access_token_life_time = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    country_code = table.Column<string>(maxLength: 10, nullable: true),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    iso_code = table.Column<string>(maxLength: 2, nullable: true),
                    icon = table.Column<string>(maxLength: 6, nullable: true),
                    order = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "coupons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(maxLength: 10, nullable: false),
                    customer_id = table.Column<long>(nullable: true),
                    is_used = table.Column<bool>(nullable: false),
                    ride_id = table.Column<long>(nullable: true),
                    amount = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    used_at = table.Column<DateTime>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    expires_at = table.Column<DateTime>(nullable: true),
                    user_id = table.Column<long>(nullable: false),
                    customer_expires_at = table.Column<DateTime>(nullable: true),
                    batch_key = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coupons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "credit_cards",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(nullable: true),
                    last_4_digits = table.Column<string>(maxLength: 4, nullable: true),
                    created_date = table.Column<DateTime>(nullable: true),
                    payment_service_token = table.Column<string>(maxLength: 50, nullable: true),
                    is_default = table.Column<bool>(nullable: true),
                    name_on_card = table.Column<string>(maxLength: 100, nullable: true),
                    is_active = table.Column<bool>(nullable: true),
                    user_token = table.Column<string>(maxLength: 50, nullable: true),
                    cc_type = table.Column<string>(maxLength: 15, nullable: true),
                    cc_association = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_credit_cards", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customer_call_records",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "character varying", nullable: true),
                    surname = table.Column<string>(type: "character varying", nullable: true),
                    src = table.Column<string>(type: "character varying", nullable: true),
                    dst = table.Column<long>(nullable: true),
                    calldate = table.Column<DateTime>(nullable: true),
                    duration = table.Column<int>(nullable: true),
                    uid = table.Column<string>(type: "character varying", nullable: true),
                    uniqueid = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_call_records", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customer_checkmobi_pins",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(nullable: true),
                    checkmobi_id = table.Column<string>(maxLength: 255, nullable: true),
                    is_verified = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_checkmobi_pins", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customer_demands",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<long>(nullable: false),
                    latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    longitude = table.Column<decimal>(type: "numeric", nullable: false),
                    ts = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_demands", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customer_phone_number_holder",
                columns: table => new
                {
                    customer_id = table.Column<int>(nullable: true),
                    temp_phone_country_code = table.Column<string>(maxLength: 10, nullable: true),
                    temp_phone_number = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "customer_popups",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    user_id = table.Column<int>(nullable: true),
                    is_read = table.Column<bool>(nullable: false),
                    popup_id = table.Column<int>(nullable: false),
                    read_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_popups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customer_reservation_debts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(nullable: false),
                    reservation_id = table.Column<int>(nullable: false),
                    card_id = table.Column<int>(nullable: false),
                    amount = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    created_date = table.Column<DateTime>(nullable: false),
                    update_date = table.Column<DateTime>(nullable: true),
                    is_success = table.Column<bool>(nullable: false),
                    user_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_reservation_debts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customer_ride_debts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(nullable: false),
                    ride_id = table.Column<int>(nullable: false),
                    card_id = table.Column<int>(nullable: true),
                    amount = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    created_date = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    update_date = table.Column<DateTime>(nullable: true),
                    is_success = table.Column<bool>(nullable: false),
                    user_id = table.Column<long>(nullable: true),
                    payment_token = table.Column<string>(type: "character varying", nullable: true),
                    transaction_token = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_ride_debts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customer_scooter_requests",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<long>(nullable: false),
                    latitude = table.Column<string>(maxLength: 50, nullable: false),
                    longitude = table.Column<string>(maxLength: 50, nullable: false),
                    ts = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_scooter_requests", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customer_sent_notifications",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: true),
                    message = table.Column<string>(maxLength: 500, nullable: true),
                    user_id = table.Column<int>(nullable: true),
                    is_read = table.Column<bool>(nullable: false),
                    read_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_sent_notifications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    mobile_phone_country_code = table.Column<string>(maxLength: 10, nullable: true),
                    mobile_phone = table.Column<string>(maxLength: 50, nullable: true),
                    sms_code = table.Column<string>(fixedLength: true, maxLength: 4, nullable: true),
                    access_token = table.Column<string>(maxLength: 100, nullable: true),
                    is_enabled = table.Column<bool>(nullable: true, defaultValueSql: "true"),
                    language = table.Column<string>(maxLength: 5, nullable: true),
                    one_signal_id = table.Column<string>(maxLength: 50, nullable: true),
                    skip_verification = table.Column<bool>(nullable: true, defaultValueSql: "false"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    last_signedin_at = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    free_tier = table.Column<bool>(nullable: false),
                    tckn = table.Column<string>(maxLength: 11, nullable: true),
                    birthdate = table.Column<DateTime>(type: "date", nullable: true),
                    notes = table.Column<string>(maxLength: 1000, nullable: true),
                    is_kvkk_read = table.Column<bool>(nullable: false),
                    kvkk_date = table.Column<DateTime>(nullable: true),
                    tckn_validated = table.Column<bool>(nullable: true),
                    id_photo = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "daily_currencies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<decimal>(type: "numeric", nullable: false),
                    date = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(now())::date")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_daily_currencies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "decisions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying", nullable: false),
                    text = table.Column<string>(type: "character varying", nullable: false),
                    order = table.Column<int>(nullable: false),
                    parent_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_decisions", x => x.id);
                    table.ForeignKey(
                        name: "decisions_fk",
                        column: x => x.parent_id,
                        principalTable: "decisions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(maxLength: 200, nullable: true),
                    ClientId = table.Column<string>(maxLength: 200, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Expiration = table.Column<DateTime>(nullable: false),
                    Data = table.Column<string>(maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "districts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    city = table.Column<string>(maxLength: 255, nullable: true),
                    district = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_districts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "expenses",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateTime>(nullable: true),
                    amount = table.Column<decimal>(type: "numeric", nullable: true),
                    description = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_expenses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "geofence_border_points",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fence_id = table.Column<int>(nullable: true),
                    hash = table.Column<string>(maxLength: 10, nullable: true),
                    lat = table.Column<string>(maxLength: 25, nullable: true),
                    lon = table.Column<string>(maxLength: 25, nullable: true),
                    point_order = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "geofence_keys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", nullable: true),
                    point_index = table.Column<string>(type: "character varying", nullable: true),
                    fence_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_geofence_keys", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "geofence_office_points",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    geofence_id = table.Column<int>(nullable: false),
                    place_name = table.Column<string>(maxLength: 50, nullable: true),
                    points = table.Column<string[]>(type: "character varying(10)[]", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "geofence_park_borders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    geofence_group = table.Column<int>(nullable: false),
                    hash = table.Column<string>(maxLength: 25, nullable: false),
                    lat = table.Column<string>(maxLength: 25, nullable: false),
                    lon = table.Column<string>(maxLength: 25, nullable: false),
                    point_order = table.Column<int>(nullable: false),
                    point_index = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "geofence_park_points",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    geofence_group = table.Column<int>(nullable: false),
                    hash = table.Column<string>(maxLength: 25, nullable: false),
                    lat = table.Column<string>(maxLength: 25, nullable: false),
                    lon = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "geofence_points",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fence_id = table.Column<int>(nullable: true),
                    hash = table.Column<string>(maxLength: 10, nullable: true),
                    lat = table.Column<string>(maxLength: 25, nullable: true),
                    lon = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "geofence_region_points",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fence_id = table.Column<int>(nullable: true),
                    map_data = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "geofence_restricted_points",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fence_group = table.Column<int>(nullable: true),
                    points = table.Column<string>(type: "json", nullable: true),
                    is_enabled = table.Column<bool>(nullable: true),
                    name = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_geofence_restricted_points", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "geofences",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    is_active = table.Column<bool>(nullable: true),
                    is_visible = table.Column<bool>(nullable: false, defaultValueSql: "true"),
                    geofence_group = table.Column<int>(nullable: true),
                    start_time = table.Column<string>(maxLength: 10, nullable: true),
                    end_time = table.Column<string>(maxLength: 10, nullable: true),
                    msg_en = table.Column<string>(maxLength: 255, nullable: true),
                    msg_tr = table.Column<string>(maxLength: 255, nullable: true),
                    discount_amount = table.Column<int>(nullable: false),
                    always_on = table.Column<bool>(nullable: false),
                    city_name = table.Column<string>(maxLength: 50, nullable: true),
                    tax_applied = table.Column<int>(nullable: false, defaultValueSql: "18"),
                    center = table.Column<string>(fixedLength: true, maxLength: 7, nullable: true),
                    enable_start_price = table.Column<bool>(nullable: true, defaultValueSql: "true"),
                    enable_reservation = table.Column<bool>(nullable: true, defaultValueSql: "true"),
                    require_credit_card = table.Column<bool>(nullable: true, defaultValueSql: "true")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_geofences", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "government_users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 100, nullable: false),
                    password = table.Column<string>(maxLength: 32, nullable: false),
                    district_id = table.Column<int>(nullable: true),
                    city = table.Column<string>(type: "character varying", nullable: true, defaultValueSql: "100"),
                    is_enabled = table.Column<bool>(nullable: true, defaultValueSql: "true"),
                    role = table.Column<string>(maxLength: 32, nullable: false),
                    phone = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_government_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "inventory_categories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    model_id = table.Column<int>(nullable: false),
                    category_name = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "inventory_component_counts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    component_stock_code = table.Column<string>(type: "character varying", nullable: true),
                    stock_count = table.Column<int>(nullable: true),
                    warehouse_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory_component_counts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "inventory_components",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    part_id = table.Column<int>(nullable: true),
                    component_stock_code = table.Column<string>(type: "character varying", nullable: true),
                    component_name = table.Column<string>(type: "character varying", nullable: true),
                    manufacturer_part_number = table.Column<string>(type: "character varying", nullable: true),
                    quantity_per_scooter = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory_components", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "inventory_model",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    model_name = table.Column<string>(type: "character varying", nullable: true),
                    scooter_body_version_id = table.Column<int>(nullable: true),
                    bom_version = table.Column<int>(nullable: true),
                    created_by = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory_model", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "inventory_part_counts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    part_stock_code = table.Column<string>(type: "character varying", nullable: true),
                    stock_count = table.Column<int>(nullable: true),
                    asset_key = table.Column<string>(maxLength: 2, nullable: true),
                    warehouse_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory_part_counts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "inventory_parts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    category_id = table.Column<int>(nullable: true),
                    stock_code = table.Column<string>(type: "character varying", nullable: true),
                    part_name = table.Column<string>(type: "character varying", nullable: true),
                    manufacturer_part_number = table.Column<string>(type: "character varying", nullable: true),
                    asset_key = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory_parts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "inventory_status",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventory_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "investor_data",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    token = table.Column<string>(maxLength: 50, nullable: false),
                    is_enabled = table.Column<bool>(nullable: false),
                    name = table.Column<string>(maxLength: 25, nullable: true),
                    last_update_date = table.Column<DateTime>(nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_investor_data", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "invoices",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    provider_id = table.Column<long>(nullable: true),
                    provider_type = table.Column<string>(type: "character varying", nullable: true),
                    ref_id = table.Column<string>(type: "character varying", nullable: true),
                    real_invoice_id = table.Column<string>(type: "character varying", nullable: true),
                    invoice_date = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    is_processed = table.Column<bool>(nullable: false),
                    charged_price = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    customer_id = table.Column<int>(nullable: true),
                    processed_date = table.Column<DateTime>(nullable: true),
                    pdf_ready = table.Column<bool>(nullable: true, defaultValueSql: "false"),
                    is_cancelled = table.Column<bool>(nullable: true, defaultValueSql: "false"),
                    cancelled_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoices", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "iot_box_inventory_history",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    scooter_id = table.Column<int>(nullable: false),
                    iot_box_id = table.Column<int>(nullable: false),
                    life = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    created_by = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iot_box_inventory_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "iot_boxes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    serial_no = table.Column<string>(type: "character varying", nullable: true),
                    life = table.Column<int>(nullable: false),
                    scooter_id = table.Column<int>(nullable: true, defaultValueSql: "0"),
                    status = table.Column<int>(nullable: true),
                    body_version_id = table.Column<int>(nullable: true),
                    warehouse_id = table.Column<int>(nullable: false),
                    price = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    stock_code = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iot_boxes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "iot_lock_inventory_history",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    scooter_id = table.Column<int>(nullable: false),
                    iot_lock_id = table.Column<int>(nullable: false),
                    life = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    created_by = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iot_lock_inventory_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "iot_locks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    serial_no = table.Column<string>(type: "character varying", nullable: true),
                    life = table.Column<int>(nullable: false),
                    scooter_id = table.Column<int>(nullable: true, defaultValueSql: "0"),
                    status = table.Column<int>(nullable: true),
                    body_version_id = table.Column<int>(nullable: true),
                    warehouse_id = table.Column<int>(nullable: false),
                    price = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    stock_code = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iot_locks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "issue_solution_types",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_issue_solution_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "issue_types",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_issue_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "issues",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(nullable: true),
                    report_date = table.Column<DateTime>(nullable: true),
                    scooter_id = table.Column<string>(maxLength: 50, nullable: true),
                    location = table.Column<string>(maxLength: 500, nullable: true),
                    comment = table.Column<string>(maxLength: 750, nullable: true),
                    photo = table.Column<string>(maxLength: 50, nullable: true),
                    issue_type_id = table.Column<int>(nullable: true),
                    is_fixed = table.Column<bool>(nullable: true, defaultValueSql: "false"),
                    latitude = table.Column<string>(maxLength: 20, nullable: true),
                    longitude = table.Column<string>(maxLength: 20, nullable: true),
                    geofence_group = table.Column<int>(nullable: false, defaultValueSql: "10"),
                    fixed_date = table.Column<DateTime>(nullable: true),
                    update_user_id = table.Column<int>(nullable: true),
                    solution_detail = table.Column<string>(maxLength: 255, nullable: true),
                    original_issue_id = table.Column<int>(nullable: true),
                    case_start_time = table.Column<DateTime>(nullable: true),
                    case_end_time = table.Column<DateTime>(nullable: true),
                    call_duration = table.Column<int>(nullable: true),
                    final_decision_id = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: true),
                    other_text = table.Column<string>(type: "character varying", nullable: true),
                    previous_issue_id = table.Column<int>(nullable: true),
                    priority = table.Column<int>(nullable: true),
                    redial_time = table.Column<DateTime>(nullable: true),
                    cosmic_room_note = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_issues", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kpi_reports",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateTime>(type: "date", nullable: true),
                    scooters_deployed = table.Column<int>(nullable: true),
                    operational_hours = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    gross_scooters_available_hours = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    scooter_availability_percent = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    net_scooter_hours_available = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    total_rides = table.Column<int>(nullable: true),
                    rides_per_scooter = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    rides_per_scooter_per_hour = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    gross_revenue_tl = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    discounts_tl = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    discounts_percent = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    net_revenue_tl = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    dollar_tl = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    gross_revenue_dollar = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    discounts_dollar = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    net_revenue_dollar = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    gross_revenue_per_ride_tl = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    net_revenue_per_ride_tl = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    gross_revenue_per_ride_dollar = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    net_revenue_per_ride_dollar = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    gross_revenue_per_scooter_tl = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    net_revenue_per_scooter_tl = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    gross_revenue_per_scooter_dollar = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    net_revenue_per_scooter_dollar = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    total_ride_minutes = table.Column<int>(nullable: true),
                    avg_ride_time = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    scooters_lost = table.Column<int>(nullable: true),
                    scooters_lost_percent = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    scooters_damaged_recoverable = table.Column<int>(nullable: true),
                    scooters_damaged_recoverable_percent = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    scooters_damaged_not_recoverable = table.Column<int>(nullable: true),
                    scooters_damaged_not_recoverable_percent = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    scooter_recovered = table.Column<int>(nullable: true),
                    unrecoverable_rate_percent = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    registrations = table.Column<int>(nullable: true),
                    total_registrations = table.Column<int>(nullable: true),
                    unique_users_who_completed_rides = table.Column<int>(nullable: true),
                    share_of_repeat_users_among_unique_users = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    total_unique_users_who_completed_rides = table.Column<int>(nullable: true),
                    total_registrations_unique_users_completed_rides_conversion = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    rides_per_unique_user = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    total_ride_km = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    km_per_ride = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    rolling_weekly_unique_riders = table.Column<int>(nullable: false),
                    repair_count = table.Column<int>(nullable: false),
                    geofence_group = table.Column<int>(nullable: true, defaultValueSql: "10")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kpi_reports", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kpi_values",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    kpi_date = table.Column<DateTime>(type: "date", nullable: true),
                    fence_group = table.Column<int>(nullable: true),
                    total_deployed = table.Column<int>(nullable: true),
                    total_count = table.Column<int>(nullable: true),
                    avg_ride_seconds = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    avg_available_seconds = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    ride_count = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kpi_values", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "marti_health_checks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    mqtt_status = table.Column<string>(maxLength: 25, nullable: true),
                    fota_status = table.Column<string>(maxLength: 25, nullable: true),
                    lambda_status = table.Column<string>(maxLength: 25, nullable: true),
                    mqtt_helper_status = table.Column<string>(maxLength: 25, nullable: true),
                    cc_status = table.Column<string>(maxLength: 25, nullable: true),
                    ts = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "motor_driver_inventory_history",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    scooter_id = table.Column<int>(nullable: false),
                    motor_driver_id = table.Column<int>(nullable: false),
                    life = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    created_by = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motor_driver_inventory_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "motor_drivers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    serial_no = table.Column<string>(type: "character varying", nullable: true),
                    life = table.Column<int>(nullable: false),
                    scooter_id = table.Column<int>(nullable: true, defaultValueSql: "0"),
                    status = table.Column<int>(nullable: true),
                    body_version_id = table.Column<int>(nullable: true),
                    warehouse_id = table.Column<int>(nullable: false),
                    price = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    stock_code = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motor_drivers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "motor_inventory_history",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    scooter_id = table.Column<int>(nullable: false),
                    motor_id = table.Column<int>(nullable: false),
                    life = table.Column<int>(nullable: false),
                    create_date = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    created_by = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motor_inventory_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "motors",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    serial_no = table.Column<string>(type: "character varying", nullable: true),
                    life = table.Column<int>(nullable: false),
                    scooter_id = table.Column<int>(nullable: true, defaultValueSql: "0"),
                    status = table.Column<int>(nullable: true),
                    body_version_id = table.Column<int>(nullable: true),
                    warehouse_id = table.Column<int>(nullable: false),
                    price = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    stock_code = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "operating_hours",
                columns: table => new
                {
                    trunc = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "operating_hours_messages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    message_tr = table.Column<string>(maxLength: 254, nullable: true),
                    message_en = table.Column<string>(maxLength: 254, nullable: true),
                    bgcolor = table.Column<string>(maxLength: 10, nullable: true),
                    icon = table.Column<string>(maxLength: 254, nullable: true),
                    image = table.Column<string>(maxLength: 254, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operating_hours_messages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "operation_work_order_statuses",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", nullable: true),
                    order_no = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operation_work_order_statuses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "operation_work_orders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(nullable: true),
                    issued_by = table.Column<int>(nullable: true),
                    issued_at = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    status = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    completed_at = table.Column<DateTime>(nullable: true),
                    regions = table.Column<int[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operation_work_orders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "operator_action_log",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(nullable: true),
                    scooter_id = table.Column<int>(nullable: true),
                    from_status_id = table.Column<int>(nullable: true),
                    to_status_id = table.Column<int>(nullable: true),
                    note = table.Column<string>(maxLength: 100, nullable: true),
                    action_time = table.Column<DateTime>(nullable: true),
                    work_order_id = table.Column<int>(nullable: true),
                    car_id = table.Column<int>(nullable: true),
                    photo = table.Column<string>(maxLength: 50, nullable: true),
                    is_validated = table.Column<bool>(nullable: true),
                    validated_by = table.Column<int>(nullable: true),
                    validation_date = table.Column<DateTime>(nullable: true),
                    position = table.Column<string>(maxLength: 50, nullable: true),
                    repair_record_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operator_action_log", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "operator_location_logs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(nullable: true),
                    location = table.Column<string>(maxLength: 16, nullable: true),
                    time = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operator_location_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "out_of_order_request",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    repair_id = table.Column<int>(nullable: false),
                    created_by = table.Column<int>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: true, defaultValueSql: "now()"),
                    created_note = table.Column<string>(type: "character varying", nullable: true),
                    is_approved = table.Column<bool>(nullable: true),
                    approved_by = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_out_of_order_request", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pb_locations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", nullable: true),
                    address = table.Column<string>(type: "character varying", nullable: true),
                    location = table.Column<string>(maxLength: 9, nullable: true),
                    photos = table.Column<string[]>(type: "character varying[]", nullable: true),
                    logo = table.Column<string>(type: "character varying", nullable: true),
                    clock_list = table.Column<string[]>(type: "character varying[]", nullable: true),
                    responsible_name = table.Column<string>(type: "character varying", nullable: true),
                    responsible_phone = table.Column<string>(type: "character varying", nullable: true),
                    responsible_email = table.Column<string>(type: "character varying", nullable: true),
                    company_title = table.Column<string>(type: "character varying", nullable: true),
                    bank_id = table.Column<int>(nullable: true),
                    tax_office_id = table.Column<string>(type: "character varying", nullable: true),
                    tax_number = table.Column<string>(type: "character varying", nullable: true),
                    iban = table.Column<string>(type: "character varying", nullable: true),
                    official_invoice_address = table.Column<string>(type: "character varying", nullable: true),
                    city_id = table.Column<int>(nullable: true),
                    is_active = table.Column<bool>(nullable: false, defaultValueSql: "true"),
                    is_enabled = table.Column<bool>(nullable: false, defaultValueSql: "true")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pb_locations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pb_powerbanks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(maxLength: 255, nullable: true),
                    status_id = table.Column<int>(nullable: false, defaultValueSql: "15"),
                    last_rent_id = table.Column<int>(nullable: false),
                    battery_level = table.Column<int>(nullable: false),
                    last_seen_at = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    last_seen_station_id = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: true, defaultValueSql: "now()"),
                    created_by = table.Column<int>(nullable: false),
                    current_slot = table.Column<int>(nullable: true),
                    starting_price = table.Column<decimal>(type: "numeric(10,2)", nullable: false, defaultValueSql: "30"),
                    recurring_price = table.Column<decimal>(type: "numeric(10,2)", nullable: false, defaultValueSql: "5"),
                    is_inside = table.Column<bool>(nullable: true),
                    need_repair = table.Column<bool>(nullable: true),
                    repair_note = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pb_powerbanks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pb_rent_review_categories",
                columns: table => new
                {
                    key = table.Column<string>(type: "character varying", nullable: false),
                    name = table.Column<string>(type: "character varying", nullable: false),
                    value = table.Column<int>(nullable: false),
                    stars = table.Column<int[]>(nullable: true),
                    show_note = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pb_rent_review_categories_pk", x => x.key);
                });

            migrationBuilder.CreateTable(
                name: "pb_rent_reviews",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rent_id = table.Column<int>(nullable: false),
                    points_given = table.Column<int>(nullable: true),
                    review = table.Column<string>(maxLength: 255, nullable: true),
                    tag_list = table.Column<int[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pb_rent_reviews", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pb_rents",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    station_id = table.Column<int>(nullable: true),
                    powerbank_id = table.Column<int>(nullable: true),
                    start_time = table.Column<DateTime>(nullable: true),
                    end_time = table.Column<DateTime>(nullable: true),
                    charged_price = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    actual_price = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    provision_token = table.Column<string>(type: "character varying", nullable: true),
                    provision_transaction_token = table.Column<string>(type: "character varying", nullable: true),
                    additional_payment_token = table.Column<string>(type: "character varying", nullable: true),
                    additional_transaction_token = table.Column<string>(type: "character varying", nullable: true),
                    return_station_id = table.Column<int>(nullable: true),
                    is_success = table.Column<bool>(nullable: true),
                    customer_id = table.Column<long>(nullable: true),
                    is_approved = table.Column<bool>(nullable: true),
                    approved_by = table.Column<int>(nullable: true),
                    approved_date = table.Column<DateTime>(nullable: true),
                    from_slot = table.Column<int>(nullable: true),
                    to_slot = table.Column<int>(nullable: true),
                    total_price = table.Column<decimal>(type: "numeric(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pb_rents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pb_stations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(maxLength: 255, nullable: true),
                    last_seen_at = table.Column<DateTime>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    location_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pb_stations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(maxLength: 200, nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(maxLength: 200, nullable: true),
                    ClientId = table.Column<string>(maxLength: 200, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Expiration = table.Column<DateTime>(nullable: true),
                    Data = table.Column<string>(maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "popups",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    is_active = table.Column<bool>(nullable: false),
                    name = table.Column<string>(type: "character varying", nullable: false),
                    path = table.Column<string>(type: "character varying", nullable: false),
                    user_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_popups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "regions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    is_enabled = table.Column<bool>(nullable: true, defaultValueSql: "true"),
                    map_data = table.Column<string>(maxLength: 1000, nullable: true),
                    fence_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "repair_action_log_reasons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repair_action_log_reasons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "repair_action_logs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    repair_record_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: false),
                    action_type = table.Column<int>(nullable: false),
                    action_time = table.Column<DateTime>(nullable: false),
                    reason = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repair_action_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "repair_control_status",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric", nullable: false),
                    status = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "repair_result_materials",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    body_version = table.Column<int>(nullable: false),
                    stock_code = table.Column<string>(type: "character varying", nullable: true, comment: "Stok tarafından düşerken ilgili tabloya gidildikten sonra hangi stoktan düşüleceğini belirler (Id gibi tekildir)"),
                    is_part = table.Column<bool>(nullable: true, comment: "Stok tarafından düşerken hangi tabloya gideceğini belirler / Inventory_Part_Stock_Count - Inventory_Component_Stock_Count"),
                    has_quantity = table.Column<bool>(nullable: false, comment: "Ekrandan Miktar girilip girilmeyeceğini kontrol eder"),
                    result_code = table.Column<int>(nullable: false, comment: "scooter_repair_result_category de vbulunan Result kod alanıyla eşleşmede kullanılır"),
                    name = table.Column<string>(type: "character varying", nullable: false, comment: "Stoktaki isimle eşleştirilmedi / Stoktan eritilmeyecek materyeller bulunduğundan / UYapıştırıcı kablo vs "),
                    has_stock_effect = table.Column<bool>(nullable: false, comment: "Stok miktarından düşülüp düşümeyeceğini kontrol eder / stock_code ve is_part girilmiş has_quantity true olmalı")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repair_result_materials", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "repair_result_materials_usage",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    repair_id = table.Column<int>(nullable: false),
                    result_material_id = table.Column<int>(nullable: false, comment: "repair_result_material tablosundaki id"),
                    quantity = table.Column<int>(nullable: true),
                    old_serial_no = table.Column<string>(type: "character varying", nullable: true),
                    new_serial_no = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repair_result_materials_usage", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "reservation_payment_status",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(type: "character varying", nullable: false),
                    order_ = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservation_payment_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "reservation_refunds",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    reservation_id = table.Column<int>(nullable: true),
                    payment_id = table.Column<string>(maxLength: 50, nullable: true),
                    conversation_id = table.Column<string>(maxLength: 50, nullable: true),
                    amount = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    created_date = table.Column<DateTime>(nullable: true, defaultValueSql: "now()"),
                    processed_date = table.Column<DateTime>(nullable: true),
                    response = table.Column<string>(maxLength: 50, nullable: true),
                    is_success = table.Column<bool>(nullable: true, defaultValueSql: "false")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservation_refunds", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ride_accidents",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ride_id = table.Column<int>(nullable: false),
                    created_by = table.Column<int>(nullable: false),
                    response_user_id = table.Column<int>(nullable: true),
                    address = table.Column<string>(maxLength: 255, nullable: false),
                    accident_date = table.Column<DateTime>(nullable: false),
                    accident_reason = table.Column<int>(nullable: false),
                    accident_type = table.Column<int>(nullable: false),
                    accident_type_note = table.Column<string>(maxLength: 255, nullable: false),
                    external_sources_exist = table.Column<bool>(nullable: false),
                    seen_on_media = table.Column<bool>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ride_accidents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ride_fines",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ride_id = table.Column<int>(nullable: true),
                    amount = table.Column<int>(nullable: true),
                    user_id = table.Column<int>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: true),
                    note = table.Column<string>(maxLength: 500, nullable: true),
                    card_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ride_fines", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ride_refund_requests",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ride_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: false),
                    created_date = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    source = table.Column<int>(nullable: false),
                    reason = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ride_refund_requests", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ride_refunds",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ride_id = table.Column<int>(nullable: true),
                    payment_id = table.Column<string>(maxLength: 50, nullable: true),
                    conversation_id = table.Column<string>(maxLength: 50, nullable: true),
                    amount = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    created_date = table.Column<DateTime>(nullable: true, defaultValueSql: "now()"),
                    processed_date = table.Column<DateTime>(nullable: true),
                    response = table.Column<string>(maxLength: 50, nullable: true),
                    is_success = table.Column<bool>(nullable: true, defaultValueSql: "false")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ride_refunds", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ride_reject_operation",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ride_id = table.Column<int>(nullable: false),
                    is_notified = table.Column<bool>(nullable: true),
                    notification_id = table.Column<int>(nullable: true),
                    is_penalty_fee_added = table.Column<bool>(nullable: true),
                    is_black_list_added = table.Column<bool>(nullable: true),
                    penalty_fee = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    created_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ride_reject_operation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ride_reject_reasons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    message_tr = table.Column<string>(maxLength: 500, nullable: true),
                    message_en = table.Column<string>(maxLength: 500, nullable: true),
                    reason = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ride_reject_reasons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ride_review_categories",
                columns: table => new
                {
                    key = table.Column<string>(type: "character varying", nullable: false),
                    name = table.Column<string>(type: "character varying", nullable: false),
                    value = table.Column<int>(nullable: false),
                    stars = table.Column<int[]>(nullable: true),
                    show_note = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ride_review_categories_pk", x => x.key);
                });

            migrationBuilder.CreateTable(
                name: "ride_reviews",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ride_id = table.Column<int>(nullable: false),
                    points_given = table.Column<int>(nullable: true),
                    review = table.Column<string>(maxLength: 255, nullable: true),
                    tag_list = table.Column<int[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ride_reviews", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rides_over_five_mins",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(maxLength: 10, nullable: false),
                    ride_id = table.Column<long>(nullable: false),
                    is_fixed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "riding_payment_errors",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(nullable: true),
                    ride_id = table.Column<int>(nullable: true),
                    error_time = table.Column<DateTime>(nullable: true),
                    credit_card_id = table.Column<int>(nullable: true),
                    reason = table.Column<string>(maxLength: 255, nullable: true),
                    is_fixed = table.Column<bool>(nullable: true, defaultValueSql: "false")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_riding_payment_errors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "role_rights",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    security_key = table.Column<string>(maxLength: 50, nullable: true),
                    role_id = table.Column<int>(nullable: true),
                    value = table.Column<bool>(nullable: true, defaultValueSql: "true")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role_rights", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    is_enabled = table.Column<bool>(nullable: true, defaultValueSql: "true"),
                    is_system_role = table.Column<bool>(nullable: true, defaultValueSql: "false"),
                    description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_alert_detail",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    scooter_id = table.Column<long>(nullable: false),
                    speed = table.Column<int>(nullable: false),
                    gps_error = table.Column<bool>(nullable: false),
                    timestamp = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    is_fixed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "scooter_bodies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    scooter_id = table.Column<long>(nullable: false),
                    scooter_body_version_id = table.Column<int>(nullable: false),
                    life = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_bodies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_body_history",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    scooter_id = table.Column<int>(nullable: false),
                    body_id = table.Column<int>(nullable: true),
                    battery_id = table.Column<int>(nullable: true),
                    motor_id = table.Column<int>(nullable: true),
                    motor_driver_id = table.Column<int>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    created_by = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_body_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_body_versions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_body_versions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_error_messages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(maxLength: 4, nullable: true),
                    message = table.Column<string>(maxLength: 255, nullable: true),
                    priority = table.Column<int>(nullable: true),
                    ts = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_error_messages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_errors",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(maxLength: 4, nullable: false),
                    ts = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    error_code = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "scooter_errors_backlog",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(maxLength: 4, nullable: true),
                    message = table.Column<string>(maxLength: 255, nullable: true),
                    priority = table.Column<int>(nullable: true),
                    ts = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_errors_backlog", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_lock_code_history",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    scooter_id = table.Column<int>(nullable: true),
                    user_id = table.Column<int>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_lock_code_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_prices",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    geofence_group = table.Column<int>(nullable: true),
                    scooter_body_version_id = table.Column<int>(nullable: true),
                    starting_price = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    recurring_price = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    reservation_price = table.Column<decimal>(type: "numeric(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_prices", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_repair_categories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    order = table.Column<int>(nullable: true),
                    result_codes = table.Column<int[]>(nullable: true),
                    group_name = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_repair_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_repair_logs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(nullable: true),
                    scooter_id = table.Column<int>(nullable: true),
                    scooter_repair_category_id = table.Column<int>(nullable: true),
                    note = table.Column<string>(maxLength: 500, nullable: true),
                    photo = table.Column<string>(maxLength: 50, nullable: true),
                    created_date = table.Column<DateTime>(nullable: true),
                    scooter_repair_result_category_id = table.Column<int>(nullable: true),
                    scooter_repair_type_id = table.Column<int>(nullable: true),
                    repair_log_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_repair_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_repair_records",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    scooter_id = table.Column<int>(nullable: false),
                    created_user = table.Column<int>(nullable: false),
                    created_date = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    repair_type_id = table.Column<int>(nullable: false),
                    repair_category_id = table.Column<int>(nullable: false),
                    repair_note = table.Column<string>(maxLength: 255, nullable: false),
                    close_user = table.Column<int>(nullable: true),
                    close_date = table.Column<DateTime>(nullable: true),
                    repair_result_category_id = table.Column<int>(nullable: true),
                    is_fixed = table.Column<bool>(nullable: false),
                    status_id = table.Column<int>(nullable: true),
                    photo = table.Column<string>(type: "character varying", nullable: true),
                    start_time = table.Column<DateTime>(nullable: true),
                    is_checked = table.Column<bool>(nullable: false),
                    warehouse_id = table.Column<int>(nullable: true),
                    is_canceled = table.Column<bool>(nullable: false),
                    repair_user_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_repair_records", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_repair_result_categories",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", nullable: false),
                    result_code = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_repair_result_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_repair_types",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_repair_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_status",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 20, nullable: true),
                    is_active = table.Column<bool>(nullable: true, defaultValueSql: "true"),
                    order_no = table.Column<int>(nullable: true),
                    group_name = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_unavailable_reasons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    scooter_id = table.Column<int>(nullable: true),
                    reason = table.Column<string>(maxLength: 10, nullable: true),
                    created_at = table.Column<DateTime>(nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_unavailable_reasons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_update_log",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ts = table.Column<DateTime>(nullable: true),
                    ok_count = table.Column<int>(nullable: false),
                    error_count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_update_log", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooter_versions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 20, nullable: true),
                    current_firmware_version = table.Column<string>(maxLength: 25, nullable: true),
                    is_default = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_versions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "scooters",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(maxLength: 50, nullable: true),
                    version = table.Column<int>(nullable: false),
                    status_id = table.Column<int>(nullable: true),
                    battery_status = table.Column<int>(nullable: true),
                    last_known_point = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "'sxk9hu93p'::character varying"),
                    last_update_time = table.Column<DateTime>(nullable: true),
                    module_battery_status = table.Column<int>(nullable: true),
                    lock_code = table.Column<string>(maxLength: 4, nullable: true),
                    sim_card_no = table.Column<string>(maxLength: 50, nullable: true),
                    is_available = table.Column<bool>(nullable: false, defaultValueSql: "true"),
                    timezone = table.Column<int>(nullable: false, defaultValueSql: "3"),
                    last_ride_id = table.Column<int>(nullable: true, defaultValueSql: "0"),
                    last_stolen_time = table.Column<DateTime>(nullable: true),
                    mqtt_password = table.Column<string>(maxLength: 50, nullable: true),
                    firmware_version = table.Column<string>(maxLength: 25, nullable: false, defaultValueSql: "0"),
                    bt_mac = table.Column<string>(maxLength: 25, nullable: true),
                    hdop = table.Column<float>(nullable: false, defaultValueSql: "4.0"),
                    attention = table.Column<bool>(nullable: false),
                    geofence_group = table.Column<int>(nullable: false, defaultValueSql: "10"),
                    need_repair = table.Column<bool>(nullable: true, defaultValueSql: "false"),
                    need_repair_note = table.Column<string>(maxLength: 200, nullable: true),
                    gsm_available = table.Column<bool>(nullable: false, defaultValueSql: "true"),
                    gsm_location = table.Column<string>(maxLength: 10, nullable: true),
                    mobile_phone_number = table.Column<string>(maxLength: 15, nullable: true),
                    total_km = table.Column<long>(nullable: true, defaultValueSql: "0"),
                    last_fota_time = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    sub_status = table.Column<long>(nullable: true),
                    charging_station_id = table.Column<int>(nullable: true),
                    scooter_body_version_id = table.Column<int>(nullable: true),
                    starting_price = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    recurring_price = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    iot_locked = table.Column<bool>(nullable: false),
                    last_locked_time = table.Column<DateTime>(nullable: true),
                    life = table.Column<int>(nullable: false),
                    reservation_price = table.Column<decimal>(type: "numeric(10,2)", nullable: false, defaultValueSql: "0.05"),
                    created_at = table.Column<DateTime>(nullable: true, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "security_rights",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    key = table.Column<string>(maxLength: 50, nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_security_rights", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "swappable_battery_status",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", nullable: false),
                    order_ = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_swappable_battery_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tasks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_by = table.Column<int>(nullable: true),
                    task_owner = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    priority = table.Column<int>(nullable: false),
                    created_date = table.Column<DateTime>(nullable: false),
                    start_date = table.Column<DateTime>(nullable: true),
                    end_date = table.Column<DateTime>(nullable: true),
                    cancelled_by = table.Column<int>(nullable: true),
                    scooter_id = table.Column<int>(nullable: true),
                    task_type = table.Column<int>(nullable: false),
                    to_location = table.Column<string>(type: "character varying", nullable: true),
                    task_count = table.Column<int>(nullable: true),
                    blocked_by = table.Column<int>(nullable: true),
                    task_location = table.Column<string>(type: "character varying", nullable: true),
                    blocked_reason = table.Column<string>(type: "character varying", nullable: true),
                    battery_id = table.Column<int>(nullable: true),
                    valid_until = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tasks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tax_offices",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", nullable: true),
                    city_id = table.Column<int>(nullable: true),
                    district_id = table.Column<int>(nullable: true),
                    code = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "user_action_reasons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    reason = table.Column<string>(type: "character varying", nullable: false),
                    action_type = table.Column<string>(type: "character varying", nullable: false),
                    key = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_action_reasons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_breaks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(nullable: false),
                    start_time = table.Column<DateTime>(nullable: false),
                    end_time = table.Column<DateTime>(nullable: true),
                    shift_no = table.Column<int>(nullable: false),
                    break_reason_id = table.Column<int>(nullable: true),
                    other_text = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_breaks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_geofences",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(nullable: true),
                    geofence_group = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_geofences", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_rights",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    right_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: false),
                    state = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_rights", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_shifts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(nullable: false),
                    shift_date = table.Column<DateTime>(nullable: false),
                    shift_no = table.Column<int>(nullable: false),
                    created_by = table.Column<int>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false, defaultValueSql: "now()"),
                    updated_at = table.Column<DateTime>(nullable: true),
                    car_id = table.Column<int>(nullable: true),
                    start_time = table.Column<DateTime>(nullable: true),
                    end_time = table.Column<DateTime>(nullable: true),
                    warehouse_id = table.Column<int>(nullable: false),
                    fence_group = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_shifts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    mobile_phone = table.Column<string>(maxLength: 50, nullable: true),
                    password = table.Column<string>(maxLength: 50, nullable: true),
                    role_id = table.Column<int>(nullable: true),
                    is_enabled = table.Column<bool>(nullable: true, defaultValueSql: "true"),
                    access_token = table.Column<string>(maxLength: 64, nullable: true),
                    one_signal_id = table.Column<string>(maxLength: 100, nullable: true),
                    geofence_id_list = table.Column<int[]>(nullable: true),
                    controlcenter_login = table.Column<bool>(nullable: true, defaultValueSql: "true"),
                    email = table.Column<string>(maxLength: 50, nullable: true),
                    claim_ids = table.Column<int[]>(nullable: true),
                    subject = table.Column<string>(maxLength: 50, nullable: true),
                    otp_token = table.Column<string>(maxLength: 4, nullable: true),
                    last_signed_in_at = table.Column<DateTime>(nullable: true),
                    agent_id = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "warehouses",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    warehouse_name = table.Column<string>(maxLength: 255, nullable: true),
                    geofence_group = table.Column<int>(nullable: true),
                    is_active = table.Column<bool>(nullable: false, defaultValueSql: "true"),
                    car_id = table.Column<int>(nullable: false),
                    is_default = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "work_orders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    date = table.Column<DateTime>(type: "date", nullable: true),
                    car_id = table.Column<int>(nullable: true),
                    personel_id = table.Column<int>(nullable: true),
                    regions = table.Column<int[]>(nullable: true),
                    is_completed = table.Column<bool>(nullable: true, defaultValueSql: "false"),
                    note = table.Column<string>(maxLength: 500, nullable: true),
                    completed_date = table.Column<DateTime>(nullable: true),
                    completed_user_id = table.Column<int>(nullable: true),
                    total = table.Column<int>(nullable: true),
                    personel = table.Column<int[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_work_orders", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "zones",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    latitude = table.Column<string>(maxLength: 50, nullable: true),
                    longitude = table.Column<string>(maxLength: 50, nullable: true),
                    is_enabled = table.Column<bool>(nullable: true, defaultValueSql: "true"),
                    scooter_count = table.Column<int>(nullable: true),
                    region_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "role_claims",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    claim_type = table.Column<string>(nullable: true),
                    claim_value = table.Column<string>(nullable: true),
                    role_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role_claims", x => x.id);
                    table.ForeignKey(
                        name: "FK_role_claims_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "scooter_substatus",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status_id = table.Column<int>(nullable: true),
                    name = table.Column<string>(maxLength: 255, nullable: true),
                    order_no = table.Column<int>(nullable: true),
                    is_active = table.Column<bool>(nullable: false, defaultValueSql: "true")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scooter_substatus", x => x.id);
                    table.ForeignKey(
                        name: "scooter_substatus_fk",
                        column: x => x.status_id,
                        principalTable: "scooter_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(nullable: false),
                    scooter_id = table.Column<int>(nullable: false),
                    start_time = table.Column<DateTime>(nullable: false),
                    end_time = table.Column<DateTime>(nullable: true),
                    amount = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    payment_status = table.Column<int>(nullable: true),
                    card_id = table.Column<int>(nullable: true),
                    payment_time = table.Column<DateTime>(nullable: true),
                    user_id = table.Column<int>(nullable: true),
                    payment_service_payment_token = table.Column<string>(type: "character varying", nullable: true),
                    payment_service_transaction_id = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.id);
                    table.ForeignKey(
                        name: "reservations_fk",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "reservations_fk_1",
                        column: x => x.scooter_id,
                        principalTable: "scooters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rides",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    customer_id = table.Column<int>(nullable: true),
                    scooter_id = table.Column<int>(nullable: true),
                    start_time = table.Column<DateTime>(nullable: true),
                    end_time = table.Column<DateTime>(nullable: true),
                    distance = table.Column<int>(nullable: true),
                    charged_price = table.Column<decimal>(type: "numeric", nullable: true),
                    credit_card_id = table.Column<int>(nullable: true),
                    payment_service_payment_token = table.Column<string>(maxLength: 50, nullable: true),
                    map_data = table.Column<string[]>(nullable: true),
                    payment_successful = table.Column<bool>(nullable: true),
                    photo = table.Column<string>(maxLength: 50, nullable: true),
                    approved_user_id = table.Column<int>(nullable: true),
                    approved_date = table.Column<DateTime>(nullable: true),
                    approved_note = table.Column<string>(maxLength: 500, nullable: true),
                    is_approved = table.Column<bool>(nullable: true),
                    actual_price = table.Column<decimal>(type: "numeric", nullable: true),
                    last_ride_point = table.Column<string>(maxLength: 20, nullable: true),
                    payment_service_transaction_id = table.Column<string>(maxLength: 50, nullable: true),
                    geofence_group = table.Column<int>(nullable: true),
                    provision_transaction = table.Column<string>(maxLength: 255, nullable: true),
                    additional_payment_transaction = table.Column<string>(maxLength: 255, nullable: true),
                    user_id = table.Column<int>(nullable: true),
                    campaign_id = table.Column<int>(nullable: true),
                    reservation_id = table.Column<int>(nullable: false),
                    reservation_price = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    start_mileage = table.Column<long>(nullable: true),
                    end_mileage = table.Column<long>(nullable: true),
                    ride_refunded_by_mileage = table.Column<bool>(nullable: true),
                    total_price = table.Column<decimal>(type: "numeric", nullable: true, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rides", x => x.id);
                    table.ForeignKey(
                        name: "rides_customers_fk",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "rides_scooters_fk",
                        column: x => x.scooter_id,
                        principalTable: "scooters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ride_refund_request_history",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    request_id = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    reason = table.Column<string>(type: "character varying", nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    user_id = table.Column<int>(nullable: false),
                    refund_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ride_refund_request_history", x => x.id);
                    table.ForeignKey(
                        name: "ride_refund_request_history_refund_fk",
                        column: x => x.refund_id,
                        principalTable: "ride_refunds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ride_refund_request_history_fk",
                        column: x => x.request_id,
                        principalTable: "ride_refund_requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "ride_refund_request_history_user_fk",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user_claims",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    claim_type = table.Column<string>(nullable: true),
                    claim_value = table.Column<string>(nullable: true),
                    user_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_claims", x => x.id);
                    table.ForeignKey(
                        name: "FK_user_claims_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_logins",
                columns: table => new
                {
                    login_provider = table.Column<string>(nullable: false),
                    provider_key = table.Column<string>(nullable: false),
                    provider_display_name = table.Column<string>(nullable: true),
                    user_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_logins", x => new { x.login_provider, x.provider_key });
                    table.ForeignKey(
                        name: "FK_user_logins_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_roles",
                columns: table => new
                {
                    role_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_roles", x => new { x.user_id, x.role_id });
                    table.ForeignKey(
                        name: "FK_user_roles_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_roles_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_tokens",
                columns: table => new
                {
                    login_provider = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    user_id = table.Column<int>(nullable: false),
                    value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_tokens", x => new { x.user_id, x.login_provider, x.name });
                    table.ForeignKey(
                        name: "FK_user_tokens_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "battery_action_logs_battery_id_idx",
                table: "battery_action_logs",
                column: "battery_id");

            migrationBuilder.CreateIndex(
                name: "battery_action_logs_to_scooter_id_idx",
                table: "battery_action_logs",
                column: "to_scooter_id");

            migrationBuilder.CreateIndex(
                name: "campaigns_start_time_idx",
                table: "campaigns",
                columns: new[] { "start_time", "end_time" });

            migrationBuilder.CreateIndex(
                name: "campaigns_customers_campaign_id_idx",
                table: "campaigns_customers",
                column: "campaign_id");

            migrationBuilder.CreateIndex(
                name: "campaigns_customers_customer_id_idx",
                table: "campaigns_customers",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "cancellation_requests_ride_id_idx",
                table: "cancellation_requests",
                column: "ride_id");

            migrationBuilder.CreateIndex(
                name: "cancellation_requests_customer_id_idx",
                table: "cancellation_requests",
                columns: new[] { "customer_id", "status" });

            migrationBuilder.CreateIndex(
                name: "cars_id_uindex",
                table: "cars",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "drivers",
                table: "cars",
                columns: new[] { "driver_1", "driver_2" });

            migrationBuilder.CreateIndex(
                name: "charge_stations_id_uindex",
                table: "charge_stations",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "user_claims_id_uindex",
                table: "claims",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "countries_id_uindex",
                table: "countries",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "coupons_code_idx",
                table: "coupons",
                column: "code");

            migrationBuilder.CreateIndex(
                name: "\"CreditCards\"_\"ID\"_uindex",
                table: "credit_cards",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "credit_cards_customer_id_idx",
                table: "credit_cards",
                columns: new[] { "customer_id", "is_default", "is_active" });

            migrationBuilder.CreateIndex(
                name: "customer_demands_ts_idx",
                table: "customer_demands",
                column: "ts");

            migrationBuilder.CreateIndex(
                name: "customer_popups_id_uindex",
                table: "customer_popups",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "customer_reservation_debts_customer_id_idx",
                table: "customer_reservation_debts",
                columns: new[] { "customer_id", "reservation_id" });

            migrationBuilder.CreateIndex(
                name: "customer_ride_debts_customer_id_idx",
                table: "customer_ride_debts",
                columns: new[] { "customer_id", "ride_id" });

            migrationBuilder.CreateIndex(
                name: "customer_scooter_requests_customer_id_idx",
                table: "customer_scooter_requests",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "customer_scooter_requests_ts_idx",
                table: "customer_scooter_requests",
                column: "ts");

            migrationBuilder.CreateIndex(
                name: "customer_sent_notifications_id_uindex",
                table: "customer_sent_notifications",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "customer_sent_notifications_customer_id_idx",
                table: "customer_sent_notifications",
                columns: new[] { "customer_id", "is_read" });

            migrationBuilder.CreateIndex(
                name: "customers_access_token_idx",
                table: "customers",
                column: "access_token");

            migrationBuilder.CreateIndex(
                name: "\"Customers\"_\"ID\"_uindex",
                table: "customers",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "customers_tckn_idx",
                table: "customers",
                column: "tckn");

            migrationBuilder.CreateIndex(
                name: "customers_id_idx",
                table: "customers",
                columns: new[] { "id", "free_tier" });

            migrationBuilder.CreateIndex(
                name: "customers_mobile_phone_idx",
                table: "customers",
                columns: new[] { "mobile_phone", "name" });

            migrationBuilder.CreateIndex(
                name: "customers_mobile_phone_country_code_idx",
                table: "customers",
                columns: new[] { "mobile_phone_country_code", "mobile_phone" });

            migrationBuilder.CreateIndex(
                name: "IX_decisions_parent_id",
                table: "decisions",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "expenses_id_uindex",
                table: "expenses",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fence_id_idx",
                table: "geofence_border_points",
                column: "hash");

            migrationBuilder.CreateIndex(
                name: "hash_idx",
                table: "geofence_points",
                column: "hash");

            migrationBuilder.CreateIndex(
                name: "government_users_id_uindex",
                table: "government_users",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "invoices_invoice_date_idx",
                table: "invoices",
                column: "invoice_date");

            migrationBuilder.CreateIndex(
                name: "invoices_provider_type_idx",
                table: "invoices",
                column: "provider_type");

            migrationBuilder.CreateIndex(
                name: "invoices_ref_id_idx",
                table: "invoices",
                column: "ref_id");

            migrationBuilder.CreateIndex(
                name: "issue_types_id_uindex",
                table: "issue_types",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "issues_id_uindex",
                table: "issues",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "kpi_reports_id_uindex",
                table: "kpi_reports",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "kpi_values_kpi_date_idx",
                table: "kpi_values",
                column: "kpi_date");

            migrationBuilder.CreateIndex(
                name: "marti_health_checks_id_idx",
                table: "marti_health_checks",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "operating_hours_messages_id_uindex",
                table: "operating_hours_messages",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "operation_work_orders_status_idx",
                table: "operation_work_orders",
                columns: new[] { "status", "user_id" });

            migrationBuilder.CreateIndex(
                name: "operator_action_log_car_id_idx",
                table: "operator_action_log",
                column: "car_id");

            migrationBuilder.CreateIndex(
                name: "operator_action_log_scooter_id_idx",
                table: "operator_action_log",
                column: "scooter_id");

            migrationBuilder.CreateIndex(
                name: "operator_action_log_to_status_id_idx",
                table: "operator_action_log",
                column: "to_status_id");

            migrationBuilder.CreateIndex(
                name: "operator_action_log_work_order_id_idx",
                table: "operator_action_log",
                column: "work_order_id");

            migrationBuilder.CreateIndex(
                name: "operator_action_log_action_time_idx",
                table: "operator_action_log",
                columns: new[] { "action_time", "car_id" });

            migrationBuilder.CreateIndex(
                name: "operator_action_log_user_id_idx",
                table: "operator_action_log",
                columns: new[] { "user_id", "scooter_id" });

            migrationBuilder.CreateIndex(
                name: "operator_location_logs_id_uindex",
                table: "operator_location_logs",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "pb_powerbanks_code_idx",
                table: "pb_powerbanks",
                column: "code");

            migrationBuilder.CreateIndex(
                name: "pb_rents_is_success_idx",
                table: "pb_rents",
                column: "is_success");

            migrationBuilder.CreateIndex(
                name: "pb_rents_powerbank_id_idx",
                table: "pb_rents",
                column: "powerbank_id");

            migrationBuilder.CreateIndex(
                name: "pb_rents_start_time_idx",
                table: "pb_rents",
                column: "start_time");

            migrationBuilder.CreateIndex(
                name: "pb_rents_station_id_idx",
                table: "pb_rents",
                column: "station_id");

            migrationBuilder.CreateIndex(
                name: "pb_stations_code_idx",
                table: "pb_stations",
                column: "code");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "regions_id_uindex",
                table: "regions",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "repair_action_logs_action_time_idx",
                table: "repair_action_logs",
                column: "action_time");

            migrationBuilder.CreateIndex(
                name: "repair_action_logs_repair_record_id_idx",
                table: "repair_action_logs",
                column: "repair_record_id");

            migrationBuilder.CreateIndex(
                name: "repair_action_logs_user_id_idx",
                table: "repair_action_logs",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "reservations_customer_id_idx",
                table: "reservations",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "reservations_scooter_id_idx",
                table: "reservations",
                column: "scooter_id");

            migrationBuilder.CreateIndex(
                name: "ride_fees_id_uindex",
                table: "ride_fines",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ride_refund_request_history_refund_id",
                table: "ride_refund_request_history",
                column: "refund_id");

            migrationBuilder.CreateIndex(
                name: "IX_ride_refund_request_history_request_id",
                table: "ride_refund_request_history",
                column: "request_id");

            migrationBuilder.CreateIndex(
                name: "IX_ride_refund_request_history_user_id",
                table: "ride_refund_request_history",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ride_refunds_ride_id_idx",
                table: "ride_refunds",
                column: "ride_id");

            migrationBuilder.CreateIndex(
                name: "ride_reject_operation_ride_id_idx",
                table: "ride_reject_operation",
                column: "ride_id");

            migrationBuilder.CreateIndex(
                name: "ride_reject_reasons_id_uindex",
                table: "ride_reject_reasons",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "rides_customer_id_idx",
                table: "rides",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "rides_geofence_group_idx",
                table: "rides",
                column: "geofence_group");

            migrationBuilder.CreateIndex(
                name: "\"CustomerRideHistory\"_\"ID\"_uindex",
                table: "rides",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "rides_photo_idx",
                table: "rides",
                column: "photo");

            migrationBuilder.CreateIndex(
                name: "rides_scooter_id_idx",
                table: "rides",
                column: "scooter_id");

            migrationBuilder.CreateIndex(
                name: "rides_start_time_idx",
                table: "rides",
                column: "start_time");

            migrationBuilder.CreateIndex(
                name: "IX_role_claims_role_id",
                table: "role_claims",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "role_rights_id_uindex",
                table: "role_rights",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "roles_id_uindex",
                table: "roles",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "scooter_body_history_body_id_idx",
                table: "scooter_body_history",
                column: "body_id");

            migrationBuilder.CreateIndex(
                name: "scooter_body_history_created_at_idx",
                table: "scooter_body_history",
                column: "created_at");

            migrationBuilder.CreateIndex(
                name: "scooter_body_history_scooter_id_idx2",
                table: "scooter_body_history",
                column: "scooter_id");

            migrationBuilder.CreateIndex(
                name: "scooter_body_history_scooter_id_idx",
                table: "scooter_body_history",
                columns: new[] { "scooter_id", "body_id" });

            migrationBuilder.CreateIndex(
                name: "scooter_error_messages_code_idx",
                table: "scooter_error_messages",
                column: "code");

            migrationBuilder.CreateIndex(
                name: "scooter_error_messages_ts_idx",
                table: "scooter_error_messages",
                column: "ts");

            migrationBuilder.CreateIndex(
                name: "scooter_errors_backlog_code_idx",
                table: "scooter_errors_backlog",
                column: "code");

            migrationBuilder.CreateIndex(
                name: "scooter_lock_code_history_scooter_id_idx",
                table: "scooter_lock_code_history",
                column: "scooter_id");

            migrationBuilder.CreateIndex(
                name: "scooter_repair_categories_id_uindex",
                table: "scooter_repair_categories",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "scooter_repair_logs_id_uindex",
                table: "scooter_repair_logs",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "scooter_repair_records_created_date_idx",
                table: "scooter_repair_records",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "scooter_repair_records_is_fixed_idx",
                table: "scooter_repair_records",
                column: "is_fixed");

            migrationBuilder.CreateIndex(
                name: "scooter_repair_records_scooter_id_idx",
                table: "scooter_repair_records",
                column: "scooter_id");

            migrationBuilder.CreateIndex(
                name: "\"ScooterStatus\"_\"ID\"_uindex",
                table: "scooter_status",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_scooter_substatus_status_id",
                table: "scooter_substatus",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "table_name_id_uindex",
                table: "scooter_versions",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "scooters_code_idx",
                table: "scooters",
                column: "code");

            migrationBuilder.CreateIndex(
                name: "scooters_geofence_id_idx",
                table: "scooters",
                column: "geofence_group");

            migrationBuilder.CreateIndex(
                name: "Scooters_\"ID\"_uindex",
                table: "scooters",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "scooters_status_id2_idx",
                table: "scooters",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "scooters_status_id3_idx",
                table: "scooters",
                columns: new[] { "status_id", "geofence_group" });

            migrationBuilder.CreateIndex(
                name: "scooters_status_id_idx",
                table: "scooters",
                columns: new[] { "status_id", "version" });

            migrationBuilder.CreateIndex(
                name: "scooters_status_id5_idx",
                table: "scooters",
                columns: new[] { "status_id", "version", "is_available" });

            migrationBuilder.CreateIndex(
                name: "security_rights_key_uindex",
                table: "security_rights",
                column: "key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "tasks_task_type_idx",
                table: "tasks",
                columns: new[] { "task_type", "status" });

            migrationBuilder.CreateIndex(
                name: "IX_user_claims_user_id",
                table: "user_claims",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "user_geofences_id_uindex",
                table: "user_geofences",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_logins_user_id",
                table: "user_logins",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_roles_role_id",
                table: "user_roles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "users_access_token_idx",
                table: "users",
                column: "access_token");

            migrationBuilder.CreateIndex(
                name: "users_id_uindex",
                table: "users",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "work_orders_id_uindex",
                table: "work_orders",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_personel",
                table: "work_orders",
                column: "personel")
                .Annotation("Npgsql:IndexMethod", "gin");

            migrationBuilder.CreateIndex(
                name: "find_work_order_idx",
                table: "work_orders",
                columns: new[] { "completed_date", "date", "car_id", "personel_id" });

            migrationBuilder.CreateIndex(
                name: "zones_id_uindex",
                table: "zones",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "zones_region_id_idx",
                table: "zones",
                column: "region_id");

            migrationBuilder.CreateIndex(
                name: "regions_is_enabled",
                table: "zones",
                columns: new[] { "is_enabled", "region_id" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "api_resources");

            migrationBuilder.DropTable(
                name: "awsdms_ddl_audit");

            migrationBuilder.DropTable(
                name: "backend_config");

            migrationBuilder.DropTable(
                name: "backend_errors");

            migrationBuilder.DropTable(
                name: "banks");

            migrationBuilder.DropTable(
                name: "batteries");

            migrationBuilder.DropTable(
                name: "battery_action_logs");

            migrationBuilder.DropTable(
                name: "call_center_users");

            migrationBuilder.DropTable(
                name: "campaigns");

            migrationBuilder.DropTable(
                name: "campaigns_customers");

            migrationBuilder.DropTable(
                name: "cancellation_requests");

            migrationBuilder.DropTable(
                name: "car_deliveries");

            migrationBuilder.DropTable(
                name: "card_add_status");

            migrationBuilder.DropTable(
                name: "cars");

            migrationBuilder.DropTable(
                name: "charge_stations");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "claims");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "coupons");

            migrationBuilder.DropTable(
                name: "credit_cards");

            migrationBuilder.DropTable(
                name: "customer_call_records");

            migrationBuilder.DropTable(
                name: "customer_checkmobi_pins");

            migrationBuilder.DropTable(
                name: "customer_demands");

            migrationBuilder.DropTable(
                name: "customer_phone_number_holder");

            migrationBuilder.DropTable(
                name: "customer_popups");

            migrationBuilder.DropTable(
                name: "customer_reservation_debts");

            migrationBuilder.DropTable(
                name: "customer_ride_debts");

            migrationBuilder.DropTable(
                name: "customer_scooter_requests");

            migrationBuilder.DropTable(
                name: "customer_sent_notifications");

            migrationBuilder.DropTable(
                name: "daily_currencies");

            migrationBuilder.DropTable(
                name: "decisions");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "districts");

            migrationBuilder.DropTable(
                name: "expenses");

            migrationBuilder.DropTable(
                name: "geofence_border_points");

            migrationBuilder.DropTable(
                name: "geofence_keys");

            migrationBuilder.DropTable(
                name: "geofence_office_points");

            migrationBuilder.DropTable(
                name: "geofence_park_borders");

            migrationBuilder.DropTable(
                name: "geofence_park_points");

            migrationBuilder.DropTable(
                name: "geofence_points");

            migrationBuilder.DropTable(
                name: "geofence_region_points");

            migrationBuilder.DropTable(
                name: "geofence_restricted_points");

            migrationBuilder.DropTable(
                name: "geofences");

            migrationBuilder.DropTable(
                name: "government_users");

            migrationBuilder.DropTable(
                name: "inventory_categories");

            migrationBuilder.DropTable(
                name: "inventory_component_counts");

            migrationBuilder.DropTable(
                name: "inventory_components");

            migrationBuilder.DropTable(
                name: "inventory_model");

            migrationBuilder.DropTable(
                name: "inventory_part_counts");

            migrationBuilder.DropTable(
                name: "inventory_parts");

            migrationBuilder.DropTable(
                name: "inventory_status");

            migrationBuilder.DropTable(
                name: "investor_data");

            migrationBuilder.DropTable(
                name: "invoices");

            migrationBuilder.DropTable(
                name: "iot_box_inventory_history");

            migrationBuilder.DropTable(
                name: "iot_boxes");

            migrationBuilder.DropTable(
                name: "iot_lock_inventory_history");

            migrationBuilder.DropTable(
                name: "iot_locks");

            migrationBuilder.DropTable(
                name: "issue_solution_types");

            migrationBuilder.DropTable(
                name: "issue_types");

            migrationBuilder.DropTable(
                name: "issues");

            migrationBuilder.DropTable(
                name: "kpi_reports");

            migrationBuilder.DropTable(
                name: "kpi_values");

            migrationBuilder.DropTable(
                name: "marti_health_checks");

            migrationBuilder.DropTable(
                name: "motor_driver_inventory_history");

            migrationBuilder.DropTable(
                name: "motor_drivers");

            migrationBuilder.DropTable(
                name: "motor_inventory_history");

            migrationBuilder.DropTable(
                name: "motors");

            migrationBuilder.DropTable(
                name: "operating_hours");

            migrationBuilder.DropTable(
                name: "operating_hours_messages");

            migrationBuilder.DropTable(
                name: "operation_work_order_statuses");

            migrationBuilder.DropTable(
                name: "operation_work_orders");

            migrationBuilder.DropTable(
                name: "operator_action_log");

            migrationBuilder.DropTable(
                name: "operator_location_logs");

            migrationBuilder.DropTable(
                name: "out_of_order_request");

            migrationBuilder.DropTable(
                name: "pb_locations");

            migrationBuilder.DropTable(
                name: "pb_powerbanks");

            migrationBuilder.DropTable(
                name: "pb_rent_review_categories");

            migrationBuilder.DropTable(
                name: "pb_rent_reviews");

            migrationBuilder.DropTable(
                name: "pb_rents");

            migrationBuilder.DropTable(
                name: "pb_stations");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "popups");

            migrationBuilder.DropTable(
                name: "regions");

            migrationBuilder.DropTable(
                name: "repair_action_log_reasons");

            migrationBuilder.DropTable(
                name: "repair_action_logs");

            migrationBuilder.DropTable(
                name: "repair_control_status");

            migrationBuilder.DropTable(
                name: "repair_result_materials");

            migrationBuilder.DropTable(
                name: "repair_result_materials_usage");

            migrationBuilder.DropTable(
                name: "reservation_payment_status");

            migrationBuilder.DropTable(
                name: "reservation_refunds");

            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "ride_accidents");

            migrationBuilder.DropTable(
                name: "ride_fines");

            migrationBuilder.DropTable(
                name: "ride_refund_request_history");

            migrationBuilder.DropTable(
                name: "ride_reject_operation");

            migrationBuilder.DropTable(
                name: "ride_reject_reasons");

            migrationBuilder.DropTable(
                name: "ride_review_categories");

            migrationBuilder.DropTable(
                name: "ride_reviews");

            migrationBuilder.DropTable(
                name: "rides");

            migrationBuilder.DropTable(
                name: "rides_over_five_mins");

            migrationBuilder.DropTable(
                name: "riding_payment_errors");

            migrationBuilder.DropTable(
                name: "role_claims");

            migrationBuilder.DropTable(
                name: "role_rights");

            migrationBuilder.DropTable(
                name: "scooter_alert_detail");

            migrationBuilder.DropTable(
                name: "scooter_bodies");

            migrationBuilder.DropTable(
                name: "scooter_body_history");

            migrationBuilder.DropTable(
                name: "scooter_body_versions");

            migrationBuilder.DropTable(
                name: "scooter_error_messages");

            migrationBuilder.DropTable(
                name: "scooter_errors");

            migrationBuilder.DropTable(
                name: "scooter_errors_backlog");

            migrationBuilder.DropTable(
                name: "scooter_lock_code_history");

            migrationBuilder.DropTable(
                name: "scooter_prices");

            migrationBuilder.DropTable(
                name: "scooter_repair_categories");

            migrationBuilder.DropTable(
                name: "scooter_repair_logs");

            migrationBuilder.DropTable(
                name: "scooter_repair_records");

            migrationBuilder.DropTable(
                name: "scooter_repair_result_categories");

            migrationBuilder.DropTable(
                name: "scooter_repair_types");

            migrationBuilder.DropTable(
                name: "scooter_substatus");

            migrationBuilder.DropTable(
                name: "scooter_unavailable_reasons");

            migrationBuilder.DropTable(
                name: "scooter_update_log");

            migrationBuilder.DropTable(
                name: "scooter_versions");

            migrationBuilder.DropTable(
                name: "security_rights");

            migrationBuilder.DropTable(
                name: "swappable_battery_status");

            migrationBuilder.DropTable(
                name: "tasks");

            migrationBuilder.DropTable(
                name: "tax_offices");

            migrationBuilder.DropTable(
                name: "user_action_reasons");

            migrationBuilder.DropTable(
                name: "user_breaks");

            migrationBuilder.DropTable(
                name: "user_claims");

            migrationBuilder.DropTable(
                name: "user_geofences");

            migrationBuilder.DropTable(
                name: "user_logins");

            migrationBuilder.DropTable(
                name: "user_rights");

            migrationBuilder.DropTable(
                name: "user_roles");

            migrationBuilder.DropTable(
                name: "user_shifts");

            migrationBuilder.DropTable(
                name: "user_tokens");

            migrationBuilder.DropTable(
                name: "warehouses");

            migrationBuilder.DropTable(
                name: "work_orders");

            migrationBuilder.DropTable(
                name: "zones");

            migrationBuilder.DropTable(
                name: "ride_refunds");

            migrationBuilder.DropTable(
                name: "ride_refund_requests");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "scooters");

            migrationBuilder.DropTable(
                name: "scooter_status");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropSequence(
                name: "security_rights_id_seq");
        }
    }
}
