using System;
using System.Collections.Generic;

namespace CRUD_EF.Models;

public partial class Admin
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Password { get; set; } = null!;
}
