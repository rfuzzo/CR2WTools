using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAnimDangleConstraint_Breast : CAnimSkeletalDangleConstraint
{
#region RED Properties

[REDProp("skeleton")]
public Handle<CSkeleton> Skeleton { get; set;}

[REDProp("dispSkeleton")]
public bool DispSkeleton { get; set;}

[REDProp("dispBoneNames")]
public bool DispBoneNames { get; set;}

[REDProp("dispBoneAxis")]
public bool DispBoneAxis { get; set;}

[REDProp("preset")]
public EBreastPreset Preset { get; set;}

[REDProp("simTime")]
public float SimTime { get; set;}

[REDProp("elA")]
public Vector ElA { get; set;}

[REDProp("startSimPointOffset")]
public float StartSimPointOffset { get; set;}

[REDProp("velDamp")]
public float VelDamp { get; set;}

[REDProp("bounceDamp")]
public float BounceDamp { get; set;}

[REDProp("inAcc")]
public float InAcc { get; set;}

[REDProp("inertiaScaler")]
public float InertiaScaler { get; set;}

[REDProp("blackHole")]
public float BlackHole { get; set;}

[REDProp("velClamp")]
public float VelClamp { get; set;}

[REDProp("gravity")]
public float Gravity { get; set;}

[REDProp("movementBoneWeight")]
public float MovementBoneWeight { get; set;}

[REDProp("rotationBoneWeight")]
public float RotationBoneWeight { get; set;}

#endregion
}
}