using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WindowFirstStart.Model.Reactors.Behaviours.SaveSettingsSectionVM
{
    internal class CheckSaveButtonStatus
    {
        public static bool Check(SolidColorBrush color, SecureString passwordBase, SecureString passwordConfirm) =>
            color.Color == Colors.Green && Globals.Security.PasswordBoxControlHelper.ConvertToUnsecureString.Convert(passwordBase)
            .SequenceEqual(Globals.Security.PasswordBoxControlHelper.ConvertToUnsecureString.Convert(passwordConfirm)) &&
            passwordBase.Length >= 8;
    }
}
