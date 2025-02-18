﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Graphics
{
    public static class Uris
    {
        public static Uri Messageboxbackground { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/messageboxbackground.png");

        public static Uri PoiishFlague { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/poland.png");
        public static Uri BritainFlague { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/Britain.png");

        public static Uri CheckConnectionToDBEnabled { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/CheckConnectionToDB.png");
        public static Uri CheckConnectionToDBDisabled { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/CheckConnectionToDBDisabled.png");

        public static Uri ShowDataIcon { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/showData.png");

        public static Uri SaveSettingsEnabled { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/SaveIconEnabled.png");
        public static Uri SaveSettingsDisabled { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/SaveIconDisabled.png");

        public static Uri AddEnabled { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/AddEnabled.png");
        public static Uri AddDisabled { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/AddDisabled.png");
    }
}
    