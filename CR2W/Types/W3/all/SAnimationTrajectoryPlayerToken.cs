using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SAnimationTrajectoryPlayerToken 
{
#region RED Properties

[REDProp("isValid")]
public bool IsValid { get; set;}

[REDProp("pointWS")]
public Vector PointWS { get; set;}

[REDProp("syncPointMS")]
public Vector SyncPointMS { get; set;}

[REDProp("timeFactor")]
public float TimeFactor { get; set;}

[REDProp("syncPointDuration")]
public float SyncPointDuration { get; set;}

[REDProp("blendIn")]
public float BlendIn { get; set;}

[REDProp("blendOut")]
public float BlendOut { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("syncTime")]
public float SyncTime { get; set;}

#endregion
}
}