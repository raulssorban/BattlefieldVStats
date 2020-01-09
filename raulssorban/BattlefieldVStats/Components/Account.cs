using System.Collections.Generic;
using System.Linq;

namespace BattlefieldV.Components
{
    public class Account
    {
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
                if ( !string.IsNullOrEmpty ( attribute ) )
                    return x.Type.ToLower () == type.ToLower () && x.Attributes.Any ( y => y.Value.ToLower () == attribute?.ToLower () );
                else
                    return x.Type.ToLower () == type.ToLower ();
            } );
        }

        public Stat GetStat ( string segmentType, string segmentAttribute, string shortName )
        {
            return GetSegment ( segmentType, segmentAttribute ).Stats.FirstOrDefault ( x => x.ShortName.ToLower () == shortName.ToLower () );
        }
    }
}
