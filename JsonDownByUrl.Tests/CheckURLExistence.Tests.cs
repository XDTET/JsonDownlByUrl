using NUnit.Framework;
using JsonDownlByUrl;
using System.Linq;
using System.Collections.Generic;

namespace JsonDownByUrl.Tests
{
    public class CheckURLExistenceTests
    {

        [Test]
        public void Good_URL_Should_Return_Not_Empty_List()
        {
            List<string> resultList = new List<string>();
            resultList.Add("https://jsonplaceholder.typicode.com/posts");

            List<string> testList = new List<string>();
            testList.Add("https://jsonplaceholder.typicode.com/posts");
            var data = new GetData("","");
            var check = new CheckURLExistence(data);
            data.data = testList;
            var action = check.UrlIsValid();

            Assert.AreEqual(action, resultList);
        }

        [Test]
        public void Wrong_URL_Should_Return_Empty_List()
        {
            List<string> resultList = new List<string>();

            List<string> testList = new List<string>();
            testList.Add("https://notexistingwebsite.com");
            var data = new GetData("","");
            var check = new CheckURLExistence(data);
            data.data = testList;
            var action = check.UrlIsValid();

            Assert.AreEqual(action, resultList);
        }
       
    }
}