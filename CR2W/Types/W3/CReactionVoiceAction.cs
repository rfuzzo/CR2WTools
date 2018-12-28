using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CReactionVoiceAction : IReactionAction
{
#region RED Properties

[REDProp("voiceset")]
public string Voiceset { get; set;}

[REDProp("cooldown")]
public float Cooldown { get; set;}

#endregion
}
}