using PharmacyUI.Configurations.Helpers;
using PharmacyUI.DataProviders.IProviders;
using PharmacyUI.Models.WebRequest.Request.Invoice;
using PharmacyUI.Models.WebRequest.Response.Invoice;
using PharmacyUI.Models.WebRequest.Response.Management;
using PharmacyUI.Models.WebRequest.Response.Sales;
using PharmacyUI.Models.WebRequest.Response.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyUI.DataProviders.Providers
{
    public class SalesDataProvider: ISalesDataProvider
    {
        public async Task<SearchResponse> ProdctToSellSearchByCode(string request)
        {
            return await APIInvoker.PostRequest<SearchResponse>(request, APIOrigin.ProdctToSellSearch());
        }

        public async Task<ProductResponse> ProdctSearchByName(string request)
        {
            return await APIInvoker.GetRequest<ProductResponse>( APIOrigin.ProdctSearch()+ "?filter="+ request);
        }

        public async Task<InvoiceTypeResponse> InvoiceTypes()
        {
            return await APIInvoker.GetRequest<InvoiceTypeResponse>(APIOrigin.InvoiceTypes());
        }

        public async Task<CuctomerResponse> customerSearch(string request)
        {
            return await APIInvoker.GetRequest<CuctomerResponse>(APIOrigin.customerSearch()+ "?request="+request);
        }

        public async Task<InvoiceCreateResponse> InvoiceCreate(SalesInvoiceRequest request)
        {
            return await APIInvoker.PostRequest<InvoiceCreateResponse>(request, APIOrigin.InvoiceCraete());
        }

        public async Task<EditSalesInvoiceResponse> InvoiceEdit(SalesInvoiceRequest request)
        {
            return await APIInvoker.PostRequest<EditSalesInvoiceResponse>(new EditSalesInvoiceRequest() { salesInvoiceRequest= request}, APIOrigin.InvoiceEdit());
        }
    }
}
