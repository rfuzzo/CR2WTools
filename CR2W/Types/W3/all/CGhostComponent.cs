using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CGhostComponent : CR4Component
{
#region RED Properties

[REDProp("isCastingShadows")]
public bool IsCastingShadows { get; set;}

[REDProp("soundEffectType")]
public EFocusModeSoundEffectType SoundEffectType { get; set;}

#endregion
}
}