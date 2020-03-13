using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainTickets.Api.Migrations
{
    public partial class UpdateTicketModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_User_LastEditorId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Tickets_TicketId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_LastEditorId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_TicketId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastEditorId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "StationFrom",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "StationTo",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TrainNumber",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddColumn<int>(
                name: "StationFromId",
                table: "Tickets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StationToId",
                table: "Tickets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrainId",
                table: "Tickets",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Station",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Station", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Train",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Train", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StationFromId",
                table: "Tickets",
                column: "StationFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StationToId",
                table: "Tickets",
                column: "StationToId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TrainId",
                table: "Tickets",
                column: "TrainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Station_StationFromId",
                table: "Tickets",
                column: "StationFromId",
                principalTable: "Station",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Station_StationToId",
                table: "Tickets",
                column: "StationToId",
                principalTable: "Station",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Train_TrainId",
                table: "Tickets",
                column: "TrainId",
                principalTable: "Train",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Station_StationFromId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Station_StationToId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Train_TrainId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Station");

            migrationBuilder.DropTable(
                name: "Train");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_StationFromId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_StationToId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_TrainId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StationFromId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "StationToId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TrainId",
                table: "Tickets");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddColumn<int>(
                name: "LastEditorId",
                table: "Tickets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StationFrom",
                table: "Tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StationTo",
                table: "Tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrainNumber",
                table: "Tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "User",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_LastEditorId",
                table: "Tickets",
                column: "LastEditorId");

            migrationBuilder.CreateIndex(
                name: "IX_User_TicketId",
                table: "User",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_User_LastEditorId",
                table: "Tickets",
                column: "LastEditorId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Tickets_TicketId",
                table: "User",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
