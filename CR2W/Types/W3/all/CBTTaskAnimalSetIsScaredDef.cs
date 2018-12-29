using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskAnimalSetIsScaredDef : IBehTreeHorseTaskDefinition
{
#region RED Properties

[REDProp("value")]
public bool Value { get; set;}

[REDProp("setOnDeactivate")]
public bool SetOnDeactivate { get; set;}

#endregion
}
}