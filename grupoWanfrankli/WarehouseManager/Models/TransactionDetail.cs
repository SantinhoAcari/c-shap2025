using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("transaction_details")]
public class TransactionDetail
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("productId")]
    public int ProductId { get; set; }

    [ForeignKey("ProductId")]
    public Product Product { get; set; } = null!;

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("transactionId")]
    public int TransactionId { get; set; }

    [ForeignKey("TransactionId")]
    public Transaction Transaction { get; set; } = null!;
}