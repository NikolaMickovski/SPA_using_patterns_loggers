using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.Common.Interfaces;
using log4net;

namespace Registar.Common
{
    public static class Logging
    {
        /// <summary>
        /// Ja koristime bibliotekata log4net, a so doluprikazaniot red kod
        /// pravime logger za klasata Logging
        /// Toa znaci deka vo zapisot za logot, do nego ke stoi imeto na klasata
        /// kade se izvrsilo logiranjeto
        /// </summary>
        private static readonly ILog theLogger = LogManager.GetLogger(typeof(Logging));

        //Vo slednite nekolku metodi ke gi iskoristime metodite koi gi nudi log4net

        public static void LogError(string message, Exception e = null, params object[] formatParams)
        {
            //Error e metod na log4net bibliotekata za logiranje na greski
            theLogger.Error("This happened: " + message + " and this was the exception " + e.ToString());
        }

        public static void LogFatal(string message)
        {
            //Fatal e metod na log4net za logiranje na fatalni greski
            theLogger.Fatal("A fatal error occured " + message);
        }

        public static void LogWarn(string message)
        {
            theLogger.Warn("Warning: " + message);
        }

        public static void LogDebug(string message)
        {
            theLogger.Debug("Debugging: " + message);
        }

        public static void LogInfo(string message)
        {
            theLogger.Info("Informing you about: " + message);
        }
    }
}
