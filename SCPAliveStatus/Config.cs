using Exiled.API.Interfaces;
using System.ComponentModel;

namespace SCPAliveStatus {
    public sealed class Config : IConfig {
        public bool IsEnabled { get; set; } = true;

        [Description("The duration for how long the Broadcast will be shown")]
        public ushort BroadcastDuration { get; set; } = 3;

        [Description("The Messsage that will be displayed for the SCP Team, when a SCP is no longer alive! {SCP} will be replaced with the SCPName")]
        public string BroadcastMessage { get; set; } = "<color=red>{SCP}</color> <color=aqua>is no longer alive! {Team}</color>";

        [Description("What SCP Death Annoucement should be enabled?")]
        public bool scp_106 { get; set; } = true;
        public bool scp_096 { get; set; } = true;
        public bool scp_173 { get; set; } = true;
        public bool scp_939_53 { get; set; } = true;
        public bool scp_939_89 { get; set; } = true;
        public bool scp_079 { get; set; } = true;
    }
}
