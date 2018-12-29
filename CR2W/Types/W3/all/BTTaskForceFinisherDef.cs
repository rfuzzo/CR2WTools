using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskForceFinisherDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("belowHealthPercent")]
public float BelowHealthPercent { get; set;}

[REDProp("whenAlone")]
public bool WhenAlone { get; set;}

[REDProp("leftStanceFinisherAnimName")]
public CName LeftStanceFinisherAnimName { get; set;}

[REDProp("rightStanceFinisherAnimName")]
public CName RightStanceFinisherAnimName { get; set;}

[REDProp("shouldCheckForFinisherDLC")]
public bool ShouldCheckForFinisherDLC { get; set;}

[REDProp("hasFinisherDLC")]
public bool HasFinisherDLC { get; set;}

#endregion
}
}