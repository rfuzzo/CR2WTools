using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphMimicsConverterNode : CBehaviorGraphNode
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

[REDProp("cachedAnimInputNode")]
public Ptr<CBehaviorGraphNode> CachedAnimInputNode { get; set;}

[REDProp("cachedMimicBaseInputNode")]
public Ptr<CBehaviorGraphNode> CachedMimicBaseInputNode { get; set;}

[REDProp("placerPrefix")]
public string PlacerPrefix { get; set;}

[REDProp("normalBlendTracksBegin")]
public int NormalBlendTracksBegin { get; set;}

[REDProp("mimicLipsyncOffset")]
public int MimicLipsyncOffset { get; set;}

[REDProp("mimicsConstraints")]
public Array<Ptr<IBehaviorMimicConstraint>> MimicsConstraints { get; set;}

#endregion
}
}