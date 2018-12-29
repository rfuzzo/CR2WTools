using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class VoicetagAppearancePair 
{
#region RED Properties

[REDProp("voicetag")]
public CName Voicetag { get; set;}

[REDProp("appearance")]
public CName Appearance { get; set;}

#endregion
}
}