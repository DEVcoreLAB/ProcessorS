using Globals.Model.Observer.Components;
using Globals.Security.PasswordBoxControlHelper;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WindowFirstStart.ViewModel;

namespace WindowFirstStart.Model.Reactors.Behaviours.PasswordSectionVM
{
    internal class PasswordConfirmBehave : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;

            return new Action(() => 
            {

                if ((mainViewModel.PasswordBase.Length == mainViewModel.PasswordConfirm.Length)
                    && mainViewModel.PasswordBase.Length >= 8 & mainViewModel.PasswordConfirm.Length >= 8)
                {
                    string passBase = ConvertToUnsecureString.Convert(mainViewModel.PasswordBase);
                    string passConfirm = ConvertToUnsecureString.Convert(mainViewModel.PasswordConfirm);

                    mainViewModel.PasswordBoxConfirmForeground = passBase.SequenceEqual(passConfirm) ?
                    new SolidColorBrush(Colors.Green) : new SolidColorBrush(Colors.Red);
                }
                else
                { 
                    mainViewModel.PasswordBoxConfirmForeground = new SolidColorBrush(Colors.Red);
                }
            });
        }
    }
}
