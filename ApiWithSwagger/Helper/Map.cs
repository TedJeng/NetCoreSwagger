using Newtonsoft.Json;
using System.Collections.Generic;

namespace ApiWithSwagger.Helper
{
    public class Map
    {
        public string Serialize<T>(IEnumerable<T> datas)
        {
            return JsonConvert.SerializeObject(datas, Formatting.Indented,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
        }
    }
}
