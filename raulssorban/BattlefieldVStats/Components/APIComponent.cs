using BattlefieldV.Components;

namespace BattlefieldV.Components
{
    public class APIComponent
    {
        internal Account Account { get; }

        public APIComponent ( Account account ) { Account = account; }
    }
}
