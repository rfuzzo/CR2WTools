using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphVectorMathNode : CBehaviorGraphVectorValueNode
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

[REDProp("operation")]
public EBehaviorVectorMathOp Operation { get; set;}

[REDProp("cachedFirstInputNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedFirstInputNode { get; set;}

[REDProp("cachedSecondInputNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedSecondInputNode { get; set;}

[REDProp("cachedScalarInputNode")]
public Ptr<CBehaviorGraphValueNode> CachedScalarInputNode { get; set;}

#endregion
}
}