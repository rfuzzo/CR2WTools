using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCheckFlyingActorsDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("minFlyingActors")]
public Int32 MinFlyingActors { get; set;}

[REDProp("maxFlyingActors")]
public Int32 MaxFlyingActors { get; set;}

[REDProp("flyingCheckType")]
public EFlyingCheck FlyingCheckType { get; set;}

[REDProp("ifNot")]
public bool IfNot { get; set;}

#endregion
}
}