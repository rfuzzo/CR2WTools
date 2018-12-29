using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_PlayAnimationOnEntity : W3SwitchEvent
{
#region RED Properties

[REDProp("entityTag")]
public CName EntityTag { get; set;}

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("operation")]
public EPropertyAnimationOperation Operation { get; set;}

[REDProp("playCount")]
public Int32 PlayCount { get; set;}

[REDProp("playLengthScale")]
public float PlayLengthScale { get; set;}

[REDProp("playMode")]
public EPropertyCurveMode PlayMode { get; set;}

[REDProp("rewindTime")]
public float RewindTime { get; set;}

#endregion
}
}