using PharmacyUI.Models.WebRequest.Request.Invoice;
using PharmacyUI.Models.WebRequest.Response;
using PharmacyUI.Models.WebRequest.Response.Invoice;
using PharmacyUI.Models.WebRequest.Response.Management;
using PharmacyUI.Models.WebRequest.Response.Sales;
using PharmacyUI.Models.WebRequest.Response.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyUI.DataProviders.IProviders
{
    public interface ISalesDataProvider
    {
        Task<SearchResponse> ProdctToSellSearchByCode(string request);
        Task<ProductResponse> ProdctSearchByName(string request);
        Task<InvoiceTypeResponse> InvoiceTypes();
        Task<CuctomerResponse> customerSearch(string request);
        Task<InvoiceCreateResponse> InvoiceCreate(EditSalesInvoiceRequest request);
        Task<EditSalesInvoiceResponse> InvoiceEdit(SalesInvoiceRequest request);
        Task<ResponseBuilder> DeleteInvoiceDet(int request);
    }
}
