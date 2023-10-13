using System;
using System.Collections.Generic;

namespace EF_DatabaseFirst.Models;

public partial class Admin
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Password { get; set; } = null!;
}
