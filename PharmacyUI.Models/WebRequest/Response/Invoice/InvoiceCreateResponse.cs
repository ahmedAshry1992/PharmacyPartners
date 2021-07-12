using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyUI.Models.WebRequest.Response.Invoice
{
    public class InvoiceCreateResponse:ResponseBuilder
    {
        public InvRes data { get; set; }
    }

    public class InvRes
    {
        public int id { get; set; }
        public DateTime createdDate { get; set; }
        public int userId { get; set; }
        public List<InvoiceSales> invoiceSales { get; set; }
        public float total { get; set; }
    }

    public class InvoiceSales
    {
        public string productName { get; set; }
        public int largeUnits { get; set; }
        public int smallUnits { get; set; }
        public float price { get; set; }
        public float discount { get; set; }
    }
}
