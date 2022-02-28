using System;
using Microsoft.EntityFrameworkCore;
using personalised_concierge_m1.Models.Entities.Facilities;
using personalised_concierge_m1.Models.Entities.Inventories;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using personalised_concierge_m1.Models.Entities.HotelServices;
using personalised_concierge_m1.Models.Entities.Itineraries;
using personalised_concierge_m1.Models.Entities.OtherServices;
using personalised_concierge_m1.Models.Entities.Requests;
using personalised_concierge_m1.Models.Entities.RoomDetails;
using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //TODO: Seed your data here if you want to add more data inside the DB.
            
            //M1 Data Seeding
            #region M1 Data Seed

            //user details
            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    account_id = 01,
                    role_id = 01,
                    username = "John Doe",
                    full_name = "John Doe",
                    profile_pic = "~/images/PFP2.png",
                    password_hash = "123",
                    
                    request_id = 01,
                    has_reservation = true,
                    reservation_id = 01,
                    phone_number = 12345678,
                    phone_number_confirmed = true,
                    two_factor_enabled = true,
                    
                    email = "john_doe@gmail.com",
                    email_confirmed = true,
                    feedback_id = 01,
                    
                    location = "Singapore",
                    currency = "sgd",
                    position = "guest",
                    secret_hashpin = "not so secret",
                    facility_id = 01,
                    // feedback_id = 01,

                },
                new Account
                {
                    account_id = 02,
                    role_id = 02,
                    username = "sarahellis",
                    full_name = "Sarah Ellis",
                    profile_pic = "~/images/PFP1.png",
                    password_hash = "123",
                    
                    request_id = 02,
                    has_reservation = true,
                    reservation_id = 01,
                    phone_number = 98765432,
                    phone_number_confirmed = true,
                    two_factor_enabled = true,
                    
                    email = "sarah_ellis@gmail.com",
                    email_confirmed = true,
                    feedback_id = 02,
                    
                    location = "Singapore",
                    currency = "sgd",
                    position = "guest",
                    secret_hashpin = "very so secret",
                    facility_id = 02,
                    
                },
                new Account
                {
                    account_id = 03,
                    role_id = 01,
                    username = "wondergirl",
                    full_name = "Wander Woman",
                    profile_pic = "~/images/PFP3.png",
                    password_hash = "123",

                    request_id = 01,
                    has_reservation = true,
                    reservation_id = 01,
                    phone_number = 98765432,
                    phone_number_confirmed = true,
                    two_factor_enabled = true,

                    email = "sarah_ellis@gmail.com",
                    email_confirmed = true,
                    feedback_id = 02,

                    location = "Singapore",
                    currency = "sgd",
                    position = "guest",
                    secret_hashpin = "very so secret",
                    facility_id = 02,

                },
                new Account
                {
                    account_id = 04,
                    role_id = 01,
                    username = "superboy",
                    full_name = "Super Man",
                    profile_pic = "~/images/PFP4.png",
                    password_hash = "123",

                    request_id = 02,
                    has_reservation = true,
                    reservation_id = 01,
                    phone_number = 98765432,
                    phone_number_confirmed = true,
                    two_factor_enabled = true,

                    email = "sarah_ellis@gmail.com",
                    email_confirmed = true,
                    feedback_id = 02,

                    location = "Singapore",
                    currency = "sgd",
                    position = "guest",
                    secret_hashpin = "very so secret",
                    facility_id = 02,

                }
            );
            
            // Room Details
            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    reservation_id = 01,
                    room_id = 01,
                    account_id = 01,
                    start_date = new DateTime(2021, 10, 21),
                    end_date = new DateTime(2021, 10, 30)
                }
            );
            
            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    reservation_id = 02,
                    room_id = 02,
                    account_id = 02,
                    start_date = new DateTime(2021, 10, 21),
                    end_date = new DateTime(2021, 10, 30)
                }
            );
            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    reservation_id = 03,
                    room_id = 03,
                    account_id = 03,
                    start_date = new DateTime(2021, 12, 21),
                    end_date = new DateTime(2021, 12, 30)
                }
            );
            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    reservation_id = 04,
                    room_id = 04,
                    account_id = 04,
                    start_date = new DateTime(2021, 11, 21),
                    end_date = new DateTime(2021, 11, 30)
                }
            );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    room_id = 01,
                    room_num = "1",
                    roomType_id = 01,
                    vacancy = true
                }
            );
            
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    room_id = 02,
                    room_num = "1",
                    roomType_id = 02,
                    vacancy = true
                }
            );
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    room_id = 03,
                    room_num = "1",
                    roomType_id = 01,
                    vacancy = true
                }
            );
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    room_id = 04,
                    room_num = "1",
                    roomType_id = 02,
                    vacancy = true
                }
            );

            modelBuilder.Entity<RoomType>().HasData(
              new RoomType
              {
                  roomtype_id = 01,
                  room_type = "Presidential Suite",
                  description = "The Presidential Suite offers a tranquil haven of comfort and luxury " +
                  "surrounded by sophisticated d'ecor designed to delight all tastes. " +
                  "Featuring a fully-equipped kitchen, bedroom, large living room - " +
                  "including a working and dining area - and guest restroom, the Presidential Suite " +
                  "is the ultimate in creating a feeling of home",
                  price = 10000
              }
            );
            
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType
                {
                    roomtype_id = 02,
                    room_type = "Business Suite",
                    description = "The Business Suite offers a tranquil haven of comfort and luxury " +
                                  "surrounded by sophisticated d'ecor designed to delight all tastes. " +
                                  "Featuring a fully-equipped kitchen, bedroom, large living room - " +
                                  "including a working and dining area - and guest restroom, the Business Suite " +
                                  "is the ultimate in creating a feeling of home",
                    price = 5000
                }
            );
                
            // Hotel Services
            modelBuilder.Entity<HotelService>().HasData(
                new HotelService
                {
                    service_id = 01,
                    account_id = 01,
                    description = "Dry Cleaning",
                    availability = true
                }
            );
            
            modelBuilder.Entity<HotelService>().HasData(
                new HotelService
                {
                    service_id = 02,
                    account_id = 02,
                    description = "Room Cleaning",
                    availability = true
                }
            );
            
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole
                {
                    role_id = 01,
                    role = "Hotel Staff",
                },
                new UserRole
                {
                    role_id = 02,
                    role = "Hotel Guest",
                }
            );

            #endregion
            
            //M2 Data Seeding
            #region M2 Data Seed
            
            #region Navigation Data Seed Start
            
            modelBuilder.Entity<Navigation>().HasData(
                new Navigation
                {
                    navigation_id = 01,
                    foodleisure_id = 01,
                    start_lon = 24.45,
                    end_lon = -43.3,
                    start_lat = 23.22,
                    end_lat = 1.34,
                    duration = 3,
                    distance = 5,
                    type = NavigationType.Car
                },
                new Navigation
                {
                    navigation_id = 02,
                    foodleisure_id = 02,
                    start_lon = 23.44,
                    end_lon = 32.33,
                    start_lat = -65.3,
                    end_lat = 76.11,
                    duration = 4,
                    distance = 9,
                    type = NavigationType.Bus
                }
            );
            
            #endregion
            
            #region Attractions Data Seed START
            modelBuilder.Entity<Attraction>().HasData(
                new Attraction
                {
                    foodleisure_id = 01,
                    attraction_hours = "9:30am-6:30pm",
                    attraction_lat = 22.3130,
                    attraction_lon = 114.0413,
                    attraction_price = 100
                },
                new Attraction
                {
                    foodleisure_id = 02,
                    attraction_hours = "12pm-6:30pm",
                    attraction_lat = 23.5454,
                    attraction_lon = 115.0222,
                    attraction_price = 80
                }
            );
            #endregion Attractions Data Seed END

            #region Itinerary Data Seed START
            modelBuilder.Entity<Itinerary>().HasData(
                new Itinerary
                {
                    itinerary_id = 01,
                    account_id = 01,
                    name= "SG Downtown",
                    description = "Going to Marina Bay Sands",
                    created_date = new DateTime(2021, 10, 21),
                    is_premade = false
                },
                new Itinerary
                {   
                    itinerary_id = 02,
                    account_id = 02,
                    name= "Haw Par Villa",
                    description = "Theme park",
                    created_date = new DateTime(2021, 12, 09),
                    is_premade = false
                }
            );
            
            #endregion Itinerary Data Seed END
            
            #region Itinerary ITEM Data Seed START
            modelBuilder.Entity<ItineraryItem>().HasData(
                new ItineraryItem
                {
                    itinerary_item_id = 01,
                    foodleisure_id = 01,
                    itinerary_id = 01,
                    sequence = 101
                },
                new ItineraryItem
                {
                    itinerary_item_id = 02,
                    foodleisure_id = 02,
                    itinerary_id = 02,
                    sequence = 12345
                }
            );
            #endregion Itinerary ITEM Data Seed END
            
            #region Food Data Seed Start

            modelBuilder.Entity<Food>().HasData(
                new Food
                {
                    foodleisure_id = 01,
                    cuisine = CuisineType.Western
                },
                new Food
                {
                    foodleisure_id = 02,
                    cuisine = CuisineType.Chinese
                }
            );

            #endregion

            #region Food Delivery Data Seed Start

            modelBuilder.Entity<FoodDelivery>().HasData(
                new FoodDelivery
                {
                    food_order_id = 01,
                    account_id = 01,
                    room_no = 20,
                    instruction = "leave food outside the door"
                },
                new FoodDelivery
                {
                    food_order_id = 02,
                    account_id = 02,
                    room_no = 19,
                    instruction = "call before coming"
                }
            );

            #endregion

            #region FoodLeisure Data Seed Start

            modelBuilder.Entity<FoodLeisure>().HasData(
                new FoodLeisure
                {
                    foodleisure_id = 01,
                    name = "Universal Studios Singapore",
                    description = "The happiest place on earth!",
                    website_link = "https://www.rwsentosa.com/en/attractions/universal-studios-singapore/explore",
                    contact_num = "+65 6577 8888",
                    type = FoodLeisureType.POI,
                    foodleisure_image= "~/images/USS.jpeg",
                    address = "8 Sentosa Gateway, 098269",
                    featured = true
                },
                new FoodLeisure
                {
                    foodleisure_id = 02,
                    name = "Maki-San (Bedok Town Square)",
                    description = "ASIA'S FIRST D.I.Y SUSHI & SALAD RESTAURANT.",
                    website_link = "https://www.makisan.com",
                    contact_num = "+65 89773448",
                    type = FoodLeisureType.Restaurant,
                    foodleisure_image = "~/images/makisan.webp",
                    address = "Blk 208D New Upper Changi Rd, Singapore 464208",
                    featured = false
                },
                new FoodLeisure
                {
                    foodleisure_id = 03,
                    name = "PS.Cafe at Raffles City",
                    description = "PS.Cafe opened in 1999 as a cosy cafe hidden within Projectshop clothing store.",
                    website_link = "https://www.pscafe.com",
                    contact_num = "+65 6708 9288",
                    type = FoodLeisureType.Restaurant,
                    foodleisure_image = "~/images/PScafe.jpeg",
                    address = "252 North Bridge Road, #03-37, Raffles City Shopping Centre, Singapore 179103",
                    featured = false
                },
                new FoodLeisure
                {
                    foodleisure_id = 04,
                    name = "Singapore Zoo",
                    description = "The Singapore Zoo, formerly known as the Singapore Zoological Gardens or Mandai Zoo, occupies 28 hectares on the margins of Upper Seletar Reservoir within Singapore's heavily forested central catchment area.",
                    website_link = "https://www.mandai.com/en/singapore-zoo.html",
                    contact_num = "+65 6269 3411",
                    type = FoodLeisureType.POI,
                    foodleisure_image = "~/images/Zoo.jpeg",
                    address = "80 Mandai Lake Rd, 729826",
                    featured = false
                }
            );

            #endregion
            
            #region Expenses Data Seed START
            modelBuilder.Entity<Expenses>().HasData(
                new Expenses
                {
                    expenses_id = 01,
                    budget_id = 01,
                    cost = 01,
                    category = "Food&Drinks",
                    description = "My Singapore Expenses"
                },
                new Expenses
                {
                    expenses_id = 02,
                    budget_id = 02,
                    cost = 23.49,
                    category = "Food&Drinks",
                    description = "nasi lemak"
                }
            );
            #endregion Expenses Data Seed END
            
            #region CheckList Data Seed START
            modelBuilder.Entity<Checklist>().HasData(
                new Checklist()
                {
                    checklist_id = 01,
                    itinerary_id = 01,
                    name = "Things to Do in Singapore",
                    description = "10 Fun things to do in SG when you are on a budget",
                    created_date = new DateTime(2022, 01, 30)
                },
                new Checklist
                {
                    checklist_id = 02,
                    itinerary_id = 02,
                    name = "Alex Checklist",
                    description = "Alex dream holiday",
                    created_date = DateTime.Now
                }
            );

            #endregion

            #region Budget Data Seed START
            modelBuilder.Entity<Budget>().HasData(
                new Budget()
                {
                    budget_id = 01,
                    itinerary_id = 01,
                    budget_estimate = 120.50,
                },
                new Budget
                {
                    budget_id = 02,
                    itinerary_id = 02,
                    budget_estimate = 231.30
                }
            );
            #endregion Budget Data Seed END

            #region Blog Data Seed START
            modelBuilder.Entity<Blog>().HasData(
                new Blog()
                {
                    blog_id = 01,
                    account_id = 01,
                    itinerary_id = 01,
                    foodleisure_id = 01,
                    name = "My Time in Singapore",
                    description = "Spending my vaccation in Singapore during summer break!",
                    created_date = new DateTime(2021, 06, 01),
                },
                new Blog()
                {
                    blog_id = 02,
                    account_id = 02,
                    itinerary_id = 02,
                    foodleisure_id = 02,
                    name = "My Time at MBS",
                    description = "Staying at MBS was such a fun time!",
                    created_date = new DateTime(2021, 09, 01),
                }
            );
            #endregion Blog Data Seed END

            #region Review Data Seed START

            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    review_id = 01,
                    account_id = 01,
                    foodleisure_id = 01,
                    review = "saizeriya sucks",
                    rating = Rating.One
                },
                new Review
                {
                    review_id = 02,
                    account_id = 02,
                    foodleisure_id = 02,
                    review = "mcdonalds is awesome!",
                    rating = Rating.Five
                }
            );


            #endregion

            #region Transportation Data Seed Start

            modelBuilder.Entity<Transportation>().HasData(
                new Transportation
                {
                    transport_id = 01,
                    company_name = "GrabCar",
                    description = "for rich people only",
                    website = "www.grab.com",
                    contact_num = 99119911
                }, 
                new Transportation
                {
                    transport_id = 02,
                    company_name = "Gojek",
                    description = "for peasant people only",
                    website = "www.gojek.com",
                    contact_num = 92206874
                }
            );

            #endregion
            #region TransportFares Data Seed Start

            modelBuilder.Entity<TransportFares>().HasData(
                new TransportFares
                {
                    fare_id = 01,
                    transport_id = 01,
                    fares_type = FaresType.Standard,
                    fares = "$3.00"
                },
                new TransportFares
                {
                    fare_id = 02,
                    transport_id = 01,
                    fares_type = FaresType.Flagdown,
                    fares = "$10.00"
                },
                new TransportFares
                {
                    fare_id = 03,
                    transport_id = 01,
                    fares_type = FaresType.Distance,
                    fares = "Every 400m thereafter or less up to 10km, $0.22"
                }
            ); ;

            #endregion


            #endregion

            //M3 Data Seeding
            #region M3 Data Seed

            #region Invertory Data Seed Start

            //Inventory
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory()
                {
                    inventory_id = 01,
                    invcate_id = 01,
                    inv_name = "FirstInventory",
                    quantity = 100,
                    status = "available"
                }
            );
            
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory()
                {
                    inventory_id = 02,
                    invcate_id = 02,
                    inv_name = "SecondInventory",
                    quantity = 200,
                    status = "available"
                }
            );

            #endregion

            #region Inventory Category Data Seed Start

            //InventoryCategory
            modelBuilder.Entity<InventoryCategory>().HasData(
                new InventoryCategory()
                {
                    invcate_id = 01,
                    cate_name = "Red Wine"
                }
            );
            
            modelBuilder.Entity<InventoryCategory>().HasData(
                new InventoryCategory()
                {
                    invcate_id = 02,
                    cate_name = "Bathroom Items"
                }
            );

            #endregion

            #region Inventory Request Data Seed Start 

            //InventoryRequest
            modelBuilder.Entity<InventoryRequest>().HasData(
                new InventoryRequest()
                {
                    invreq_id = 01,
                    inventory_id = 01,
                    quantity = 50,
                    status_id = 01,
                    price = 100,
                    remarks = "Inventory Request 01",
                    created_date = new DateTime(2022, 01, 25),
                    updated_date = new DateTime(2022, 01, 29)
                }
            );
            
            modelBuilder.Entity<InventoryRequest>().HasData(
                new InventoryRequest()
                {
                    invreq_id = 02,
                    inventory_id = 02,
                    quantity = 100,
                    status_id = 02,
                    price = 200,
                    remarks = "Inventory Request 02",
                    created_date = new DateTime(2022, 01, 26),
                    updated_date = new DateTime(2022, 01, 30)
                }
            );

            #endregion

            #region Facility Data Seed Start

            //Facility
            modelBuilder.Entity<Facility>().HasData(
                new Facility()
                {
                    facility_id = 01,
                    hotel_id = 01,
                    name = "Basketball Court",
                    status = "Available",
                    operation_start_time = DateTime.Now,
                    operation_end_time = DateTime.Now,
                }
            );
            
            modelBuilder.Entity<Facility>().HasData(
                new Facility()
                {
                    facility_id = 02,
                    hotel_id = 02,
                    name = "Tennis Court",
                    status = "Available",
                    operation_start_time = DateTime.Now,
                    operation_end_time = DateTime.Now
                }
            );

            #endregion

            #region FacilitBooking Data Seed Start

            //FacilityBooking
            modelBuilder.Entity<FacilityBooking>().HasData(
                new FacilityBooking()
                {
                    facilitybooking_id = 01,
                    facility_id = 01,
                    account_id = 01,
                    booking_start = DateTime.Now,
                    booking_end = DateTime.Now,
                }
            );
            
            modelBuilder.Entity<FacilityBooking>().HasData(
                new FacilityBooking()
                {
                    facilitybooking_id = 02,
                    facility_id = 02,
                    account_id = 02,
                    booking_start = DateTime.Now,
                    booking_end = DateTime.Now,
                }
            );

            #endregion

            #region Feedback Data Seed Start

            //Feedback
            modelBuilder.Entity<Feedback>().HasData(
                new Feedback()
                {
                    feedback_id = 01,
                    account_id = 01,
                    type = "General",
                    description = "Perfect dream hotel after a hard project",
                    created_at = DateTime.Now
                }
            );
            
            //Feedback
            modelBuilder.Entity<Feedback>().HasData(
                new Feedback()
                {
                    feedback_id = 02,
                    account_id = 02,
                    type = "General",
                    description = "Perfect dream hotel after a hard project",
                    created_at = DateTime.Now
                }
            );

            #endregion

            #region Requests Data Seed Start

            //Guest_Requests
            modelBuilder.Entity<GuestRequest>().HasData(
                new GuestRequest
                {
                    account_id = 01,
                    request_id = 01,
                    serviced_by = 01,
                    status = "In progress",
                    is_deleted = false,
                    created_at = DateTime.Now,
                    deleted_at = DateTime.Now,
                    serviced_at = DateTime.Now
                }
            );
            
            modelBuilder.Entity<GuestRequest>().HasData(
                new GuestRequest
                {
                    account_id = 02,
                    request_id = 02,
                    serviced_by = 02,
                    status = "In progress",
                    is_deleted = false,
                    created_at = DateTime.Now,
                    deleted_at = DateTime.Now,
                    serviced_at = DateTime.Now
                }
            );

            //Requests
            modelBuilder.Entity<Request>().HasData(
                new Request
                {
                    request_id = 01,
                    requesttype_id = 01,
                    request_msg = "2 towels"
                }
            );
            
            modelBuilder.Entity<Request>().HasData(
                new Request
                {
                    request_id = 02,
                    requesttype_id = 02,
                    request_msg = "2 Toilet Paper"
                }
            );

            //Request_type
            modelBuilder.Entity<RequestType>().HasData(
                new RequestType
                {
                    requesttype_id = 01,
                    type_value = "RoomService",
                    is_deleted = false,
                    created_at = DateTime.Now,
                    deleted_at = DateTime.Now
                }
            );
            
            modelBuilder.Entity<RequestType>().HasData(
                new RequestType
                {
                    requesttype_id = 02,
                    type_value = "Bathroom replenishment",
                    is_deleted = false,
                    created_at = DateTime.Now,
                    deleted_at = DateTime.Now
                }
            );

            #endregion
            
            #endregion
            
        }
    }
}