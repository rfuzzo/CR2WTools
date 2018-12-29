using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CQCAttitude : IActorConditionType
{
#region RED Properties

[REDProp("inverted")]
public bool Inverted { get; set;}

[REDProp("attitude")]
public EAIAttitude Attitude { get; set;}

#endregion
}
}