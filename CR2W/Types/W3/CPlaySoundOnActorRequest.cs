using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CPlaySoundOnActorRequest : IEntityStateChangeRequest
{
#region RED Properties

[REDProp("boneName")]
public CName BoneName { get; set;}

[REDProp("soundName")]
public StringAnsi SoundName { get; set;}

[REDProp("fadeTime")]
public float FadeTime { get; set;}

#endregion
}
}