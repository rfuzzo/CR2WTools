using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCameraPivotPositionControllerSlide : ICustomCameraScriptedPivotPositionController
{
#region RED Properties

[REDProp("originalPosition")]
public Vector OriginalPosition { get; set;}

[REDProp("blendSpeed")]
public float BlendSpeed { get; set;}

[REDProp("timeCur")]
public float TimeCur { get; set;}

#endregion
}
}