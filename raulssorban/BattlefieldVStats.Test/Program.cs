using BattlefieldV;
using BattlefieldV.Components;
using Humanlights.Components;
using Humanlights.Extensions;
using System;
using System.Linq;

namespace BattlefieldVStats.Test
{
    class Program
    {
        static void Main ( string [] args )
        {
            var handle = "TaveracoTTV";
            var platform = User.Platforms.Origin;

            Console.WriteLine ( $"> API" );
            TestAPI ( handle, platform );

            Console.WriteLine ( $"> User" );
            TestUser ( handle, platform );

            Console.ReadLine ();
        }

        static void TestAPI ( string handle, User.Platforms platform = User.Platforms.Origin )
        {
            var api = API.Fetch ( handle, platform );

            Console.WriteLine ( $"Headshots: {api.OverviewStats.Headshots.Percentile}%" );
            Console.WriteLine ( $"Kills: {api.OverviewStats.Kills.DisplayValue}" );
            Console.WriteLine ( $"Wins (Conquest GM): {api.GameModeStats.ConquestStats.Wins.DisplayValue}" );
            Console.WriteLine ( $"Losses (Breakthrough GM): {api.GameModeStats.BreakthroughStats.Losses.DisplayValue}" );
            Console.WriteLine ( $"Support KD-Ratio: {api.ClassStats.SupportStats.KDRatio.DisplayValue}" );
            Console.WriteLine ( $"Support Kills Per Minute KD-Ratio: {api.ClassStats.SupportStats.KillsPerMinute.DisplayValue}" );
        }

        static void TestUser ( string handle, User.Platforms platform = User.Platforms.Origin )
        {
            var account = User.Fetch ( handle, platform );

            Console.WriteLine ( $"Handle: {account.Handle}" );
            Console.WriteLine ( $"Identifier: {account.Identifier}" );
            Console.WriteLine ( $"Platform: {account.Platform}" );
            Console.WriteLine ( $"Country Code: {account.CountryCode}" );
            Console.WriteLine ( $"Avatar URL: {account.AvatarUrl}" );
            Console.WriteLine ( $"> Segments" );
            foreach(var segment in account.Segments )
            {
                Console.WriteLine ( $"> {segment.Type}, {segment.Attributes.Select(x => $"{x.Key}: {x.Value}").ToArray().ToString(", ", ", ")}" );
            
                foreach(var stat in segment.Stats )
                {
                    Console.WriteLine ( $"  > {stat.ShortName}: {stat.DisplayName} {stat.DisplayCategory} {stat.DisplayType} {stat.DisplayValue}" );
                }
            }
        }
    }
}
