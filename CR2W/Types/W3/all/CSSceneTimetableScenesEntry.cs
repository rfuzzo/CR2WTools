using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSSceneTimetableScenesEntry 
{
#region RED Properties

[REDProp("storyScene")]
public Handle<CStoryScene> StoryScene { get; set;}

[REDProp("sceneInputSection")]
public string SceneInputSection { get; set;}

[REDProp("cooldownTime")]
public float CooldownTime { get; set;}

[REDProp("weight")]
public float Weight { get; set;}

[REDProp("priority")]
public EArbitratorPriorities Priority { get; set;}

[REDProp("forceMode")]
public EStorySceneForcingMode ForceMode { get; set;}

#endregion
}
}