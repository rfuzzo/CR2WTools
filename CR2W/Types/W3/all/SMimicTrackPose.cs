using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SMimicTrackPose 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("tracks")]
public Array<float> Tracks { get; set;}

[REDProp("mapping")]
public Array<Int32> Mapping { get; set;}

#endregion
}
}