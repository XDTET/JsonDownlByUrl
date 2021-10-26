using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JsonDownlByUrl
{
    public class GetData
    {
       public List<string> data { get; set; } = new List<string>();
        public string path { get; set; }
        public string urls { get; set; }
        public string testPath { get; set; }
        public List<string> testData { get; set; } = new List<string>();

       public GetData(string _urls, string _testPath)
        {
            urls = _urls;
            testPath = _testPath;
        }
        public bool gettingData()
        {
            testData = CheckURLSyntax.checkAndTrim(urls);

           if (CheckPath.checkingPath(testPath) == true && testData.Count > 0)
            {
                path = testPath;
                data = testData;
                return true;
            }
            else
            {
                if(CheckPath.checkingPath(testPath) == false)
                {
                    Console.WriteLine("Wrong path");
                    return false;
                }
                return false;
            }

        }

    }
}
