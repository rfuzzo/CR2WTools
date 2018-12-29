using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskUnderwaterSwimAroundTarget : CBTTaskVolumetricMove
{
#region RED Properties

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("frontalHeadingOffset")]
public Int32 FrontalHeadingOffset { get; set;}

[REDProp("randomFactor")]
public Int32 RandomFactor { get; set;}

[REDProp("randomHeightAmplitude")]
public float RandomHeightAmplitude { get; set;}

[REDProp("minimumWaterDepth")]
public float MinimumWaterDepth { get; set;}

[REDProp("useActionTarget")]
public bool UseActionTarget { get; set;}

[REDProp("maxProximityToSurface")]
public float MaxProximityToSurface { get; set;}

#endregion
}
}