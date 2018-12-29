using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SCutsceneActorDef 
{
#region RED Properties

[REDProp("name")]
public string Name { get; set;}

[REDProp("tag")]
public TagList Tag { get; set;}

[REDProp("voiceTag")]
public CName VoiceTag { get; set;}

[REDProp("template")]
public Soft<CEntityTemplate> Template { get; set;}

[REDProp("appearance")]
public CName Appearance { get; set;}

[REDProp("type")]
public ECutsceneActorType Type { get; set;}

[REDProp("finalPosition")]
public TagList FinalPosition { get; set;}

[REDProp("killMe")]
public bool KillMe { get; set;}

[REDProp("useMimic")]
public bool UseMimic { get; set;}

[REDProp("animationAtFinalPosition")]
public CName AnimationAtFinalPosition { get; set;}

#endregion
}
}