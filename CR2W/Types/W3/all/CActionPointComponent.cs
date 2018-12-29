using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CActionPointComponent : CWayPointComponent
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("isStreamed")]
public bool IsStreamed { get; set;}

[REDProp("isVisible")]
public bool IsVisible { get; set;}

[REDProp("icon")]
public Handle<CBitmapTexture> Icon { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("jobTreeRes")]
public Handle<CJobTree> JobTreeRes { get; set;}

[REDProp("actionBreakable")]
public bool ActionBreakable { get; set;}

[REDProp("breakableByCutscene")]
public bool BreakableByCutscene { get; set;}

[REDProp("preferredNextAPs")]
public TagList PreferredNextAPs { get; set;}

[REDProp("activateOnStart")]
public bool ActivateOnStart { get; set;}

[REDProp("placementImportance")]
public EWorkPlacementImportance PlacementImportance { get; set;}

[REDProp("ignoreCollosions")]
public bool IgnoreCollosions { get; set;}

[REDProp("disableSoftReactions")]
public bool DisableSoftReactions { get; set;}

[REDProp("fireSourceDependent")]
public bool FireSourceDependent { get; set;}

[REDProp("forceKeepIKactive")]
public bool ForceKeepIKactive { get; set;}

[REDProp("customWorkTree")]
public Ptr<CAIPerformCustomWorkTree> CustomWorkTree { get; set;}

[REDProp("eventWorkStarted")]
public Array<Ptr<IPerformableAction>> EventWorkStarted { get; set;}

[REDProp("eventWorkEnded")]
public Array<Ptr<IPerformableAction>> EventWorkEnded { get; set;}

#endregion
}
}