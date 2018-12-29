using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Action_Attack : W3DamageAction
{
#region RED Properties

[REDProp("weaponId")]
public SItemUniqueId WeaponId { get; set;}

[REDProp("crossbowId")]
public SItemUniqueId CrossbowId { get; set;}

[REDProp("attackName")]
public CName AttackName { get; set;}

[REDProp("attackTypeName")]
public CName AttackTypeName { get; set;}

[REDProp("isAttackReflected")]
public bool IsAttackReflected { get; set;}

[REDProp("isParried")]
public bool IsParried { get; set;}

[REDProp("isCountered")]
public bool IsCountered { get; set;}

[REDProp("attackAnimName")]
public CName AttackAnimName { get; set;}

[REDProp("hitTime")]
public float HitTime { get; set;}

[REDProp("weaponEntity")]
public Handle<CItemEntity> WeaponEntity { get; set;}

[REDProp("weaponSlot")]
public CName WeaponSlot { get; set;}

[REDProp("boneIndex")]
public Int32 BoneIndex { get; set;}

[REDProp("soundAttackType")]
public CName SoundAttackType { get; set;}

[REDProp("usedZeroStaminaPerk")]
public bool UsedZeroStaminaPerk { get; set;}

[REDProp("applyBuffsIfParried")]
public bool ApplyBuffsIfParried { get; set;}

#endregion
}
}