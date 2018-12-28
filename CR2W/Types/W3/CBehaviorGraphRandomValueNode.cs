using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphRandomValueNode : CBehaviorGraphValueNode
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

[REDProp("value")]
public float Value { get; set;}

[REDProp("randDefaultValue")]
public bool RandDefaultValue { get; set;}

[REDProp("rand")]
public bool Rand { get; set;}

[REDProp("cooldown")]
public float Cooldown { get; set;}

[REDProp("min")]
public float Min { get; set;}

[REDProp("max")]
public float Max { get; set;}

#endregion
}
}