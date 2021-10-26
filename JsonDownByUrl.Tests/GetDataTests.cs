using JsonDownlByUrl;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDownByUrl.Tests
{
    class GetDataTests
    {
        [Test]
        public void Wrong_Path_And_Good_URL_Should_Return_False()
        {
            var assert = false;

            var getData = new GetData("https://jsonplaceholder.typicode.com/posts/1", "nonexistingpath");
            getData.testData = CheckURLSyntax.checkAndTrim(getData.urls);

            var action = getData.gettingData();

            Assert.AreEqual(assert, action);
        }
        [Test]
        public void Wrong_URL_and_Wrong_Path_Should_Return_False()
        {
            var assert = false;

            var getData = new GetData("something22", "nonexistingpath");
            getData.testData = CheckURLSyntax.checkAndTrim(getData.urls);

            var action = getData.gettingData();

            Assert.AreEqual(assert, action);
        }
        [Test]
        public void Wrong_URL_And_Good_Path_Should_Return_False()
        {
            var assert = false;

            var getData = new GetData("something123", @"C:\Users\Adrian\Documents\DemoLibrary");
            getData.testData = CheckURLSyntax.checkAndTrim(getData.urls);

            var action = getData.gettingData();

            Assert.AreEqual(assert, action);
        }
        [Test]
        public void Good_URL_And_Good_Path_Should_Return_True()
        {
            var assert = true;

            var getData = new GetData("https://jsonplaceholder.typicode.com/posts/1", @"C:\Users\Adrian\Documents\DemoLibrary");
            getData.testData = CheckURLSyntax.checkAndTrim(getData.urls);

            var action = getData.gettingData();

            Assert.AreEqual(assert, action);
        }
    }
}
