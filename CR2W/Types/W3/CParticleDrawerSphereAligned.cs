using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CParticleDrawerSphereAligned : IParticleDrawer
{
#region RED Properties

[REDProp("verticalFixed")]
public bool VerticalFixed { get; set;}

#endregion
}
}