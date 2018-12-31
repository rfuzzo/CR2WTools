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
public class CFXTrackGroup : CFXBase
{
#region RED Properties

[REDProp("name")]
public string Name { get; set;}

[REDProp("tracks")]
public Array<Ptr<CFXTrack>> Tracks { get; set;}

[REDProp("isExpanded")]
public bool IsExpanded { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("trackGroupColor")]
public Color TrackGroupColor { get; set;}

[REDProp("componentName")]
public CName ComponentName { get; set;}

#endregion
}
}