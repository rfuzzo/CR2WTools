using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMajorPlaceOfPowerEntity : CInteractiveEntity
{
#region RED Properties

[REDProp("interactionComponent")]
public Handle<CInteractionComponent> InteractionComponent { get; set;}

[REDProp("buffType")]
public EShrineBuffs BuffType { get; set;}

[REDProp("buffUniqueName")]
public string BuffUniqueName { get; set;}

[REDProp("fxOnIdle")]
public CName FxOnIdle { get; set;}

[REDProp("fxOnChannel")]
public CName FxOnChannel { get; set;}

[REDProp("fxOnSuccess")]
public CName FxOnSuccess { get; set;}

[REDProp("channelingTime")]
public float ChannelingTime { get; set;}

[REDProp("buffDuration")]
public float BuffDuration { get; set;}

[REDProp("buffCooldown")]
public GameTime BuffCooldown { get; set;}

[REDProp("skillPointGranted")]
public bool SkillPointGranted { get; set;}

[REDProp("isRecharging")]
public bool IsRecharging { get; set;}

[REDProp("lastUsed")]
public GameTime LastUsed { get; set;}

[REDProp("isPlaceOfPowerInIdle")]
public bool IsPlaceOfPowerInIdle { get; set;}

[REDProp("voicesetTimestamp")]
public GameTime VoicesetTimestamp { get; set;}

[REDProp("initialVoicesetPlayed")]
public bool InitialVoicesetPlayed { get; set;}

#endregion
}
}