using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SDeckDefinition 
{
#region RED Properties

[REDProp("cardIndices")]
public Array<Int32> CardIndices { get; set;}

[REDProp("leaderIndex")]
public int LeaderIndex { get; set;}

[REDProp("unlocked")]
public bool Unlocked { get; set;}

[REDProp("specialCard")]
public int SpecialCard { get; set;}

[REDProp("dynamicCardRequirements")]
public Array<Int32> DynamicCardRequirements { get; set;}

[REDProp("dynamicCards")]
public Array<Int32> DynamicCards { get; set;}

#endregion
}
}