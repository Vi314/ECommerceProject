﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Text;

namespace NetECommerce.Common
{
    public static class SessionHelper
    {
        //Set
        public static void SetSessionJson(this ISession _session, string _key, object _value) 
        {
            _session.SetString(_key, JsonConvert.SerializeObject(_value));
        }

        //Get
        public static T GetProductFromJson<T>(this ISession session, string key)
        {
            var result = session.GetString(key);

            if (result == null)
            {
                return default(T);
            }
            else
            {
                var deserialize = JsonConvert.DeserializeObject<T>(result);
                return deserialize;
            }
        }

    }
}
