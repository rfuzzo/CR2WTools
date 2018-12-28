using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTKeepAwayWalls : CMoveSTKeepAwayWallsInPathfollow
{
#region RED Properties

[REDProp("wallDetectionDistance")]
public float WallDetectionDistance { get; set;}

[REDProp("headingImportance")]
public float HeadingImportance { get; set;}

#endregion
}
}