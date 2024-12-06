using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADocumentation.Projects.Globals.Graphics
{
    public class Uris
    {
        public static Uri Messageboxbackground { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/messageboxbackground.png");

        public static Uri PoiishFlague { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/poland.png");
        public static Uri BritainFlague { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/Britain.png");

        public static Uri CheckConnectionToDBEnabled { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/CheckConnectionToDB.png");
        public static Uri CheckConnectionToDBDisabled { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/CheckConnectionToDBDisabled.png");

        public static Uri ShowDataIcon { get; } = new Uri("pack://application:,,,/Globals;component/Graphics/GraphicFiles/showData.png");
    }
}
    