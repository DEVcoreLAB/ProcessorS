using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Security.PasswordBoxControlHelper
{
    public class ConvertToSecureString
    {
        public static SecureString Convert(string plainText)
        {
            if (plainText == null)
            {
                return null;
            }

            SecureString secure = new SecureString();

            foreach (char c in plainText)
            {
                secure.AppendChar(c);
            }

            secure.MakeReadOnly();

            return secure;
        }
    }
}
