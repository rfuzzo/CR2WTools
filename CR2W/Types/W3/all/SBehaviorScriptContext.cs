using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBehaviorScriptContext 
{
#region RED Properties

[REDProp("poseLS")]
public Array<EngineQsTransform> PoseLS { get; set;}

[REDProp("poseMS")]
public Array<EngineQsTransform> PoseMS { get; set;}

[REDProp("floatTracks")]
public Array<float> FloatTracks { get; set;}

[REDProp("inputParamsF")]
public Array<float> InputParamsF { get; set;}

[REDProp("inputParamsV")]
public Array<Vector> InputParamsV { get; set;}

[REDProp("localParamsF")]
public Array<float> LocalParamsF { get; set;}

[REDProp("localParamsV")]
public Array<Vector> LocalParamsV { get; set;}

[REDProp("localParamsM")]
public Array<Matrix> LocalParamsM { get; set;}

[REDProp("localParamsT")]
public Array<EngineQsTransform> LocalParamsT { get; set;}

[REDProp("timeDelta")]
public float TimeDelta { get; set;}

[REDProp("visualDebug")]
public Ptr<CVisualDebug> VisualDebug { get; set;}

#endregion
}
}