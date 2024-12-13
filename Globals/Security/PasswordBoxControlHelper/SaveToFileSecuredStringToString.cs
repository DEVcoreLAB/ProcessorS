using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Security.PasswordBoxControlHelper
{
    public class SaveToFileSecuredStringToString
    {
       public static string Save(SecureString secureString)
       {
            return Marshal.PtrToStringBSTR(Marshal.SecureStringToBSTR(secureString));
       }
    }
}
