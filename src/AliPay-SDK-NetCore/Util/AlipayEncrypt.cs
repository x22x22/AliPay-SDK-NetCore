﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace Aop.Api.Util
{
    internal class AlipayEncrypt
    {
        /// <summary>
        ///     128位0向量
        /// </summary>
        private static readonly byte[] AES_IV = initIv(16);

        /// <summary>
        ///     AES 加密
        /// </summary>
        /// <param name="encryptKey"></param>
        /// <param name="bizContent"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static string AesEncrypt(string encryptKey, string bizContent, string charset)
        {
            var keyArray = Convert.FromBase64String(encryptKey);
            byte[] toEncryptArray = null;

            if (string.IsNullOrEmpty(charset))
                toEncryptArray = Encoding.UTF8.GetBytes(bizContent);
            else
                toEncryptArray = Encoding.GetEncoding(charset).GetBytes(bizContent);
            //http://stackoverflow.com/questions/35912849/rijndael-in-class-library-package-not-available-for-dotnet5-4
            //https://zh.wikipedia.org/wiki/%E9%AB%98%E7%BA%A7%E5%8A%A0%E5%AF%86%E6%A0%87%E5%87%86
            //AES is Rijndael with a 16 byte block size set. If your data was encrypted with Rijndael with a 16 byte block size you can use AES to decrypt it.
            //严格地说，AES和Rijndael加密法并不完全一样（虽然在实际应用中两者可以互换），因为Rijndael加密法可以支持更大范围的区块和密钥长度：AES的区块长度固定为128比特，密钥长度则可以是128，192或256比特；而Rijndael使用的密钥和区块长度均可以是128，192或256比特。加密过程中使用的密钥是由Rijndael密钥生成方案产生。
            //System.Security.Cryptography.RijndaelManaged rDel = new System.Security.Cryptography.RijndaelManaged();
            var rDel = Aes.Create();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;
            rDel.IV = AES_IV;

            var cTransform = rDel.CreateEncryptor(rDel.Key, rDel.IV);
            var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray);
        }

        /// <summary>
        ///     AES解密
        /// </summary>
        /// <param name="encryptKey"></param>
        /// <param name="bizContent"></param>
        /// <param name="charset"></param>
        /// <returns></returns>
        public static string AesDencrypt(string encryptKey, string bizContent, string charset)
        {
            var keyArray = Convert.FromBase64String(encryptKey);
            var toEncryptArray = Convert.FromBase64String(bizContent);

            //http://stackoverflow.com/questions/35912849/rijndael-in-class-library-package-not-available-for-dotnet5-4
            //https://zh.wikipedia.org/wiki/%E9%AB%98%E7%BA%A7%E5%8A%A0%E5%AF%86%E6%A0%87%E5%87%86
            //AES is Rijndael with a 16 byte block size set. If your data was encrypted with Rijndael with a 16 byte block size you can use AES to decrypt it.
            //严格地说，AES和Rijndael加密法并不完全一样（虽然在实际应用中两者可以互换），因为Rijndael加密法可以支持更大范围的区块和密钥长度：AES的区块长度固定为128比特，密钥长度则可以是128，192或256比特；而Rijndael使用的密钥和区块长度均可以是128，192或256比特。加密过程中使用的密钥是由Rijndael密钥生成方案产生。
            //System.Security.Cryptography.RijndaelManaged rDel = new System.Security.Cryptography.RijndaelManaged();
            var rDel = Aes.Create();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.CBC;
            rDel.Padding = PaddingMode.PKCS7;
            rDel.IV = AES_IV;

            var cTransform = rDel.CreateDecryptor(rDel.Key, rDel.IV);
            var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            if (string.IsNullOrEmpty(charset))
                return Encoding.UTF8.GetString(resultArray);
            return Encoding.GetEncoding(charset).GetString(resultArray);
        }

        /// <summary>
        ///     初始化向量
        /// </summary>
        /// <param name="blockSize"></param>
        /// <returns></returns>
        private static byte[] initIv(int blockSize)
        {
            var iv = new byte[blockSize];
            for (var i = 0; i < blockSize; i++)
                iv[i] = 0x0;
            return iv;
        }
    }
}