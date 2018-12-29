using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class ICustomCameraBaseController : CObject
{
#region RED Properties

[REDProp("controllerName")]
public CName ControllerName { get; set;}

#endregion
}
}