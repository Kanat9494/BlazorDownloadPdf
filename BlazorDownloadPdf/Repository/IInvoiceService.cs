namespace BlazorDownloadPdf.Repository;

public interface IInvoiceService
{
    List<Invoice> GetInvoices();

    Invoice Save(Invoice invoice);

    Invoice UploadPdf(int invoiceId, byte[] pdf);

    void DeletePdf(int invoiceId);
}
