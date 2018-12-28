using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SComboAttackCallbackInfo 
{
#region RED Properties

[REDProp("outDirection")]
public EAttackDirection OutDirection { get; set;}

[REDProp("outDistance")]
public EAttackDistance OutDistance { get; set;}

[REDProp("outAttackType")]
public EComboAttackType OutAttackType { get; set;}

[REDProp("inAspectName")]
public CName InAspectName { get; set;}

[REDProp("inGlobalAttackCounter")]
public int InGlobalAttackCounter { get; set;}

[REDProp("inStringAttackCounter")]
public int InStringAttackCounter { get; set;}

[REDProp("inAttackId")]
public int InAttackId { get; set;}

[REDProp("prevDirAttack")]
public bool PrevDirAttack { get; set;}

[REDProp("outRotateToEnemyAngle")]
public float OutRotateToEnemyAngle { get; set;}

[REDProp("outSlideToPosition")]
public Vector OutSlideToPosition { get; set;}

[REDProp("outShouldTranslate")]
public bool OutShouldTranslate { get; set;}

[REDProp("outShouldRotate")]
public bool OutShouldRotate { get; set;}

[REDProp("outLeftString")]
public bool OutLeftString { get; set;}

#endregion
}
}