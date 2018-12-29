using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCameraPivotPositionControllerKeepRelative : ICustomCameraScriptedPivotPositionController
{
#region RED Properties

[REDProp("offset")]
public Vector Offset { get; set;}

[REDProp("isSet")]
public bool IsSet { get; set;}

#endregion
}
}