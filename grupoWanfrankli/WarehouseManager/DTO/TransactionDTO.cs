public class TransactionDTO
{
    public int Id { get; set; }
    public string? Type { get; set; }
    public int ReceiverId { get; set; }
    public int Letter { get; set; }
    public string? Observation { get; set; }
    public DateTime Datetime { get; set; }
}