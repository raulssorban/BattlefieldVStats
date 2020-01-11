using BattlefieldV.Components;

namespace BattlefieldV.Components
{
    public class APIComponent
    {
        internal User Account { get; }

        public APIComponent ( User account ) { Account = account; }
    }
}