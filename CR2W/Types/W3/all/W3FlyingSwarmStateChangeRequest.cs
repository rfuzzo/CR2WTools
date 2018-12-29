using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FlyingSwarmStateChangeRequest : CObject
{
#region RED Properties

[REDProp("groupId")]
public CFlyingGroupId GroupId { get; set;}

[REDProp("stateName")]
public CName StateName { get; set;}

#endregion
}
}