﻿using SubControlSupplierProject.Langs;
using SubControlSupplierProject.View.NewSchemaUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl.Command.AddNewItem
{
    internal class AddNewItemButtonAction
    {
        NewSchemaMainViewModel newSchemaMainViewModel;

        public AddNewItemButtonAction(NewSchemaMainViewModel newSchemaMainViewModel)
        {
            this.newSchemaMainViewModel = newSchemaMainViewModel;
        }

        public void Execute(object? parameter)
        {
            NewSchemaControl newSchemaControl = parameter as NewSchemaControl;

            RowDefinition rowDefinition = new RowDefinition();
            rowDefinition.Height = new GridLength(1, GridUnitType.Auto);
            newSchemaControl.GridForItems.RowDefinitions.Add(rowDefinition);
            Grid itemGrid = AddToControl(newSchemaMainViewModel.NameOfNewItem, newSchemaMainViewModel.SelectedTypeOfNewItem);
            Grid.SetRow(itemGrid, newSchemaControl.GridForItems.RowDefinitions.Count - 1);
            newSchemaControl.GridForItems.Children.Add(itemGrid);

            AddToDictionary(newSchemaMainViewModel.NameOfNewItem, newSchemaMainViewModel.SelectedTypeOfNewItem);

            newSchemaMainViewModel.SelectedTypeOfNewItem = null;
            newSchemaMainViewModel.NameOfNewItem = null;
        }

        public void AddToDictionary(string itemName, string itemType)
        {
            if (itemType == Langs.Lang.textBox)
            {
                newSchemaMainViewModel.ItemsToSaveDictionary.Add
                    (
                    itemName, 
                    Globals.DbOperations.InvariantTypeOfControls.ControlTypes.TextBoxControl.ToString()
                    );
            }
            else if (itemType == Langs.Lang.comboBox)
            {
                newSchemaMainViewModel.ItemsToSaveDictionary.Add
                    (
                    itemName,
                    Globals.DbOperations.InvariantTypeOfControls.ControlTypes.ComboBoxControl.ToString()
                    );
            }
            else if (itemType == Langs.Lang.checkBox)
            {
                newSchemaMainViewModel.ItemsToSaveDictionary.Add
                    (
                    itemName,
                    Globals.DbOperations.InvariantTypeOfControls.ControlTypes.CheckBoxControl.ToString()
                    );
            }
 
        }

        public Grid AddToControl(string itemName, string itemType)
        {
            Grid itemGrid = new Grid();
            ColumnDefinition nameColumnDefinition = new ColumnDefinition();
            nameColumnDefinition.Width = new GridLength(1, GridUnitType.Star);
            ColumnDefinition typeColumnDefinition = new ColumnDefinition();
            typeColumnDefinition.Width = new GridLength(1, GridUnitType.Star);
            itemGrid.ColumnDefinitions.Add(nameColumnDefinition);
            itemGrid.ColumnDefinitions.Add(typeColumnDefinition);



            TextBlock nameTextBlock = new TextBlock();
            nameTextBlock.Text = itemName;
            nameTextBlock.HorizontalAlignment = HorizontalAlignment.Left;
            nameTextBlock.VerticalAlignment = VerticalAlignment.Center;
            nameTextBlock.TextWrapping = TextWrapping.Wrap;
            nameTextBlock.Margin = new Thickness(5, 0, 5, 0);
            nameTextBlock.FontSize = Globals.SettingFiles.SettingFontProperties.Default.FontSize;
            Grid.SetColumn(nameTextBlock, 0);
            itemGrid.Children.Add(nameTextBlock);

            if (itemType == Langs.Lang.textBox)
            {
                TextBox textBox = new TextBox();
                textBox.VerticalAlignment = VerticalAlignment.Center;
                textBox.IsEnabled = false;
                Grid.SetColumn(textBox, 1);
                itemGrid.Children.Add(textBox);
            }
            else if (itemType == Langs.Lang.comboBox)
            {
                ComboBox comboBox = new ComboBox();
                comboBox.VerticalAlignment = VerticalAlignment.Center;
                comboBox.IsEnabled = false;
                Grid.SetColumn(comboBox, 1);
                itemGrid.Children.Add(comboBox);
            }
            else if (itemType == Langs.Lang.checkBox)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.VerticalContentAlignment = VerticalAlignment.Center;
                checkBox.IsEnabled = false;
                Grid.SetColumn(checkBox, 1);
                itemGrid.Children.Add(checkBox);

            }

            return itemGrid;
        }
    }
}
