using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphTimerValueNode : CBehaviorGraphValueBaseNode
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

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphValueNode> CachedInputNode { get; set;}

[REDProp("type")]
public EBehaviorValueTimerType Type { get; set;}

[REDProp("maxValue")]
public float MaxValue { get; set;}

[REDProp("timeScale")]
public float TimeScale { get; set;}

[REDProp("threshold")]
public float Threshold { get; set;}

[REDProp("cachedFirstInputNode")]
public Ptr<CBehaviorGraphValueNode> CachedFirstInputNode { get; set;}

#endregion
}
}