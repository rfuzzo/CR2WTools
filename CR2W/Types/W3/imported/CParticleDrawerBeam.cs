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
public class CParticleDrawerBeam : IParticleDrawer
{
#region RED Properties

[REDProp("texturesPerUnit")]
public float TexturesPerUnit { get; set;}

[REDProp("spread")]
public Ptr<IEvaluatorVector> Spread { get; set;}

[REDProp("numSegments")]
public UInt32 NumSegments { get; set;}

#endregion
}
}