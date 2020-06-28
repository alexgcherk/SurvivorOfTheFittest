using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TestPing()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Format("http://localhost:7982/api/Server"));
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string jsonResponse = reader.ReadToEnd();
            Assert.AreEqual("Initialized",jsonResponse);          
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
