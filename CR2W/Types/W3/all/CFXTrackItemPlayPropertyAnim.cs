using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFXTrackItemPlayPropertyAnim : CFXTrackItem
{
#region RED Properties

[REDProp("timeBegin")]
public float TimeBegin { get; set;}

[REDProp("timeDuration")]
public float TimeDuration { get; set;}

[REDProp("propertyAnimationName")]
public CName PropertyAnimationName { get; set;}

[REDProp("restoreAtEnd")]
public bool RestoreAtEnd { get; set;}

[REDProp("loopCount")]
public uint LoopCount { get; set;}

#endregion
}
}