using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFundi.Web.Migrations
{
    public partial class dbScritp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubscriptionDescritption",
                table: "MonthlySubscriptions");

            migrationBuilder.AddColumn<string>(
                name: "SubscriptionDescription",
                table: "MonthlySubscriptions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubscriptionDescription",
                table: "MonthlySubscriptions");

            migrationBuilder.AddColumn<string>(
                name: "SubscriptionDescritption",
                table: "MonthlySubscriptions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
