using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSkeletalAnimationAttackTrajectoryParam : ISkeletalAnimationSetEntryParam
{
#region RED Properties

[REDProp("tagId")]
public CName TagId { get; set;}

[REDProp("type")]
public EAnimationAttackType Type { get; set;}

[REDProp("slowMotionTimeFactor")]
public float SlowMotionTimeFactor { get; set;}

[REDProp("hitDuration")]
public float HitDuration { get; set;}

[REDProp("postHitEnd")]
public float PostHitEnd { get; set;}

[REDProp("slowMotionStart")]
public float SlowMotionStart { get; set;}

[REDProp("slowMotionEnd")]
public float SlowMotionEnd { get; set;}

[REDProp("dampOutEnd")]
public float DampOutEnd { get; set;}

#endregion
}
}