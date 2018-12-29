using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SStorySceneGameplayActionCallbackInfo 
{
#region RED Properties

[REDProp("outChangeItems")]
public bool OutChangeItems { get; set;}

[REDProp("outDontUseSceneTeleport")]
public bool OutDontUseSceneTeleport { get; set;}

[REDProp("inActorPosition")]
public Vector InActorPosition { get; set;}

[REDProp("inActorHeading")]
public Vector InActorHeading { get; set;}

[REDProp("inGameplayAction")]
public int InGameplayAction { get; set;}

[REDProp("inActor")]
public Handle<CActor> InActor { get; set;}

#endregion
}
}