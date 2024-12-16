using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Security.PasswordBoxControlHelper
{
    public class ReadFromFileSecuredStringToString
    {
        public static string UnprotectString(string protectedBase64)
        {
            byte[] protectedBytes = Convert.FromBase64String(protectedBase64);

            byte[] plainBytes = ProtectedData.Unprotect(
                protectedBytes,
                null,
                DataProtectionScope.CurrentUser
            );

            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
