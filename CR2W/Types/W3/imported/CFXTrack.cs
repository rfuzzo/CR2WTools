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
public class CFXTrack : CFXBase
{
#region RED Properties

[REDProp("trackItems", 2,0)]
public Array<Ptr<CFXTrackItem>> TrackItems { get; set;}

[REDProp("name")]
public string Name { get; set;}

#endregion
}
}