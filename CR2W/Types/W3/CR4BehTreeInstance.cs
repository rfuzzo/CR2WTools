using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CR4BehTreeInstance : CBehTreeInstance
{
#region RED Properties

[REDProp("dependentObjects")]
public Array<Handle<IScriptable>> DependentObjects { get; set;}

[REDProp("onReattachCallback")]
public Array<Handle<IBehTreeMetanodeOnSpawnDefinition>> OnReattachCallback { get; set;}

#endregion
}
}