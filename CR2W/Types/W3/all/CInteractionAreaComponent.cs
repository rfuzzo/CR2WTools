using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CInteractionAreaComponent : CComponent
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

[REDProp("rangeMin")]
public float RangeMin { get; set;}

[REDProp("rangeMax")]
public float RangeMax { get; set;}

[REDProp("rangeAngle")]
public uint RangeAngle { get; set;}

[REDProp("height")]
public float Height { get; set;}

[REDProp("isPlayerOnly")]
public bool IsPlayerOnly { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("manualTestingOnly")]
public bool ManualTestingOnly { get; set;}

[REDProp("checkLineOfSight")]
public bool CheckLineOfSight { get; set;}

[REDProp("alwaysVisibleRange")]
public float AlwaysVisibleRange { get; set;}

[REDProp("lineOfSightOffset")]
public Vector LineOfSightOffset { get; set;}

[REDProp("performScriptedTest")]
public bool PerformScriptedTest { get; set;}

#endregion
}
}