using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SSceneCameraShotDescription 
{
#region RED Properties

[REDProp("shotName")]
public CName ShotName { get; set;}

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("overrideDof")]
public bool OverrideDof { get; set;}

[REDProp("dofIntensity")]
public float DofIntensity { get; set;}

[REDProp("dofBlurDistNear")]
public float DofBlurDistNear { get; set;}

[REDProp("dofFocusDistNear")]
public float DofFocusDistNear { get; set;}

[REDProp("dofFocusDistFar")]
public float DofFocusDistFar { get; set;}

[REDProp("dofBlurDistFar")]
public float DofBlurDistFar { get; set;}

#endregion
}
}