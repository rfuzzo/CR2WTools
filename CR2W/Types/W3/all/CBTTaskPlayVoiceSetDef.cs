using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPlayVoiceSetDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("voiceSet")]
public CBehTreeValString VoiceSet { get; set;}

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("waitUntilSpeechIsFinished")]
public bool WaitUntilSpeechIsFinished { get; set;}

[REDProp("randomizeSpeechStart")]
public bool RandomizeSpeechStart { get; set;}

[REDProp("dontActivateWhileSpeaking")]
public bool DontActivateWhileSpeaking { get; set;}

[REDProp("speachStartDelay")]
public float SpeachStartDelay { get; set;}

[REDProp("playOnDeactivate")]
public bool PlayOnDeactivate { get; set;}

[REDProp("playAfterXtimes")]
public Int32 PlayAfterXtimes { get; set;}

[REDProp("breakCurrentSpeach")]
public bool BreakCurrentSpeach { get; set;}

#endregion
}
}