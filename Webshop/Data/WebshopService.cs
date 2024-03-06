using Microsoft.EntityFrameworkCore;
using Webshop.Models;

namespace Webshop.Data;

public class WebshopService
{
    private readonly ApplicationDbContext _context;

    public WebshopService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<ApplicationUser> GetUserCart(ApplicationUser user)
    {
        return _context.Users
            .Include(u => u.CartItems)
            .First(u => u.Id == user.Id);
    }
    
    public async Task<List<Product>> GetAllProducts()
    {
        // await Task.Delay(500);
        var productsTask = _context.Products.ToListAsync();
        var products = await productsTask;
        return products;
    }

    public async Task UpdateUser(ApplicationUser user)
    {
        _context.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> ProcessOrder(ICollection<CartItem> items)
    {
        bool allProcessed = true;
        
        var products = await GetAllProducts();
        foreach (var item in items)
        {
            var matching = products.FirstOrDefault(p => p.Id == item.ProductId);
            if (matching is null)
            {
                items.Remove(item);
            }
            else if (item.Quantity > matching.QuantityAvailable)
            {
                item.Quantity = matching.QuantityAvailable;
                if (matching.QuantityAvailable == 0)
                {
                    items.Remove(item);
                }
                allProcessed = false;
            }
            else
            {
                _context.Update(matching);
                matching.QuantityAvailable = matching.QuantityAvailable - item.Quantity;
            }
        }

        if (allProcessed is true)
        {
            await _context.SaveChangesAsync();
        }
        return allProcessed;
    }
}