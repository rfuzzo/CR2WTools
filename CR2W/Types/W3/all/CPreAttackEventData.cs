using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPreAttackEventData 
{
#region RED Properties

[REDProp("attackName")]
public CName AttackName { get; set;}

[REDProp("weaponSlot")]
public CName WeaponSlot { get; set;}

[REDProp("hitReactionType")]
public int HitReactionType { get; set;}

[REDProp("rangeName")]
public CName RangeName { get; set;}

[REDProp("Damage_Friendly")]
public bool Damage_Friendly { get; set;}

[REDProp("Damage_Neutral")]
public bool Damage_Neutral { get; set;}

[REDProp("Damage_Hostile")]
public bool Damage_Hostile { get; set;}

[REDProp("Can_Parry_Attack")]
public bool Can_Parry_Attack { get; set;}

[REDProp("hitFX")]
public CName HitFX { get; set;}

[REDProp("hitBackFX")]
public CName HitBackFX { get; set;}

[REDProp("hitParriedFX")]
public CName HitParriedFX { get; set;}

[REDProp("hitBackParriedFX")]
public CName HitBackParriedFX { get; set;}

[REDProp("swingType")]
public int SwingType { get; set;}

[REDProp("swingDir")]
public int SwingDir { get; set;}

[REDProp("soundAttackType")]
public CName SoundAttackType { get; set;}

[REDProp("canBeDodged")]
public bool CanBeDodged { get; set;}

[REDProp("cameraAnimOnMissedHit")]
public CName CameraAnimOnMissedHit { get; set;}

#endregion
}
}