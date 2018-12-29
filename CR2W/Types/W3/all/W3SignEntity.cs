using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SignEntity : CGameplayEntity
{
#region RED Properties

[REDProp("owner")]
public Handle<W3SignOwner> Owner { get; set;}

[REDProp("attachedTo")]
public Handle<CEntity> AttachedTo { get; set;}

[REDProp("boneIndex")]
public Int32 BoneIndex { get; set;}

[REDProp("fireMode")]
public Int32 FireMode { get; set;}

[REDProp("skillEnum")]
public ESkill SkillEnum { get; set;}

[REDProp("signType")]
public ESignType SignType { get; set;}

[REDProp("actionBuffs")]
public Array<SEffectInfo> ActionBuffs { get; set;}

[REDProp("friendlyCastEffect")]
public CName FriendlyCastEffect { get; set;}

[REDProp("cachedCost")]
public float CachedCost { get; set;}

[REDProp("usedFocus")]
public bool UsedFocus { get; set;}

#endregion
}
}