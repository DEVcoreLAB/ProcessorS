using ADocumentation.Projects.Globals.Graphics;
using Globals.Model.Observer.Components;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowFirstStart.ViewModel;

namespace WindowFirstStart.Model.Reactors.Behaviours.PasswordSectionVM
{
    internal class PasswordBaseBehave : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;

            return new Action(() => 
            {
                if (mainViewModel.PasswordBase.Length >= 8)
                { 
                    mainViewModel.IsPasswordBoxConfirmEnabled = true;
                }
                else
                {
                    mainViewModel.IsPasswordBoxConfirmEnabled = false;
                }
            });
        }
    }
}
