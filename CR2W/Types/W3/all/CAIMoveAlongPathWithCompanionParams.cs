using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMoveAlongPathWithCompanionParams : CAIMoveAlongPathParams
{
#region RED Properties

[REDProp("companionTag")]
public CName CompanionTag { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("companionOffset")]
public float CompanionOffset { get; set;}

[REDProp("progressWhenCompanionIsAhead")]
public bool ProgressWhenCompanionIsAhead { get; set;}

[REDProp("progressOnlyWhenCompanionIsAhead")]
public bool ProgressOnlyWhenCompanionIsAhead { get; set;}

[REDProp("matchCompanionSpeed")]
public bool MatchCompanionSpeed { get; set;}

[REDProp("allowLeaderToRideOff")]
public bool AllowLeaderToRideOff { get; set;}

[REDProp("moveTypeAfterMaxDistance")]
public EMoveType MoveTypeAfterMaxDistance { get; set;}

#endregion
}
}