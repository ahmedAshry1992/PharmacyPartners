using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyUI.Models.WebRequest.Response.Invoice
{
    public class InvoiceStatusResponse
    {
        public InvoiceStatus data { get; set; }
    }
    public class InvoiceStatus
    {
        public int id { get; set; }
        public string status { get; set; }
    }
}
