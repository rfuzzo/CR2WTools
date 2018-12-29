using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHorseSheathWeaponsForRider : IBehTreeTask
{
#region RED Properties

[REDProp("processLeftItem")]
public bool ProcessLeftItem { get; set;}

[REDProp("processRightItem")]
public bool ProcessRightItem { get; set;}

[REDProp("rider")]
public Handle<CActor> Rider { get; set;}

#endregion
}
}