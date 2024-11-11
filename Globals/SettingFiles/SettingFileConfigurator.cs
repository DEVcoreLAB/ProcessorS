using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Globals.SettingFiles.Base;

namespace Globals.SettingFiles
{
    public class SettingFileConfigurator
    {
        public IConfigureFile ConfigureFile { get;private set; }

        public SettingFileConfigurator(IConfigureFile configureFile)
        {
            ConfigureFile = configureFile;
        }
    }
}
