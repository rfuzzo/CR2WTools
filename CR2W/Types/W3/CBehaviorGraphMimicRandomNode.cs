using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphMimicRandomNode : CBehaviorGraphRandomNode
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("activateNotification")]
public CName ActivateNotification { get; set;}

[REDProp("deactivateNotification")]
public CName DeactivateNotification { get; set;}

[REDProp("generateEditorFragments")]
public bool GenerateEditorFragments { get; set;}

[REDProp("id")]
public uint Id { get; set;}

[REDProp("weights")]
public Array<float> Weights { get; set;}

[REDProp("cooldowns")]
public Array<float> Cooldowns { get; set;}

[REDProp("maxStartAnimTime")]
public Array<float> MaxStartAnimTime { get; set;}

[REDProp("cachedInputNodes")]
public Array<Ptr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

#endregion
}
}