using Microsoft.EntityFrameworkCore;
using Npgsql;
using personalised_concierge_m1.Models;
using personalised_concierge_m1.Models.Entities.RoomDetails;
using personalised_concierge_m1.Models.Entities.Itineraries;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using personalised_concierge_m1.Models.Entities.HotelServices;
using personalised_concierge_m1.Models.Entities.UserDetails;
using personalised_concierge_m1.Models.Entities.Facilities;
using personalised_concierge_m1.Models.Entities.Inventories;
using personalised_concierge_m1.Models.Entities.OtherServices;
using personalised_concierge_m1.Models.Entities.Requests;
using personalised_concierge_m1.Models.Interfaces.OtherServices;

namespace personalised_concierge_m1.Data
{
    public class ConciergeContext : DbContext
    {
        public ConciergeContext(DbContextOptions<ConciergeContext> options) : base(options)
        {
            
        }

        public static ITransportationRepo Transportation { get; internal set; }

        //Entities need to be set in DB using DBSet so that EF knows where to look for the data.
        #region DBSetting Entities
        //TODO: All Entities to be found by DbSet goes here.

        //M1 Room Details
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        
        //M1 Hotel Services
        public DbSet<HotelService> HotelServices { get; set; }

        //M1 User Details
        public DbSet<Account> Accounts { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        //M2 Itineraries
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Checklist> Checklists { get; set; }
        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<ItineraryItem> ItineraryItems { get; set; }
        public DbSet<Itinerary> Itineraries { get; set; }

        //M2 Food Leisure Services
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<FoodLeisure> FoodLeisures { get; set; }
        public DbSet<Food> Foods { get; set; }
        
        //M2 Other Services
        public DbSet<FoodDelivery> FoodDeliveries { get; set; }
        public DbSet<Navigation> Navigations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Transportation> Transportations { get; set; }
        public DbSet<TransportFares> TransportFares { get; set; }
        
        //M3 Facilities
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<FacilityBooking> FacilityBookings { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        
        //M3 Inventories
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryCategory> InventoryCategories { get; set; }
        public DbSet<InventoryRequest> InventoryRequests { get; set; }
        
        //M3 Requests
        public DbSet<GuestRequest> GuestRequests { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestType> RequestTypes { get; set; }
        
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<Rating>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<CuisineType>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<FoodLeisureType>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<NavigationType>();
            NpgsqlConnection.GlobalTypeMapper.MapEnum<FaresType>();
            builder.UseNpgsql(connectionString: "Server=localhost; Database=postgres; Port=5432; User Id=postgres; Password=123456;");
        }

        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.HasPostgresEnum<CuisineType>();
            modelBuilder.HasPostgresEnum<FoodLeisureType>();
            modelBuilder.HasPostgresEnum<Rating>();
            modelBuilder.HasPostgresEnum<NavigationType>();
            modelBuilder.HasPostgresEnum<FaresType>();

            //M2 model builders for enum conversion
            modelBuilder.Entity<Food>()
                .Property(u => u.cuisine)
                .HasConversion<CuisineType>();
            
            modelBuilder.Entity<FoodLeisure>()
                .Property(u => u.type)
                .HasConversion<FoodLeisureType>();
            
            
            modelBuilder.Entity<Review>()
                .Property(u => u.rating)
                .HasConversion<Rating>();
            
            
            modelBuilder.Entity<Navigation>()
                .Property(u => u.type)
                .HasConversion<NavigationType>();

            modelBuilder.Entity<TransportFares>()
                .Property(u => u.fares_type)
                .HasConversion<FaresType>();
            
            

            //M3 model builder
            modelBuilder.Entity<GuestRequest>()
                .HasKey(g => new {g.account_id, g.request_id}); //create composite key
            
            modelBuilder.Seed();
        }
    }
}