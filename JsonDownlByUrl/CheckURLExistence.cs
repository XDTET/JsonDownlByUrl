using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JsonDownlByUrl
{
    public class CheckURLExistence
    {
        GetData _urldata;

        public CheckURLExistence( GetData urldata)
        {
            _urldata = urldata;
        }
        public List<string> UrlIsValid()
        {
            List<string> validUrls = new List<string>();
            foreach (var url in _urldata.data)
            {
                    try
                    {
                        HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
                        request.Timeout = 2000; //set the timeout to 5 seconds to keep the user from waiting too long for the page to load
                        request.Method = "HEAD"; //Get only the header information -- no need to download any content

                        using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                        {
                            int statusCode = (int)response.StatusCode;
                            if (statusCode >= 100 && statusCode < 400) //Good requests
                            {
                                validUrls.Add(url);
                            }
                            else if (statusCode >= 500 && statusCode <= 510) //Server Errors
                            {
                                Console.WriteLine(($"The remote server has thrown an internal error. Url is not valid: {url}"));
                            }
                        }
                    }
                    catch (WebException ex)
                    {
                        if (ex.Status == WebExceptionStatus.ProtocolError) //400 errors
                        {
                            Console.WriteLine(($"Status [{ex.Status}] returned for url: {url}"), ex);
                        }
                        else
                        {
                            Console.WriteLine(($"Status [{ex.Status}] returned for url: {url}"), ex);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(($"Could not test url {url}."), ex);
                    }
            }
            return validUrls;
        }
    }
}
