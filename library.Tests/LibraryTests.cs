using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace library.Tests
{
    [TestClass]
    public class LibraryTests
    {
        static string password = "Testtestte2";


        [TestMethod]
        public void test()
        {
            bool result = false;
            

            foreach (char d in password)
            {
                if (password.Length > 8)
                    result = true;
            }
            bool expected = true;
            String c = new String();
            bool actual = c.First(result);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void another_test()
        {
            bool result = false;


            foreach (char d in password)
            {
                if (!Char.IsDigit(d))
                    result = true;
            }
            bool expected = true;
            String c = new String();
            bool actual = c.First(result);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void and_another_test()
        {
            bool result = false;


            foreach (char d in password)
            {
                if (Char.IsUpper(d))
                    result = true;
            }
            bool expected = true;
            String c = new String();
            bool actual = c.First(result);
            Assert.AreEqual(expected, actual);
        }
    }
}
