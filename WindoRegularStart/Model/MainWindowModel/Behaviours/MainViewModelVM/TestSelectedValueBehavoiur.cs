using Globals.Model.Observer.Components;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowRegularStart.ViewModel.MainWindowViewModel;

namespace WindowRegularStart.Model.MainWindowModel.Behaviours.MainViewModelVM
{
    internal class TestSelectedValueBehavoiur : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
           MainViewModel mainViewModel = viewModel as MainViewModel;

            return new Action(() => 
            {
                if (mainViewModel.TestSelectedValue == 40)
                {
                    mainViewModel.TestSelectedValue = 10000;
                }
            });
        }
    }
}
