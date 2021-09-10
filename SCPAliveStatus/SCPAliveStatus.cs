using System;
using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using SCPAliveStatus.Events;

namespace SCPAliveStatus 
{
    public class SCPAliveStatus : Plugin<Config> 
    {
        internal static SCPAliveStatus Instance { get; private set; }

        public override string Author => "Marco15453";
        public override string Name => "SCPAliveStatus";
        public override Version Version => new Version(1, 2, 0);
        public override Version RequiredExiledVersion => new Version(3, 0, 0);

        private PlayerHandler playerHandler;

        public override void OnEnabled() 
        {
            Instance = this;
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled() 
        {
            UnregisterEvents();
            base.OnDisabled();
        }

        private void RegisterEvents() 
        {
            playerHandler = new PlayerHandler();

            // Player
            Exiled.Events.Handlers.Player.Dying += playerHandler.onDying;
        }

        private void UnregisterEvents() 
        {

            // Player
            Exiled.Events.Handlers.Player.Dying -= playerHandler.onDying;

            playerHandler = null;
        }
    }
}
