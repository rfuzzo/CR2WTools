using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CFlyingSwarmScriptInput : CObject
{
#region RED Properties

[REDProp("groupList")]
public Array<CFlyingSwarmGroup> GroupList { get; set;}

#endregion
}
}