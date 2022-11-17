namespace BlazorDownloadPdf.Data;

public class InvoiceContext : DbContext
{
    public InvoiceContext() { }

    public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options) { }

    public DbSet<Invoice> Invoices { get; set; }
}
