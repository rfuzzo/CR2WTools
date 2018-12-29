using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskIsEffectActiveDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("target")]
public Handle<CNewNPC> Target { get; set;}

[REDProp("effectName")]
public CName EffectName { get; set;}

#endregion
}
}