using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskSetAdditiveHitFlagDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onAnimEvent")]
public CName OnAnimEvent { get; set;}

[REDProp("flag")]
public bool Flag { get; set;}

[REDProp("additiveHits")]
public bool AdditiveHits { get; set;}

[REDProp("additiveCriticalStates")]
public bool AdditiveCriticalStates { get; set;}

[REDProp("overrideOnly")]
public bool OverrideOnly { get; set;}

[REDProp("playNormalHitOnCritical")]
public bool PlayNormalHitOnCritical { get; set;}

#endregion
}
}