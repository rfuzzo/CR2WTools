using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_KnockdownTypeApplicator : W3ApplicatorEffect
{
#region RED Properties

[REDProp("customEffectValue")]
public SAbilityAttributeValue CustomEffectValue { get; set;}

[REDProp("customDuration")]
public float CustomDuration { get; set;}

[REDProp("customAbilityName")]
public CName CustomAbilityName { get; set;}

#endregion
}
}