using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class STimeScaleSourceSet 
{
#region RED Properties

[REDProp("priority")]
public int Priority { get; set;}

[REDProp("entries")]
public Array<STimeScaleSource> Entries { get; set;}

#endregion
}
}