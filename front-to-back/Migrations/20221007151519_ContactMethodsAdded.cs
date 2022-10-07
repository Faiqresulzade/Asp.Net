using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace front_to_back.Migrations
{
    public partial class ContactMethodsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_catagoryCompenents_Catagories_CatagoryId",
                table: "catagoryCompenents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contactInfos",
                table: "contactInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_catagoryCompenents",
                table: "catagoryCompenents");

            migrationBuilder.RenameTable(
                name: "contactInfos",
                newName: "ContactInfos");

            migrationBuilder.RenameTable(
                name: "catagoryCompenents",
                newName: "CatagoryCompenents");

            migrationBuilder.RenameIndex(
                name: "IX_catagoryCompenents_CatagoryId",
                table: "CatagoryCompenents",
                newName: "IX_CatagoryCompenents_CatagoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactInfos",
                table: "ContactInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatagoryCompenents",
                table: "CatagoryCompenents",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ContactMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMethods", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CatagoryCompenents_Catagories_CatagoryId",
                table: "CatagoryCompenents",
                column: "CatagoryId",
                principalTable: "Catagories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatagoryCompenents_Catagories_CatagoryId",
                table: "CatagoryCompenents");

            migrationBuilder.DropTable(
                name: "ContactMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactInfos",
                table: "ContactInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatagoryCompenents",
                table: "CatagoryCompenents");

            migrationBuilder.RenameTable(
                name: "ContactInfos",
                newName: "contactInfos");

            migrationBuilder.RenameTable(
                name: "CatagoryCompenents",
                newName: "catagoryCompenents");

            migrationBuilder.RenameIndex(
                name: "IX_CatagoryCompenents_CatagoryId",
                table: "catagoryCompenents",
                newName: "IX_catagoryCompenents_CatagoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contactInfos",
                table: "contactInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_catagoryCompenents",
                table: "catagoryCompenents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_catagoryCompenents_Catagories_CatagoryId",
                table: "catagoryCompenents",
                column: "CatagoryId",
                principalTable: "Catagories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
