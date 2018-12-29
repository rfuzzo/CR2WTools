using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAnimPointCloudLookAtParam : ISkeletalAnimationSetEntryParam
{
#region RED Properties

[REDProp("boneName")]
public CName BoneName { get; set;}

[REDProp("boneMSInv")]
public Matrix BoneMSInv { get; set;}

[REDProp("boneTransMSInv")]
public EngineQsTransform BoneTransMSInv { get; set;}

[REDProp("directionLS")]
public Vector DirectionLS { get; set;}

[REDProp("pointsBS")]
public Array<Vector> PointsBS { get; set;}

[REDProp("pointToTriMapping")]
public Array<Array<Int32>> PointToTriMapping { get; set;}

[REDProp("refPose")]
public Array<EngineQsTransform> RefPose { get; set;}

#endregion
}
}