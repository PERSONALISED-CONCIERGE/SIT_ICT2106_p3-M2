using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using personalised_concierge_m1.Models.Entities.OtherServices;

namespace personalised_concierge_m1.Migrations
{
    public partial class initialaddwSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:food_leisure_type", "restaurant,hawker,poi,hotel_facilities")
                .Annotation("Npgsql:Enum:navigation_type", "walk,drive,car,taxi,train,bus")
                .Annotation("Npgsql:Enum:rating", "one,two,three,four,five")
                .Annotation("Npgsql:Enum:transportation_type", "taxi,limo,car_sharing,radio_taxi,bus_charter");

            migrationBuilder.CreateTable(
                name: "Attractions",
                schema: "public",
                columns: table => new
                {
                    foodleisure_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    attraction_hours = table.Column<string>(type: "varchar(20)", nullable: false),
                    attraction_lat = table.Column<double>(type: "double precision", nullable: false),
                    attraction_lon = table.Column<double>(type: "double precision", nullable: false),
                    attraction_price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attractions", x => x.foodleisure_id);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                schema: "public",
                columns: table => new
                {
                    facility_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    hotel_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    status = table.Column<string>(type: "varchar(100)", nullable: false),
                    operation_start_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    operation_end_time = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.facility_id);
                });

            migrationBuilder.CreateTable(
                name: "FoodLeisures",
                schema: "public",
                columns: table => new
                {
                    foodleisure_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: false),
                    website_link = table.Column<string>(type: "varchar(500)", nullable: true),
                    contact_num = table.Column<string>(type: "varchar(20)", nullable: false),
                    type = table.Column<FoodLeisureType>(type: "food_leisure_type", nullable: false),
                    address = table.Column<string>(type: "varchar(500)", nullable: false),
                    category = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodLeisures", x => x.foodleisure_id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                schema: "public",
                columns: table => new
                {
                    foodleisure_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cuisine = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.foodleisure_id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryCategories",
                schema: "public",
                columns: table => new
                {
                    invcate_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cate_name = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryCategories", x => x.invcate_id);
                });

            migrationBuilder.CreateTable(
                name: "RequestTypes",
                schema: "public",
                columns: table => new
                {
                    requesttype_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type_value = table.Column<string>(type: "varchar(100)", nullable: false),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTypes", x => x.requesttype_id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                schema: "public",
                columns: table => new
                {
                    roomtype_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    room_type = table.Column<string>(type: "varchar(100)", nullable: false),
                    description = table.Column<string>(type: "varchar(800)", nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.roomtype_id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "public",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.role_id);
                });

            migrationBuilder.CreateTable(
                name: "Navigations",
                schema: "public",
                columns: table => new
                {
                    navigation_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    foodleisure_id = table.Column<int>(type: "integer", nullable: false),
                    start_lon = table.Column<double>(type: "double precision", nullable: false),
                    end_lon = table.Column<double>(type: "double precision", nullable: false),
                    start_lat = table.Column<double>(type: "double precision", nullable: false),
                    end_lat = table.Column<double>(type: "double precision", nullable: false),
                    duration = table.Column<int>(type: "integer", nullable: false),
                    distance = table.Column<int>(type: "integer", nullable: false),
                    type = table.Column<NavigationType>(type: "navigation_type", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Navigations", x => x.navigation_id);
                    table.ForeignKey(
                        name: "FK_Navigations_FoodLeisures_foodleisure_id",
                        column: x => x.foodleisure_id,
                        principalSchema: "public",
                        principalTable: "FoodLeisures",
                        principalColumn: "foodleisure_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                schema: "public",
                columns: table => new
                {
                    inventory_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    invcate_id = table.Column<int>(type: "integer", nullable: false),
                    inv_name = table.Column<string>(type: "varchar(50)", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.inventory_id);
                    table.ForeignKey(
                        name: "FK_Inventories_InventoryCategories_invcate_id",
                        column: x => x.invcate_id,
                        principalSchema: "public",
                        principalTable: "InventoryCategories",
                        principalColumn: "invcate_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                schema: "public",
                columns: table => new
                {
                    request_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    requesttype_id = table.Column<int>(type: "integer", nullable: false),
                    request_msg = table.Column<string>(type: "varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.request_id);
                    table.ForeignKey(
                        name: "FK_Requests_RequestTypes_requesttype_id",
                        column: x => x.requesttype_id,
                        principalSchema: "public",
                        principalTable: "RequestTypes",
                        principalColumn: "requesttype_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                schema: "public",
                columns: table => new
                {
                    room_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    roomType_id = table.Column<int>(type: "integer", nullable: false),
                    room_num = table.Column<string>(type: "varchar(100)", nullable: false),
                    vacancy = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.room_id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_roomType_id",
                        column: x => x.roomType_id,
                        principalSchema: "public",
                        principalTable: "RoomTypes",
                        principalColumn: "roomtype_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryRequests",
                schema: "public",
                columns: table => new
                {
                    invreq_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    inventory_id = table.Column<int>(type: "integer", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    status_id = table.Column<int>(type: "integer", nullable: false),
                    price = table.Column<int>(type: "integer", nullable: false),
                    remarks = table.Column<string>(type: "varchar(200)", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryRequests", x => x.invreq_id);
                    table.ForeignKey(
                        name: "FK_InventoryRequests_Inventories_inventory_id",
                        column: x => x.inventory_id,
                        principalSchema: "public",
                        principalTable: "Inventories",
                        principalColumn: "inventory_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                schema: "public",
                columns: table => new
                {
                    account_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_id = table.Column<int>(type: "integer", nullable: false),
                    guest_type = table.Column<string>(type: "varchar(50)", nullable: true),
                    username = table.Column<string>(type: "varchar(100)", nullable: false),
                    full_name = table.Column<string>(type: "varchar(50)", nullable: false),
                    password_hash = table.Column<string>(type: "varchar(100)", nullable: false),
                    access_key = table.Column<string>(type: "varchar(50)", nullable: true),
                    request_id = table.Column<int>(type: "integer", nullable: false),
                    has_reservation = table.Column<bool>(type: "boolean", nullable: false),
                    reservation_id = table.Column<int>(type: "integer", nullable: false),
                    phone_number = table.Column<int>(type: "integer", nullable: false),
                    phone_number_confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    two_factor_enabled = table.Column<bool>(type: "boolean", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: false),
                    email_confirmed = table.Column<bool>(type: "boolean", nullable: false),
                    feedback_id = table.Column<int>(type: "integer", nullable: false),
                    location = table.Column<string>(type: "varchar(500)", nullable: true),
                    distance_from_hotel = table.Column<decimal>(type: "numeric", nullable: false),
                    currency = table.Column<string>(type: "varchar(100)", nullable: true),
                    facility_id = table.Column<int>(type: "integer", nullable: false),
                    position = table.Column<string>(type: "varchar(50)", nullable: true),
                    secret_hashpin = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.account_id);
                    table.ForeignKey(
                        name: "FK_Accounts_Facilities_facility_id",
                        column: x => x.facility_id,
                        principalSchema: "public",
                        principalTable: "Facilities",
                        principalColumn: "facility_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_Requests_request_id",
                        column: x => x.request_id,
                        principalSchema: "public",
                        principalTable: "Requests",
                        principalColumn: "request_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_UserRoles_role_id",
                        column: x => x.role_id,
                        principalSchema: "public",
                        principalTable: "UserRoles",
                        principalColumn: "role_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FacilityBookings",
                schema: "public",
                columns: table => new
                {
                    facilitybooking_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    facility_id = table.Column<int>(type: "integer", nullable: false),
                    account_id = table.Column<int>(type: "integer", nullable: false),
                    booking_start = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    booking_end = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityBookings", x => x.facilitybooking_id);
                    table.ForeignKey(
                        name: "FK_FacilityBookings_Accounts_account_id",
                        column: x => x.account_id,
                        principalSchema: "public",
                        principalTable: "Accounts",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacilityBookings_Facilities_facility_id",
                        column: x => x.facility_id,
                        principalSchema: "public",
                        principalTable: "Facilities",
                        principalColumn: "facility_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                schema: "public",
                columns: table => new
                {
                    feedback_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    account_id = table.Column<int>(type: "integer", nullable: false),
                    type = table.Column<string>(type: "varchar(50)", nullable: false),
                    description = table.Column<string>(type: "varchar(200)", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.feedback_id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Accounts_account_id",
                        column: x => x.account_id,
                        principalSchema: "public",
                        principalTable: "Accounts",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodDeliveries",
                schema: "public",
                columns: table => new
                {
                    food_order_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    account_id = table.Column<int>(type: "integer", nullable: false),
                    room_no = table.Column<int>(type: "integer", nullable: false),
                    instruction = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodDeliveries", x => x.food_order_id);
                    table.ForeignKey(
                        name: "FK_FoodDeliveries_Accounts_account_id",
                        column: x => x.account_id,
                        principalSchema: "public",
                        principalTable: "Accounts",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestRequests",
                schema: "public",
                columns: table => new
                {
                    account_id = table.Column<int>(type: "integer", nullable: false),
                    request_id = table.Column<int>(type: "integer", nullable: false),
                    serviced_by = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<string>(type: "varchar(50)", nullable: false),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    serviced_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestRequests", x => new { x.account_id, x.request_id });
                    table.ForeignKey(
                        name: "FK_GuestRequests_Accounts_account_id",
                        column: x => x.account_id,
                        principalSchema: "public",
                        principalTable: "Accounts",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuestRequests_Accounts_serviced_by",
                        column: x => x.serviced_by,
                        principalSchema: "public",
                        principalTable: "Accounts",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuestRequests_Requests_request_id",
                        column: x => x.request_id,
                        principalSchema: "public",
                        principalTable: "Requests",
                        principalColumn: "request_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelServices",
                schema: "public",
                columns: table => new
                {
                    service_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    account_id = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "varchar(100)", nullable: false),
                    availability = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelServices", x => x.service_id);
                    table.ForeignKey(
                        name: "FK_HotelServices_Accounts_account_id",
                        column: x => x.account_id,
                        principalSchema: "public",
                        principalTable: "Accounts",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Itineraries",
                schema: "public",
                columns: table => new
                {
                    itinerary_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    account_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    is_premade = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itineraries", x => x.itinerary_id);
                    table.ForeignKey(
                        name: "FK_Itineraries_Accounts_account_id",
                        column: x => x.account_id,
                        principalSchema: "public",
                        principalTable: "Accounts",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                schema: "public",
                columns: table => new
                {
                    reservation_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    account_id = table.Column<int>(type: "integer", nullable: false),
                    room_id = table.Column<int>(type: "integer", nullable: false),
                    start_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    end_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.reservation_id);
                    table.ForeignKey(
                        name: "FK_Reservations_Accounts_account_id",
                        column: x => x.account_id,
                        principalSchema: "public",
                        principalTable: "Accounts",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_room_id",
                        column: x => x.room_id,
                        principalSchema: "public",
                        principalTable: "Rooms",
                        principalColumn: "room_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                schema: "public",
                columns: table => new
                {
                    review_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    account_id = table.Column<int>(type: "integer", nullable: false),
                    foodleisure_id = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: true),
                    rating = table.Column<Rating>(type: "rating", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.review_id);
                    table.ForeignKey(
                        name: "FK_Reviews_Accounts_account_id",
                        column: x => x.account_id,
                        principalSchema: "public",
                        principalTable: "Accounts",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_FoodLeisures_foodleisure_id",
                        column: x => x.foodleisure_id,
                        principalSchema: "public",
                        principalTable: "FoodLeisures",
                        principalColumn: "foodleisure_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transportations",
                schema: "public",
                columns: table => new
                {
                    transport_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    account_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: true),
                    website = table.Column<string>(type: "varchar(500)", nullable: true),
                    contact_num = table.Column<int>(type: "integer", maxLength: 8, nullable: false),
                    type = table.Column<TransportationType>(type: "transportation_type", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportations", x => x.transport_id);
                    table.ForeignKey(
                        name: "FK_Transportations_Accounts_account_id",
                        column: x => x.account_id,
                        principalSchema: "public",
                        principalTable: "Accounts",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                schema: "public",
                columns: table => new
                {
                    blog_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    account_id = table.Column<int>(type: "integer", nullable: false),
                    itinerary_id = table.Column<int>(type: "integer", nullable: false),
                    foodleisure_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.blog_id);
                    table.ForeignKey(
                        name: "FK_Blogs_Accounts_account_id",
                        column: x => x.account_id,
                        principalSchema: "public",
                        principalTable: "Accounts",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_FoodLeisures_foodleisure_id",
                        column: x => x.foodleisure_id,
                        principalSchema: "public",
                        principalTable: "FoodLeisures",
                        principalColumn: "foodleisure_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Itineraries_itinerary_id",
                        column: x => x.itinerary_id,
                        principalSchema: "public",
                        principalTable: "Itineraries",
                        principalColumn: "itinerary_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Budgets",
                schema: "public",
                columns: table => new
                {
                    budget_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    itinerary_id = table.Column<int>(type: "integer", nullable: false),
                    budget_estimate = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.budget_id);
                    table.ForeignKey(
                        name: "FK_Budgets_Itineraries_itinerary_id",
                        column: x => x.itinerary_id,
                        principalSchema: "public",
                        principalTable: "Itineraries",
                        principalColumn: "itinerary_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checklists",
                schema: "public",
                columns: table => new
                {
                    checklist_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    itinerary_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checklists", x => x.checklist_id);
                    table.ForeignKey(
                        name: "FK_Checklists_Itineraries_itinerary_id",
                        column: x => x.itinerary_id,
                        principalSchema: "public",
                        principalTable: "Itineraries",
                        principalColumn: "itinerary_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItineraryItems",
                schema: "public",
                columns: table => new
                {
                    itinerary_item_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    foodleisure_id = table.Column<int>(type: "integer", nullable: false),
                    itinerary_id = table.Column<int>(type: "integer", nullable: false),
                    sequence = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItineraryItems", x => x.itinerary_item_id);
                    table.ForeignKey(
                        name: "FK_ItineraryItems_FoodLeisures_foodleisure_id",
                        column: x => x.foodleisure_id,
                        principalSchema: "public",
                        principalTable: "FoodLeisures",
                        principalColumn: "foodleisure_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItineraryItems_Itineraries_itinerary_id",
                        column: x => x.itinerary_id,
                        principalSchema: "public",
                        principalTable: "Itineraries",
                        principalColumn: "itinerary_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                schema: "public",
                columns: table => new
                {
                    expenses_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    budget_id = table.Column<int>(type: "integer", nullable: false),
                    cost = table.Column<double>(type: "double precision", nullable: false),
                    category = table.Column<string>(type: "varchar(50)", nullable: false),
                    description = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.expenses_id);
                    table.ForeignKey(
                        name: "FK_Expenses_Budgets_budget_id",
                        column: x => x.budget_id,
                        principalSchema: "public",
                        principalTable: "Budgets",
                        principalColumn: "budget_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Attractions",
                columns: new[] { "foodleisure_id", "attraction_hours", "attraction_lat", "attraction_lon", "attraction_price" },
                values: new object[,]
                {
                    { 1, "9:30am-6:30pm", 22.312999999999999, 114.04130000000001, 100.0 },
                    { 2, "12pm-6:30pm", 23.545400000000001, 115.0222, 80.0 }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Facilities",
                columns: new[] { "facility_id", "hotel_id", "name", "operation_end_time", "operation_start_time", "status" },
                values: new object[,]
                {
                    { 1, 1, "Basketball Court", new DateTime(2022, 2, 7, 15, 36, 40, 849, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 2, 7, 15, 36, 40, 849, DateTimeKind.Local).AddTicks(2600), "Available" },
                    { 2, 2, "Tennis Court", new DateTime(2022, 2, 7, 15, 36, 40, 849, DateTimeKind.Local).AddTicks(3650), new DateTime(2022, 2, 7, 15, 36, 40, 849, DateTimeKind.Local).AddTicks(3640), "Available" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "FoodLeisures",
                columns: new[] { "foodleisure_id", "address", "category", "contact_num", "description", "name", "type", "website_link" },
                values: new object[,]
                {
                    { 1, "Lantau Island, Hong Kong", "Theme Park", "+852 3550 3388", "The happiest place on earth!", "Hong Kong Disneyland", FoodLeisureType.POI, "https://www.hongkongdisneyland.com/" },
                    { 2, "Jurong East", "Theme Park", "89773448", "seasfood restaurant", "Tunglok", FoodLeisureType.Restaurant, "tunglok.com" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Foods",
                columns: new[] { "foodleisure_id", "cuisine" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "InventoryCategories",
                columns: new[] { "invcate_id", "cate_name" },
                values: new object[,]
                {
                    { 1, "Red Wine" },
                    { 2, "Bathroom Items" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "RequestTypes",
                columns: new[] { "requesttype_id", "created_at", "deleted_at", "is_deleted", "type_value" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 7, 15, 36, 40, 850, DateTimeKind.Local).AddTicks(6880), new DateTime(2022, 2, 7, 15, 36, 40, 850, DateTimeKind.Local).AddTicks(7270), false, "RoomService" },
                    { 2, new DateTime(2022, 2, 7, 15, 36, 40, 850, DateTimeKind.Local).AddTicks(7800), new DateTime(2022, 2, 7, 15, 36, 40, 850, DateTimeKind.Local).AddTicks(7810), false, "Bathroom replenishment" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "RoomTypes",
                columns: new[] { "roomtype_id", "description", "price", "room_type" },
                values: new object[,]
                {
                    { 1, "The Presidential Suite offers a tranquil haven of comfort and luxury surrounded by sophisticated d'ecor designed to delight all tastes. Featuring a fully-equipped kitchen, bedroom, large living room - including a working and dining area - and guest restroom, the Presidential Suite is the ultimate in creating a feeling of home", 10000m, "Presidential Suite" },
                    { 2, "The Business Suite offers a tranquil haven of comfort and luxury surrounded by sophisticated d'ecor designed to delight all tastes. Featuring a fully-equipped kitchen, bedroom, large living room - including a working and dining area - and guest restroom, the Business Suite is the ultimate in creating a feeling of home", 5000m, "Business Suite" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "UserRoles",
                columns: new[] { "role_id", "role" },
                values: new object[,]
                {
                    { 1, "Hotel Staff" },
                    { 2, "Hotel Guest" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Inventories",
                columns: new[] { "inventory_id", "inv_name", "invcate_id", "quantity", "status" },
                values: new object[,]
                {
                    { 1, "FirstInventory", 1, 100, "available" },
                    { 2, "SecondInventory", 2, 200, "available" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Navigations",
                columns: new[] { "navigation_id", "distance", "duration", "end_lat", "end_lon", "foodleisure_id", "start_lat", "start_lon", "type" },
                values: new object[,]
                {
                    { 1, 5, 3, 1.3400000000000001, -43.299999999999997, 1, 23.219999999999999, 24.449999999999999, NavigationType.Car },
                    { 2, 9, 4, 76.109999999999999, 32.329999999999998, 2, -65.299999999999997, 23.440000000000001, NavigationType.Bus }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Requests",
                columns: new[] { "request_id", "request_msg", "requesttype_id" },
                values: new object[,]
                {
                    { 1, "2 towels", 1 },
                    { 2, "2 Toilet Paper", 2 }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Rooms",
                columns: new[] { "room_id", "roomType_id", "room_num", "vacancy" },
                values: new object[,]
                {
                    { 1, 1, "1", true },
                    { 2, 2, "1", true }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Accounts",
                columns: new[] { "account_id", "access_key", "currency", "distance_from_hotel", "email", "email_confirmed", "facility_id", "feedback_id", "full_name", "guest_type", "has_reservation", "location", "password_hash", "phone_number", "phone_number_confirmed", "position", "request_id", "reservation_id", "role_id", "secret_hashpin", "two_factor_enabled", "username" },
                values: new object[,]
                {
                    { 1, null, "sgd", 0m, "john_doe@gmail.com", true, 1, 1, "John Doe", null, true, "Singapore", "123", 12345678, true, "guest", 1, 1, 1, "not so secret", true, "John Doe" },
                    { 2, null, "sgd", 0m, "sarah_ellis@gmail.com", true, 2, 2, "Sarah Ellis", null, true, "Singapore", "123", 98765432, true, "guest", 2, 1, 2, "very so secret", true, "sarahellis" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "InventoryRequests",
                columns: new[] { "invreq_id", "created_date", "inventory_id", "price", "quantity", "remarks", "status_id", "updated_date" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100, 50, "Inventory Request 01", 1, new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 200, 100, "Inventory Request 02", 2, new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "FacilityBookings",
                columns: new[] { "facilitybooking_id", "account_id", "booking_end", "booking_start", "facility_id" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 2, 7, 15, 36, 40, 849, DateTimeKind.Local).AddTicks(6260), new DateTime(2022, 2, 7, 15, 36, 40, 849, DateTimeKind.Local).AddTicks(5360), 1 },
                    { 2, 2, new DateTime(2022, 2, 7, 15, 36, 40, 849, DateTimeKind.Local).AddTicks(7060), new DateTime(2022, 2, 7, 15, 36, 40, 849, DateTimeKind.Local).AddTicks(7050), 2 }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Feedbacks",
                columns: new[] { "feedback_id", "account_id", "created_at", "description", "type" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 2, 7, 15, 36, 40, 849, DateTimeKind.Local).AddTicks(9170), "Perfect dream hotel after a hard project", "General" },
                    { 2, 2, new DateTime(2022, 2, 7, 15, 36, 40, 849, DateTimeKind.Local).AddTicks(9780), "Perfect dream hotel after a hard project", "General" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "FoodDeliveries",
                columns: new[] { "food_order_id", "account_id", "instruction", "room_no" },
                values: new object[,]
                {
                    { 1, 1, "leave food outside the door", 20 },
                    { 2, 2, "call before coming", 19 }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "GuestRequests",
                columns: new[] { "account_id", "request_id", "created_at", "deleted_at", "is_deleted", "serviced_at", "serviced_by", "status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 2, 7, 15, 36, 40, 850, DateTimeKind.Local).AddTicks(2310), new DateTime(2022, 2, 7, 15, 36, 40, 850, DateTimeKind.Local).AddTicks(2700), false, new DateTime(2022, 2, 7, 15, 36, 40, 850, DateTimeKind.Local).AddTicks(3090), 1, "In progress" },
                    { 2, 2, new DateTime(2022, 2, 7, 15, 36, 40, 850, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 2, 7, 15, 36, 40, 850, DateTimeKind.Local).AddTicks(3660), false, new DateTime(2022, 2, 7, 15, 36, 40, 850, DateTimeKind.Local).AddTicks(3660), 2, "In progress" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "HotelServices",
                columns: new[] { "service_id", "account_id", "availability", "description" },
                values: new object[,]
                {
                    { 1, 1, true, "Dry Cleaning" },
                    { 2, 2, true, "Room Cleaning" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Itineraries",
                columns: new[] { "itinerary_id", "account_id", "created_date", "description", "is_premade", "name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Going to Marina Bay Sands", false, "SG Downtown" },
                    { 2, 2, new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Theme park", false, "Haw Par Villa" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Reservations",
                columns: new[] { "reservation_id", "account_id", "end_date", "room_id", "start_date" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Reviews",
                columns: new[] { "review_id", "account_id", "description", "foodleisure_id", "rating" },
                values: new object[,]
                {
                    { 1, 1, "saizeriya sucks", 1, Rating.One },
                    { 2, 2, "mcdonalds is awesome!", 2, Rating.Five }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Transportations",
                columns: new[] { "transport_id", "account_id", "contact_num", "description", "name", "type", "website" },
                values: new object[,]
                {
                    { 2, 2, 92206874, "for peasant people only", "Gojek", TransportationType.Taxi, "www.gojek.com" },
                    { 1, 1, 99119911, "for rich people only", "GrabCar", TransportationType.Taxi, "www.grab.com" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Blogs",
                columns: new[] { "blog_id", "account_id", "created_date", "description", "foodleisure_id", "itinerary_id", "name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spending my vaccation in Singapore during summer break!", 1, 1, "My Time in Singapore" },
                    { 2, 2, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Staying at MBS was such a fun time!", 2, 2, "My Time at MBS" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Budgets",
                columns: new[] { "budget_id", "budget_estimate", "itinerary_id" },
                values: new object[,]
                {
                    { 1, 120.5, 1 },
                    { 2, 231.30000000000001, 2 }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Checklists",
                columns: new[] { "checklist_id", "created_date", "description", "itinerary_id", "name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "10 Fun things to do in SG when you are on a budget", 1, "Things to Do in Singapore" },
                    { 2, new DateTime(2022, 2, 7, 15, 36, 40, 843, DateTimeKind.Local).AddTicks(7990), "Alex dream holiday", 2, "Alex Checklist" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "ItineraryItems",
                columns: new[] { "itinerary_item_id", "foodleisure_id", "itinerary_id", "sequence" },
                values: new object[,]
                {
                    { 1, 1, 1, 101 },
                    { 2, 2, 2, 12345 }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Expenses",
                columns: new[] { "expenses_id", "budget_id", "category", "cost", "description" },
                values: new object[,]
                {
                    { 1, 1, "Food&Drinks", 1.0, "My Singapore Expenses" },
                    { 2, 2, "Food&Drinks", 23.489999999999998, "nasi lemak" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_facility_id",
                schema: "public",
                table: "Accounts",
                column: "facility_id");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_request_id",
                schema: "public",
                table: "Accounts",
                column: "request_id");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_role_id",
                schema: "public",
                table: "Accounts",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_account_id",
                schema: "public",
                table: "Blogs",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_foodleisure_id",
                schema: "public",
                table: "Blogs",
                column: "foodleisure_id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_itinerary_id",
                schema: "public",
                table: "Blogs",
                column: "itinerary_id");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_itinerary_id",
                schema: "public",
                table: "Budgets",
                column: "itinerary_id");

            migrationBuilder.CreateIndex(
                name: "IX_Checklists_itinerary_id",
                schema: "public",
                table: "Checklists",
                column: "itinerary_id");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_budget_id",
                schema: "public",
                table: "Expenses",
                column: "budget_id");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityBookings_account_id",
                schema: "public",
                table: "FacilityBookings",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityBookings_facility_id",
                schema: "public",
                table: "FacilityBookings",
                column: "facility_id");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_account_id",
                schema: "public",
                table: "Feedbacks",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_FoodDeliveries_account_id",
                schema: "public",
                table: "FoodDeliveries",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_GuestRequests_request_id",
                schema: "public",
                table: "GuestRequests",
                column: "request_id");

            migrationBuilder.CreateIndex(
                name: "IX_GuestRequests_serviced_by",
                schema: "public",
                table: "GuestRequests",
                column: "serviced_by");

            migrationBuilder.CreateIndex(
                name: "IX_HotelServices_account_id",
                schema: "public",
                table: "HotelServices",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_invcate_id",
                schema: "public",
                table: "Inventories",
                column: "invcate_id");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryRequests_inventory_id",
                schema: "public",
                table: "InventoryRequests",
                column: "inventory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Itineraries_account_id",
                schema: "public",
                table: "Itineraries",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryItems_foodleisure_id",
                schema: "public",
                table: "ItineraryItems",
                column: "foodleisure_id");

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryItems_itinerary_id",
                schema: "public",
                table: "ItineraryItems",
                column: "itinerary_id");

            migrationBuilder.CreateIndex(
                name: "IX_Navigations_foodleisure_id",
                schema: "public",
                table: "Navigations",
                column: "foodleisure_id");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_requesttype_id",
                schema: "public",
                table: "Requests",
                column: "requesttype_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_account_id",
                schema: "public",
                table: "Reservations",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_room_id",
                schema: "public",
                table: "Reservations",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_account_id",
                schema: "public",
                table: "Reviews",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_foodleisure_id",
                schema: "public",
                table: "Reviews",
                column: "foodleisure_id");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_roomType_id",
                schema: "public",
                table: "Rooms",
                column: "roomType_id");

            migrationBuilder.CreateIndex(
                name: "IX_Transportations_account_id",
                schema: "public",
                table: "Transportations",
                column: "account_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attractions",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Blogs",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Checklists",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Expenses",
                schema: "public");

            migrationBuilder.DropTable(
                name: "FacilityBookings",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Feedbacks",
                schema: "public");

            migrationBuilder.DropTable(
                name: "FoodDeliveries",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Foods",
                schema: "public");

            migrationBuilder.DropTable(
                name: "GuestRequests",
                schema: "public");

            migrationBuilder.DropTable(
                name: "HotelServices",
                schema: "public");

            migrationBuilder.DropTable(
                name: "InventoryRequests",
                schema: "public");

            migrationBuilder.DropTable(
                name: "ItineraryItems",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Navigations",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Reservations",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Reviews",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Transportations",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Budgets",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Inventories",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Rooms",
                schema: "public");

            migrationBuilder.DropTable(
                name: "FoodLeisures",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Itineraries",
                schema: "public");

            migrationBuilder.DropTable(
                name: "InventoryCategories",
                schema: "public");

            migrationBuilder.DropTable(
                name: "RoomTypes",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Accounts",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Facilities",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Requests",
                schema: "public");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "public");

            migrationBuilder.DropTable(
                name: "RequestTypes",
                schema: "public");
        }
    }
}
