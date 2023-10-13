using System;
using System.Collections.Generic;

namespace CRUD_EF.Models;

public partial class ProductIncome
{
    public int Id { get; set; }

    public int Quantity { get; set; }

    public decimal IncomingPrice { get; set; }

    public decimal OutcomingPrice { get; set; }

    public int ProductId { get; set; }

    public DateTime IncomingDate { get; set; }
}
