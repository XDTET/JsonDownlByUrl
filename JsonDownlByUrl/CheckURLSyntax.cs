using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JsonDownlByUrl
{
    public static class CheckURLSyntax
    {
        public static List<string> checkAndTrim(string urls)
        {
            List<string> result = new List<string>();
            var data = urls.Trim().Split(';').ToList();
            foreach(var item in data)
            {
                if (Uri.IsWellFormedUriString(item, UriKind.Absolute) & !Regex.IsMatch(item, @"[('),|\!@#$%^&*_{}]"))
                {
                    result.Add(item);
                }
                else
                {
                    Console.WriteLine($"Wrong URL: {item}");
                }
            }
            return result; 
        }
    }
}
