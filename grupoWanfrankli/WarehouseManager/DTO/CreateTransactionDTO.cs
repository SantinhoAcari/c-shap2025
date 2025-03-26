public class CreateTransactionDTO
{
    public string Type { get; set; } = string.Empty;
    public int ReceiverId { get; set; }
    public int Letter { get; set; }
    public string Observation { get; set; } = string.Empty;
}