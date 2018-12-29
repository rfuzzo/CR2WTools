using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3CombatDamageEntity : CInteractiveEntity
{
#region RED Properties

[REDProp("victims")]
public Array<Handle<CActor>> Victims { get; set;}

[REDProp("victim")]
public Handle<CActor> Victim { get; set;}

[REDProp("isActive")]
public bool IsActive { get; set;}

#endregion
}
}