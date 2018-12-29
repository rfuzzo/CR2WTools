using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAnimDangleConstraint_NobleDressFix : IAnimDangleConstraint
{
#region RED Properties

[REDProp("boneNameA")]
public string BoneNameA { get; set;}

[REDProp("boneNameB")]
public string BoneNameB { get; set;}

[REDProp("boneAxisA")]
public EAxis BoneAxisA { get; set;}

[REDProp("boneAxisB")]
public EAxis BoneAxisB { get; set;}

[REDProp("boneValueA")]
public float BoneValueA { get; set;}

[REDProp("boneValueB")]
public float BoneValueB { get; set;}

#endregion
}
}