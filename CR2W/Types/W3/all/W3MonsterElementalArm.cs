using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MonsterElementalArm : CGameplayEntity
{
#region RED Properties

[REDProp("physcialComponent")]
public Handle<CComponent> PhyscialComponent { get; set;}

[REDProp("victims")]
public Array<Handle<CActor>> Victims { get; set;}

[REDProp("victim")]
public Handle<CActor> Victim { get; set;}

[REDProp("isActive")]
public bool IsActive { get; set;}

[REDProp("action")]
public Handle<W3DamageAction> Action { get; set;}

[REDProp("owner")]
public Handle<CActor> Owner { get; set;}

[REDProp("component")]
public Handle<CMeshComponent> Component { get; set;}

#endregion
}
}