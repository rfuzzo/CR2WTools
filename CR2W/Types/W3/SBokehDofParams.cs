using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SBokehDofParams 
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("hexToCircleScale")]
public float HexToCircleScale { get; set;}

[REDProp("usePhysicalSetup")]
public bool UsePhysicalSetup { get; set;}

[REDProp("planeInFocus")]
public float PlaneInFocus { get; set;}

[REDProp("fStops")]
public EApertureValue FStops { get; set;}

[REDProp("bokehSizeMuliplier")]
public float BokehSizeMuliplier { get; set;}

#endregion
}
}