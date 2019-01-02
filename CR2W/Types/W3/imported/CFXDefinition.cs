using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFXDefinition : CObject
{
#region RED Properties

[REDProp("trackGroups", 2,0)]
public Array<Ptr<CFXTrackGroup>> TrackGroups { get; set;}

[REDProp("length")]
public float Length { get; set;}

[REDProp("loopStart")]
public float LoopStart { get; set;}

[REDProp("loopEnd")]
public float LoopEnd { get; set;}

[REDProp("name")]
public CName Name { get; set;}

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("showDistance")]
public float ShowDistance { get; set;}

[REDProp("stayInMemory")]
public bool StayInMemory { get; set;}

[REDProp("isLooped")]
public bool IsLooped { get; set;}

[REDProp("randomStart")]
public bool RandomStart { get; set;}

#endregion
}
}