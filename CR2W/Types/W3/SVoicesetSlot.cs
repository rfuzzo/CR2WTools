using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SVoicesetSlot 
{
#region RED Properties

[REDProp("scene")]
public Soft<CStoryScene> Scene { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("voiceTag")]
public CName VoiceTag { get; set;}

#endregion
}
}