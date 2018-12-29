using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_Tangled : W3ImmobilizeEffect
{
#region RED Properties

[REDProp("particleEnt")]
public Handle<W3VisualFx> ParticleEnt { get; set;}

#endregion
}
}