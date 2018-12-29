using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_UseRiddleNode : W3SwitchEvent
{
#region RED Properties

[REDProp("riddleNodeTag")]
public CName RiddleNodeTag { get; set;}

#endregion
}
}