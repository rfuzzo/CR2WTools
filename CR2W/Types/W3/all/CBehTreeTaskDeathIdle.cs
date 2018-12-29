using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskDeathIdle : IBehTreeTask
{
#region RED Properties

[REDProp("setAppearanceTo")]
public CName SetAppearanceTo { get; set;}

[REDProp("changeAppearanceAfter")]
public float ChangeAppearanceAfter { get; set;}

[REDProp("disableRagdollAfter")]
public float DisableRagdollAfter { get; set;}

[REDProp("disableCollision")]
public bool DisableCollision { get; set;}

[REDProp("disableCollisionDelay")]
public float DisableCollisionDelay { get; set;}

[REDProp("tag")]
public Array<CName> Tag { get; set;}

[REDProp("timeStamp")]
public float TimeStamp { get; set;}

#endregion
}
}