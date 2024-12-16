using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Security.PasswordBoxControlHelper
{
    public class SaveToFileStringToSecuredString
    {
       public static string ConvertString(string plainText)
       {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] protectedBytes = ProtectedData.Protect(
                plainBytes,
                null,
                DataProtectionScope.CurrentUser 
            );

            return Convert.ToBase64String(protectedBytes);
        }
    }
}
