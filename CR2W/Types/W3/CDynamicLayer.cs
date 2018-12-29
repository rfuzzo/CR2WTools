using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CDynamicLayer : CLayer
{
#region RED Properties

[REDProp("entities")]
public Array<Ptr<CEntity>> Entities { get; set;}

[REDProp("sectorData")]
public Handle<CSectorData> SectorData { get; set;}

[REDProp("nameCount")]
public uint NameCount { get; set;}

#endregion
}
}