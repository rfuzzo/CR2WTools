using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskRaiseEventOnEntityDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("entityTag")]
public CName EntityTag { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("forceEvent")]
public bool ForceEvent { get; set;}

[REDProp("maxDistFromNpc")]
public float MaxDistFromNpc { get; set;}

[REDProp("raiseSameEventOnOwner")]
public bool RaiseSameEventOnOwner { get; set;}

#endregion
}
}