using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    National_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    Room_Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Room_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Room_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Room_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Free = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price_In_Day = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.Room_Number);
                });

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    Reser_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Id = table.Column<int>(type: "int", nullable: false),
                    Room_Number = table.Column<int>(type: "int", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Out = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pay_Up = table.Column<double>(type: "float", nullable: false),
                    Pay_Down = table.Column<double>(type: "float", nullable: false),
                    Total_Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.Reser_Id);
                    table.ForeignKey(
                        name: "FK_reservations_clients_Client_Id",
                        column: x => x.Client_Id,
                        principalTable: "clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservations_rooms_Room_Number",
                        column: x => x.Room_Number,
                        principalTable: "rooms",
                        principalColumn: "Room_Number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_reservations_Client_Id",
                table: "reservations",
                column: "Client_Id");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_Room_Number",
                table: "reservations",
                column: "Room_Number");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "rooms");
        }
    }
}
