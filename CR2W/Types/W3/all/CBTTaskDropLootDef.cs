using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDropLootDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("delay")]
public float Delay { get; set;}

#endregion
}
}