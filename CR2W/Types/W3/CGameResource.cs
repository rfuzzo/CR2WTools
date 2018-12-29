using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CGameResource : CResource
{
#region RED Properties

[REDProp("worlds")]
public Array<SWorldDescription> Worlds { get; set;}

[REDProp("defaultPlayerTemplate")]
public Soft<CEntityTemplate> DefaultPlayerTemplate { get; set;}

[REDProp("defaultCameraTemplate")]
public Soft<CEntityTemplate> DefaultCameraTemplate { get; set;}

[REDProp("startingPoint")]
public EngineTransform StartingPoint { get; set;}

[REDProp("newGameLoadingVideo")]
public string NewGameLoadingVideo { get; set;}

[REDProp("playGoChunksToActivate")]
public Array<CName> PlayGoChunksToActivate { get; set;}

#endregion
}
}