using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataProtectionSample.Helper
{
    public class DataProtectionHelper
    {
        private readonly IDataProtectionProvider _dataProtectionProvider;

        public DataProtectionHelper(IDataProtectionProvider dataProtectionProvider)
        {
            _dataProtectionProvider = dataProtectionProvider;
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="textToEncrypt"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Encrypt(string textToEncrypt, string key)
        {
            return _dataProtectionProvider.CreateProtector(key).Protect(textToEncrypt);
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="cipherText"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Decrypt(string cipherText, string key)
        {
            return _dataProtectionProvider.CreateProtector(key).Unprotect(cipherText);
        }
    }
}
