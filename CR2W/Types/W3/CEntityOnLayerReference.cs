using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CEntityOnLayerReference 
{
#region RED Properties

[REDProp("layerGuid")]
public CGUID LayerGuid { get; set;}

[REDProp("entityGuid")]
public CGUID EntityGuid { get; set;}

#endregion
}
}