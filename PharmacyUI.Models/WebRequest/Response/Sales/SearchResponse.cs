using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PharmacyUI.Models.WebRequest.Response.Sales
{
    public class SearchResponse: ResponseBuilder
    {
        public List<Search> data { get; set; }
    }

    public class Search
    {
        public string name { get; set; }
        public float price { get; set; }
        public int code { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy/MM/dd}")]
        public DateTime expiry { get; set; }
        public int items { get; set; }
        public int defualtItems { get; set; }
    }
}
