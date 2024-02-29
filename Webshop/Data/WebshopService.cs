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

    // public async Task UpdateUser(ApplicationUser user)
    // {
    //     _context.Update(user);
    //     _context.SaveChanges();
    // }
    //
    // public async Task<ApplicationUser> GetUserItemsInfo(ApplicationUser user)
    // {
    //     return _context.Users.Include(u => u.Items).First(u => u.Id == user.Id);
    // }

    public async Task<List<Product>> GetAllProducts()
    {
        // await Task.Delay(500);
        var productsTask = _context.Products.ToListAsync();
        var products = await productsTask;
        return products;
    }
}