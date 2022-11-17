namespace BlazorDownloadPdf.Data;

public class Invoice
{
    [Key]
    public int InvoiceId { get; set; }
    public int Number { get; set; }
    public DateTime Date { get; set; }
    public decimal Value { get; set; }
    public byte[]? Attachment { get; set; }
}
