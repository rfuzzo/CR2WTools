using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEntityTemplate : CResource
{
#region RED Properties

[REDProp("includes", 2,0)]
public Array<Handle<CEntityTemplate>> Includes { get; set;}

[REDProp("overrides", 2,0)]
public Array<SEntityTemplateOverride> Overrides { get; set;}

[REDProp("properOverrides")]
public bool ProperOverrides { get; set;}

[REDProp("backgroundOffset")]
public Vector BackgroundOffset { get; set;}

[REDProp("dataCompilationTime")]
public CDateTime DataCompilationTime { get; set;}

[REDProp("entityClass")]
public CName EntityClass { get; set;}

[REDProp("entityObject")]
public Ptr<CEntity> EntityObject { get; set;}

[REDProp("bodyParts", 2,0)]
public Array<CEntityBodyPart> BodyParts { get; set;}

[REDProp("appearances", 2,0)]
public Array<CEntityAppearance> Appearances { get; set;}

[REDProp("usedAppearances", 2,0)]
public Array<CName> UsedAppearances { get; set;}

[REDProp("voicetagAppearances", 2,0)]
public Array<VoicetagAppearancePair> VoicetagAppearances { get; set;}

[REDProp("effects", 2,0)]
public Array<Ptr<CFXDefinition>> Effects { get; set;}

[REDProp("slots", 2,0)]
public Array<EntitySlot> Slots { get; set;}

[REDProp("templateParams", 2,0)]
public Array<Ptr<CEntityTemplateParam>> TemplateParams { get; set;}

[REDProp("coloringEntries", 2,0)]
public Array<SEntityTemplateColoringEntry> ColoringEntries { get; set;}

[REDProp("instancePropEntries", 2,0)]
public Array<SComponentInstancePropertyEntry> InstancePropEntries { get; set;}

[REDProp("flatCompiledData", 2,0)]
public Array<byte> FlatCompiledData { get; set;}

[REDProp("streamedAttachments", 2,0)]
public Array<SStreamedAttachment> StreamedAttachments { get; set;}

[REDProp("cookedEffects", 2,0)]
public Array<CEntityTemplateCookedEffect> CookedEffects { get; set;}

[REDProp("cookedEffectsVersion")]
public UInt32 CookedEffectsVersion { get; set;}

#endregion
}
}