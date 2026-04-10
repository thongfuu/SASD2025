using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestaurantLogic.Models;

[Table("orders")]
public partial class Order
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("table_id")]
    public int TableId { get; set; }

    [Column("open_at", TypeName = "timestamp without time zone")]
    public DateTime OpenAt { get; set; }

    [Column("close_at", TypeName = "timestamp without time zone")]
    public DateTime? CloseAt { get; set; }

    [Column("total_amount", TypeName = "money")]
    public decimal? TotalAmount { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    [ForeignKey("TableId")]
    [InverseProperty("Orders")]
    public virtual Table Table { get; set; } = null!;
}
