using Exiled.API.Interfaces;
using System.ComponentModel;
using System.Collections.Generic;

namespace SCPAliveStatus 
{
    public sealed class Config : IConfig 
    {
        [Description("Should the plugin be enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("The duration for how long the Broadcast will be shown")]
        public ushort BroadcastDuration { get; set; } = 3;

        [Description("The Messsage that will be displayed for the SCP Team, when a SCP is no longer alive! {SCP} will be replaced with the SCPName")]
        public string BroadcastMessage { get; set; } = "{SCP} is no longer alive!";

        [Description("What SCP Death Annoucement should be shown?")]
        public Dictionary<RoleType, bool> annoucement_roles { get; set; } = new Dictionary<RoleType, bool> 
        {
            { RoleType.Scp106, true},
            { RoleType.Scp096, true},
            { RoleType.Scp173, true},
            { RoleType.Scp93953, true},
            { RoleType.Scp93989, true},
            { RoleType.Scp079, true},
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true }
        };
    }
}
