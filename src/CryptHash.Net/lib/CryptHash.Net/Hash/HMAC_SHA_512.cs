﻿/*
 *      Alessandro Cagliostro, 2019
 *      
 *      https://github.com/alecgn
 */

using CryptHash.Net.Hash.HashResults;
using CryptHash.Net.Hash.Base;

namespace CryptHash.Net.Hash
{
    public class HMAC_SHA_512 : HMACBase
    {
        /// <summary>
        /// Computes the HMACSHA512 of an input byte array using a 512 bit key.
        /// </summary>
        /// <param name="bytesToComputeHMAC">The input byte array to compute the HMACSHA512.</param>
        /// <param name="key">The 512 bit key byte array. Leave empty or pass null to auto-generate a secure random key. The key will be present in the HMACHashResult return.</param>
        /// <returns>HMACHashResult</returns>
        public HMACHashResult ComputeHMAC(byte[] bytesToComputeHMAC, byte[] key = null)
        {
            return base.ComputeHMAC(Enums.HMACAlgorithm.HMACSHA512, bytesToComputeHMAC, key);
        }

        /// <summary>
        /// Computes the HMACSHA512 of an input string using a 512 bit key.
        /// </summary>
        /// <param name="stringToComputeHMAC">The input string to compute the HMACSHA512.</param>
        /// <param name="key">The 512 bit key byte array. Leave empty or pass null to auto-generate a secure random key. The key will be present in the HMACHashResult return.</param>
        /// <returns>HMACHashResult</returns>
        public HMACHashResult ComputeHMAC(string stringToComputeHMAC, byte[] key = null)
        {
            return base.ComputeHMAC(Enums.HMACAlgorithm.HMACSHA512, stringToComputeHMAC, key);
        }

        /// <summary>
        /// Computes the HMACSHA512 of an input file using a 512 bit key.
        /// </summary>
        /// <param name="filePathToComputeHMAC">The input file path to compute the HMACSHA512.</param>
        /// <param name="key">The 512 bit key byte array. Leave empty or pass null to auto-generate a secure random key. The key will be present in the HMACHashResult return.</param>
        /// <returns>HMACHashResult</returns>
        public HMACHashResult ComputeFileHMAC(string filePathToComputeHMAC, byte[] key = null)
        {
            return base.ComputeFileHMAC(Enums.HMACAlgorithm.HMACSHA512, filePathToComputeHMAC, key);
        }

        /// <summary>
        /// Verifies the HMACSHA512 of an input byte array using a 512 bit key.
        /// </summary>
        /// <param name="hmacBytes">The pre-computed HMACSHA512 byte array.</param>
        /// <param name="bytesToVerifyHMAC">The input byte array to compute and verify the HMACSHA512.</param>
        /// <param name="key">The 512 bit key byte array.</param>
        /// <returns>HMACHashResult</returns>
        public HMACHashResult VerifyHMAC(byte[] hmacBytes, byte[] bytesToVerifyHMAC, byte[] key)
        {
            return base.VerifyHMAC(Enums.HMACAlgorithm.HMACSHA512, hmacBytes, bytesToVerifyHMAC, key);
        }

        /// <summary>
        /// Verifies the HMACSHA512 of an input string using a 512 bit key.
        /// </summary>
        /// <param name="hmacHexString">The pre-computed HMACSHA512 hexadecimal encoded string.</param>
        /// <param name="stringToVerifyHMAC">The input string to compute and verify the HMACSHA512.</param>
        /// <param name="key">The 512 bit key byte array.</param>
        /// <returns>HMACHashResult</returns>
        public HMACHashResult VerifyHMAC(string hmacHexString, string stringToVerifyHMAC, byte[] key)
        {
            return base.VerifyHMAC(Enums.HMACAlgorithm.HMACSHA512, hmacHexString, stringToVerifyHMAC, key);
        }

        /// <summary>
        /// Verifies the HMACSHA512 of an input file using a 512 bit key.
        /// </summary>
        /// <param name="hmacHexString">The pre-computed HMACSHA512 hexadecimal encoded string.</param>
        /// <param name="filePathToVerifyHMAC">The input file path to compute and verify the HMACSHA512.</param>
        /// <param name="key">The 512 bit key byte array.</param>
        /// <returns>HMACHashResult</returns>
        public HMACHashResult VerifyFileHMAC(string hmacHexString, string filePathToVerifyHMAC, byte[] key)
        {
            return base.VerifyFileHMAC(Enums.HMACAlgorithm.HMACSHA512, hmacHexString, filePathToVerifyHMAC, key);
        }

        /// <summary>
        /// Verifies the HMACSHA512 of an input file using a 512 bit key.
        /// </summary>
        /// <param name="hmacBytes">The pre-computed HMACSHA512 byte array.</param>
        /// <param name="filePathToVerifyHMAC">The input file path to compute and verify the HMACSHA512.</param>
        /// <param name="key">The 512 bit key byte array.</param>
        /// <returns>HMACHashResult</returns>
        public HMACHashResult VerifyFileHMAC(byte[] hmacBytes, string sourceFilePath, byte[] key)
        {
            return base.VerifyFileHMAC(Enums.HMACAlgorithm.HMACSHA512, hmacBytes, sourceFilePath, key);
        }
    }
}