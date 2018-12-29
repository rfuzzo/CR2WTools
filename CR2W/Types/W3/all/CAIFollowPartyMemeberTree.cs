using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIFollowPartyMemeberTree : CAIIdleTree
{
#region RED Properties

[REDProp("followPartyMember")]
public CName FollowPartyMember { get; set;}

[REDProp("followDistance")]
public float FollowDistance { get; set;}

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

#endregion
}
}