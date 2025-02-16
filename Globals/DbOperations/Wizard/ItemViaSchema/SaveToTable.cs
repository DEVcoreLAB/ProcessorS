using Globals.DbOperations.DbasesNames;
using Globals.Logger.Log4N;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Globals.DbOperations.Wizard.TableViaSchema
{
    public class SaveToTable
    {
        private Type _dataSchema;
        private object _dataObject;

        public SaveToTable(Type dataSchema, object dataObject)
        {
            _dataSchema = dataSchema;
            _dataObject = dataObject; 
        }

        public async Task Save(string connectionString, DbNames nameOfDataBase, string nameOfTable)
        {
            try
            {
               if (_dataSchema == null || _dataObject == null)
                {
                    await Application.Current.Dispatcher.InvokeAsync(() =>
                    {
                        MessageBox.Show($"Null input data exception in: {this.GetType().Name}", "Error",
                                        MessageBoxButton.OK, MessageBoxImage.Error);
                    });

                    L4N.L4NDefault.Error($"Null input data exception in: {this.GetType().Name}");
                    return;
                }

                StringBuilder stringBuilder = new StringBuilder();
                var propertyInfo = _dataSchema.GetProperties(); 

                foreach (var property in propertyInfo)
                {
                    object propertyValue = property.GetValue(_dataObject); 
                    if (propertyValue is ObservableCollection<string> collection)
                    {
                        stringBuilder.AppendLine($@"List: {property.Name}");
                        foreach (var item in collection)
                        {
                            await Task.Delay(1);
                            stringBuilder.AppendLine($@"      {item}");
                        }
                        stringBuilder.Append("\n");
                    }
                    else
                    {
                        stringBuilder.AppendLine($@"{property.Name}   {property.PropertyType}  {propertyValue}");
                    }
                }

                await Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    MessageBox.Show(stringBuilder.ToString(), "data to save info",
                                    MessageBoxButton.OK, MessageBoxImage.Information);
                });
            }
            catch (Exception ex)
            {
                await Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    MessageBox.Show($"Error while saving: {ex.Message}", "Error",
                                    MessageBoxButton.OK, MessageBoxImage.Error);
                });

                L4N.L4NDefault.Error($"error in: {ex}       {this.GetType().Name}");
            }
        }
    }
}
