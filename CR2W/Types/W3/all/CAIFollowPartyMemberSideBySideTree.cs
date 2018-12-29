using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIFollowPartyMemberSideBySideTree : CAIFollowPartyMemeberTree
{
#region RED Properties

[REDProp("useCustomSteeringGraph")]
public bool UseCustomSteeringGraph { get; set;}

[REDProp("customSteeringGraph")]
public Handle<CMoveSteeringBehavior> CustomSteeringGraph { get; set;}

#endregion
}
}