using System;
using System.Security.Cryptography;
using System.Text;

namespace FutBud.Services
{
    static class Encryption
    {

        static public string Encrypt(string str)
        {
            var data = Encoding.Unicode.GetBytes(str);
            byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encrypted);
        }

        static public string Decrypt(string str)
        {
            byte[] data = Convert.FromBase64String(str);
            byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            return Encoding.Unicode.GetString(decrypted);
        }
    }
}
