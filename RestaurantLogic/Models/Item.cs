using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestaurantLogic.Models;

[Table("items")]
public partial class Item
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(100)]
    public string Name { get; set; } = null!;

    [Column("price", TypeName = "money")]
    public decimal Price { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
