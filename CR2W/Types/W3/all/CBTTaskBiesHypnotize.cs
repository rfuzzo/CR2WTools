using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskBiesHypnotize : CBTTask3StateAttack
{
#region RED Properties

[REDProp("cameraIndex")]
public Int32 CameraIndex { get; set;}

[REDProp("ignoreConeCheck")]
public bool IgnoreConeCheck { get; set;}

[REDProp("done")]
public bool Done { get; set;}

#endregion
}
}