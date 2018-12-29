using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageAnimatedMovement : IBehTreeTask
{
#region RED Properties

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("flag")]
public bool Flag { get; set;}

#endregion
}
}