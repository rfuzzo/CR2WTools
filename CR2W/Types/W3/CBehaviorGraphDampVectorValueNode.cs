using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphDampVectorValueNode : CBehaviorGraphVectorValueNode
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

[REDProp("increaseSpeed")]
public Vector IncreaseSpeed { get; set;}

[REDProp("decreaseSpeed")]
public Vector DecreaseSpeed { get; set;}

[REDProp("absolute")]
public bool Absolute { get; set;}

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedInputNode { get; set;}

[REDProp("cachedIncSpeedNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedIncSpeedNode { get; set;}

[REDProp("cachedDecSpeedNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedDecSpeedNode { get; set;}

#endregion
}
}