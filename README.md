# SCPAliveStatus
A plugin that adds a broadcast to all SCPs when one SCP dies

# Config
Name | Type | Description | Default
---- | ---- | ----------- | -------
is_enabled | bool | Is the plugin enabled? | true
broadcast_duration | ushort | The duration for how long the Broadcast will be shown | 3
broadcast_message | string | The Messsage that will be displayed for the SCP Team, when a SCP is no longer alive! {SCP} will be replaced with the SCPName | {SCP} is no longer alive!
scp_106 | bool | What SCP Death Annoucement should be shown? | true
scp_096 | bool | // | true
scp_173 | bool | // | true
scp_939_53 | bool | // | true
scp_939_89 | bool | // | true
scp_079 | bool | // | true

# Default Config
```yml
s_c_p_alive_status:
  is_enabled: true
  # The duration for how long the Broadcast will be shown
  broadcast_duration: 3
  # The Messsage that will be displayed for the SCP Team, when a SCP is no longer alive! {SCP} will be replaced with the SCPName
  broadcast_message: {SCP} is no longer alive!
  # What SCP Death Annoucement should be shown?
  scp_106: true
  scp_096: true
  scp_173: true
  scp_939_53: true
  scp_939_89: true
  scp_079: true
```