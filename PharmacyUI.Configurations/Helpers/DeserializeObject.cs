using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyUI.Configurations.Helpers
{
    public class DeserializeObject
    {
        public static T Load<T>(string json)
        {
            object result = JsonConvert.DeserializeObject<T>(json);
            return (T)Convert.ChangeType(result,typeof(T));
        }
    }
}
