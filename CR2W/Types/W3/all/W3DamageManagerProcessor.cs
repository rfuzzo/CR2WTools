using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DamageManagerProcessor : CObject
{
#region RED Properties

[REDProp("playerAttacker")]
public Handle<CR4Player> PlayerAttacker { get; set;}

[REDProp("playerVictim")]
public Handle<CR4Player> PlayerVictim { get; set;}

[REDProp("action")]
public Handle<W3DamageAction> Action { get; set;}

[REDProp("attackAction")]
public Handle<W3Action_Attack> AttackAction { get; set;}

[REDProp("weaponId")]
public SItemUniqueId WeaponId { get; set;}

[REDProp("actorVictim")]
public Handle<CActor> ActorVictim { get; set;}

[REDProp("actorAttacker")]
public Handle<CActor> ActorAttacker { get; set;}

[REDProp("dm")]
public Handle<CDefinitionsManagerAccessor> Dm { get; set;}

[REDProp("attackerMonsterCategory")]
public EMonsterCategory AttackerMonsterCategory { get; set;}

[REDProp("victimMonsterCategory")]
public EMonsterCategory VictimMonsterCategory { get; set;}

[REDProp("victimCanBeHitByFists")]
public bool VictimCanBeHitByFists { get; set;}

#endregion
}
}