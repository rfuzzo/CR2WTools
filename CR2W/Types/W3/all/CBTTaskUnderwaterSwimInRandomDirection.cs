using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskUnderwaterSwimInRandomDirection : CBTTaskVolumetricMove
{
#region RED Properties

[REDProp("stayInGuardArea")]
public bool StayInGuardArea { get; set;}

[REDProp("maxProximityToSurface")]
public float MaxProximityToSurface { get; set;}

[REDProp("minimumWaterDepth")]
public float MinimumWaterDepth { get; set;}

[REDProp("randomizeDirectionDelay")]
public SRangeF RandomizeDirectionDelay { get; set;}

[REDProp("m_destinationDistance")]
public float M_destinationDistance { get; set;}

#endregion
}
}