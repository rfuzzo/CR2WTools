using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCustomApplyEffectAttack : CBTTaskAttack
{
#region RED Properties

[REDProp("applyEffectInterval")]
public float ApplyEffectInterval { get; set;}

[REDProp("activateOnAnimEvent")]
public CName ActivateOnAnimEvent { get; set;}

[REDProp("activationTimeStamp")]
public float ActivationTimeStamp { get; set;}

[REDProp("activated")]
public bool Activated { get; set;}

#endregion
}
}