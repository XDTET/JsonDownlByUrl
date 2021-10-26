using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JsonDownlByUrl
{
    public class DownloadData
    {
        HttpClient httpClient = new HttpClient();

        public async Task<string> downloadDataString(string url) => await httpClient.GetStringAsync(url);
    }
}
