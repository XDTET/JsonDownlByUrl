using System;
using System.Linq;
using System.Threading.Tasks;

namespace JsonDownlByUrl
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter the URL's ");
            var urls = Console.ReadLine();

            Console.WriteLine("Enter the path ");
            var testPath = Console.ReadLine();

            GetData data = new GetData(urls, testPath);
            CheckURLExistence check = new CheckURLExistence(data);
            SaveData saveData = new SaveData(data);
            DownloadData downloadData = new DownloadData();

            var isDataRight = data.gettingData();
            if(isDataRight == true)
            {
                var isUrlRight = check.UrlIsValid();

                if (isUrlRight.Count > 0)
                {
                        for (int i = 0; i <= isUrlRight.Count - 1; i++)
                        {
                            var item = isUrlRight[i];
                            var stringToSave = await downloadData.downloadDataString(item);
                            saveData.ExampleAsync(stringToSave.ToString(), i);
                        }
                        await Task.WhenAll(saveData.tasks);
                }
                else
                {
                    Console.WriteLine("No valid URL's added.");
                }
            }
              
        }
    }
}
