using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models;

public class IncomeProduct : BaseModel
{
    [Required]
    public int Quantity { get; set; }

    [Required]
    public decimal IncomingPrice { get; set; }

    [Required]
    public decimal OutcomingPrice { get; set; }

    [Required]
    public DateTime IncomingDate { get; set; }

    [Required]
    public int ProductId { get; set; }


    public Product Product = new();
}