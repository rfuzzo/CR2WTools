using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CRewardGroup : CResource
{
#region RED Properties

[REDProp("rewards")]
public Array<SReward> Rewards { get; set;}

[REDProp("subGroups")]
public Array<Handle<CRewardGroup>> SubGroups { get; set;}

[REDProp("isSubGroup")]
public bool IsSubGroup { get; set;}

#endregion
}
}