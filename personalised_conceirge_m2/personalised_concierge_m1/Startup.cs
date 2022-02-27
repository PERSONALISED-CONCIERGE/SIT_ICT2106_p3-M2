using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using personalised_concierge_m1.Data;
using personalised_concierge_m1.Data.FoodLeisureServices;
using personalised_concierge_m1.Data.HotelServices;
using personalised_concierge_m1.Data.Facilities;
using personalised_concierge_m1.Data.Inventories;
using personalised_concierge_m1.Data.OtherServices;
using personalised_concierge_m1.Data.Requests;
using personalised_concierge_m1.Data.RoomDetails;
using personalised_concierge_m1.Data.UnitOfWorks;
using personalised_concierge_m1.Data.Itineraries;
using personalised_concierge_m1.Data.UserDetails;
using personalised_concierge_m1.Models.Interfaces;
using personalised_concierge_m1.Models.Interfaces.FoodLeisureServices;
using personalised_concierge_m1.Models.Interfaces.HotelServices;
using personalised_concierge_m1.Models.Interfaces.Itineraries;
using personalised_concierge_m1.Models.Interfaces.RoomDetails;
using personalised_concierge_m1.Models.Interfaces.UserDetails;
using personalised_concierge_m1.Models.Interfaces.Facilities;
using personalised_concierge_m1.Models.Interfaces.Inventories;
using personalised_concierge_m1.Models.Interfaces.OtherServices;
using personalised_concierge_m1.Models.Interfaces.Requests;


namespace personalised_concierge_m1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ConciergeContext>(options =>
                {
                    options.UseNpgsql(Configuration.GetConnectionString("P306Database"));
                    options.EnableSensitiveDataLogging();
                }
            );
            services.AddControllersWithViews();

            #region Repositories
            //TODO: All Repository to use PostGresSQL DB needs to be registered in service here:

            // M1 Room Details
            services.AddTransient<IReservationRepo, ReservationRepo>();
            services.AddTransient<IRoomRepo, RoomRepo>();
            services.AddTransient<IRoomTypeRepo, RoomTypeRepo>();
            
            // M1 Hotel Services
            services.AddTransient<IHotelServiceRepo, HotelServiceRepo>();

            // M1 User Details
            services.AddTransient<IAccountRepo, AccountRepo>();
            services.AddTransient<IUserRoleRepo, UserRoleRepo>();

            // M2 Itineraries
            services.AddTransient<IBlogRepo, BlogRepo>();
            services.AddTransient<IBudgetRepo, BudgetRepo>();
            services.AddTransient<IChecklistRepo, ChecklistRepo>();
            services.AddTransient<IExpensesRepo, ExpensesRepo>();
            services.AddTransient<IItineraryItemRepo, ItineraryItemRepo>();
            services.AddTransient<IItineraryRepo, ItineraryRepo>();
            
            // M2 Food Leisure Services
            services.AddTransient<IAttractionRepo, AttractionRepo>();
            services.AddTransient<IFoodLeisureRepo, FoodLeisureRepo>();
            services.AddTransient<IFoodRepo, FoodRepo>();
            
            // M2 Other Services
            services.AddTransient<IFoodDeliveryRepo, FoodDeliveryRepo>();
            services.AddTransient<INavigationRepo, NavigationRepo>();
            services.AddTransient<IReviewRepo, ReviewRepo>();
            services.AddTransient<ITransportationRepo,TransportationRepo>();

            // M3 Facilities
            services.AddTransient<IFacilityRepo, FacilityRepo>();
            services.AddTransient<IFacilityBookingRepo, FacilityBookingRepo>();
            services.AddTransient<IFeedbackRepo, FeedbackRepo>();
            
            // M3 Inventories 
            services.AddTransient<IInventoryRepo, InventoryRepo>();
            services.AddTransient<IInventoryCategoryRepo, InventoryCategoryRepo>();
            services.AddTransient<IInventoryRequestRepo, InventoryRequestRepo>();
            
            // M3 Guest Requests
            services.AddTransient<IGuestRequestRepo, GuestRequestRepo>();
            services.AddTransient<IRequestRepo, RequestRepo>();
            services.AddTransient<IRequestTypeRepo,RequestTypeRepo>();
            
            #endregion
            
            // UnitOfWork Registration
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IM2UnitOfWork, M2UnitOfWork>();
            services.AddTransient<IM3UnitOfWork, M3UnitOfWork>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}