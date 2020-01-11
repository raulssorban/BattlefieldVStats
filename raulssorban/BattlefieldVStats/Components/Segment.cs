using System.Collections.Generic;
using System.Linq;

namespace BattlefieldV.Components
{
    public class Segment
    {
        public string Type { get; set; }
        public Dictionary<string, string> Attributes { get; set; } = new Dictionary<string, string> ();
        public List<Stat> Stats { get; set; } = new List<Stat> ();

        public Stat GetStat ( string shortName )
        {
            return Stats.FirstOrDefault ( x => x.ShortName == shortName );
        }
    }
}
