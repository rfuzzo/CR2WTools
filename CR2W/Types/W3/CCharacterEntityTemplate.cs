using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CCharacterEntityTemplate : CEntityTemplate
{
#region RED Properties

[REDProp("includes")]
public Array<Handle<CEntityTemplate>> Includes { get; set;}

[REDProp("overrides")]
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

[REDProp("bodyParts")]
public Array<CEntityBodyPart> BodyParts { get; set;}

[REDProp("appearances")]
public Array<CEntityAppearance> Appearances { get; set;}

[REDProp("usedAppearances")]
public Array<CName> UsedAppearances { get; set;}

[REDProp("voicetagAppearances")]
public Array<VoicetagAppearancePair> VoicetagAppearances { get; set;}

[REDProp("effects")]
public Array<Ptr<CFXDefinition>> Effects { get; set;}

[REDProp("slots")]
public Array<EntitySlot> Slots { get; set;}

[REDProp("templateParams")]
public Array<Ptr<CEntityTemplateParam>> TemplateParams { get; set;}

[REDProp("coloringEntries")]
public Array<SEntityTemplateColoringEntry> ColoringEntries { get; set;}

[REDProp("instancePropEntries")]
public Array<SComponentInstancePropertyEntry> InstancePropEntries { get; set;}

[REDProp("flatCompiledData")]
public Array<byte> FlatCompiledData { get; set;}

[REDProp("streamedAttachments")]
public Array<SStreamedAttachment> StreamedAttachments { get; set;}

[REDProp("cookedEffects")]
public Array<CEntityTemplateCookedEffect> CookedEffects { get; set;}

[REDProp("cookedEffectsVersion")]
public uint CookedEffectsVersion { get; set;}

[REDProp("baseEntityOverride")]
public Handle<CEntityTemplate> BaseEntityOverride { get; set;}

#endregion
}
}