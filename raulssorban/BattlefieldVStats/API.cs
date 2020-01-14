using BattlefieldV.Components;
using System.Threading.Tasks;

namespace BattlefieldV
{
    public class API
    {
        public API ( User account )
        {
            OverviewStats = new Overview ( account );
            GameModeStats = new GameMode ( account );
            ClassStats = new Class ( account );
        }

        public static API Fetch ( string handle, User.Platforms platform = User.Platforms.Origin )
        {
            var account = User.Fetch ( handle, platform );
            var api = new API ( account )
            {
                OverviewStats = new Overview ( account ),
                GameModeStats = new GameMode ( account ),
                ClassStats = new Class ( account )
            };

            return api;
        }
        public static async Task<API> FetchAsync ( string handle, User.Platforms platform = User.Platforms.Origin )
        {
            var account = await User.FetchAsync ( handle, platform );
            var api = new API ( account )
            {
                OverviewStats = new Overview ( account ),
                GameModeStats = new GameMode ( account ),
                ClassStats = new Class ( account )
            };

            return api;
        }

        public Overview OverviewStats { get; private set; }
        public GameMode GameModeStats { get; private set; }
        public Class ClassStats { get; private set; }

        public class Overview : APIComponent
        {
            public Overview ( User account ) : base ( account ) { }

            public Stat ScorePerMinute { get { return Account.GetStat ( "overview", null, "scorePerMinute" ); } }
            public Stat KDRatio { get { return Account.GetStat ( "overview", null, "kdRatio" ); } }
            public Stat Kills { get { return Account.GetStat ( "overview", null, "kills" ); } }
            public Stat Deaths { get { return Account.GetStat ( "overview", null, "deaths" ); } }
            public Stat Damage { get { return Account.GetStat ( "overview", null, "damage" ); } }
            public Stat Assists { get { return Account.GetStat ( "overview", null, "assists" ); } }
            public Stat KillsAggregated { get { return Account.GetStat ( "overview", null, "killsAggregated" ); } }
            public Stat AssistsAsKills { get { return Account.GetStat ( "overview", null, "assistsAsKills" ); } }
            public Stat ShotsTaken { get { return Account.GetStat ( "overview", null, "shotsTaken" ); } }
            public Stat ShotsHit { get { return Account.GetStat ( "overview", null, "shotsHit" ); } }
            public Stat ShotsAccuracy { get { return Account.GetStat ( "overview", null, "shotsAccuracy" ); } }
            public Stat KillStreak { get { return Account.GetStat ( "overview", null, "killStreak" ); } }
            public Stat DogtagsTaken { get { return Account.GetStat ( "overview", null, "dogtagsTaken" ); } }
            public Stat AvengerKills { get { return Account.GetStat ( "overview", null, "avengerKills" ); } }
            public Stat SaviorKills { get { return Account.GetStat ( "overview", null, "saviorKills" ); } }
            public Stat Headshots { get { return Account.GetStat ( "overview", null, "headshots" ); } }
            public Stat SuppressionAssists { get { return Account.GetStat ( "overview", null, "suppressionAssists" ); } }
            public Stat LongestHeadshot { get { return Account.GetStat ( "overview", null, "longestHeadshot" ); } }
            public Stat KillsPerMinute { get { return Account.GetStat ( "overview", null, "killsPerMinute" ); } }
            public Stat DamagePerMinute { get { return Account.GetStat ( "overview", null, "damagePerMinute" ); } }
            public Stat Heals { get { return Account.GetStat ( "overview", null, "heals" ); } }
            public Stat Revives { get { return Account.GetStat ( "overview", null, "revives" ); } }
            public Stat RevivesRecieved { get { return Account.GetStat ( "overview", null, "revivesRecieved" ); } }
            public Stat Resupplies { get { return Account.GetStat ( "overview", null, "resupplies" ); } }
            public Stat Repairs { get { return Account.GetStat ( "overview", null, "repairs" ); } }
            public Stat AceSquad { get { return Account.GetStat ( "overview", null, "aceSquad" ); } }
            public Stat SquadSpawns { get { return Account.GetStat ( "overview", null, "squadSpawns" ); } }
            public Stat SquadWipes { get { return Account.GetStat ( "overview", null, "squadWipes" ); } }
            public Stat OrdersCompleted { get { return Account.GetStat ( "overview", null, "ordersCompleted" ); } }
            public Stat WLPercentage { get { return Account.GetStat ( "overview", null, "wlPercentage" ); } }
            public Stat Wins { get { return Account.GetStat ( "overview", null, "wins" ); } }
            public Stat Losses { get { return Account.GetStat ( "overview", null, "losses" ); } }
            public Stat Draws { get { return Account.GetStat ( "overview", null, "draws" ); } }
            public Stat Rounds { get { return Account.GetStat ( "overview", null, "rounds" ); } }
            public Stat RoundsPlayed { get { return Account.GetStat ( "overview", null, "roundsPlayed" ); } }
            public Stat Rank { get { return Account.GetStat ( "overview", null, "rank" ); } }
            public Stat RankScore { get { return Account.GetStat ( "overview", null, "rankScore" ); } }
            public Stat TimePlayed { get { return Account.GetStat ( "overview", null, "timePlayed" ); } }
            public Stat ScoreRound { get { return Account.GetStat ( "overview", null, "scoreRound" ); } }
            public Stat ScoreGeneral { get { return Account.GetStat ( "overview", null, "scoreGeneral" ); } }
            public Stat ScoreCombat { get { return Account.GetStat ( "overview", null, "scoreCombat" ); } }
            public Stat ScoreDefensive { get { return Account.GetStat ( "overview", null, "scoreDefensive" ); } }
            public Stat ScoreObjective { get { return Account.GetStat ( "overview", null, "scoreObjective" ); } }
            public Stat ScoreBonus { get { return Account.GetStat ( "overview", null, "scoreBonus" ); } }
            public Stat ScoreSquad { get { return Account.GetStat ( "overview", null, "scoreSquad" ); } }
            public Stat ScoreAward { get { return Account.GetStat ( "overview", null, "scoreAward" ); } }
            public Stat ScoreAssault { get { return Account.GetStat ( "overview", null, "scoreAssault" ); } }
            public Stat ScoreMedic { get { return Account.GetStat ( "overview", null, "scoreMedic" ); } }
            public Stat ScoreSupport { get { return Account.GetStat ( "overview", null, "scoreSupport" ); } }
            public Stat ScoreRecon { get { return Account.GetStat ( "overview", null, "scoreRecon" ); } }
            public Stat ScoreAir { get { return Account.GetStat ( "overview", null, "scoreAir" ); } }
            public Stat ScoreLand { get { return Account.GetStat ( "overview", null, "scoreLand" ); } }
            public Stat ScoreTanks { get { return Account.GetStat ( "overview", null, "scoreTanks" ); } }
            public Stat ScoreTransports { get { return Account.GetStat ( "overview", null, "scoreTransports" ); } }
            public Stat RankProgression { get { return Account.GetStat ( "overview", null, "rankProgression" ); } }
        }
        public class GameMode : APIComponent
        {
            public GameMode ( User account ) : base ( account )
            {
                AirborneStats = new GameModeStat ( account, "airborne" );
                BreakthroughStats = new GameModeStat ( account, "breakthrough" );
                ConquestStats = new GameModeStat ( account, "conquest" );
                SquadConquestStats = new GameModeStat ( account, "squadConquest" );
                DominationStats = new GameModeStat ( account, "domination" );
                FinalStandStats = new GameModeStat ( account, "finalStand" );
                TdmStats = new GameModeStat ( account, "tdm" );
                FrontlinesStats = new GameModeStat ( account, "frontlines" );
            }

            public GameModeStat AirborneStats { get; }
            public GameModeStat BreakthroughStats { get; }
            public GameModeStat ConquestStats { get; }
            public GameModeStat SquadConquestStats { get; }
            public GameModeStat DominationStats { get; }
            public GameModeStat FinalStandStats { get; }
            public GameModeStat TdmStats { get; }
            public GameModeStat FrontlinesStats { get; }

            public class GameModeStat : APIComponent
            {
                public GameModeStat ( User account, string attribute ) : base ( account ) { Attribute = attribute; }

                private string Attribute { get; set; }

                public Stat Wins { get { return Account.GetStat ( "gamemode", Attribute, "wins" ); } }
                public Stat Losses { get { return Account.GetStat ( "gamemode", Attribute, "losses" ); } }
                public Stat WLPercentage { get { return Account.GetStat ( "gamemode", Attribute, "wlPercentage" ); } }
                public Stat Score { get { return Account.GetStat ( "gamemode", Attribute, "score" ); } }
                public Stat FlagDefends { get { return Account.GetStat ( "gamemode", Attribute, "flagDefends" ); } }
                public Stat FlagCaptures { get { return Account.GetStat ( "gamemode", Attribute, "flagCaptures" ); } }
                public Stat ArtilleryDefenseKills { get { return Account.GetStat ( "gamemode", Attribute, "artilleryDefenseKills" ); } }
                public Stat BombsPlaced { get { return Account.GetStat ( "gamemode", Attribute, "bombsPlaced" ); } }
                public Stat BombsDefused { get { return Account.GetStat ( "gamemode", Attribute, "bombsDefused" ); } }
                public Stat MessagesDelivered { get { return Account.GetStat ( "gamemode", Attribute, "messagesDelivered" ); } }
                public Stat CarriersKills { get { return Account.GetStat ( "gamemode", Attribute, "carriersKills" ); } }
                public Stat CarriersReleased { get { return Account.GetStat ( "gamemode", Attribute, "carriersReleased" ); } }
                public Stat MessagesWritten { get { return Account.GetStat ( "gamemode", Attribute, "messagesWritten" ); } }
            }
        }
        public class Class : APIComponent
        {
            public Class ( User account ) : base ( account )
            {
                AssaultStats = new ClassStat ( account, "assault" );
                MedicStats = new ClassStat ( account, "medic" );
                PilotStats = new ClassStat ( account, "pilot" );
                ReconStats = new ClassStat ( account, "recon" );
                SupportStats = new ClassStat ( account, "support" );
                TankerStats = new ClassStat ( account, "tanker" );
            }

            public ClassStat AssaultStats { get; }
            public ClassStat MedicStats { get; }
            public ClassStat PilotStats { get; }
            public ClassStat ReconStats { get; }
            public ClassStat SupportStats { get; }
            public ClassStat TankerStats { get; }

            public class ClassStat : APIComponent
            {
                public ClassStat ( User account, string attribute ) : base ( account ) { Attribute = attribute; }

                private string Attribute { get; set; }

                public string ClassIconUrl { get { return Account.GetSegment ( "class", Attribute ).Attributes [ "imageUrl" ]; } }

                public Stat Rank { get { return Account.GetStat ( "class", Attribute, "rank" ); } }
                public Stat Kills { get { return Account.GetStat ( "class", Attribute, "kills" ); } }
                public Stat Deaths { get { return Account.GetStat ( "class", Attribute, "deaths" ); } }
                public Stat KillsPerMinute { get { return Account.GetStat ( "class", Attribute, "killsPerMinute" ); } }
                public Stat KDRatio { get { return Account.GetStat ( "class", Attribute, "kdRatio" ); } }
                public Stat TimePlayed { get { return Account.GetStat ( "class", Attribute, "timePlayed" ); } }
                public Stat ShotsFired { get { return Account.GetStat ( "class", Attribute, "shotsFired" ); } }
                public Stat ShotsHit { get { return Account.GetStat ( "class", Attribute, "shotsHit" ); } }
                public Stat ShotsAccuracy { get { return Account.GetStat ( "class", Attribute, "shotsAccuracy" ); } }
                public Stat Score { get { return Account.GetStat ( "class", Attribute, "score" ); } }
                public Stat ScorePerMinute { get { return Account.GetStat ( "class", Attribute, "scorePerMinute" ); } }
            }
        }
    }
}
