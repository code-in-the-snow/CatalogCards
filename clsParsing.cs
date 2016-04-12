using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogCards
{
    public class clsParsing
    {
        public Newtonsoft.Json.Linq.JObject data { get; set; }
        public string id { get; set; }

        public List<string> PullDictionaryData(Newtonsoft.Json.Linq.JObject obj, string detail, string root)
        {
            int i = 0;
            bool is_more = true;
            List<string> dataList = new List<string>();

            while ((is_more) && (i < 5))
            {
                try
                {
                    dataList.Add((string)obj[root][detail][i]["name"]); ;
                    i++;
                }

                catch (NullReferenceException)
                {
                    is_more = false;
                }

                catch (ArgumentOutOfRangeException)
                {
                    is_more = false;
                }
            }
            return dataList;
        }

        public string GetCallNumber(Newtonsoft.Json.Linq.JObject obj)
        {
            string temp = "";
            int i = 0;
            bool is_more = true;
            while (is_more)
                try
                {
                    temp += (string)obj[id]["classifications"]["dewey_decimal_class"][i];
                    i++;
                }
                catch (ArgumentOutOfRangeException)
                {
                    is_more = false;
                }
                catch (NullReferenceException)
                {
                    is_more = false;
                }
            return temp;
        }
    }
}
