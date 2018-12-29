using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskAddBuffsDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("buffs")]
public Array<EEffectType> Buffs { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("customValue")]
public SAbilityAttributeValue CustomValue { get; set;}

#endregion
}
}