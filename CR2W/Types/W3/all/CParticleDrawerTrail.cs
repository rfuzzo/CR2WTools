using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CParticleDrawerTrail : IParticleDrawer
{
#region RED Properties

[REDProp("texturesPerUnit")]
public float TexturesPerUnit { get; set;}

[REDProp("dynamicTexCoords")]
public bool DynamicTexCoords { get; set;}

[REDProp("minSegmentsPer360Degrees")]
public int MinSegmentsPer360Degrees { get; set;}

#endregion
}
}