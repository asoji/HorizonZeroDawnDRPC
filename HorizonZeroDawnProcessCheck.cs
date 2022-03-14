using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using NetDiscordRpc.RPC;
using Newtonsoft.Json.Linq;

namespace HorizonZeroDawnDRPC {
    public partial class HorizonZeroDawnProcessCheck {
        public static void ProcessCheck() {
            for (int i = 0;; i--) {
                Process[] processes = Process.GetProcessesByName("HorizonZeroDawn");
                if (processes.Length > 0) {
                    DiscordRichPresence.DiscordRpc.UpdateDetails("Aloy is exploring!");
                    DiscordRichPresence.DiscordRpc.Logger.Info("Horizon Zero Dawn is Running!");
                    Thread.Sleep(1000);
                } else {
                    DiscordRichPresence.DiscordRpc.UpdateDetails("Game is not running!");
                    DiscordRichPresence.DiscordRpc.Logger.Warning("Horizon Zero Dawn is Not Running!");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}