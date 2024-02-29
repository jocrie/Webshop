using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webshop.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sale = table.Column<bool>(type: "bit", nullable: false),
                    QuantityAvailable = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Currency", "Description", "ImagePath", "Name", "Price", "QuantityAvailable", "Sale", "ShortDescription" },
                values: new object[] { 1, 0, "Nestled in a quiet neighborhood, this historic brick house exudes character and potential. Built circa 1920, it has weathered the decades and now awaits a new chapter. The generous corner lot boasts mature trees and ample green space.\nCalling all DIY enthusiasts! If you’re passionate about restoration and have a vision for transforming neglected gems, this is your canvas. The house retains its original brick facade, showcasing timeless craftsmanship. Inside, the layout includes three bedrooms, a cozy living room, and a vintage kitchen. Expect to tackle electrical updates, plumbing repairs, and perhaps even structural adjustments. Bring your imagination—open up the floor plan, add a sunroom, or create a dreamy attic retreat.\nThe brickwork tells stories of bygone eras, waiting for your TLC. The living room fireplace could be a cozy focal point once restored. Imagine sipping coffee on the porch swing, watching the seasons change. With the right renovations, this house could become a sought-after gem.\nWhy choose this project? It’s not just about fixing up a house; it’s about preserving local history and breathing new life into a charming relic. Are you ready to write the next chapter for this vintage brick beauty? 🏡💫", "./images/1.jpg", "Vintage Brick House", 100000.0, 2, true, "Your Canvas for Restoration and Timeless Transformation!" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
