using System;
using System.Collections;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace B3.Infrastructure.PagedList.JsonConverter
{
    public class PagedListJsonConverter : Newtonsoft.Json.JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var items = ((IEnumerable)value).Cast<object>().Select(x => x).ToArray();
            var jValue = JArray.FromObject(items, serializer);

            var jsonJObject = new JObject { { "Items", jValue } };

            var properties = typeof (IPagedList).GetProperties();
        
            foreach (var property in properties)
                jsonJObject.Add(property.Name, new JValue(property.GetValue(value)));

            jsonJObject.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return (typeof(IPagedList).IsAssignableFrom(objectType));
        }
    }
}