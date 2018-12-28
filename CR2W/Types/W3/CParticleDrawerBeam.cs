using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CParticleDrawerBeam : IParticleDrawer
{
#region RED Properties

[REDProp("texturesPerUnit")]
public float TexturesPerUnit { get; set;}

[REDProp("spread")]
public Ptr<IEvaluatorVector> Spread { get; set;}

[REDProp("numSegments")]
public uint NumSegments { get; set;}

#endregion
}
}