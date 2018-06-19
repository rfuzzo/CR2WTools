
using System;
using CR2W.Attributes;
using CR2W.IO;

namespace CR2W.Types.W3
{
	public class W3Boat : CResource
	{
        

        [W3Type("tags")]
        public TagList Tags { get; set; }

        [W3Type("transform")]
        public EngineTransform Transform { get; set; }

        [W3Type("transformParent")]
        public Ptr<CHardAttachment> TransformParent { get; set; }

        [W3Type("guid")]
        public CGUID Guid { get; set; }

        [W3Type("components")]
        [W3ArrayFlags(2, 0)]
        public Array<Ptr<CComponent>> Components { get; set; }

        [W3Type("template")]
        public Handle<CEntityTemplate> _Template { get; set; } //inherited

        [W3Type("streamingDataBuffer")]
        public SharedDataBuffer StreamingDataBuffer { get; set; }

        [W3Type("streamingDistance")]
        public byte StreamingDistance { get; set; } //uint8

        [W3Type("entityStaticFlags")]
        public EEntityStaticFlags EntityStaticFlags { get; set; }

        [W3Type("autoPlayEffectName")]
        public CName AutoPlayEffectName { get; set; }

        [W3Type("entityFlags")]
        public byte EntityFlags { get; set; } //uint8

        [W3Type("idTag")]
        public IdTag IdTag { get; set; }

        [W3Type("isSaveable")]
        public bool IsSaveable { get; set; } 

        [W3Type("propertyAnimationSet")]
        public Ptr<CPropertyAnimationSet> PropertyAnimationSet { get; set; }

        [W3Type("displayName")]
        public LocalizedString DisplayName { get; set; }

        [W3Type("stats")]
        public Ptr<CCharacterStats> Stats { get; set; }

        [W3Type("isInteractionActivator")]
        public bool IsInteractionActivator { get; set; }

        [W3Type("aimVector")]
        public Vector AimVector { get; set; }

        [W3Type("gameplayFlags")]
        public UInt32 GameplayFlags { get; set; }

        [W3Type("focusModeVisibility")]
        public EFocusModeVisibility FocusModeVisibility { get; set; }

        [W3Type("teleportedFromOtherHUB")]
        public bool TeleportedFromOtherHUB { get; set; }


        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);
        }
    }
}
