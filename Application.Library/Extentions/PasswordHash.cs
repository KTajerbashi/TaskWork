using System;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLogic.Library.Extentions
{

    public static class PasswordHash
    {
        public static string EncodeServerName(string serverName)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(serverName));
        }

        public static string DecodeServerName(string encodedServername)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(encodedServername));
        }
    }
}
