using Globals.Model.Observer.Components;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowFirstStart.ViewModel;

namespace WindowFirstStart.Model.Reactors.Behaviours.FontSizesVM
{
    internal class FontSizeSelectedValueBehave : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;

            return new Action(() =>
            {
                //if (mainViewModel.FontSizeSelectedValue == 18)
                //{
                //    mainViewModel.FontSizeSelectedValue = 12;
                //}
            });
        }
    }
}
