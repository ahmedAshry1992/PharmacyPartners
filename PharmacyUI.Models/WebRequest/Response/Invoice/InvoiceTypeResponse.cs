using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyUI.Models.WebRequest.Response.Invoice
{
    public class InvoiceTypeResponse: ResponseBuilder
    {
        public List<InvoiceType> data { get; set; }
    }

    public class InvoiceType
    {
        public int id { get; set; }
        public string type { get; set; }
    }

}
