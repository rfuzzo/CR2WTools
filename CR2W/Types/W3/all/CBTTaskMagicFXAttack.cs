using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskMagicFXAttack : CBTTaskMagicAttack
{
#region RED Properties

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("effectEntityTemplate")]
public Handle<CEntityTemplate> EffectEntityTemplate { get; set;}

[REDProp("dealDmgOnDeactivate")]
public bool DealDmgOnDeactivate { get; set;}

[REDProp("couldntLoadResource")]
public bool CouldntLoadResource { get; set;}

#endregion
}
}