using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SAreaMapPinInfo 
{
#region RED Properties

[REDProp("areaType")]
public int AreaType { get; set;}

[REDProp("position")]
public Vector Position { get; set;}

[REDProp("worldPath")]
public string WorldPath { get; set;}

[REDProp("requiredChunk")]
public CName RequiredChunk { get; set;}

[REDProp("localisationName")]
public CName LocalisationName { get; set;}

[REDProp("localisationDescription")]
public CName LocalisationDescription { get; set;}

#endregion
}
}