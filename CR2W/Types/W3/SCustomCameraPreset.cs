using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SCustomCameraPreset 
{
#region RED Properties

[REDProp("pressetName")]
public CName PressetName { get; set;}

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("offset")]
public Vector Offset { get; set;}

#endregion
}
}