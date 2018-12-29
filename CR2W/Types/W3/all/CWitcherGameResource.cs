using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CWitcherGameResource : CCommonGameResource
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

[REDProp("mainQuest")]
public Soft<CQuest> MainQuest { get; set;}

[REDProp("guiConfigOverride")]
public Soft<CGuiConfigResource> GuiConfigOverride { get; set;}

[REDProp("mapPinConfig")]
public SMapPinConfig MapPinConfig { get; set;}

[REDProp("huntingClueCategoryResource")]
public Soft<C2dArray> HuntingClueCategoryResource { get; set;}

[REDProp("journalRootDirectory")]
public string JournalRootDirectory { get; set;}

#endregion
}
}