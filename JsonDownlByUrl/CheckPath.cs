using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDownlByUrl
{
    public static class CheckPath
    {
        public static bool checkingPath(string path)
        {
                bool isValid = true;

                try
                {
                    isValid = Path.IsPathRooted(path);    
                    if(!Directory.Exists(path))
                    {
                        isValid = false;
                    }
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Wrong path");
                }

                return isValid;
            
        }
    }
}
