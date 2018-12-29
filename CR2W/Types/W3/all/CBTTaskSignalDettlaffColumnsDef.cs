using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSignalDettlaffColumnsDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("summonerComponent")]
public Handle<W3SummonerComponent> SummonerComponent { get; set;}

[REDProp("summonsArray")]
public Array<Handle<CEntity>> SummonsArray { get; set;}

[REDProp("columnEntity")]
public Handle<CDettlaffColumn> ColumnEntity { get; set;}

[REDProp("shouldComplete")]
public bool ShouldComplete { get; set;}

[REDProp("startPumping")]
public bool StartPumping { get; set;}

[REDProp("stopPumping")]
public bool StopPumping { get; set;}

#endregion
}
}