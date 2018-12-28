using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphEngineVectorValueNode : CBehaviorGraphVectorVariableNode
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

[REDProp("variableName")]
public CName VariableName { get; set;}

[REDProp("engineValueType")]
public EBehaviorEngineVectorValueType EngineValueType { get; set;}

[REDProp("manualControl")]
public bool ManualControl { get; set;}

[REDProp("cachedVectorVariable")]
public Ptr<CBehaviorVectorVariable> CachedVectorVariable { get; set;}

#endregion
}
}