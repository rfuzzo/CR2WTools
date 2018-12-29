using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CDLCManager : CObject
{
#region RED Properties

[REDProp("definitions")]
public Array<Handle<CDLCDefinition>> Definitions { get; set;}

[REDProp("mountedContent")]
public Array<Handle<IGameplayDLCMounter>> MountedContent { get; set;}

#endregion
}
}