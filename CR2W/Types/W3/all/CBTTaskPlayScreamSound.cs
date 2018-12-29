using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPlayScreamSound : IBehTreeTask
{
#region RED Properties

[REDProp("minFrequency")]
public float MinFrequency { get; set;}

[REDProp("maxFrequency")]
public float MaxFrequency { get; set;}

[REDProp("actor")]
public Handle<CActor> Actor { get; set;}

#endregion
}
}