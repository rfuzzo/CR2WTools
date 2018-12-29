using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3LocationArea : CGameplayEntity
{
#region RED Properties

[REDProp("locationNameKey")]
public CName LocationNameKey { get; set;}

[REDProp("rewardName")]
public CName RewardName { get; set;}

[REDProp("discovered")]
public bool Discovered { get; set;}

#endregion
}
}