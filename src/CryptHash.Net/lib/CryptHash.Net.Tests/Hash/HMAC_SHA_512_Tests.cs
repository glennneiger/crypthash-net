﻿using CryptHash.Net.Hash;
using CryptHash.Net.Hash.HashResults;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CryptHash.Net.Tests.Hash
{
    [TestClass]
    public class HMAC_SHA_512_Tests
    {
        HMAC_SHA_512 _hmacSha512 = new HMAC_SHA_512();
        string _testString = "This is a test string!";

        [TestMethod]
        public void ComputeAndVerifyHMAC_String()
        {
            HMACHashResult verifyResult = new HMACHashResult();
            var errorMessage = "";

            var hmacResult = _hmacSha512.ComputeHMAC(_testString);

            if (hmacResult.Success)
            {
                verifyResult = _hmacSha512.VerifyHMAC(hmacResult.HashString, _testString, hmacResult.Key);

                if (!verifyResult.Success)
                    errorMessage = verifyResult.Message;
            }
            else
                errorMessage = hmacResult.Message;


            Assert.IsTrue((hmacResult.Success && verifyResult.Success), errorMessage);
        }
    }
}
