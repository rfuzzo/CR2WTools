using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCastSign : CBTTaskAttack
{
#region RED Properties

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("signEntity")]
public Handle<W3SignEntity> SignEntity { get; set;}

[REDProp("action")]
public Handle<W3DamageAction> Action { get; set;}

[REDProp("signType")]
public ESignType SignType { get; set;}

[REDProp("attackRangeName")]
public CName AttackRangeName { get; set;}

[REDProp("signOwner")]
public Handle<W3SignOwnerBTTaskCastSign> SignOwner { get; set;}

#endregion
}
}