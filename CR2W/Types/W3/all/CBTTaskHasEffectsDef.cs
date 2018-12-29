using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHasEffectsDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("effects")]
public Array<EEffectType> Effects { get; set;}

#endregion
}
}