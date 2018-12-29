using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SBoatDestructionVolume 
{
#region RED Properties

[REDProp("areaHealth")]
public float AreaHealth { get; set;}

[REDProp("volumeCorners")]
public Vector VolumeCorners { get; set;}

[REDProp("volumeLocalPosition")]
public Vector VolumeLocalPosition { get; set;}

#endregion
}
}