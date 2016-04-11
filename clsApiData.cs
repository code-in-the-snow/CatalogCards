using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CatalogCards
{
    class clsApiData
    {
        public string id { get; set; }

        public Newtonsoft.Json.Linq.JObject GetAPIData()
        {
            string url_base = @"https://openlibrary.org/api/books?bibkeys=";
            string url_params = "&jscmd=data&format=json";

            WebClient client = new WebClient();
            Stream stream = client.OpenRead(url_base + this.id + url_params);
            StreamReader reader = new StreamReader(stream);

            Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(reader.ReadLine());
            stream.Close();
            return obj;
        }
    }
}
