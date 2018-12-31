using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEnvSharpenParameters 
{
#region RED Properties

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("sharpenNear")]
public SSimpleCurve SharpenNear { get; set;}

[REDProp("sharpenFar")]
public SSimpleCurve SharpenFar { get; set;}

[REDProp("distanceNear")]
public SSimpleCurve DistanceNear { get; set;}

[REDProp("distanceFar")]
public SSimpleCurve DistanceFar { get; set;}

[REDProp("lumFilterOffset")]
public SSimpleCurve LumFilterOffset { get; set;}

[REDProp("lumFilterRange")]
public SSimpleCurve LumFilterRange { get; set;}

#endregion
}
}