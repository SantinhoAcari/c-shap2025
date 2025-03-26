using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("transactions")]
public class Transaction
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("type")]
    public required string Type { get; set; }

    [Column("receiverId")]
    public int ReceiverId { get; set; }

    [ForeignKey("ReceiverId")]
    public Receiver Receiver { get; set; } = null!;

    [Column("letter")]
    public int? Letter { get; set; }

    [Column("observation")]
    public string? Observation { get; set; } = string.Empty;

    [Column("datetime")]
    public DateTime DateTime { get; set; } = DateTime.Now;

    public List<TransactionDetail> TransactionDetails { get; set; } = new();
}