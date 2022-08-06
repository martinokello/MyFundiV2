using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFundi.Web.Migrations
{
    public partial class renameSubsciptionName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubscriptonName",
                table: "MonthlySubscriptions");

            migrationBuilder.AddColumn<string>(
                name: "SubscriptionName",
                table: "MonthlySubscriptions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubscriptionName",
                table: "MonthlySubscriptions");

            migrationBuilder.AddColumn<string>(
                name: "SubscriptonName",
                table: "MonthlySubscriptions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
