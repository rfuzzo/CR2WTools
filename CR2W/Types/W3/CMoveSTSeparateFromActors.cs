using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSTSeparateFromActors : IMoveSteeringTask
{
#region RED Properties

[REDProp("separationDistance")]
public float SeparationDistance { get; set;}

[REDProp("headingImportance")]
public float HeadingImportance { get; set;}

#endregion
}
}