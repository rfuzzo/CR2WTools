using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MedallionController : CObject
{
#region RED Properties

[REDProp("deactivateTimer")]
public float DeactivateTimer { get; set;}

[REDProp("instantIntensity")]
public float InstantIntensity { get; set;}

[REDProp("isBlocked")]
public bool IsBlocked { get; set;}

[REDProp("focusModeFactor")]
public float FocusModeFactor { get; set;}

[REDProp("defaultDuration")]
public float DefaultDuration { get; set;}

[REDProp("defaultTreshold")]
public float DefaultTreshold { get; set;}

[REDProp("maxTreshold")]
public float MaxTreshold { get; set;}

#endregion
}
}