using NetDiscordRpc;
using NetDiscordRpc.Core.Logger;
using NetDiscordRpc.RPC;

namespace HorizonZeroDawnDRPC {
    public partial class DiscordRichPresence {
        public static DiscordRPC DiscordRpc;

        public static void Setup() {
            DiscordRpc = new DiscordRPC("952776705288835102");

            // DiscordRpc.Logger = new ConsoleLogger(); // uncomment if you want to see DRPC output too

            DiscordRpc.Initialize();
            
            DiscordRpc.SetPresence(new RichPresence() {
                Details = "Game is not running!",
                
                Buttons = new Button[] {
                    new() { Label = "Get Horizon Zero Dawn!", Url = "https://store.steampowered.com/app/1151640/Horizon_Zero_Dawn_Complete_Edition/" }
                }
            });

            DiscordRpc.Invoke();
        }
    }
}