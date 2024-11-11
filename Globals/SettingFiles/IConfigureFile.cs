using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.SettingFiles
{
    public interface IConfigureFile
    {
        public void Configure<T>(T settingFile, object value) where T : System.Configuration.ApplicationSettingsBase;
    }
}
