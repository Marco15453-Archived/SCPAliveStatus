using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace SCPAliveStatus.Events 
{
    internal sealed class PlayerHandler 
    {

        public void onDying(DyingEventArgs ev) 
        {
            if (!ev.Target.IsScp) return;

            if (SCPAliveStatus.Instance.Config.annoucement_roles.TryGetValue(ev.Target.Role, out bool value) && !value) return;

            ushort duration = SCPAliveStatus.Instance.Config.BroadcastDuration;
            var message = SCPAliveStatus.Instance.Config.BroadcastMessage.Replace("{SCP}", ev.Target.Role.ToString());

            foreach (Player scp in Player.Get(Team.SCP)) 
            {
                scp.Broadcast(duration, message, Broadcast.BroadcastFlags.Normal, false);
            }
        }
    }
}
