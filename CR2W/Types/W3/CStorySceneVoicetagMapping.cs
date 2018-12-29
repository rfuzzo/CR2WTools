using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CStorySceneVoicetagMapping 
{
#region RED Properties

[REDProp("voicetag")]
public CName Voicetag { get; set;}

[REDProp("mustUseContextActor")]
public bool MustUseContextActor { get; set;}

[REDProp("invulnerable")]
public bool Invulnerable { get; set;}

[REDProp("actorOptional")]
public bool ActorOptional { get; set;}

#endregion
}
}