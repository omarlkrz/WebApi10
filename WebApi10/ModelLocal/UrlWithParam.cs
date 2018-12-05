using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventV2.ModelLocal
{
    public class UrlWithParam
    {
        public String Url { get; set; }
        public List<String> ListParam { get; set; }

        public UrlWithParam(string url, List<string> listParam)
        {
            Url = url;
            ListParam = listParam;
        }
        public UrlWithParam()
        {
          
        }
    }
}
