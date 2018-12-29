using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAICommunityRedefinitionParameters : CAIIdleRedefinitionParameters
{
#region RED Properties

[REDProp("useDefaultIdleBehaviors")]
public bool UseDefaultIdleBehaviors { get; set;}

[REDProp("canFlyInIdle")]
public bool CanFlyInIdle { get; set;}

#endregion
}
}