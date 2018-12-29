using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphMimicEyesCorrectionNode : CBehaviorGraphBaseMimicNode
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

[REDProp("trackEyeLeft_Left")]
public string TrackEyeLeft_Left { get; set;}

[REDProp("trackEyeLeft_Right")]
public string TrackEyeLeft_Right { get; set;}

[REDProp("trackEyeRight_Left")]
public string TrackEyeRight_Left { get; set;}

[REDProp("trackEyeRight_Right")]
public string TrackEyeRight_Right { get; set;}

#endregion
}
}