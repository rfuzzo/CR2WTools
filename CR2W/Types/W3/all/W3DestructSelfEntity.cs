using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DestructSelfEntity : CGameplayEntity
{
#region RED Properties

[REDProp("destructAfterDelay")]
public float DestructAfterDelay { get; set;}

[REDProp("stopEffectDuration")]
public float StopEffectDuration { get; set;}

[REDProp("effectToStop")]
public CName EffectToStop { get; set;}

#endregion
}
}