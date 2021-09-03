using System;
using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using SCPAliveStatus.Events;

namespace SCPAliveStatus {
    public class SCPAliveStatus : Plugin<Config> {
        internal static SCPAliveStatus Instance { get; private set; }

        private PlayerHandler playerHandler;

        public override void OnEnabled() {
            Instance = this;
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled() {
            UnregisterEvents();
            base.OnDisabled();
        }

        private void RegisterEvents() {
            playerHandler = new PlayerHandler();

            // Player
            Exiled.Events.Handlers.Player.Dying += playerHandler.onDying;
        }

        private void UnregisterEvents() {

            // Player
            Exiled.Events.Handlers.Player.Dying -= playerHandler.onDying;

            playerHandler = null;
        }
    }
}
