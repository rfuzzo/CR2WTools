using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SStorySceneLightDimmerProperties 
{
#region RED Properties

[REDProp("ambientLevel")]
public SSimpleCurve AmbientLevel { get; set;}

[REDProp("marginFactor")]
public SSimpleCurve MarginFactor { get; set;}

#endregion
}
}