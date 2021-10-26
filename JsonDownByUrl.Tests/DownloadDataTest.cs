using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonDownlByUrl;

namespace JsonDownByUrl.Tests
{
    class DownloadDataTest
    {
        [Test]
        public async Task Got_Good_Data_Should_Return_String()
        {
            var assert = "{\n  \"userId\": 1,\n  \"id\": 1,\n  \"title\": \"sunt aut facere repellat provident occaecati excepturi optio reprehenderit\"," +
                "\n  \"body\": \"quia et suscipit\\nsuscipit recusandae consequuntur expedita et cum\\nreprehenderit molestiae ut ut quas" +
                " totam\\nnostrum rerum est autem sunt rem eveniet architecto\"\n}";

            var downloadData = new DownloadData();
            var action = await downloadData.downloadDataString("https://jsonplaceholder.typicode.com/posts/1");

            Assert.AreEqual(assert, action);
        }
    }
}
