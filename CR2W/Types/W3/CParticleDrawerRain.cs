using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CParticleDrawerRain : IParticleDrawer
{
#region RED Properties

[REDProp("stretchPerVelocity")]
public float StretchPerVelocity { get; set;}

[REDProp("blendStartVelocity")]
public float BlendStartVelocity { get; set;}

[REDProp("blendEndVelocity")]
public float BlendEndVelocity { get; set;}

#endregion
}
}