using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models;

public class Category : BaseModel
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    public List<Product> Products = new();
}