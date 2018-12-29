using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskDeathIdleDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("setAppearanceTo")]
public CBehTreeValCName SetAppearanceTo { get; set;}

[REDProp("changeAppearanceAfter")]
public CBehTreeValFloat ChangeAppearanceAfter { get; set;}

[REDProp("disableCollision")]
public CBehTreeValBool DisableCollision { get; set;}

[REDProp("disableCollisionDelay")]
public CBehTreeValFloat DisableCollisionDelay { get; set;}

[REDProp("disableRagdollAfter")]
public CBehTreeValFloat DisableRagdollAfter { get; set;}

#endregion
}
}