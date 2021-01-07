using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using  Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CustomerPublication.Services
{
    public class PublicationService : IPublicationService
    {
        public Result<string> SavePublication(IEnumerable<Publication> publications)
        {
            
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using StreamWriter sw = new StreamWriter(@"C:\Test\test.txt");
            using JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, publications);
            
            return new Result<string>(){Message = "Successful"};
        }
    }

}
