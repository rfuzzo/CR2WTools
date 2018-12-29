using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SFurDistanceLOD 
{
#region RED Properties

[REDProp("enableDistanceLOD")]
public bool EnableDistanceLOD { get; set;}

[REDProp("distanceLODStart")]
public float DistanceLODStart { get; set;}

[REDProp("distanceLODEnd")]
public float DistanceLODEnd { get; set;}

[REDProp("distanceLODFadeStart")]
public float DistanceLODFadeStart { get; set;}

[REDProp("distanceLODWidth")]
public float DistanceLODWidth { get; set;}

[REDProp("distanceLODDensity")]
public float DistanceLODDensity { get; set;}

#endregion
}
}