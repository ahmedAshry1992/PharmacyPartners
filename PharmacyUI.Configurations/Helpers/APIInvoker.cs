using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyUI.Configurations.Helpers
{
    public class APIInvoker
    {
        public static async Task<T> GetRequest<T>(string url)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.RequestFormat=DataFormat.Json;
            //if (!string.IsNullOrEmpty(token)) , string token
            //    request.AddHeader("authorization", "Bearer " + token);
            IRestResponse response = await client.ExecuteAsync(request);
            return DeserializeObject.Load<T>(response.Content);
        }

        public static async Task<T> PostRequest<T>(Object model, string url)
        {
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(model), ParameterType.RequestBody);
            //if (!string.IsNullOrEmpty(token))
            //    request.AddHeader("authorization", "Bearer " + token);, string token
            IRestResponse response = await client.ExecuteAsync(request);
            return DeserializeObject.Load<T>(response.Content);
        }
    }
}
