using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskToadFindCorpses : IBehTreeTask
{
#region RED Properties

[REDProp("corpsesArray")]
public Array<Handle<CGameplayEntity>> CorpsesArray { get; set;}

[REDProp("closestCorpse")]
public Handle<CGameplayEntity> ClosestCorpse { get; set;}

[REDProp("searchRange")]
public float SearchRange { get; set;}

[REDProp("maxResults")]
public Int32 MaxResults { get; set;}

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("tempMinDist")]
public float TempMinDist { get; set;}

[REDProp("minDist")]
public float MinDist { get; set;}

[REDProp("closestCorpsePos")]
public Vector ClosestCorpsePos { get; set;}

#endregion
}
}