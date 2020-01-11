namespace BattlefieldV.Components
{
    public class Stat
    {
        public string ShortName { get; set; }

        public string DisplayName { get; set; }
        public string DisplayCategory { get; set; }
        public string Category { get; set; }

        public float Value { get; set; }
        public float Percentile { get; set; }

        public string DisplayValue { get; set; }
        public string DisplayType { get; set; }
    }
}
