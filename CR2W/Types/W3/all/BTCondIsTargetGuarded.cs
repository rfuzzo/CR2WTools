using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondIsTargetGuarded : IBehTreeTask
{
#region RED Properties

[REDProp("longerThan")]
public float LongerThan { get; set;}

[REDProp("timeStamp")]
public float TimeStamp { get; set;}

[REDProp("guardedRegistered")]
public bool GuardedRegistered { get; set;}

#endregion
}
}