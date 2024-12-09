using ADocumentation.Projects.Globals.Graphics;
using Globals.Graphics;
using Globals.Model.Observer.Components;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WindowFirstStart.ViewModel;

namespace WindowFirstStart.Model.Reactors.Behaviours.ConnectionStringVM
{
    class ConnectionStringTextboxTextBehave : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;

            return new Action(() => 
            {

                if (!string.IsNullOrEmpty(mainViewModel.ConnectionStringTextboxText))
                {
                    mainViewModel.ConnStringButtonIsEnabled = true;
                    mainViewModel.ConnStrinngTextBoxForeground = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    mainViewModel.ConnStringButtonIsEnabled = false;
                }
                mainViewModel.CheckConnectioStringButtonBackground = SetProperButtonBackground.Set(mainViewModel.ConnStringButtonIsEnabled,Uris.CheckConnectionToDBEnabled,Uris.CheckConnectionToDBDisabled);
            });
        }
    }
}

