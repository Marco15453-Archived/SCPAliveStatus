using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace SCPAliveStatus.Events {
    internal sealed class PlayerHandler {

        public void onDying(DyingEventArgs ev) {
            if(ev.Target.IsScp) {
                var target_scp = ev.Target.Role;

                Log.Info(target_scp);

                if (target_scp == RoleType.Scp106 && SCPAliveStatus.Instance.Config.scp_106 == false) return;
                if (target_scp == RoleType.Scp096 && SCPAliveStatus.Instance.Config.scp_096 == false) return;
                if (target_scp == RoleType.Scp173 && SCPAliveStatus.Instance.Config.scp_173 == false) return;
                if (target_scp == RoleType.Scp93953 && SCPAliveStatus.Instance.Config.scp_939_53 == false) return;
                if (target_scp == RoleType.Scp93989 && SCPAliveStatus.Instance.Config.scp_939_89 == false) return;
                if (target_scp == RoleType.Scp079 && SCPAliveStatus.Instance.Config.scp_079 == false) return;


                ushort duration = SCPAliveStatus.Instance.Config.BroadcastDuration;
                var message = SCPAliveStatus.Instance.Config.BroadcastMessage.Replace("{SCP}", ev.Target.Role.ToString());

                foreach(Player scp in Player.Get(Team.SCP)) {
                    scp.Broadcast(duration, message, Broadcast.BroadcastFlags.Normal, false);
                }
            }
        }
    }
}
