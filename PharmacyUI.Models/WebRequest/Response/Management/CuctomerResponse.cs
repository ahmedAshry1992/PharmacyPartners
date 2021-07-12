using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyUI.Models.WebRequest.Response.Management
{
    public class CuctomerResponse: ResponseBuilder
    {
        public List<Cuctomer> data { get; set; }
    }
    public class Cuctomer
    {
        public int id { get; set; }
        public string Name { set; get; }          
        public string phoneNumber { set; get; }
        public string address { set; get; }
        public int? points { set; get; }
        public int modifiedBy { get; set; }
        public int createdBy { get; set; }
    }
}
