using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskManageRepulseProjectileEvents : IBehTreeTask
{
#region RED Properties

[REDProp("performRepulseProjectileDelay")]
public float PerformRepulseProjectileDelay { get; set;}

[REDProp("ownerPosition")]
public Vector OwnerPosition { get; set;}

#endregion
}
}