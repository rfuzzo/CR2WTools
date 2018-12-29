using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SFurMaterialSet 
{
#region RED Properties

[REDProp("useWetness")]
public bool UseWetness { get; set;}

[REDProp("physicalMaterials")]
public SFurPhysicalMaterials PhysicalMaterials { get; set;}

[REDProp("graphicalMaterials")]
public SFurGraphicalMaterials GraphicalMaterials { get; set;}

#endregion
}
}