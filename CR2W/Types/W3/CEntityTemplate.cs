
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEntityTemplate : CResource
	{
		[W3Type("includes")]
		public Array<Handle<CEntityTemplate>> Includes { get; set; }

		[W3Type("overrides")]
		public Array<SEntityTemplateOverride> Overrides { get; set; }

		[W3Type("properOverrides")]
		public bool ProperOverrides { get; set; }

		[W3Type("backgroundOffset")]
		public Vector BackgroundOffset { get; set; }

		[W3Type("dataCompilationTime")]
		public CDateTime DataCompilationTime { get; set; }

		[W3Type("entityClass")]
		public CName EntityClass { get; set; }

		[W3Type("entityObject")]
		public Ptr<CEntity> EntityObject { get; set; }

		[W3Type("bodyParts")]
		public Array<CEntityBodyPart> BodyParts { get; set; }

		[W3Type("appearances")]
		public Array<CEntityAppearance> Appearances { get; set; }

		[W3Type("usedAppearances")]
		public Array<CName> UsedAppearances { get; set; }

		[W3Type("voicetagAppearances")]
		public Array<VoicetagAppearancePair> VoicetagAppearances { get; set; }

		[W3Type("effects")]
		public Array<Ptr<CFXDefinition>> Effects { get; set; }

		[W3Type("slots")]
		public Array<EntitySlot> Slots { get; set; }

		[W3Type("templateParams")]
		public Array<Ptr<CEntityTemplateParam>> TemplateParams { get; set; }

		[W3Type("coloringEntries")]
		public Array<SEntityTemplateColoringEntry> ColoringEntries { get; set; }

		[W3Type("instancePropEntries")]
		public Array<SComponentInstancePropertyEntry> InstancePropEntries { get; set; }

		[W3Type("flatCompiledData")]
		public Array<UInt8> FlatCompiledData { get; set; }

		[W3Type("streamedAttachments")]
		public Array<SStreamedAttachment> StreamedAttachments { get; set; }

		[W3Type("cookedEffects")]
		public Array<CEntityTemplateCookedEffect> CookedEffects { get; set; }

		[W3Type("cookedEffectsVersion")]
		public UInt32 CookedEffectsVersion { get; set; }

	}
}
