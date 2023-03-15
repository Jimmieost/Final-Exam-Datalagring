using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerServiceSystem.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Cases_CaseEntityId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CaseEntityId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CaseEntityId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Cases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CustomerId",
                table: "Cases",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Customers_CustomerId",
                table: "Cases",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Customers_CustomerId",
                table: "Cases");

            migrationBuilder.DropIndex(
                name: "IX_Cases_CustomerId",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Cases");

            migrationBuilder.AddColumn<int>(
                name: "CaseEntityId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CaseEntityId",
                table: "Customers",
                column: "CaseEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Cases_CaseEntityId",
                table: "Customers",
                column: "CaseEntityId",
                principalTable: "Cases",
                principalColumn: "Id");
        }
    }
}
