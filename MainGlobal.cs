using System.Collections.Generic;

using Discord.WebSocket;

namespace RoboSinc
{
    internal static class MainGlobal
    {
        internal static SocketGuild Server { get; set; }
        internal static DiscordSocketClient Client { get; set; }
        
        internal static int ClientHash { get; set; }
        
        internal static string conS = "BOT_TOKEN_HERE";
    }
}
