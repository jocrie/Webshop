using Webshop.Enums;

namespace Webshop.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ShortDescription { get; set; }
    public double Price { get; set; }
    public Currencies Currency { get; set; }
    public string ImagePath { get; set; }
    public bool Sale { get; set; }
    public int QuantityAvailable { get; set; }
}