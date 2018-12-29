using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SCutsceneActorOverrideMapping 
{
#region RED Properties

[REDProp("actorName")]
public string ActorName { get; set;}

[REDProp("cutsceneActorDef")]
public SCutsceneActorDef CutsceneActorDef { get; set;}

#endregion
}
}