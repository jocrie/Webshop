using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Webshop.Enums;
using Webshop.Models;

namespace Webshop.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Product> Products { get; set; }

    // Seed product data
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1, Name = "Vintage Brick House",
                Description =
                    "Nestled in a quiet neighborhood, this historic brick house exudes character and potential. Built circa 1920, it has weathered the decades and now awaits a new chapter. The generous corner lot boasts mature trees and ample green space.\nCalling all DIY enthusiasts! If you’re passionate about restoration and have a vision for transforming neglected gems, this is your canvas. The house retains its original brick facade, showcasing timeless craftsmanship. Inside, the layout includes three bedrooms, a cozy living room, and a vintage kitchen. Expect to tackle electrical updates, plumbing repairs, and perhaps even structural adjustments. Bring your imagination—open up the floor plan, add a sunroom, or create a dreamy attic retreat.\nThe brickwork tells stories of bygone eras, waiting for your TLC. The living room fireplace could be a cozy focal point once restored. Imagine sipping coffee on the porch swing, watching the seasons change. With the right renovations, this house could become a sought-after gem.\nWhy choose this project? It’s not just about fixing up a house; it’s about preserving local history and breathing new life into a charming relic. Are you ready to write the next chapter for this vintage brick beauty? \ud83c\udfe1\ud83d\udcab",
                ShortDescription = "Your Canvas for Restoration and Timeless Transformation!",
                Price = 100000,
                Currency = Currencies.SEK,
                ImagePath = "./images/1.jpg",
                QuantityAvailable = 2,
                Sale = true
            },
            new Product
            {
                Id = 2, Name = "Baywatch Bliss",
                Description =
                    "Nestled along the sun-kissed shoreline, this charming beachfront cabin beckons with its vintage allure. Imagine the laid-back vibes of a classic Baywatch lifeguard station—where sun, surf, and adventure collide. Despite its compact size, this cabin holds big promises for those seeking coastal magic.\nThe cabin’s picture-perfect windows frame azure waters, allowing you to watch the tides ebb and flow. Every sunrise and sunset becomes a private show. Sip your favorite drink on the deck as the sun dips below the horizon—a daily spectacle that never loses its charm. Just steps away from the shore, kick off your shoes and feel the warm sand between your toes. The beach is your backyard, and the surfboard hooks outside are ready for those exhilarating wave rides.\nWhy choose this beach haven? Channel your inner Mitch Buchannon or CJ Parker—this cabin captures that iconic coastal allure. Let the rhythmic waves soothe your soul and wash away everyday worries. Pack your sunscreen, flip-flops, and a sense of adventure. This beachfront cabin is your ticket to sun-kissed days and starlit nights. \ud83c\udf34\ud83c\udf1f",
                ShortDescription = "Your Seaside Retreat Awaits!",
                Price = 1000000,
                Currency = Currencies.SEK,
                ImagePath = "./images/2.jpg",
                QuantityAvailable = 5,
                Sale = true
            },
            new Product
            {
                Id = 3,
                Name = "Enchanting Earth Dwelling",
                ShortDescription = "Where Magic Meets Reality",
                Description =
                    "Nestled into the gentle curve of an earth wall, this extraordinary house seems plucked straight from the pages of a fairytale. Its round windows, like curious eyes, peer out into the world, inviting wonder and imagination. The vibrant hues of red and orange dance across its walls, as if painted by mischievous forest sprites.\nBut it’s the grass-covered roof that truly captures the heart. A living carpet of green blankets the dwelling, seamlessly merging it with the surrounding landscape. Wildflowers peek through, adding bursts of color—a secret garden hidden in plain sight.\nStep inside, and you’ll find cozy nooks and crannies, each with its own story to tell. The walls breathe ancient tales, and the hearth crackles with warmth. Fairies might flit about, tending to their tiny abode, while the scent of moss and damp earth lingers in the air.\nComplete with tiny windows that only a fairy could look through, the fairy door and irresistible cottage house-top make this a truly magical experience—if you’ll only believe. Eclectic styles and colors add to the magic, as does the pebble pathway with multi-colored flowery stepping-stones.\nWhy choose this dwelling? Because here, reality and enchantment intertwine, and every day feels like a chapter from a timeless tale. \ud83c\udf3f\ud83c\udfe0\u2728",
                Price = 3000000,
                Currency = Currencies.SEK,
                ImagePath = "./images/3.jpg",
                QuantityAvailable = 1,
                Sale = true
            },
            new Product
            {
                Id = 4,
                Name = "Rustic Charm",
                Description =
                    "Nestled amidst the rolling countryside, this extraordinary home resides within the sturdy walls of an old windmill. Its brick exterior, weathered by time, tells tales of generations past. The circular structure, once a sentinel of the landscape, now cradles a cozy haven.\nStep through the heavy wooden door, and you’ll find yourself in a world where history and comfort intertwine. The original mill machinery—gears, cogs, and timeworn beams—stands as silent witnesses to centuries of grain-grinding labor. Sunlight filters through the round windows, casting warm patterns on the brickwork.\nThe living spaces are unconventional yet inviting. The kitchen, snug against the curved walls, boasts a hearth where meals are prepared with a touch of nostalgia. Ascend the winding staircase to the upper levels—the former milling floors—now transformed into bedrooms, each with its own nook and cranny. The views from the circular windows are nothing short of enchanting: rolling hills, swaying grass, and perhaps a distant farmhouse.\nOutside, the sails no longer turn with the wind, but the windmill’s spirit remains. The garden, bordered by ancient stones, blooms with wildflowers and herbs. A wooden bench invites contemplation, and the rustling leaves provide a soothing soundtrack.\nWhy choose this dwelling? Because it’s not just a house; it’s a living piece of history—a testament to resilience and adaptation. Here, the past whispers, and the present embraces. Are you ready to make your own mark within these sturdy brick walls? \ud83c\udf3e\ud83c\udfe0\u2728",
                ShortDescription = "Living Inside an Ancient Brick Windmill",
                Price = 1500000,
                Currency = Currencies.SEK,
                ImagePath = "./images/4.jpg",
                QuantityAvailable = 0,
                Sale = false
            },
            new Product
            {
                Id = 5,
                Name = "The Green Tent of Infinite Horizons",
                Description =
                    "Imagine a cozy green tent, just big enough for two souls seeking adventure. Its fabric whispers tales of distant lands, and its zippers hold the promise of secret passages. Set it up wherever your heart desires—on a mountain peak, by a tranquil lake, or beneath a star-studded sky.\nFlexibility is its superpower. Fold it into your backpack, and it becomes your portable sanctuary. Unfurl it on a windswept ridge, and suddenly, you’re perched on the edge of the world. The flaps, like curious eyelids, open to reveal breathtaking vistas—the kind that make your breath catch and your spirit soar.\nAt dawn, unzip the entrance and step out onto dew-kissed grass. The world awaits: mist-shrouded valleys, ancient forests, and sun-kissed meadows. Breakfast tastes better when cooked over a tiny stove, surrounded by nature’s grandeur. And as night falls, zip up snugly, cocooned in warmth, listening to the wind weave stories through the tent’s fabric.\nWhy choose this humble abode? Because it’s not just a tent; it’s an invitation to explore. Whether you’re atop a mountain, beside a roaring river, or deep in a mystical forest, this green haven adapts. It’s where dreams merge with reality, and the stars become your ceiling.\nSo pack light, wander far, and let the green tent carry you to magnificent places. Adventure awaits—inside and out. \ud83c\udf3f\ud83c\udfd5\ufe0f\u2728",
                ShortDescription = "Adventurer’s Oasis",
                Price = 5000,
                Currency = Currencies.SEK,
                ImagePath = "./images/5.jpg",
                QuantityAvailable = 2,
                Sale = false
            }
            );
    }
}
