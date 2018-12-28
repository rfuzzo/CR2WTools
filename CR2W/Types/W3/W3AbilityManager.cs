using CR2W.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
    public class W3AbilityManager : IScriptable
    {
        #region RED Properties

        [REDProp("statPoints")]
        public Array<SBaseStat> StatPoints { get; set; }

        [REDProp("resistStats")]
        public Array<SResistanceValue> ResistStats { get; set; }

        [REDProp("blockedAbilities")]
        public Array<SBlockedAbility> BlockedAbilities { get; set; }

        [REDProp("owner")]
        public Handle<CActor> Owner { get; set; }

        [REDProp("charStats")]
        public Handle<CCharacterStats> CharStats { get; set; }

        [REDProp("usedDifficultyMode")]
        public EDifficultyMode UsedDifficultyMode { get; set; }

        [REDProp("usedHealthType")]
        public EBaseCharacterStats UsedHealthType { get; set; }

        [REDProp("difficultyAbilities")]
        public Array<Array<CName>> DifficultyAbilities { get; set; }

        [REDProp("ignoresDifficultySettings")]
        public bool IgnoresDifficultySettings { get; set; }

        #endregion

        //FIXME abstract classes
        public override UInt16 Flags { get; set; }
        public override UInt32 Template { get; set; }

        public override event SerializeEventHandler Serialize;
        public override event DeSerializeEventHandler DeSerialize;

        public override void OnSerialize(IFile source, REDEventArgs e) { }
        public override void OnDeSerialize(IFile source, REDEventArgs e) { }

    }
}
