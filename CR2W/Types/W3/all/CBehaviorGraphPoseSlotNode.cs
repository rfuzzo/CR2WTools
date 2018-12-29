using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphPoseSlotNode : CBehaviorGraphBaseNode
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
public Ptr<CBehaviorGraphNode> CachedInputNode { get; set;}

[REDProp("slotName")]
public CName SlotName { get; set;}

[REDProp("firstBone")]
public string FirstBone { get; set;}

[REDProp("worldSpace")]
public bool WorldSpace { get; set;}

[REDProp("interpolation")]
public EInterpolationType Interpolation { get; set;}

[REDProp("blendFloatTracks")]
public bool BlendFloatTracks { get; set;}

[REDProp("ignoreZeroFloatTracks")]
public bool IgnoreZeroFloatTracks { get; set;}

#endregion
}
}