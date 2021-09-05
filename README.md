# SCPAliveStatus
A plugin that adds a broadcast to all SCPs when one SCP dies

# Config
Name | Type | Description | Default
---- | ---- | ----------- | -------
is_enabled | bool | Is the plugin enabled? | true
broadcast_duration | ushort | The duration for how long the Broadcast will be shown | 3
broadcast_message | string | The Messsage that will be displayed for the SCP Team, when a SCP is no longer alive! {SCP} will be replaced with the SCPName | {SCP} is no longer alive!
annoucement_roles | Dictionary | What SCP Death Annoucement should be shown? | All true

# Default Config
```yml
s_c_p_alive_status:
  is_enabled: true
  # The duration for how long the Broadcast will be shown
  broadcast_duration: 3
  # The Messsage that will be displayed for the SCP Team, when a SCP is no longer alive! {SCP} will be replaced with the SCPName
  broadcast_message: {SCP} is no longer alive!
  # What SCP Death Annoucement should be shown?
  annoucement_roles:
    Scp106: true
    Scp096: true
    Scp173: true
    Scp93953: true
    Scp93989: true
    Scp079: true
```
