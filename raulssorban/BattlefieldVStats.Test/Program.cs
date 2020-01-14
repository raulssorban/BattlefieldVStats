using BattlefieldV;
using BattlefieldV.Components;
using Humanlights.Components;
using Humanlights.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BattlefieldVStats.Test
{
    class Program
    {
        static void Main ( string [] args )
        {
            var handle = "Ordoprime";
            var platform = User.Platforms.Origin;

            Console.WriteLine ( $"> User" );
            TestUser ( handle, platform );

            Console.WriteLine ( $"\n> User (Async)" );
            Task.Run ( async delegate () { await TestUserAsync ( handle, platform ); } );

            Console.WriteLine ( $"\n> API" );
            TestAPI ( handle, platform );

            Console.WriteLine ( $"\n> API (Async)" );
            Task.Run ( async delegate () { await TestAPIAsync ( handle, platform ); } );

            Console.ReadLine ();
        }

        static void TestAPI ( string handle, User.Platforms platform = User.Platforms.Origin )
        {
            var api = API.Fetch ( handle, platform );

            if ( api.HasException )
            {
                Console.WriteLine ( $"Could not fetch the API '{handle}' ({platform.ToString ()}): {api.Exception.Message}" );
            }
            else
            {
                var overview = api.OverviewStats;
                var gameMode = api.GameModeStats;
                var @class = api.ClassStats;

                var columns = new string [] { "", "Short Name", "Display Name", "Display Category", "Category", "Value", "Percentile", "Display Value", "Display Type" };
                var overviewTable = new StringTable ( columns );
                var gameModeTable = new StringTable ( columns );
                var classTable = new StringTable ( columns );

                //
                // Overview
                //
                Console.WriteLine ( $"Overview" );
                {
                    AddStat ( overviewTable, "Overview", overview.ScorePerMinute );
                    AddStat ( overviewTable, "Overview", overview.KDRatio );
                    AddStat ( overviewTable, "Overview", overview.Kills );
                    AddStat ( overviewTable, "Overview", overview.Deaths );
                    AddStat ( overviewTable, "Overview", overview.Damage );
                    AddStat ( overviewTable, "Overview", overview.Assists );
                    AddStat ( overviewTable, "Overview", overview.KillsAggregated );
                    AddStat ( overviewTable, "Overview", overview.AssistsAsKills );
                    AddStat ( overviewTable, "Overview", overview.ShotsTaken );
                    AddStat ( overviewTable, "Overview", overview.ShotsHit );
                    AddStat ( overviewTable, "Overview", overview.ShotsAccuracy );
                    AddStat ( overviewTable, "Overview", overview.KillStreak );
                    AddStat ( overviewTable, "Overview", overview.DogtagsTaken );
                    AddStat ( overviewTable, "Overview", overview.AvengerKills );
                    AddStat ( overviewTable, "Overview", overview.SaviorKills );
                    AddStat ( overviewTable, "Overview", overview.Headshots );
                    AddStat ( overviewTable, "Overview", overview.SuppressionAssists );
                    AddStat ( overviewTable, "Overview", overview.LongestHeadshot );
                    AddStat ( overviewTable, "Overview", overview.KillsPerMinute );
                    AddStat ( overviewTable, "Overview", overview.DamagePerMinute );
                    AddStat ( overviewTable, "Overview", overview.Heals );
                    AddStat ( overviewTable, "Overview", overview.Revives );
                    AddStat ( overviewTable, "Overview", overview.RevivesRecieved );
                    AddStat ( overviewTable, "Overview", overview.Resupplies );
                    AddStat ( overviewTable, "Overview", overview.Repairs );
                    AddStat ( overviewTable, "Overview", overview.AceSquad );
                    AddStat ( overviewTable, "Overview", overview.SquadSpawns );
                    AddStat ( overviewTable, "Overview", overview.SquadWipes );
                    AddStat ( overviewTable, "Overview", overview.OrdersCompleted );
                    AddStat ( overviewTable, "Overview", overview.WLPercentage );
                    AddStat ( overviewTable, "Overview", overview.Wins );
                    AddStat ( overviewTable, "Overview", overview.Losses );
                    AddStat ( overviewTable, "Overview", overview.Draws );
                    AddStat ( overviewTable, "Overview", overview.Rounds );
                    AddStat ( overviewTable, "Overview", overview.RoundsPlayed );
                    AddStat ( overviewTable, "Overview", overview.Rank );
                    AddStat ( overviewTable, "Overview", overview.RankScore );
                    AddStat ( overviewTable, "Overview", overview.TimePlayed );
                    AddStat ( overviewTable, "Overview", overview.ScoreRound );
                    AddStat ( overviewTable, "Overview", overview.ScoreGeneral );
                    AddStat ( overviewTable, "Overview", overview.ScoreCombat );
                    AddStat ( overviewTable, "Overview", overview.ScoreDefensive );
                    AddStat ( overviewTable, "Overview", overview.ScoreObjective );
                    AddStat ( overviewTable, "Overview", overview.ScoreBonus );
                    AddStat ( overviewTable, "Overview", overview.ScoreSquad );
                    AddStat ( overviewTable, "Overview", overview.ScoreAward );
                    AddStat ( overviewTable, "Overview", overview.ScoreAssault );
                    AddStat ( overviewTable, "Overview", overview.ScoreSupport );
                    AddStat ( overviewTable, "Overview", overview.ScoreRecon );
                    AddStat ( overviewTable, "Overview", overview.ScoreAir );
                    AddStat ( overviewTable, "Overview", overview.ScoreLand );
                    AddStat ( overviewTable, "Overview", overview.ScoreTanks );
                    AddStat ( overviewTable, "Overview", overview.ScoreTransports );
                    AddStat ( overviewTable, "Overview", overview.RankProgression );
                }

                //
                // Game Mode
                //
                Console.WriteLine ( $"Game Mode" );
                {
                    AddGameMode ( gameModeTable, gameMode?.AirborneStats, $"Airborne" );
                    AddGameMode ( gameModeTable, gameMode?.BreakthroughStats, $"Breakthrough" );
                    AddGameMode ( gameModeTable, gameMode?.ConquestStats, $"Conquest" );
                    AddGameMode ( gameModeTable, gameMode?.SquadConquestStats, $"Squad Conquest" );
                    AddGameMode ( gameModeTable, gameMode?.DominationStats, $"Domination" );
                    AddGameMode ( gameModeTable, gameMode?.FinalStandStats, $"Final Stand" );
                    AddGameMode ( gameModeTable, gameMode?.TdmStats, $"TDM" );
                    AddGameMode ( gameModeTable, gameMode?.FrontlinesStats, $"Frontlines" );
                }

                //
                // Class
                //
                Console.WriteLine ( "Class" );
                {
                    AddClass ( classTable, @class.AssaultStats, $"Assault" );
                    AddClass ( classTable, @class.MedicStats, $"Medic" );
                    AddClass ( classTable, @class.PilotStats, $"Pilot" );
                    AddClass ( classTable, @class.ReconStats, $"Recon" );
                    AddClass ( classTable, @class.SupportStats, $"Support" );
                    AddClass ( classTable, @class.TankerStats, $"Tanker" );
                }

                Console.WriteLine ( overviewTable.ToStringMinimal () );
                Console.WriteLine ( gameModeTable.ToStringMinimal () );
                Console.WriteLine ( classTable.ToStringMinimal () );
            }
        }
        static async Task TestAPIAsync ( string handle, User.Platforms platform = User.Platforms.Origin )
        {
            var api = await API.FetchAsync ( handle, platform );

            if ( api.HasException )
            {
                Console.WriteLine ( $"Could not fetch the API '{handle}' ({platform.ToString ()}): {api.Exception.Message}" );
            }
            else
            {
                var overview = api.OverviewStats;
                var gameMode = api.GameModeStats;
                var @class = api.ClassStats;

                var columns = new string [] { "", "Short Name", "Display Name", "Display Category", "Category", "Value", "Percentile", "Display Value", "Display Type" };
                var overviewTable = new StringTable ( columns );
                var gameModeTable = new StringTable ( columns );
                var classTable = new StringTable ( columns );

                //
                // Overview
                //
                Console.WriteLine ( $"Overview" );
                {
                    AddStat ( overviewTable, "Overview", overview.ScorePerMinute );
                    AddStat ( overviewTable, "Overview", overview.KDRatio );
                    AddStat ( overviewTable, "Overview", overview.Kills );
                    AddStat ( overviewTable, "Overview", overview.Deaths );
                    AddStat ( overviewTable, "Overview", overview.Damage );
                    AddStat ( overviewTable, "Overview", overview.Assists );
                    AddStat ( overviewTable, "Overview", overview.KillsAggregated );
                    AddStat ( overviewTable, "Overview", overview.AssistsAsKills );
                    AddStat ( overviewTable, "Overview", overview.ShotsTaken );
                    AddStat ( overviewTable, "Overview", overview.ShotsHit );
                    AddStat ( overviewTable, "Overview", overview.ShotsAccuracy );
                    AddStat ( overviewTable, "Overview", overview.KillStreak );
                    AddStat ( overviewTable, "Overview", overview.DogtagsTaken );
                    AddStat ( overviewTable, "Overview", overview.AvengerKills );
                    AddStat ( overviewTable, "Overview", overview.SaviorKills );
                    AddStat ( overviewTable, "Overview", overview.Headshots );
                    AddStat ( overviewTable, "Overview", overview.SuppressionAssists );
                    AddStat ( overviewTable, "Overview", overview.LongestHeadshot );
                    AddStat ( overviewTable, "Overview", overview.KillsPerMinute );
                    AddStat ( overviewTable, "Overview", overview.DamagePerMinute );
                    AddStat ( overviewTable, "Overview", overview.Heals );
                    AddStat ( overviewTable, "Overview", overview.Revives );
                    AddStat ( overviewTable, "Overview", overview.RevivesRecieved );
                    AddStat ( overviewTable, "Overview", overview.Resupplies );
                    AddStat ( overviewTable, "Overview", overview.Repairs );
                    AddStat ( overviewTable, "Overview", overview.AceSquad );
                    AddStat ( overviewTable, "Overview", overview.SquadSpawns );
                    AddStat ( overviewTable, "Overview", overview.SquadWipes );
                    AddStat ( overviewTable, "Overview", overview.OrdersCompleted );
                    AddStat ( overviewTable, "Overview", overview.WLPercentage );
                    AddStat ( overviewTable, "Overview", overview.Wins );
                    AddStat ( overviewTable, "Overview", overview.Losses );
                    AddStat ( overviewTable, "Overview", overview.Draws );
                    AddStat ( overviewTable, "Overview", overview.Rounds );
                    AddStat ( overviewTable, "Overview", overview.RoundsPlayed );
                    AddStat ( overviewTable, "Overview", overview.Rank );
                    AddStat ( overviewTable, "Overview", overview.RankScore );
                    AddStat ( overviewTable, "Overview", overview.TimePlayed );
                    AddStat ( overviewTable, "Overview", overview.ScoreRound );
                    AddStat ( overviewTable, "Overview", overview.ScoreGeneral );
                    AddStat ( overviewTable, "Overview", overview.ScoreCombat );
                    AddStat ( overviewTable, "Overview", overview.ScoreDefensive );
                    AddStat ( overviewTable, "Overview", overview.ScoreObjective );
                    AddStat ( overviewTable, "Overview", overview.ScoreBonus );
                    AddStat ( overviewTable, "Overview", overview.ScoreSquad );
                    AddStat ( overviewTable, "Overview", overview.ScoreAward );
                    AddStat ( overviewTable, "Overview", overview.ScoreAssault );
                    AddStat ( overviewTable, "Overview", overview.ScoreSupport );
                    AddStat ( overviewTable, "Overview", overview.ScoreRecon );
                    AddStat ( overviewTable, "Overview", overview.ScoreAir );
                    AddStat ( overviewTable, "Overview", overview.ScoreLand );
                    AddStat ( overviewTable, "Overview", overview.ScoreTanks );
                    AddStat ( overviewTable, "Overview", overview.ScoreTransports );
                    AddStat ( overviewTable, "Overview", overview.RankProgression );
                }

                //
                // Game Mode
                //
                Console.WriteLine ( $"Game Mode" );
                {
                    AddGameMode ( gameModeTable, gameMode?.AirborneStats, $"Airborne" );
                    AddGameMode ( gameModeTable, gameMode?.BreakthroughStats, $"Breakthrough" );
                    AddGameMode ( gameModeTable, gameMode?.ConquestStats, $"Conquest" );
                    AddGameMode ( gameModeTable, gameMode?.SquadConquestStats, $"Squad Conquest" );
                    AddGameMode ( gameModeTable, gameMode?.DominationStats, $"Domination" );
                    AddGameMode ( gameModeTable, gameMode?.FinalStandStats, $"Final Stand" );
                    AddGameMode ( gameModeTable, gameMode?.TdmStats, $"TDM" );
                    AddGameMode ( gameModeTable, gameMode?.FrontlinesStats, $"Frontlines" );
                }

                //
                // Class
                //
                Console.WriteLine ( "Class" );
                {
                    AddClass ( classTable, @class.AssaultStats, $"Assault" );
                    AddClass ( classTable, @class.MedicStats, $"Medic" );
                    AddClass ( classTable, @class.PilotStats, $"Pilot" );
                    AddClass ( classTable, @class.ReconStats, $"Recon" );
                    AddClass ( classTable, @class.SupportStats, $"Support" );
                    AddClass ( classTable, @class.TankerStats, $"Tanker" );
                }

                Console.WriteLine ( overviewTable.ToStringMinimal () );
                Console.WriteLine ( gameModeTable.ToStringMinimal () );
                Console.WriteLine ( classTable.ToStringMinimal () );
            }
        }

        static void AddStat ( StringTable table, string title, Stat stat )
        {
            table.AddRow ( title, stat.ShortName, stat.DisplayName, stat.DisplayCategory, stat.Category, stat.Value, stat.Percentile, stat.DisplayValue, stat.DisplayType );
        }
        static void AddGameMode ( StringTable table, API.GameMode.GameModeStat stat, string title )
        {
            AddStat ( table, title, stat.Wins );
            AddStat ( table, title, stat.Losses );
            AddStat ( table, title, stat.WLPercentage );
            AddStat ( table, title, stat.Score );
            AddStat ( table, title, stat.FlagDefends );
            AddStat ( table, title, stat.FlagCaptures );
            AddStat ( table, title, stat.ArtilleryDefenseKills );
            AddStat ( table, title, stat.BombsPlaced );
            AddStat ( table, title, stat.BombsDefused );
            AddStat ( table, title, stat.MessagesDelivered );
            AddStat ( table, title, stat.CarriersKills );
            AddStat ( table, title, stat.CarriersReleased );
            AddStat ( table, title, stat.MessagesWritten );
        }
        static void AddClass ( StringTable table, API.Class.ClassStat stat, string title )
        {
            AddStat ( table, title, stat.Rank );
            AddStat ( table, title, stat.Kills );
            AddStat ( table, title, stat.Deaths );
            AddStat ( table, title, stat.KillsPerMinute );
            AddStat ( table, title, stat.KDRatio );
            AddStat ( table, title, stat.TimePlayed );
            AddStat ( table, title, stat.ShotsFired );
            AddStat ( table, title, stat.ShotsHit );
            AddStat ( table, title, stat.ShotsAccuracy );
            AddStat ( table, title, stat.Score );
            AddStat ( table, title, stat.ScorePerMinute );
        }

        static void TestUser ( string handle, User.Platforms platform = User.Platforms.Origin )
        {
            var user = User.Fetch ( handle, platform );

            if ( user.HasException )
            {
                Console.WriteLine ( $"Could not fetch the User '{handle}' ({platform.ToString ()}): {user.Exception.Message}" );
            }
            else
            {
                Console.WriteLine ( $"Handle: {user.Handle}" );
                Console.WriteLine ( $"Identifier: {user.Identifier}" );
                Console.WriteLine ( $"Platform: {user.Platform}" );
                Console.WriteLine ( $"Country Code: {user.CountryCode}" );
                Console.WriteLine ( $"Avatar URL: {user.AvatarUrl}" );
                Console.WriteLine ( $"> Segments" );

                foreach ( var segment in user.Segments )
                {
                    Console.WriteLine ( $"> {segment.Type}, {segment.Attributes.Select ( x => $"{x.Key}: {x.Value}" ).ToArray ().ToString ( ", ", ", " )}" );

                    foreach ( var stat in segment.Stats )
                    {
                        Console.WriteLine ( $"  > {stat.ShortName}: {stat.DisplayName} {stat.DisplayCategory} {stat.DisplayType} {stat.DisplayValue}" );
                    }
                }
            }
        }
        static async Task TestUserAsync ( string handle, User.Platforms platform = User.Platforms.Origin )
        {
            var user = await User.FetchAsync ( handle, platform );

            if ( user.HasException )
            {
                Console.WriteLine ( $"Could not fetch the User '{handle}' ({platform.ToString ()}): {user.Exception.Message}" );
            }
            else
            {
                Console.WriteLine ( $"Handle: {user.Handle}" );
                Console.WriteLine ( $"Identifier: {user.Identifier}" );
                Console.WriteLine ( $"Platform: {user.Platform}" );
                Console.WriteLine ( $"Country Code: {user.CountryCode}" );
                Console.WriteLine ( $"Avatar URL: {user.AvatarUrl}" );
                Console.WriteLine ( $"> Segments" );

                foreach ( var segment in user.Segments )
                {
                    Console.WriteLine ( $"> {segment.Type}, {segment.Attributes.Select ( x => $"{x.Key}: {x.Value}" ).ToArray ().ToString ( ", ", ", " )}" );

                    foreach ( var stat in segment.Stats )
                    {
                        Console.WriteLine ( $"  > {stat.ShortName}: {stat.DisplayName} {stat.DisplayCategory} {stat.DisplayType} {stat.DisplayValue}" );
                    }
                }
            }
        }
    }
}
