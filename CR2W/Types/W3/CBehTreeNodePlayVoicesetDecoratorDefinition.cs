using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodePlayVoicesetDecoratorDefinition : IBehTreeNodeSpeechDecoratorDefinition
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

[REDProp("minSpeechDelay")]
public float MinSpeechDelay { get; set;}

[REDProp("maxSpeechDelay")]
public float MaxSpeechDelay { get; set;}

[REDProp("waitUntilSpeechIsFinished")]
public bool WaitUntilSpeechIsFinished { get; set;}

[REDProp("dontActivateWhileSpeaking")]
public bool DontActivateWhileSpeaking { get; set;}

#endregion
}
}