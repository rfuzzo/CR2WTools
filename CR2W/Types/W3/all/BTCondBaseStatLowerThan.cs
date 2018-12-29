using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondBaseStatLowerThan : IBehTreeTask
{
#region RED Properties

[REDProp("checkedActor")]
public EStatOwner CheckedActor { get; set;}

[REDProp("baseStatType")]
public EBaseCharacterStats BaseStatType { get; set;}

[REDProp("statValue")]
public float StatValue { get; set;}

[REDProp("percentage")]
public bool Percentage { get; set;}

[REDProp("ifNot")]
public bool IfNot { get; set;}

#endregion
}
}