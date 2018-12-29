using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSpawnDettlaffColumnsDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("owner")]
public Handle<CNewNPC> Owner { get; set;}

[REDProp("tempActor")]
public Handle<CActor> TempActor { get; set;}

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("amountToSpawn")]
public Int32 AmountToSpawn { get; set;}

[REDProp("minDistanceFromTarget")]
public float MinDistanceFromTarget { get; set;}

[REDProp("maxDistanceFromTarget")]
public float MaxDistanceFromTarget { get; set;}

[REDProp("minDistFromEachOther")]
public float MinDistFromEachOther { get; set;}

[REDProp("tagToFind")]
public CName TagToFind { get; set;}

[REDProp("entityToFind")]
public Handle<CEntity> EntityToFind { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("shouldComplete")]
public bool ShouldComplete { get; set;}

[REDProp("summonerComponent")]
public Handle<W3SummonerComponent> SummonerComponent { get; set;}

[REDProp("usedPos")]
public Array<Vector> UsedPos { get; set;}

#endregion
}
}