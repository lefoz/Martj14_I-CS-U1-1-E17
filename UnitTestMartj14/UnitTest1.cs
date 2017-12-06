using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMartj14
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ISerielNumberGenereter sg = new SerielNumberGenereter();
            Dictionary<string, bool> testDic = new Dictionary<string, bool>();
            testDic = sg.GenerateSerielNumberDictionary(100);
            foreach (var item in testDic)
            {
                Console.WriteLine(testDic.GetEnumerator());
                Console.ReadKey();
            }
        }

        public interface ISerielNumberGenereter
        {
        }
    }
}
