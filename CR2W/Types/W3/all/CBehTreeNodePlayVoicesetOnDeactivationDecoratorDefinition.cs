using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodePlayVoicesetOnDeactivationDecoratorDefinition : IBehTreeNodeSpeechDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("voiceSet")]
public CBehTreeValString VoiceSet { get; set;}

[REDProp("voicePriority")]
public CBehTreeValInt VoicePriority { get; set;}

[REDProp("playAfterXTimes")]
public UInt16 PlayAfterXTimes { get; set;}

[REDProp("chanceToPlay")]
public float ChanceToPlay { get; set;}

#endregion
}
}