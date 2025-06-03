using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExampleTest2.Models;

[Table("Product_Order")]
[PrimaryKey(nameof(OrderId), nameof(ProductId))]
public class ProductOrder
{
    [ForeignKey(nameof(Order))]
    public int OrderId { get; set; }
    
    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }
    
    public Order Order { get; set; } = null!;

    public Product Product { get; set; } = null!;
    
    public int Amount { get; set; }

    
    
}