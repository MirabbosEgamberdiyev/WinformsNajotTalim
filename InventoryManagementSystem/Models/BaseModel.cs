using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models;

public class BaseModel
{
    [Key]
    [Required]
    public int Id { get; set; }
}