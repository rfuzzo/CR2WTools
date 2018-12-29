using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SavedSoundClue : CGameplayEntity
{
#region RED Properties

[REDProp("savedFocusModeSoundEffectType")]
public EFocusModeSoundEffectType SavedFocusModeSoundEffectType { get; set;}

#endregion
}
}