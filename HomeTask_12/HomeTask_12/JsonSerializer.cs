using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTask12;
using Newtonsoft.Json;

namespace HomeTask_12
{
    public class JsonSerializer
    {
        public string Serialize(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            return json;
        }

        public Hryvnia Deserialize(string json)
        {
            var deserializedHryvnia = JsonConvert.DeserializeObject<Hryvnia>(json);
            return deserializedHryvnia;
        }
    }
}
