using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFindActorsByTagDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("foundActorsArray")]
public Array<Handle<CActor>> FoundActorsArray { get; set;}

[REDProp("operator")]
public EOperator Operator { get; set;}

[REDProp("numberOfActors")]
public Int32 NumberOfActors { get; set;}

[REDProp("range")]
public float Range { get; set;}

[REDProp("onlyLiveActors")]
public bool OnlyLiveActors { get; set;}

[REDProp("oppNo")]
public Int32 OppNo { get; set;}

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

#endregion
}
}