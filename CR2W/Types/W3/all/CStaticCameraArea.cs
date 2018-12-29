using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStaticCameraArea : CEntity
{
#region RED Properties

[REDProp("cameraTag")]
public CName CameraTag { get; set;}

[REDProp("onlyForPlayer")]
public bool OnlyForPlayer { get; set;}

[REDProp("activatorTag")]
public CName ActivatorTag { get; set;}

#endregion
}
}