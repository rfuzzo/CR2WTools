using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CCurveEntitySpawner : CObject
{
#region RED Properties

[REDProp("density")]
public uint Density { get; set;}

[REDProp("variation")]
public float Variation { get; set;}

[REDProp("templateWeights")]
public Array<SEntityWeight> TemplateWeights { get; set;}

#endregion
}
}