using System;
using System.Diagnostics;
using System.Threading;

namespace HorizonZeroDawnDRPC {
    public class HorizonZeroDawnProcessCheck {
        public static void ProcessCheck() {
            for (var i = 0;; i--) {
                var processes = Process.GetProcessesByName("HorizonZeroDawn");
                switch (processes.Length) {
                    case 0: // Game is off
                        DiscordRichPresence.DiscordRpc.UpdateDetails("Game is not running!");
                        DiscordRichPresence.DiscordRpc.Logger.Warning("Horizon Zero Dawn is Not Running!");
                        Program.log.Warning("Horizon Zero Dawn is Not Running!");
                        Thread.Sleep(1000);
                        break;
                    case 1: // Game is on
                        DiscordRichPresence.DiscordRpc.UpdateDetails("Aloy is exploring!");
                        DiscordRichPresence.DiscordRpc.Logger.Info("Horizon Zero Dawn is Running!");
                        Program.log.Info("Horizon Zero Dawn is Running!");
                        Thread.Sleep(1000);
                        break;
                    default: // HOW. WHAT.
                        Console.Write("What the fuck did you do?");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}