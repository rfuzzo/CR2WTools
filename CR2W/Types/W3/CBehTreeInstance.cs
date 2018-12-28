using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeInstance : CObject
{
#region RED Properties

[REDProp("dependentObjects")]
public Array<Handle<IScriptable>> DependentObjects { get; set;}

[REDProp("onReattachCallback")]
public Array<Handle<IBehTreeMetanodeOnSpawnDefinition>> OnReattachCallback { get; set;}

#endregion
}
}