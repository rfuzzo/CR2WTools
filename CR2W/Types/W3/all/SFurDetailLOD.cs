using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SFurDetailLOD 
{
#region RED Properties

[REDProp("enableDetailLOD")]
public bool EnableDetailLOD { get; set;}

[REDProp("detailLODStart")]
public float DetailLODStart { get; set;}

[REDProp("detailLODEnd")]
public float DetailLODEnd { get; set;}

[REDProp("detailLODWidth")]
public float DetailLODWidth { get; set;}

[REDProp("detailLODDensity")]
public float DetailLODDensity { get; set;}

#endregion
}
}