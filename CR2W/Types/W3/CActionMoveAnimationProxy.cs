using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CActionMoveAnimationProxy : CObject
{
#region RED Properties

[REDProp("isInitialized")]
public bool IsInitialized { get; set;}

[REDProp("isValid")]
public bool IsValid { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("prevTime")]
public float PrevTime { get; set;}

[REDProp("currTime")]
public float CurrTime { get; set;}

[REDProp("finished")]
public bool Finished { get; set;}

#endregion
}
}