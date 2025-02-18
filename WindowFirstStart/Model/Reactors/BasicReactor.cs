﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Globals.Model.Observer;
using Globals.Model.Observer.Components;
using Globals.ViewModel;
using WindowFirstStart.Model.Reactors.Behaviours.ConnectionStringVM;
using WindowFirstStart.Model.Reactors.Behaviours.FontSizesVM;
using WindowFirstStart.Model.Reactors.Behaviours.HelpControlMouseEnter;
using WindowFirstStart.Model.Reactors.Behaviours.LanguageSelectVM;
using WindowFirstStart.Model.Reactors.Behaviours.PasswordSectionVM;
using WindowFirstStart.ViewModel;

namespace WindowFirstStart.Model.Reactors
{
    internal class BasicReactor : IReactor
    {
        public void ReactForChange<T>(PropertyInfo newValue, object odlValue, T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;
            Connector connector = null;

            if (newValue.Name == nameof(mainViewModel.FontSizeSelectedValue))
            {
                connector = new Connector(new FontSizeSelectedValueBehave());
            }
            if (newValue.Name == nameof(mainViewModel.SelectedLanguage))
            {
                connector = new Connector(new LanguageChangedBehave());
            }
            if (newValue.Name == nameof(mainViewModel.ConnectionStringTextboxText))
            {
                connector = new Connector(new ConnectionStringTextboxTextBehave());
            }
            if (newValue.Name == nameof(mainViewModel.PasswordBase))
            {
                connector = new Connector(new PasswordBaseBehave());
            }
            if (newValue.Name == nameof(mainViewModel.PasswordConfirm))
            {
                connector = new Connector(new PasswordConfirmBehave());
            }
            if (newValue.Name == nameof(mainViewModel.ControlName))
            {
                connector = new Connector(new ControlNameBehave());
            }

            if (connector != null)
            {
                InvokeActionByDispatcher(connector.Behaviour.GetAction(mainViewModel));
            }
        }

        public void InvokeActionByDispatcher(Action action)
        {
            Dispatcher.CurrentDispatcher.BeginInvoke(action, DispatcherPriority.Background);
        }
    }
}
