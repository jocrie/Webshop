using System.ComponentModel.DataAnnotations;

namespace Webshop.Models;

public class DeliveryInfo
{
    [Required]
    //[StringLength(10, ErrorMessage = "First name is too long.")]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string StreetName { get; set; }
    [Required]
    public string StreetNumber { get; set; }
    [Required]
    public string PostalCode { get; set; }
    [Required]
    public string City { get; set; }
}