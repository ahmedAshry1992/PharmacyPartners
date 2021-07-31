using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyUI.Models.WebRequest.Response.Invoice
{
    public class EditSalesInvoiceResponse:ResponseBuilder
    {
        public InvoiceEdit data { get; set; }
    }

    public class InvoiceEdit
    {
        public int invoiceId { get; set; }
        public int id { get; set; }
    }
}
