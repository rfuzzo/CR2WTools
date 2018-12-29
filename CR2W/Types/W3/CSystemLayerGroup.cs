using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CSystemLayerGroup : CLayerGroup
{
#region RED Properties

[REDProp("name")]
public string Name { get; set;}

[REDProp("depotPath")]
public string DepotPath { get; set;}

[REDProp("absolutePath")]
public string AbsolutePath { get; set;}

[REDProp("isVisibleOnStart")]
public bool IsVisibleOnStart { get; set;}

[REDProp("systemGroup")]
public bool SystemGroup { get; set;}

[REDProp("hasEmbeddedLayerInfos")]
public bool HasEmbeddedLayerInfos { get; set;}

[REDProp("idHash")]
public UInt64 IdHash { get; set;}

#endregion
}
}