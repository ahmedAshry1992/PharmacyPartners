using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PharmacyPartners.UI.Infrastructre.API
{
    public class ResponseBuilder
    {
        public static ResponseBuilder CreateResponseBilder(HttpStatusCode statusCode, object result = null, object error = null)
        {
            return new ResponseBuilder(statusCode, result, error);
        }

        public string version => "1.0.0";
        public int statusCode { get; set; }
        public string requestId { get; }
        public object error { get; set; }
        public object result { get; set; }
        public object success { get; set; }
        protected ResponseBuilder(HttpStatusCode statusCode, object result = null, object error = null)
        {
            this.requestId = Guid.NewGuid().ToString();
            this.statusCode = (int)statusCode;
            this.success = ((int)statusCode) == 200 ? true : false;
            this.result = result;
            this.error = error != null ? error : new string[] { };
        }
    }
}
