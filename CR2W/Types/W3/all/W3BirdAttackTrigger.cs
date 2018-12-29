using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3BirdAttackTrigger : CEntity
{
#region RED Properties

[REDProp("lair")]
public Handle<CFlyingSwarmMasterLair> Lair { get; set;}

[REDProp("affectedEntityTag")]
public CName AffectedEntityTag { get; set;}

[REDProp("attackRequestInterval")]
public float AttackRequestInterval { get; set;}

[REDProp("affectBirdsInRange")]
public float AffectBirdsInRange { get; set;}

#endregion
}
}