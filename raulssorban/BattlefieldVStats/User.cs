using Humanlights.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BattlefieldV.Components
{
    public class User
    {
        public static User Fetch ( string handle, Platforms platform = Platforms.Origin )
        {
            var client = new WebClient ();
            var accountPlatformUrl = platform == User.Platforms.Origin ? "origin" : platform == User.Platforms.XBox ? "xbl" : platform == User.Platforms.PlayStation ? "psn" : "";
            var data = client.DownloadString ( $"https://api.tracker.gg/api/v2/bfv/standard/profile/{accountPlatformUrl}/{handle}" );
            var jObject = JsonConvert.DeserializeObject ( data ) as JObject;

            return Parse ( new User (), jObject );
        }
        public static async Task<User> FetchAsync ( string handle, Platforms platform = Platforms.Origin )
        {
            var client = new WebClient ();
            var accountPlatformUrl = platform == User.Platforms.Origin ? "origin" : platform == User.Platforms.XBox ? "xbl" : platform == User.Platforms.PlayStation ? "psn" : "";
            var data = await client.DownloadStringTaskAsync ( new System.Uri ( $"https://api.tracker.gg/api/v2/bfv/standard/profile/{accountPlatformUrl}/{handle}" ) );
            var jObject = JsonConvert.DeserializeObject ( data ) as JObject;

            return Parse ( new User (), jObject );
        }

        private static User Parse ( User user, JObject jObject )
        {
            var root = jObject [ "data" ];
            var userInfo = root [ "userInfo" ];
            var platform = root [ "platformInfo" ];
            var segments = root [ "segments" ];

            #region Parsing

            //
            // Platform IDs:
            //      Origin      = 5 = origin
            //      Playstation = 2 = psn
            //      XBox        = 1 = xbl
            //
            switch ( platform [ "platformSlug" ].ToString () )
            {
                case "origin":
                    user.Platform = User.Platforms.Origin;
                    break;
                case "xbl":
                    user.Platform = User.Platforms.XBox;
                    break;
                case "psn":
                    user.Platform = User.Platforms.PlayStation;
                    break;
            }

            user.Handle = platform [ "platformUserHandle" ].ToString ();
            user.Identifier = platform [ "platformUserIdentifier" ].ToString ();
            user.AvatarUrl = platform [ "avatarUrl" ].ToString ();
            user.CountryCode = userInfo [ "countryCode" ].ToString ();

            user.IsPremium = userInfo [ "isPremium" ].ToString ().ToBool ();
            user.IsVerified = userInfo [ "isVerified" ].ToString ().ToBool ();
            user.IsInfluencer = userInfo [ "isInfluencer" ].ToString ().ToBool ();

            foreach ( var segment in segments )
            {
                var newSegment = new Segment ();
                {
                    newSegment.Type = segment [ "type" ].ToString ();

                    foreach ( var attribute in segment [ "attributes" ].Children () )
                    {
                        newSegment.Attributes.Add ( attribute.ToString ().Split ( ':' ) [ 0 ].Replace ( "\"", "" ), attribute.ToList () [ 0 ].ToString () );
                    }

                    foreach ( var metadata in segment [ "metadata" ].Children () )
                    {
                        newSegment.Attributes.Add ( metadata.ToString ().Split ( ':' ) [ 0 ].Replace ( "\"", "" ), metadata.ToList () [ 0 ].ToString () );
                    }

                    foreach ( var stat in segment [ "stats" ].Children () )
                    {
                        var newStat = new Stat ();
                        {
                            newStat.ShortName = stat.ToString ().Split ( '\n' ) [ 0 ].Replace ( "\"", "" ).Replace ( ": {", "" ).Trim ();

                            newStat.DisplayName = stat.First [ "displayName" ].ToString ();
                            newStat.DisplayCategory = stat.First [ "displayCategory" ].ToString ();
                            newStat.Category = stat.First [ "category" ].ToString ();

                            newStat.Value = stat.First [ "value" ].ToString ().ToFloat ();
                            newStat.Percentile = stat.First [ "percentile" ].ToString ().ToFloat ();

                            newStat.DisplayValue = stat.First [ "displayValue" ].ToString ();
                            newStat.DisplayType = stat.First [ "displayCategory" ].ToString ();
                        }
                        newSegment.Stats.Add ( newStat );
                    }
                }
                user.Segments.Add ( newSegment );
            }

            #endregion

            return user;
        }

        public enum Platforms
        {
            Origin,
            XBox,
            PlayStation
        }

        public string Handle { get; set; }
        public string Identifier { get; set; }
        public string AvatarUrl { get; set; }
        public string CountryCode { get; set; }
        public Platforms Platform { get; set; }

        public bool IsPremium { get; set; }
        public bool IsVerified { get; set; }
        public bool IsInfluencer { get; set; }

        public List<Segment> Segments { get; set; } = new List<Segment> ();

        public Segment GetSegment ( string type, string attribute )
        {
            return Segments.FirstOrDefault ( ( x ) =>
            {
                if ( !string.IsNullOrEmpty ( attribute ) && x.Attributes.Count > 0 )
                    return x.Type.ToLower ().Trim () == type.ToLower ().Trim () &&
                           x.Attributes.ToList ().Any ( y => y.Value.ToLower ().Trim () == attribute?.ToLower ().Trim () );
                else
                    return x.Type.ToLower ().Trim () == type.ToLower ().Trim ();
            } );
        }

        public Stat GetStat ( string segmentType, string segmentAttribute, string shortName )
        {
            var stat = GetSegment ( segmentType, segmentAttribute )?.Stats?.FirstOrDefault ( x => x.ShortName.ToLower ().Trim () == shortName.ToLower ().Trim () );

            if ( string.IsNullOrEmpty ( stat.DisplayValue ) ) stat.DisplayValue = "None";
            if ( string.IsNullOrEmpty ( stat.DisplayType ) ) stat.DisplayType = "None";
            if ( string.IsNullOrEmpty ( stat.DisplayCategory ) ) stat.DisplayCategory = "None";
            if ( string.IsNullOrEmpty ( stat.Category ) ) stat.Category = "None";

            return stat;
        }
    }
}
