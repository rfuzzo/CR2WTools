using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskIsFriendlyNearTarget : IBehTreeTask
{
#region RED Properties

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("considerOwnerAsFriendly")]
public bool ConsiderOwnerAsFriendly { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

#endregion
}
}