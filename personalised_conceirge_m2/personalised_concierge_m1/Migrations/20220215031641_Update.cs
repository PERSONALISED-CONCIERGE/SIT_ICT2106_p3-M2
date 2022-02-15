using System;
using Microsoft.EntityFrameworkCore.Migrations;
using personalised_concierge_m1.Models.Entities.OtherServices;

namespace personalised_concierge_m1.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "public",
                table: "Checklists",
                keyColumn: "checklist_id",
                keyValue: 2,
                column: "created_date",
                value: new DateTime(2022, 2, 15, 11, 16, 39, 852, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "Facilities",
                keyColumn: "facility_id",
                keyValue: 1,
                columns: new[] { "operation_end_time", "operation_start_time" },
                values: new object[] { new DateTime(2022, 2, 15, 11, 16, 39, 873, DateTimeKind.Local).AddTicks(3230), new DateTime(2022, 2, 15, 11, 16, 39, 873, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "Facilities",
                keyColumn: "facility_id",
                keyValue: 2,
                columns: new[] { "operation_end_time", "operation_start_time" },
                values: new object[] { new DateTime(2022, 2, 15, 11, 16, 39, 873, DateTimeKind.Local).AddTicks(4720), new DateTime(2022, 2, 15, 11, 16, 39, 873, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "FacilityBookings",
                keyColumn: "facilitybooking_id",
                keyValue: 1,
                columns: new[] { "booking_end", "booking_start" },
                values: new object[] { new DateTime(2022, 2, 15, 11, 16, 39, 873, DateTimeKind.Local).AddTicks(9370), new DateTime(2022, 2, 15, 11, 16, 39, 873, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "FacilityBookings",
                keyColumn: "facilitybooking_id",
                keyValue: 2,
                columns: new[] { "booking_end", "booking_start" },
                values: new object[] { new DateTime(2022, 2, 15, 11, 16, 39, 874, DateTimeKind.Local).AddTicks(840), new DateTime(2022, 2, 15, 11, 16, 39, 874, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "Feedbacks",
                keyColumn: "feedback_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2022, 2, 15, 11, 16, 39, 874, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "Feedbacks",
                keyColumn: "feedback_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2022, 2, 15, 11, 16, 39, 874, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "GuestRequests",
                keyColumns: new[] { "account_id", "request_id" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "created_at", "deleted_at", "serviced_at" },
                values: new object[] { new DateTime(2022, 2, 15, 11, 16, 39, 875, DateTimeKind.Local).AddTicks(2490), new DateTime(2022, 2, 15, 11, 16, 39, 875, DateTimeKind.Local).AddTicks(3240), new DateTime(2022, 2, 15, 11, 16, 39, 875, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "GuestRequests",
                keyColumns: new[] { "account_id", "request_id" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "created_at", "deleted_at", "serviced_at" },
                values: new object[] { new DateTime(2022, 2, 15, 11, 16, 39, 875, DateTimeKind.Local).AddTicks(5280), new DateTime(2022, 2, 15, 11, 16, 39, 875, DateTimeKind.Local).AddTicks(5350), new DateTime(2022, 2, 15, 11, 16, 39, 875, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "RequestTypes",
                keyColumn: "requesttype_id",
                keyValue: 1,
                columns: new[] { "created_at", "deleted_at" },
                values: new object[] { new DateTime(2022, 2, 15, 11, 16, 39, 876, DateTimeKind.Local).AddTicks(3440), new DateTime(2022, 2, 15, 11, 16, 39, 876, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "RequestTypes",
                keyColumn: "requesttype_id",
                keyValue: 2,
                columns: new[] { "created_at", "deleted_at" },
                values: new object[] { new DateTime(2022, 2, 15, 11, 16, 39, 876, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 2, 15, 11, 16, 39, 876, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.InsertData(
                schema: "public",
                table: "TransportFares",
                columns: new[] { "fare_id", "fare_name", "fares", "transport_id", "type" },
                values: new object[,]
                {
                    { 1, "Basic Fares", "$3.00", 1, TaxiType.Standard },
                    { 2, "Non-Basic Fares", "$10.00", 1, TaxiType.Standard }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "public",
                table: "TransportFares",
                keyColumn: "fare_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "TransportFares",
                keyColumn: "fare_id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                schema: "public",
                table: "Checklists",
                keyColumn: "checklist_id",
                keyValue: 2,
                column: "created_date",
                value: new DateTime(2022, 2, 14, 11, 32, 49, 16, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "Facilities",
                keyColumn: "facility_id",
                keyValue: 1,
                columns: new[] { "operation_end_time", "operation_start_time" },
                values: new object[] { new DateTime(2022, 2, 14, 11, 32, 49, 36, DateTimeKind.Local).AddTicks(1520), new DateTime(2022, 2, 14, 11, 32, 49, 36, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "Facilities",
                keyColumn: "facility_id",
                keyValue: 2,
                columns: new[] { "operation_end_time", "operation_start_time" },
                values: new object[] { new DateTime(2022, 2, 14, 11, 32, 49, 36, DateTimeKind.Local).AddTicks(2990), new DateTime(2022, 2, 14, 11, 32, 49, 36, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "FacilityBookings",
                keyColumn: "facilitybooking_id",
                keyValue: 1,
                columns: new[] { "booking_end", "booking_start" },
                values: new object[] { new DateTime(2022, 2, 14, 11, 32, 49, 36, DateTimeKind.Local).AddTicks(7600), new DateTime(2022, 2, 14, 11, 32, 49, 36, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "FacilityBookings",
                keyColumn: "facilitybooking_id",
                keyValue: 2,
                columns: new[] { "booking_end", "booking_start" },
                values: new object[] { new DateTime(2022, 2, 14, 11, 32, 49, 36, DateTimeKind.Local).AddTicks(9090), new DateTime(2022, 2, 14, 11, 32, 49, 36, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "Feedbacks",
                keyColumn: "feedback_id",
                keyValue: 1,
                column: "created_at",
                value: new DateTime(2022, 2, 14, 11, 32, 49, 37, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "Feedbacks",
                keyColumn: "feedback_id",
                keyValue: 2,
                column: "created_at",
                value: new DateTime(2022, 2, 14, 11, 32, 49, 37, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                schema: "public",
                table: "GuestRequests",
                keyColumns: new[] { "account_id", "request_id" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "created_at", "deleted_at", "serviced_at" },
                values: new object[] { new DateTime(2022, 2, 14, 11, 32, 49, 37, DateTimeKind.Local).AddTicks(9790), new DateTime(2022, 2, 14, 11, 32, 49, 38, DateTimeKind.Local).AddTicks(600), new DateTime(2022, 2, 14, 11, 32, 49, 38, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "GuestRequests",
                keyColumns: new[] { "account_id", "request_id" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "created_at", "deleted_at", "serviced_at" },
                values: new object[] { new DateTime(2022, 2, 14, 11, 32, 49, 38, DateTimeKind.Local).AddTicks(2690), new DateTime(2022, 2, 14, 11, 32, 49, 38, DateTimeKind.Local).AddTicks(2780), new DateTime(2022, 2, 14, 11, 32, 49, 38, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "RequestTypes",
                keyColumn: "requesttype_id",
                keyValue: 1,
                columns: new[] { "created_at", "deleted_at" },
                values: new object[] { new DateTime(2022, 2, 14, 11, 32, 49, 39, DateTimeKind.Local).AddTicks(1380), new DateTime(2022, 2, 14, 11, 32, 49, 39, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                schema: "public",
                table: "RequestTypes",
                keyColumn: "requesttype_id",
                keyValue: 2,
                columns: new[] { "created_at", "deleted_at" },
                values: new object[] { new DateTime(2022, 2, 14, 11, 32, 49, 39, DateTimeKind.Local).AddTicks(3550), new DateTime(2022, 2, 14, 11, 32, 49, 39, DateTimeKind.Local).AddTicks(3650) });
        }
    }
}
