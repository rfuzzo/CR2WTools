using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorMimicCloseEyesConstraint : IBehaviorMimicConstraint
{
#region RED Properties

[REDProp("eyeClosedTrack_Left")]
public int EyeClosedTrack_Left { get; set;}

[REDProp("eyeClosedTrack_Right")]
public int EyeClosedTrack_Right { get; set;}

[REDProp("bonesToOverride_Left")]
public Array<string> BonesToOverride_Left { get; set;}

[REDProp("bonesToOverride_Right")]
public Array<string> BonesToOverride_Right { get; set;}

#endregion
}
}