using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CQCHasAbility : IActorConditionType
{
#region RED Properties

[REDProp("inverted")]
public bool Inverted { get; set;}

[REDProp("ability")]
public CName Ability { get; set;}

#endregion
}
}