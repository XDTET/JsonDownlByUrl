using JsonDownlByUrl;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDownByUrl.Tests
{
    class CheckPathTests
    {
        [Test]
        public void Wrong_Path_Should_Return_False()
        {
            var result = false;

            var action = CheckPath.checkingPath("notapath");

            Assert.AreEqual(result, action);
        }
        [Test]
        public void Not_Existing_Path_Should_Return_False()
        {
            var result = false;

            var action = CheckPath.checkingPath(@"C:\Users\Adrian\Documents\DemoLibrary\NotaLibrary");

            Assert.AreEqual(result, action);
        }
        [Test]
        public void Existing_Path_Should_Return_True()
        {
            var result = true;

            var action = CheckPath.checkingPath(@"C:\Users\Adrian\Documents\DemoLibrary");

            Assert.AreEqual(result, action);
        }
    }
}
