using JsonDownlByUrl;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDownByUrl.Tests
{
    class SaveDataTest
    {
        [Test]
        public void When_Call_List_Gets_Higher()
        {
            int assert = 1;

            var getData = new GetData("", "");
            var saveData = new SaveData(getData);
            saveData.ExampleAsync("", 1);

            Assert.AreEqual(assert, saveData.tasks.Count());
        }
    }
}
