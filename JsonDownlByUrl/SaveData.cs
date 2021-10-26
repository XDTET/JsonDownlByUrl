using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDownlByUrl
{
    public class SaveData
    {
        GetData _data;
        public List<Task> tasks { get; set; } = new List<Task>();
        public SaveData(GetData data)
        {
            _data = data;
        }

        public  void ExampleAsync(string content, int i)
        {
            var task = Task.Run(() =>
            {
                File.AppendAllText(_data.path + '/' + i + ".txt", content);
            });
            tasks.Add(task);

        }
    }
}
