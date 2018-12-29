using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Poster : CGameplayEntity
{
#region RED Properties

[REDProp("descriptionGenerated")]
public bool DescriptionGenerated { get; set;}

[REDProp("description")]
public string Description { get; set;}

[REDProp("camera")]
public Handle<CEntityTemplate> Camera { get; set;}

[REDProp("factOnRead")]
public string FactOnRead { get; set;}

[REDProp("factOnInteraction")]
public string FactOnInteraction { get; set;}

[REDProp("blendInTime")]
public float BlendInTime { get; set;}

[REDProp("blendOutTime")]
public float BlendOutTime { get; set;}

[REDProp("fadeStartDuration")]
public float FadeStartDuration { get; set;}

[REDProp("fadeEndDuration")]
public float FadeEndDuration { get; set;}

[REDProp("focusModeHighlight")]
public EFocusModeVisibility FocusModeHighlight { get; set;}

[REDProp("alignLeft")]
public bool AlignLeft { get; set;}

[REDProp("restoreUsableItemAtEnd")]
public bool RestoreUsableItemAtEnd { get; set;}

[REDProp("spawnedCamera")]
public Handle<CStaticCamera> SpawnedCamera { get; set;}

#endregion
}
}