namespace BlazorDownloadPdf.Repository;

public class InvoiceService : IInvoiceService
{
    InvoiceContext _invoiceContext;

    public InvoiceService(InvoiceContext invoiceContext)
    {
        _invoiceContext = invoiceContext;
    }
    public void DeletePdf(int invoiceId)
    {
        _invoiceContext.Invoices.SingleOrDefault(x => x.InvoiceId == invoiceId).Attachment = null;
        _invoiceContext.SaveChanges();
    }

    public List<Invoice> GetInvoices()
    {
        return _invoiceContext.Invoices.ToList();
    }

    public Invoice Save(Invoice invoice)
    {
        _invoiceContext.Invoices.Add(invoice);
        _invoiceContext.SaveChanges();
        return invoice;
    }

    public Invoice UploadPdf(int invoiceId, byte[] pdf)
    {
        _invoiceContext.Invoices.SingleOrDefault(x => x.InvoiceId == invoiceId).Attachment = pdf;
        _invoiceContext.SaveChanges();
        return _invoiceContext.Invoices.SingleOrDefault(x => x.InvoiceId == invoiceId);
    }
}
