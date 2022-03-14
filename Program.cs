using System;

namespace HorizonZeroDawnDRPC {
    class Program {
        static void Main(string[] args) {
            DiscordRichPresence.Setup();
            HorizonZeroDawnProcessCheck.ProcessCheck();
            Console.ReadKey(true);
        }
    }
}
