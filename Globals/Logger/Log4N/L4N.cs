using Globals.Logger.Log4N.Config;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Logger.Log4N
{
    public static class L4N
    {
        public static ILog? L4NDefault { get; private set; }

        static L4N()
        {
            L4NDefault = new L4NDefaultConfig().Set(SettingFiles.SettingFilePath.Default.SystemPath);
        }
    }
}
