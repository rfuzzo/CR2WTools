using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBehaviorGraphTrackInfo 
{
#region RED Properties

[REDProp("trackName")]
public string TrackName { get; set;}

[REDProp("weight")]
public float Weight { get; set;}

#endregion
}
}