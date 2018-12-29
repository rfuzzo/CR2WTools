using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CThrowableStateAiming : CScriptableState
{
#region RED Properties

[REDProp("stopAiming")]
public bool StopAiming { get; set;}

[REDProp("collisionGroupsNames")]
public Array<CName> CollisionGroupsNames { get; set;}

#endregion
}
}