using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models;

public class Admin : BaseModel
{
    [Required]
    [StringLength(100)]
    public string FullName { get; set; } = string.Empty;

    [Required]
    [StringLength(15)]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Password { get; set; } = string.Empty;
}