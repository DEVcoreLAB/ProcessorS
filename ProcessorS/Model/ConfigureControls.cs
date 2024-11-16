using Globals.MyControlsSchemas.Controls.MyButton;
using Globals.MyControlsSchemas;
using Globals.SettingFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProcessorS.Model
{
    internal class ConfigureControls
    {
        public ConfigureControls()
        {
            SetMyControls();
        }

        private void SetMyControls()
        {
            SetCustmControl setCustmControl = new SetCustmControl(new ButtonBasic());
            var buttonStyle = setCustmControl.setControl.SetControlProperties(SettingFontProperties.Default.FontSize);

            Application.Current.Resources.Remove(typeof(System.Windows.Controls.Button));
            Application.Current.Resources.Add(typeof(System.Windows.Controls.Button), buttonStyle);
        }
    }
}
