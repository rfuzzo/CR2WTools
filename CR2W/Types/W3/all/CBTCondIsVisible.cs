using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondIsVisible : IBehTreeTask
{
#region RED Properties

[REDProp("gameplayVisibility")]
public bool GameplayVisibility { get; set;}

[REDProp("meshVisibility")]
public bool MeshVisibility { get; set;}

[REDProp("forceComplete")]
public bool ForceComplete { get; set;}

[REDProp("target")]
public bool Target { get; set;}

[REDProp("invert")]
public bool Invert { get; set;}

#endregion
}
}