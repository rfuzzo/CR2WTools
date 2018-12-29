using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PlayerStateAimThrow : CR4PlayerStateExtendedMovable
{
#region RED Properties

[REDProp("camera")]
public Handle<CCustomCamera> Camera { get; set;}

[REDProp("fovVel")]
public float FovVel { get; set;}

[REDProp("initialPitch")]
public float InitialPitch { get; set;}

[REDProp("cachedHorTimeout")]
public float CachedHorTimeout { get; set;}

[REDProp("cachedVerTimeout")]
public float CachedVerTimeout { get; set;}

[REDProp("prevState")]
public CName PrevState { get; set;}

[REDProp("followTarget")]
public bool FollowTarget { get; set;}

[REDProp("followPitch")]
public float FollowPitch { get; set;}

[REDProp("isRotating")]
public bool IsRotating { get; set;}

#endregion
}
}