
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEntityTemplate : CResource
	{
		[W3Type("includes")]
        [W3ArrayFlags(2, 0)]
        public Array<Handle<CEntityTemplate>> Includes { get; set; }

		[W3Type("overrides")]
        [W3ArrayFlags(2, 0)]
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
        [W3ArrayFlags(2, 0)]
        public Array<CEntityBodyPart> BodyParts { get; set; }

		[W3Type("appearances")]
        [W3ArrayFlags(2, 0)]
        public Array<CEntityAppearance> Appearances { get; set; }

		[W3Type("usedAppearances")]
        [W3ArrayFlags(2, 0)]
        public Array<CName> UsedAppearances { get; set; }

		[W3Type("voicetagAppearances")]
        [W3ArrayFlags(2, 0)]
        public Array<VoicetagAppearancePair> VoicetagAppearances { get; set; }

		[W3Type("effects")]
        [W3ArrayFlags(2, 0)]
        public Array<Ptr<CFXDefinition>> Effects { get; set; }

		[W3Type("slots")]
        [W3ArrayFlags(2, 0)]
        public Array<EntitySlot> Slots { get; set; }

		[W3Type("templateParams")]
        [W3ArrayFlags(2, 0)]
        public Array<Ptr<CEntityTemplateParam>> TemplateParams { get; set; }

		[W3Type("coloringEntries")]
        [W3ArrayFlags(2, 0)]
        public Array<SEntityTemplateColoringEntry> ColoringEntries { get; set; }

		[W3Type("instancePropEntries")]
        [W3ArrayFlags(2, 0)]
        public Array<SComponentInstancePropertyEntry> InstancePropEntries { get; set; }

		[W3Type("flatCompiledData")]
        [W3ArrayFlags(2, 0)]
        public Array<UInt8> FlatCompiledData { get; set; }

		[W3Type("streamedAttachments")]
        [W3ArrayFlags(2, 0)]
        public Array<SStreamedAttachment> StreamedAttachments { get; set; }

		[W3Type("cookedEffects")]
        [W3ArrayFlags(2, 0)]
        public Array<CEntityTemplateCookedEffect> CookedEffects { get; set; }

		[W3Type("cookedEffectsVersion")]
		public UInt32 CookedEffectsVersion { get; set; }

	}
}
