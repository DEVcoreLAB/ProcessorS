using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Security.PasswordBoxControlHelper
{
    public class ConvertToUnsecureString
    {
        public static string Convert(SecureString secureString)
        {
            if (secureString == null)
            {
                return string.Empty;
            }

            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString =
                    System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(
                        secureString);

                return System.Runtime.InteropServices.Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocUnicode(
                    unmanagedString);
            }
        }
    }
}
