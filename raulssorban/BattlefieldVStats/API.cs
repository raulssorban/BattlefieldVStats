using BattlefieldV.Components;

namespace BattlefieldV
{
    public class API
    {
        public API ( Account account )
        {
            OverviewStats = new Overview ( account );
            GameModeStats = new GameMode ( account );
            ClassStats = new Class ( account );
        }
        public API ( string handle, Account.Platforms platform = Account.Platforms.Origin )
        {
            var account = BattlefieldV.Manager.GetAccount ( handle, platform );

            OverviewStats = new Overview ( account );
            GameModeStats = new GameMode ( account );
            ClassStats = new Class ( account );
        }

        public Overview OverviewStats { get; }
        public GameMode GameModeStats { get; }
        public Class ClassStats { get; set; }

        public class Overview : APIComponent
        {
            public Overview ( Account account ) : base ( account ) { }

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
            public GameMode ( Account account ) : base ( account )
            {
                AirboneStats = new Airbone ( account );
                BreakthroughStats = new Breakthrough ( account );
                ConquestStats = new Conquest ( account );
                SquadConquestStats = new SquadConquest ( account );
                DominationStats = new Domination ( account );
                FinalStandStats = new FinalStand ( account );
                TdmStats = new Tdm ( account );
                FrontlinesStats = new Frontlines ( account );
            }

            public Airbone AirboneStats { get; }
            public Breakthrough BreakthroughStats { get; }
            public Conquest ConquestStats { get; }
            public SquadConquest SquadConquestStats { get; }
            public Domination DominationStats { get; }
            public FinalStand FinalStandStats { get; }
            public Tdm TdmStats { get; }
            public Frontlines FrontlinesStats { get; }

            public class Airbone : APIComponent
            {
                public Airbone ( Account account ) : base ( account ) { }

                public Stat Wins { get { return Account.GetStat ( "gamemode", "airborne", "wins" ); } }
                public Stat Losses { get { return Account.GetStat ( "gamemode", "airborne", "losses" ); } }
                public Stat WLPercentage { get { return Account.GetStat ( "gamemode", "airborne", "wlPercentage" ); } }
                public Stat Score { get { return Account.GetStat ( "gamemode", "airborne", "score" ); } }
                public Stat FlagDefends { get { return Account.GetStat ( "gamemode", "airborne", "flagDefends" ); } }
                public Stat FlagCaptures { get { return Account.GetStat ( "gamemode", "airborne", "flagCaptures" ); } }
                public Stat ArtilleryDefenseKills { get { return Account.GetStat ( "gamemode", "airborne", "artilleryDefenseKills" ); } }
                public Stat BombsPlaced { get { return Account.GetStat ( "gamemode", "airborne", "bombsPlaced" ); } }
                public Stat BombsDefused { get { return Account.GetStat ( "gamemode", "airborne", "bombsDefused" ); } }
                public Stat MessagesDelivered { get { return Account.GetStat ( "gamemode", "airborne", "messagesDelivered" ); } }
                public Stat CarriersKills { get { return Account.GetStat ( "gamemode", "airborne", "carriersKills" ); } }
                public Stat CarriersReleased { get { return Account.GetStat ( "gamemode", "airborne", "carriersReleased" ); } }
                public Stat MessagesWritten { get { return Account.GetStat ( "gamemode", "airborne", "messagesWritten" ); } }
            }
            public class Breakthrough : APIComponent
            {
                public Breakthrough ( Account account ) : base ( account ) { }

                public Stat Wins { get { return Account.GetStat ( "gamemode", "breakthrough", "wins" ); } }
                public Stat Losses { get { return Account.GetStat ( "gamemode", "breakthrough", "losses" ); } }
                public Stat WLPercentage { get { return Account.GetStat ( "gamemode", "breakthrough", "wlPercentage" ); } }
                public Stat Score { get { return Account.GetStat ( "gamemode", "breakthrough", "score" ); } }
                public Stat FlagDefends { get { return Account.GetStat ( "gamemode", "breakthrough", "flagDefends" ); } }
                public Stat FlagCaptures { get { return Account.GetStat ( "gamemode", "breakthrough", "flagCaptures" ); } }
                public Stat ArtilleryDefenseKills { get { return Account.GetStat ( "gamemode", "breakthrough", "artilleryDefenseKills" ); } }
                public Stat BombsPlaced { get { return Account.GetStat ( "gamemode", "breakthrough", "bombsPlaced" ); } }
                public Stat BombsDefused { get { return Account.GetStat ( "gamemode", "breakthrough", "bombsDefused" ); } }
                public Stat MessagesDelivered { get { return Account.GetStat ( "gamemode", "breakthrough", "messagesDelivered" ); } }
                public Stat CarriersKills { get { return Account.GetStat ( "gamemode", "breakthrough", "carriersKills" ); } }
                public Stat CarriersReleased { get { return Account.GetStat ( "gamemode", "breakthrough", "carriersReleased" ); } }
                public Stat MessagesWritten { get { return Account.GetStat ( "gamemode", "breakthrough", "messagesWritten" ); } }
            }
            public class Conquest : APIComponent
            {
                public Conquest ( Account account ) : base ( account ) { }

                public Stat Wins { get { return Account.GetStat ( "gamemode", "conquest", "wins" ); } }
                public Stat Losses { get { return Account.GetStat ( "gamemode", "conquest", "losses" ); } }
                public Stat WLPercentage { get { return Account.GetStat ( "gamemode", "conquest", "wlPercentage" ); } }
                public Stat Score { get { return Account.GetStat ( "gamemode", "conquest", "score" ); } }
                public Stat FlagDefends { get { return Account.GetStat ( "gamemode", "conquest", "flagDefends" ); } }
                public Stat FlagCaptures { get { return Account.GetStat ( "gamemode", "conquest", "flagCaptures" ); } }
                public Stat ArtilleryDefenseKills { get { return Account.GetStat ( "gamemode", "conquest", "artilleryDefenseKills" ); } }
                public Stat BombsPlaced { get { return Account.GetStat ( "gamemode", "conquest", "bombsPlaced" ); } }
                public Stat BombsDefused { get { return Account.GetStat ( "gamemode", "conquest", "bombsDefused" ); } }
                public Stat MessagesDelivered { get { return Account.GetStat ( "gamemode", "conquest", "messagesDelivered" ); } }
                public Stat CarriersKills { get { return Account.GetStat ( "gamemode", "conquest", "carriersKills" ); } }
                public Stat CarriersReleased { get { return Account.GetStat ( "gamemode", "conquest", "carriersReleased" ); } }
                public Stat MessagesWritten { get { return Account.GetStat ( "gamemode", "conquest", "messagesWritten" ); } }
            }
            public class SquadConquest : APIComponent
            {
                public SquadConquest ( Account account ) : base ( account ) { }

                public Stat Wins { get { return Account.GetStat ( "gamemode", "squadConquest", "wins" ); } }
                public Stat Losses { get { return Account.GetStat ( "gamemode", "squadConquest", "losses" ); } }
                public Stat WLPercentage { get { return Account.GetStat ( "gamemode", "squadConquest", "wlPercentage" ); } }
                public Stat Score { get { return Account.GetStat ( "gamemode", "squadConquest", "score" ); } }
                public Stat FlagDefends { get { return Account.GetStat ( "gamemode", "squadConquest", "flagDefends" ); } }
                public Stat FlagCaptures { get { return Account.GetStat ( "gamemode", "squadConquest", "flagCaptures" ); } }
                public Stat ArtilleryDefenseKills { get { return Account.GetStat ( "gamemode", "squadConquest", "artilleryDefenseKills" ); } }
                public Stat BombsPlaced { get { return Account.GetStat ( "gamemode", "squadConquest", "bombsPlaced" ); } }
                public Stat BombsDefused { get { return Account.GetStat ( "gamemode", "squadConquest", "bombsDefused" ); } }
                public Stat MessagesDelivered { get { return Account.GetStat ( "gamemode", "squadConquest", "messagesDelivered" ); } }
                public Stat CarriersKills { get { return Account.GetStat ( "gamemode", "squadConquest", "carriersKills" ); } }
                public Stat CarriersReleased { get { return Account.GetStat ( "gamemode", "squadConquest", "carriersReleased" ); } }
                public Stat MessagesWritten { get { return Account.GetStat ( "gamemode", "squadConquest", "messagesWritten" ); } }
            }
            public class Domination : APIComponent
            {
                public Domination ( Account account ) : base ( account ) { }

                public Stat Wins { get { return Account.GetStat ( "gamemode", "domination", "wins" ); } }
                public Stat Losses { get { return Account.GetStat ( "gamemode", "domination", "losses" ); } }
                public Stat WLPercentage { get { return Account.GetStat ( "gamemode", "domination", "wlPercentage" ); } }
                public Stat Score { get { return Account.GetStat ( "gamemode", "domination", "score" ); } }
                public Stat FlagDefends { get { return Account.GetStat ( "gamemode", "domination", "flagDefends" ); } }
                public Stat FlagCaptures { get { return Account.GetStat ( "gamemode", "domination", "flagCaptures" ); } }
                public Stat ArtilleryDefenseKills { get { return Account.GetStat ( "gamemode", "domination", "artilleryDefenseKills" ); } }
                public Stat BombsPlaced { get { return Account.GetStat ( "gamemode", "domination", "bombsPlaced" ); } }
                public Stat BombsDefused { get { return Account.GetStat ( "gamemode", "domination", "bombsDefused" ); } }
                public Stat MessagesDelivered { get { return Account.GetStat ( "gamemode", "domination", "messagesDelivered" ); } }
                public Stat CarriersKills { get { return Account.GetStat ( "gamemode", "domination", "carriersKills" ); } }
                public Stat CarriersReleased { get { return Account.GetStat ( "gamemode", "domination", "carriersReleased" ); } }
                public Stat MessagesWritten { get { return Account.GetStat ( "gamemode", "domination", "messagesWritten" ); } }
            }
            public class FinalStand : APIComponent
            {
                public FinalStand ( Account account ) : base ( account ) { }

                public Stat Wins { get { return Account.GetStat ( "gamemode", "finalStand", "wins" ); } }
                public Stat Losses { get { return Account.GetStat ( "gamemode", "finalStand", "losses" ); } }
                public Stat WLPercentage { get { return Account.GetStat ( "gamemode", "finalStand", "wlPercentage" ); } }
                public Stat Score { get { return Account.GetStat ( "gamemode", "finalStand", "score" ); } }
                public Stat FlagDefends { get { return Account.GetStat ( "gamemode", "finalStand", "flagDefends" ); } }
                public Stat FlagCaptures { get { return Account.GetStat ( "gamemode", "finalStand", "flagCaptures" ); } }
                public Stat ArtilleryDefenseKills { get { return Account.GetStat ( "gamemode", "finalStand", "artilleryDefenseKills" ); } }
                public Stat BombsPlaced { get { return Account.GetStat ( "gamemode", "finalStand", "bombsPlaced" ); } }
                public Stat BombsDefused { get { return Account.GetStat ( "gamemode", "finalStand", "bombsDefused" ); } }
                public Stat MessagesDelivered { get { return Account.GetStat ( "gamemode", "finalStand", "messagesDelivered" ); } }
                public Stat CarriersKills { get { return Account.GetStat ( "gamemode", "finalStand", "carriersKills" ); } }
                public Stat CarriersReleased { get { return Account.GetStat ( "gamemode", "finalStand", "carriersReleased" ); } }
                public Stat MessagesWritten { get { return Account.GetStat ( "gamemode", "finalStand", "messagesWritten" ); } }
            }
            public class Tdm : APIComponent
            {
                public Tdm ( Account account ) : base ( account ) { }

                public Stat Wins { get { return Account.GetStat ( "gamemode", "tdm", "wins" ); } }
                public Stat Losses { get { return Account.GetStat ( "gamemode", "tdm", "losses" ); } }
                public Stat WLPercentage { get { return Account.GetStat ( "gamemode", "tdm", "wlPercentage" ); } }
                public Stat Score { get { return Account.GetStat ( "gamemode", "tdm", "score" ); } }
                public Stat FlagDefends { get { return Account.GetStat ( "gamemode", "tdm", "flagDefends" ); } }
                public Stat FlagCaptures { get { return Account.GetStat ( "gamemode", "tdm", "flagCaptures" ); } }
                public Stat ArtilleryDefenseKills { get { return Account.GetStat ( "gamemode", "tdm", "artilleryDefenseKills" ); } }
                public Stat BombsPlaced { get { return Account.GetStat ( "gamemode", "tdm", "bombsPlaced" ); } }
                public Stat BombsDefused { get { return Account.GetStat ( "gamemode", "tdm", "bombsDefused" ); } }
                public Stat MessagesDelivered { get { return Account.GetStat ( "gamemode", "tdm", "messagesDelivered" ); } }
                public Stat CarriersKills { get { return Account.GetStat ( "gamemode", "tdm", "carriersKills" ); } }
                public Stat CarriersReleased { get { return Account.GetStat ( "gamemode", "tdm", "carriersReleased" ); } }
                public Stat MessagesWritten { get { return Account.GetStat ( "gamemode", "tdm", "messagesWritten" ); } }
            }
            public class Frontlines : APIComponent
            {
                public Frontlines ( Account account ) : base ( account ) { }

                public Stat Wins { get { return Account.GetStat ( "gamemode", "frontlines", "wins" ); } }
                public Stat Losses { get { return Account.GetStat ( "gamemode", "frontlines", "losses" ); } }
                public Stat WLPercentage { get { return Account.GetStat ( "gamemode", "frontlines", "wlPercentage" ); } }
                public Stat Score { get { return Account.GetStat ( "gamemode", "frontlines", "score" ); } }
                public Stat FlagDefends { get { return Account.GetStat ( "gamemode", "frontlines", "flagDefends" ); } }
                public Stat FlagCaptures { get { return Account.GetStat ( "gamemode", "frontlines", "flagCaptures" ); } }
                public Stat ArtilleryDefenseKills { get { return Account.GetStat ( "gamemode", "frontlines", "artilleryDefenseKills" ); } }
                public Stat BombsPlaced { get { return Account.GetStat ( "gamemode", "frontlines", "bombsPlaced" ); } }
                public Stat BombsDefused { get { return Account.GetStat ( "gamemode", "frontlines", "bombsDefused" ); } }
                public Stat MessagesDelivered { get { return Account.GetStat ( "gamemode", "frontlines", "messagesDelivered" ); } }
                public Stat CarriersKills { get { return Account.GetStat ( "gamemode", "frontlines", "carriersKills" ); } }
                public Stat CarriersReleased { get { return Account.GetStat ( "gamemode", "frontlines", "carriersReleased" ); } }
                public Stat MessagesWritten { get { return Account.GetStat ( "gamemode", "frontlines", "messagesWritten" ); } }
            }
        }
        public class Class : APIComponent
        {
            public Class ( Account account ) : base ( account )
            {
                AssaultStats = new Assault ( account );
                MedicStats = new Medic ( account );
                PilotStats = new Pilot ( account );
                ReconStats = new Recon ( account );
                SupportStats = new Support ( account );
                TankerStats = new Tanker ( account );
            }

            public Assault AssaultStats { get; }
            public Medic MedicStats { get; }
            public Pilot PilotStats { get; }
            public Recon ReconStats { get; }
            public Support SupportStats { get; }
            public Tanker TankerStats { get; }

            public class Assault : APIComponent
            {
                public Assault ( Account account ) : base ( account ) { }

                public string ClassIconUrl { get { return Account.GetSegment ( "class", "assault" ).Attributes [ "imageUrl" ]; } }

                public Stat Rank { get { return Account.GetStat ( "class", "assault", "rank" ); } }
                public Stat Kills { get { return Account.GetStat ( "class", "assault", "kills" ); } }
                public Stat Deaths { get { return Account.GetStat ( "class", "assault", "deaths" ); } }
                public Stat KillsPerMinute { get { return Account.GetStat ( "class", "assault", "killsPerMinute" ); } }
                public Stat KDRatio { get { return Account.GetStat ( "class", "assault", "kdRatio" ); } }
                public Stat TimePlayed { get { return Account.GetStat ( "class", "assault", "timePlayed" ); } }
                public Stat ShotsFired { get { return Account.GetStat ( "class", "assault", "shotsFired" ); } }
                public Stat ShotsHit { get { return Account.GetStat ( "class", "assault", "shotsHit" ); } }
                public Stat ShotsAccuracy { get { return Account.GetStat ( "class", "assault", "shotsAccuracy" ); } }
                public Stat Score { get { return Account.GetStat ( "class", "assault", "score" ); } }
                public Stat ScorePerMinute { get { return Account.GetStat ( "class", "assault", "scorePerMinute" ); } }
            }
            public class Medic : APIComponent
            {
                public Medic ( Account account ) : base ( account ) { }

                public string ClassIconUrl { get { return Account.GetSegment ( "class", "medic" ).Attributes [ "imageUrl" ]; } }

                public Stat Rank { get { return Account.GetStat ( "class", "medic", "rank" ); } }
                public Stat Kills { get { return Account.GetStat ( "class", "medic", "kills" ); } }
                public Stat Deaths { get { return Account.GetStat ( "class", "medic", "deaths" ); } }
                public Stat KillsPerMinute { get { return Account.GetStat ( "class", "medic", "killsPerMinute" ); } }
                public Stat KDRatio { get { return Account.GetStat ( "class", "medic", "kdRatio" ); } }
                public Stat TimePlayed { get { return Account.GetStat ( "class", "medic", "timePlayed" ); } }
                public Stat ShotsFired { get { return Account.GetStat ( "class", "medic", "shotsFired" ); } }
                public Stat ShotsHit { get { return Account.GetStat ( "class", "medic", "shotsHit" ); } }
                public Stat ShotsAccuracy { get { return Account.GetStat ( "class", "medic", "shotsAccuracy" ); } }
                public Stat Score { get { return Account.GetStat ( "class", "medic", "score" ); } }
                public Stat ScorePerMinute { get { return Account.GetStat ( "class", "medic", "scorePerMinute" ); } }
            }
            public class Pilot : APIComponent
            {
                public Pilot ( Account account ) : base ( account ) { }

                public string ClassIconUrl { get { return Account.GetSegment ( "class", "pilot" ).Attributes [ "imageUrl" ]; } }

                public Stat Rank { get { return Account.GetStat ( "class", "pilot", "rank" ); } }
                public Stat Kills { get { return Account.GetStat ( "class", "pilot", "kills" ); } }
                public Stat Deaths { get { return Account.GetStat ( "class", "pilot", "deaths" ); } }
                public Stat KillsPerMinute { get { return Account.GetStat ( "class", "pilot", "killsPerMinute" ); } }
                public Stat KDRatio { get { return Account.GetStat ( "class", "pilot", "kdRatio" ); } }
                public Stat TimePlayed { get { return Account.GetStat ( "class", "pilot", "timePlayed" ); } }
                public Stat ShotsFired { get { return Account.GetStat ( "class", "pilot", "shotsFired" ); } }
                public Stat ShotsHit { get { return Account.GetStat ( "class", "pilot", "shotsHit" ); } }
                public Stat ShotsAccuracy { get { return Account.GetStat ( "class", "pilot", "shotsAccuracy" ); } }
                public Stat Score { get { return Account.GetStat ( "class", "pilot", "score" ); } }
                public Stat ScorePerMinute { get { return Account.GetStat ( "class", "pilot", "scorePerMinute" ); } }
            }
            public class Recon : APIComponent
            {
                public Recon ( Account account ) : base ( account ) { }

                public string ClassIconUrl { get { return Account.GetSegment ( "class", "recon" ).Attributes [ "imageUrl" ]; } }

                public Stat Rank { get { return Account.GetStat ( "class", "recon", "rank" ); } }
                public Stat Kills { get { return Account.GetStat ( "class", "recon", "kills" ); } }
                public Stat Deaths { get { return Account.GetStat ( "class", "recon", "deaths" ); } }
                public Stat KillsPerMinute { get { return Account.GetStat ( "class", "recon", "killsPerMinute" ); } }
                public Stat KDRatio { get { return Account.GetStat ( "class", "recon", "kdRatio" ); } }
                public Stat TimePlayed { get { return Account.GetStat ( "class", "recon", "timePlayed" ); } }
                public Stat ShotsFired { get { return Account.GetStat ( "class", "recon", "shotsFired" ); } }
                public Stat ShotsHit { get { return Account.GetStat ( "class", "recon", "shotsHit" ); } }
                public Stat ShotsAccuracy { get { return Account.GetStat ( "class", "recon", "shotsAccuracy" ); } }
                public Stat Score { get { return Account.GetStat ( "class", "recon", "score" ); } }
                public Stat ScorePerMinute { get { return Account.GetStat ( "class", "recon", "scorePerMinute" ); } }
            }
            public class Support : APIComponent
            {
                public Support ( Account account ) : base ( account ) { }

                public string ClassIconUrl { get { return Account.GetSegment ( "class", "support" ).Attributes [ "imageUrl" ]; } }

                public Stat Rank { get { return Account.GetStat ( "class", "support", "rank" ); } }
                public Stat Kills { get { return Account.GetStat ( "class", "support", "kills" ); } }
                public Stat Deaths { get { return Account.GetStat ( "class", "support", "deaths" ); } }
                public Stat KillsPerMinute { get { return Account.GetStat ( "class", "support", "killsPerMinute" ); } }
                public Stat KDRatio { get { return Account.GetStat ( "class", "support", "kdRatio" ); } }
                public Stat TimePlayed { get { return Account.GetStat ( "class", "support", "timePlayed" ); } }
                public Stat ShotsFired { get { return Account.GetStat ( "class", "support", "shotsFired" ); } }
                public Stat ShotsHit { get { return Account.GetStat ( "class", "support", "shotsHit" ); } }
                public Stat ShotsAccuracy { get { return Account.GetStat ( "class", "support", "shotsAccuracy" ); } }
                public Stat Score { get { return Account.GetStat ( "class", "support", "score" ); } }
                public Stat ScorePerMinute { get { return Account.GetStat ( "class", "support", "scorePerMinute" ); } }
            }
            public class Tanker : APIComponent
            {
                public Tanker ( Account account ) : base ( account ) { }

                public string ClassIconUrl { get { return Account.GetSegment ( "class", "tanker" ).Attributes [ "imageUrl" ]; } }

                public Stat Rank { get { return Account.GetStat ( "class", "tanker", "rank" ); } }
                public Stat Kills { get { return Account.GetStat ( "class", "tanker", "kills" ); } }
                public Stat Deaths { get { return Account.GetStat ( "class", "tanker", "deaths" ); } }
                public Stat KillsPerMinute { get { return Account.GetStat ( "class", "tanker", "killsPerMinute" ); } }
                public Stat KDRatio { get { return Account.GetStat ( "class", "tanker", "kdRatio" ); } }
                public Stat TimePlayed { get { return Account.GetStat ( "class", "tanker", "timePlayed" ); } }
                public Stat ShotsFired { get { return Account.GetStat ( "class", "tanker", "shotsFired" ); } }
                public Stat ShotsHit { get { return Account.GetStat ( "class", "tanker", "shotsHit" ); } }
                public Stat ShotsAccuracy { get { return Account.GetStat ( "class", "tanker", "shotsAccuracy" ); } }
                public Stat Score { get { return Account.GetStat ( "class", "tanker", "score" ); } }
                public Stat ScorePerMinute { get { return Account.GetStat ( "class", "tanker", "scorePerMinute" ); } }
            }
        }
    }
}
