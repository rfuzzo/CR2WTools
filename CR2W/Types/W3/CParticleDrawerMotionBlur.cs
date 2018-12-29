using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CParticleDrawerMotionBlur : IParticleDrawer
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