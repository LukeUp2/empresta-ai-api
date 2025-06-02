using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace api.Services
{
    public class PasswordEncrypter
    {
        private readonly string _additionalKey;
        public PasswordEncrypter(string additionalKey)
        {
            _additionalKey = additionalKey;
        }

        public string Encrypt(string password)
        {
            var passwordWithAdditionalKey = $"{password}{_additionalKey}";

            var bytes = Encoding.UTF8.GetBytes(passwordWithAdditionalKey);
            var hashBytes = SHA512.HashData(bytes);

            return ConvertBytesToString(hashBytes);
        }

        private string ConvertBytesToString(byte[] bytes)
        {
            var stringBuilder = new StringBuilder();
            foreach (byte b in bytes)
            {
                stringBuilder.Append(b.ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}