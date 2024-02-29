using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Webshop.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Currency", "Description", "ImagePath", "Name", "Price", "QuantityAvailable", "Sale", "ShortDescription" },
                values: new object[,]
                {
                    { 2, 0, "Nestled along the sun-kissed shoreline, this charming beachfront cabin beckons with its vintage allure. Imagine the laid-back vibes of a classic Baywatch lifeguard station—where sun, surf, and adventure collide. Despite its compact size, this cabin holds big promises for those seeking coastal magic.\nThe cabin’s picture-perfect windows frame azure waters, allowing you to watch the tides ebb and flow. Every sunrise and sunset becomes a private show. Sip your favorite drink on the deck as the sun dips below the horizon—a daily spectacle that never loses its charm. Just steps away from the shore, kick off your shoes and feel the warm sand between your toes. The beach is your backyard, and the surfboard hooks outside are ready for those exhilarating wave rides.\nWhy choose this beach haven? Channel your inner Mitch Buchannon or CJ Parker—this cabin captures that iconic coastal allure. Let the rhythmic waves soothe your soul and wash away everyday worries. Pack your sunscreen, flip-flops, and a sense of adventure. This beachfront cabin is your ticket to sun-kissed days and starlit nights. 🌴🌟", "./images/2.jpg", "Baywatch Bliss", 1000000.0, 5, true, "Your Seaside Retreat Awaits!" },
                    { 3, 0, "Nestled into the gentle curve of an earth wall, this extraordinary house seems plucked straight from the pages of a fairytale. Its round windows, like curious eyes, peer out into the world, inviting wonder and imagination. The vibrant hues of red and orange dance across its walls, as if painted by mischievous forest sprites.\nBut it’s the grass-covered roof that truly captures the heart. A living carpet of green blankets the dwelling, seamlessly merging it with the surrounding landscape. Wildflowers peek through, adding bursts of color—a secret garden hidden in plain sight.\nStep inside, and you’ll find cozy nooks and crannies, each with its own story to tell. The walls breathe ancient tales, and the hearth crackles with warmth. Fairies might flit about, tending to their tiny abode, while the scent of moss and damp earth lingers in the air.\nComplete with tiny windows that only a fairy could look through, the fairy door and irresistible cottage house-top make this a truly magical experience—if you’ll only believe. Eclectic styles and colors add to the magic, as does the pebble pathway with multi-colored flowery stepping-stones.\nWhy choose this dwelling? Because here, reality and enchantment intertwine, and every day feels like a chapter from a timeless tale. 🌿🏠✨", "./images/3.jpg", "Enchanting Earth Dwelling", 3000000.0, 1, true, "Where Magic Meets Reality" },
                    { 4, 0, "Nestled amidst the rolling countryside, this extraordinary home resides within the sturdy walls of an old windmill. Its brick exterior, weathered by time, tells tales of generations past. The circular structure, once a sentinel of the landscape, now cradles a cozy haven.\nStep through the heavy wooden door, and you’ll find yourself in a world where history and comfort intertwine. The original mill machinery—gears, cogs, and timeworn beams—stands as silent witnesses to centuries of grain-grinding labor. Sunlight filters through the round windows, casting warm patterns on the brickwork.\nThe living spaces are unconventional yet inviting. The kitchen, snug against the curved walls, boasts a hearth where meals are prepared with a touch of nostalgia. Ascend the winding staircase to the upper levels—the former milling floors—now transformed into bedrooms, each with its own nook and cranny. The views from the circular windows are nothing short of enchanting: rolling hills, swaying grass, and perhaps a distant farmhouse.\nOutside, the sails no longer turn with the wind, but the windmill’s spirit remains. The garden, bordered by ancient stones, blooms with wildflowers and herbs. A wooden bench invites contemplation, and the rustling leaves provide a soothing soundtrack.\nWhy choose this dwelling? Because it’s not just a house; it’s a living piece of history—a testament to resilience and adaptation. Here, the past whispers, and the present embraces. Are you ready to make your own mark within these sturdy brick walls? 🌾🏠✨", "./images/4.jpg", "Rustic Charm", 1500000.0, 0, false, "Living Inside an Ancient Brick Windmill" },
                    { 5, 0, "Imagine a cozy green tent, just big enough for two souls seeking adventure. Its fabric whispers tales of distant lands, and its zippers hold the promise of secret passages. Set it up wherever your heart desires—on a mountain peak, by a tranquil lake, or beneath a star-studded sky.\nFlexibility is its superpower. Fold it into your backpack, and it becomes your portable sanctuary. Unfurl it on a windswept ridge, and suddenly, you’re perched on the edge of the world. The flaps, like curious eyelids, open to reveal breathtaking vistas—the kind that make your breath catch and your spirit soar.\nAt dawn, unzip the entrance and step out onto dew-kissed grass. The world awaits: mist-shrouded valleys, ancient forests, and sun-kissed meadows. Breakfast tastes better when cooked over a tiny stove, surrounded by nature’s grandeur. And as night falls, zip up snugly, cocooned in warmth, listening to the wind weave stories through the tent’s fabric.\nWhy choose this humble abode? Because it’s not just a tent; it’s an invitation to explore. Whether you’re atop a mountain, beside a roaring river, or deep in a mystical forest, this green haven adapts. It’s where dreams merge with reality, and the stars become your ceiling.\nSo pack light, wander far, and let the green tent carry you to magnificent places. Adventure awaits—inside and out. 🌿🏕️✨", "./images/5.jpg", "The Green Tent of Infinite Horizons", 5000.0, 2, false, "Adventurer’s Oasis" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
