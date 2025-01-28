using ControlMainWizard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

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

            SetButtonsBorderToBlack setButtonsBorderToBlack = new SetButtonsBorderToBlack();
            setButtonsBorderToBlack.Set(MainViewModel);

            MainViewModel.BlockDiagramButtonBorderBrush = new System.Windows.Media.SolidColorBrush(Colors.Orange);
        }
    }
}
