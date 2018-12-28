using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CDropPhysicsSetup : CObject
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("particles")]
public Soft<CParticleSystem> Particles { get; set;}

[REDProp("curves")]
public Array<SDropPhysicsCurves> Curves { get; set;}

#endregion
}
}