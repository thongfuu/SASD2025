using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestaurantLogic.Models;

[Table("order_items")]
public partial class OrderItem
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("order_id")]
    public int OrderId { get; set; }

    [Column("item_id")]
    public int ItemId { get; set; }

    [Column("count")]
    public int Count { get; set; }

    [Column("is_printed")]
    public bool IsPrinted { get; set; }

    [Column("note")]
    [StringLength(200)]
    public string Note { get; set; } = null!;

    [ForeignKey("ItemId")]
    [InverseProperty("OrderItems")]
    public virtual Item Item { get; set; } = null!;

    [ForeignKey("OrderId")]
    [InverseProperty("OrderItems")]
    public virtual Order Order { get; set; } = null!;
}
