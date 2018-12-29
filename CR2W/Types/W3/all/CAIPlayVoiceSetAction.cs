using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIPlayVoiceSetAction : IAIActionTree
{
#region RED Properties

[REDProp("voiceSet")]
public string VoiceSet { get; set;}

[REDProp("priority")]
public Int32 Priority { get; set;}

#endregion
}
}