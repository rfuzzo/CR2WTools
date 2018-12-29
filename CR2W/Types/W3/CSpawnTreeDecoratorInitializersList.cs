using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CSpawnTreeDecoratorInitializersList : ISpawnTreeDecorator
{
#region RED Properties

[REDProp("nodeName")]
public CName NodeName { get; set;}

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("childNode")]
public Ptr<ISpawnTreeBaseNode> ChildNode { get; set;}

[REDProp("topInitializers")]
public Array<Ptr<ISpawnTreeInitializer>> TopInitializers { get; set;}

#endregion
}
}