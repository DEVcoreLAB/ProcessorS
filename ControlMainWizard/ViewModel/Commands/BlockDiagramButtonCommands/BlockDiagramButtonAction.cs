using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMainWizard.ViewModel.Commands.BlockDiagramButtonCommands
{
    internal class BlockDiagramButtonAction 
    {
        MainViewModel MainViewModel { get; }

        public BlockDiagramButtonAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Execute(object? parameter)
        { 
            if (MainViewModel.MainUserControlContent is not SubControlBlockDiagramProject.View.BlockDiagramControl)
            {
                MainViewModel.MainUserControlContent = new SubControlBlockDiagramProject.View.BlockDiagramControl();
            }
        }
    }
}
