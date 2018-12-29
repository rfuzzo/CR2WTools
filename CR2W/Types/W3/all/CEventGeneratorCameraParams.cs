using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEventGeneratorCameraParams 
{
#region RED Properties

[REDProp("cameraPlane")]
public ECameraPlane CameraPlane { get; set;}

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("targetSlot")]
public int TargetSlot { get; set;}

[REDProp("sourceSlot")]
public int SourceSlot { get; set;}

[REDProp("usableForGenerator")]
public bool UsableForGenerator { get; set;}

#endregion
}
}