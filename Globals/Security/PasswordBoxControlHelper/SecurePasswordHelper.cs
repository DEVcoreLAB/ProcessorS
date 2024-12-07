using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Globals.Security.PasswordBoxControlHelper
{
    public static class SecurePasswordHelper
    {
        public static readonly DependencyProperty SecurePasswordProperty =
            DependencyProperty.RegisterAttached(
                "SecurePassword",
                typeof(SecureString),
                typeof(SecurePasswordHelper),
                new FrameworkPropertyMetadata(
                    default(SecureString),
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    OnSecurePasswordChanged));

        public static SecureString GetSecurePassword(DependencyObject obj)
        {
            return (SecureString)obj.GetValue(SecurePasswordProperty);
        }

        public static void SetSecurePassword(DependencyObject obj, SecureString value)
        {
            obj.SetValue(SecurePasswordProperty, value);
        }

        private static void OnSecurePasswordChanged(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {

            if (d is PasswordBox passwordBox)
            {
                passwordBox.Loaded -= PasswordBox_Loaded;
                passwordBox.Loaded += PasswordBox_Loaded;
            }
        }

        private static void PasswordBox_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is PasswordBox passwordBox)
            {
                passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
                UpdatePasswordBox(passwordBox);
            }
        }

        private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (sender is PasswordBox passwordBox)
            {
                var secureString = new SecureString();
                foreach (var c in passwordBox.Password)
                {
                    secureString.AppendChar(c);
                }

                secureString.MakeReadOnly();

                SetSecurePassword(passwordBox, secureString);
            }
        }

        private static void UpdatePasswordBox(PasswordBox passwordBox)
        {
            passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;
            try
            {
                var secureString = GetSecurePassword(passwordBox) ?? new SecureString();

                string password = ConvertToUnsecureString.Convert(secureString);
                passwordBox.Password = password;
            }
            finally
            {
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
            }
        }

    }
}
