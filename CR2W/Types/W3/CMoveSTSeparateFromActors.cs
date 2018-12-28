using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTSeparateFromActors : IMoveSteeringTask
{
#region RED Properties

[REDProp("separationDistance")]
public float SeparationDistance { get; set;}

[REDProp("headingImportance")]
public float HeadingImportance { get; set;}

#endregion
}
}