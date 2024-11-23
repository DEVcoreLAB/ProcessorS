using Globals.Model.Observer.Components;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Model.Observer
{
    public class TObserver<T1, T2> where T1 : BaseViewModel where T2 : IReactor
    {
        public T1 _viewModel;
        public T2 _viewModelReact;
        public List<PropertyInfo> PropertyInfos = new List<PropertyInfo>();

        // Storing Previous Property Values
        private Dictionary<string, object> PreviousValues = new Dictionary<string, object>();

        /// <summary>
        /// ViewModel observer. T must inherit from BaseViewModel
        /// </summary>
        /// <param name="viewModel"></param>
        public TObserver(T1 viewModel, T2 viewModelReact)
        {
            _viewModel = viewModel;
            _viewModelReact = viewModelReact;

            InitializePropsTracking();
            _viewModel.PropertyChanged += _TviewModel_PropertyChanged;
        }


        // Method for Initializing Property Monitoring
        private void InitializePropsTracking()
        {
            foreach (PropertyInfo property in _viewModel.GetType().GetProperties())
            {
                PropertyInfos.Add(property);

                // We store the initial property value
                var initialValue = property.GetValue(_viewModel);
                PreviousValues[property.Name] = initialValue;
            }
        }

        // Called on Every Property Change in the ViewModel
        private void _TviewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            // We check if the property has changed
            ObserveViewModelChanges();
        }

        // Property Change Observer
        public void ObserveViewModelChanges()
        {
            foreach (PropertyInfo property in PropertyInfos)
            {
                // Retrieving the Current Property Value
                var currentValue = property.GetValue(_viewModel);

                // Checking if the value has changed
                if (!Equals(PreviousValues[property.Name], currentValue))
                {
                    // The value has changed, we react
                    _viewModelReact.ReactForChange<T1>(property, PreviousValues[property.Name], _viewModel);

                    // We update the stored value
                    PreviousValues[property.Name] = currentValue;
                }
            }
        }
    }
}
