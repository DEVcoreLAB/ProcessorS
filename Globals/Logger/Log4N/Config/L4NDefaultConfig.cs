using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using log4net.Repository;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Logger.Log4N.Config
{
    internal class L4NDefaultConfig
    {
        public ILog Set(string pathToLoggerData)
        {
            ILoggerRepository repository = LogManager.CreateRepository("MyDefaultRepository");

            ConsoleAppender consoleAppender = new ConsoleAppender();
            consoleAppender.Layout = new PatternLayout("%date    [%thread]    %-5level    %class    %method     %logger - %message%newline");
            consoleAppender.Threshold = Level.Info;
            consoleAppender.ActivateOptions();

            RollingFileAppender fileAppender = new RollingFileAppender();
            fileAppender.File = $@"{pathToLoggerData}\Logger\{DateTime.UtcNow.ToShortDateString()}\log.txt";
            fileAppender.Layout = new PatternLayout("%date    [%thread]    %-5level    %class    %method     %logger - %message%newline");
            fileAppender.Threshold = Level.Info;
            fileAppender.RollingStyle = RollingFileAppender.RollingMode.Size;
            fileAppender.MaxSizeRollBackups = 5;
            fileAppender.MaximumFileSize = "10MB";
            fileAppender.StaticLogFileName = true;
            fileAppender.ActivateOptions();

            log4net.Repository.Hierarchy.Logger rootLogger = ((Hierarchy)repository).Root;

            rootLogger.AddAppender(consoleAppender);
            rootLogger.AddAppender(fileAppender);

            rootLogger.Level = Level.Info;

            BasicConfigurator.Configure(repository.GetAppenders());

            return LogManager.GetLogger("DefaultLogger");
        }
    }
}
