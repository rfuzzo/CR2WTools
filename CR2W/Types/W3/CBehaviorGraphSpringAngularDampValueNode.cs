using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphSpringAngularDampValueNode : CBehaviorGraphSpringDampValueNode
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

[REDProp("factor")]
public float Factor { get; set;}

[REDProp("scale")]
public float Scale { get; set;}

[REDProp("forceInputValueOnActivate")]
public bool ForceInputValueOnActivate { get; set;}

[REDProp("isDegree")]
public bool IsDegree { get; set;}

#endregion
}
}