using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyUI.Models.WebRequest.Response
{
    public class ResponseBuilder
    {
        public string requestId { get; }

        public string[] error { get; set; }

        public bool success { get; set; }
    }
}
