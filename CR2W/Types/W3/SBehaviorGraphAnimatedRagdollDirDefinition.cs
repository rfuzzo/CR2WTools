using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SBehaviorGraphAnimatedRagdollDirDefinition 
{
#region RED Properties

[REDProp("dirIndexValue")]
public float DirIndexValue { get; set;}

[REDProp("relativeAngle")]
public float RelativeAngle { get; set;}

[REDProp("applyAngleToMovement")]
public float ApplyAngleToMovement { get; set;}

[REDProp("replacements")]
public Array<SBehaviorGraphAnimatedRagdollDirReplacement> Replacements { get; set;}

#endregion
}
}