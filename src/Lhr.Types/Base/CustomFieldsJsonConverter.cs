using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Lhr.Types.Base
{
    public class CustomFieldsJsonConverter : Newtonsoft.Json.JsonConverter
    {
        public override Boolean CanConvert(Type objectType)
        {
            return objectType == typeof(Base.EntityBase ); 
        }

        public override Object ReadJson(JsonReader reader, Type objectType, Object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, Object value, JsonSerializer serializer)
        {
            //writer.WriteStartObject();

            //List<LhrFieldValue> items = (List<LhrFieldValue>)value;
            //foreach(LhrFieldValue item in items)
            //{
            //    writer.WriteStartObject();
            //    writer.WritePropertyName(item.FieldName);
            //    serializer.Serialize(writer, item.Value);
            //    //writer.WriteValue(item.Value);
            //    writer.WriteEndObject();
            //    //writer.Flush();
            //}
            //writer.WriteEndObject();
            Base.EntityBase data = (Base.EntityBase)value;
            JObject jo = new JObject();

            foreach (LhrFieldValue item in data.AllFieldValues )
            {
                jo.Add(new JProperty(item.FieldName, item.Value));
            }
            jo.WriteTo(writer);
        }
    }
}
