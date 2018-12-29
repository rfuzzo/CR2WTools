using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskTauntDef : CBTTaskPlayAnimationEventDecoratorDef
{
#region RED Properties

[REDProp("tauntType")]
public ETauntType TauntType { get; set;}

[REDProp("tauntDelay")]
public float TauntDelay { get; set;}

[REDProp("useXMLTauntChance")]
public bool UseXMLTauntChance { get; set;}

#endregion
}
}