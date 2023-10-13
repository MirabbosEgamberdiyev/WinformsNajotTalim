using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models;

public class Product : BaseModel
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [StringLength(1000)]
    public string Description { get; set; } = string.Empty;

    [Required]
    public decimal Price { get; set; }

    [Required]
    public int CategoryId { get; set; }



    public Category Category = new();
    public List<IncomeProduct> IncomeProducts = new();
}