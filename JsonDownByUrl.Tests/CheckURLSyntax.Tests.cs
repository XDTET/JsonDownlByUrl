using NUnit.Framework;
using JsonDownlByUrl;
using System.Linq;
using System.Collections.Generic;

namespace JsonDownByUrl.Tests
{
    public class CheckURLSyntaxTests
    {
        [Test]
        public void URL_with_wrong_sign_Should_Return_Empty_List()
        {
            List<string> resultList = new List<string>();

            var testString ="https://somewebsite.com,https://annotherwebsite.com";
            var action = CheckURLSyntax.checkAndTrim(testString);

            Assert.AreEqual(action, resultList);
        }
        [Test]
        public void One_URL_Should_Return__Not_Empty_List()
        {
            List<string> resultList = new List<string>();
            resultList.Add("https://somewebsite.com");

            var testString = "https://somewebsite.com";
            var action = CheckURLSyntax.checkAndTrim(testString);

            Assert.AreEqual(action, resultList);
        }
        [Test]
        public void Not_URL_Should_Return_Empty_List()
        {
            List<string> resultList = new List<string>();

            var testString = "something12";
            var action = CheckURLSyntax.checkAndTrim(testString);

            Assert.AreEqual(action, resultList);
        }
        [Test]
        public void Empty_Data_Should_Return_Empty_List()
        {
            List<string> resultList = new List<string>();

            var testString = "";
            var action = CheckURLSyntax.checkAndTrim(testString);

            Assert.AreEqual(action, resultList);
        }
        [Test]
        public void Good_Data_Should_Return_Not_Empty_List()
        {
            List<string> resultList = new List<string>();
            resultList.Add("https://somewebsite.com");
            resultList.Add("https://anotherwebsite.com");

            var testString = "https://somewebsite.com;https://anotherwebsite.com";

            var action = CheckURLSyntax.checkAndTrim(testString);

            Assert.AreEqual(action, resultList);
        }
    }
}