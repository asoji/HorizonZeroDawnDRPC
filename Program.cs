using System;
using EasyLog;

namespace HorizonZeroDawnDRPC {
    class Program {
        public static Logger log = new Logger();
        public static Config cfg = new Config();

        static void SetConfig() {
            cfg.Date = true;
            cfg.Console = true;
            cfg.ClearOnStart = true;
        }
        public static void Main(string[] args) {
            log.cfg = cfg;
            SetConfig();

            DiscordRichPresence.Setup();
            HorizonZeroDawnProcessCheck.ProcessCheck();
            Console.ReadKey(true);
        }
    }
}
