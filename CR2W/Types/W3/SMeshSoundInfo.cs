using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SMeshSoundInfo 
{
#region RED Properties

[REDProp("soundTypeIdentification")]
public CName SoundTypeIdentification { get; set;}

[REDProp("soundSizeIdentification")]
public CName SoundSizeIdentification { get; set;}

[REDProp("soundBoneMappingInfo")]
public CName SoundBoneMappingInfo { get; set;}

#endregion
}
}