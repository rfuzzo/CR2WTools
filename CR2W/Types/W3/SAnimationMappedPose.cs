using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SAnimationMappedPose 
{
#region RED Properties

[REDProp("bones")]
public Array<EngineQsTransform> Bones { get; set;}

[REDProp("tracks")]
public Array<float> Tracks { get; set;}

[REDProp("bonesMapping")]
public Array<Int32> BonesMapping { get; set;}

[REDProp("tracksMapping")]
public Array<Int32> TracksMapping { get; set;}

[REDProp("weight")]
public float Weight { get; set;}

[REDProp("mode")]
public ESAnimationMappedPoseMode Mode { get; set;}

[REDProp("correctionID")]
public CGUID CorrectionID { get; set;}

[REDProp("correctionIdleID")]
public CName CorrectionIdleID { get; set;}

#endregion
}
}