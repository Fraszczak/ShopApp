using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ShopApp.Extensions
{

    //It's not good practice to keep data on sever, but for this app its best way to create shop basket interface 
    public static class SessionExtensions
    {
        public static void SetObjectAsJason(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
