using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Mutation7BaseEffect : CBaseGameplayEffect
{
#region RED Properties

[REDProp("actors")]
public Array<Handle<CActor>> Actors { get; set;}

[REDProp("sonarEntity")]
public Handle<CEntity> SonarEntity { get; set;}

[REDProp("meshComponent")]
public Handle<CMeshComponent> MeshComponent { get; set;}

[REDProp("streamingHax")]
public bool StreamingHax { get; set;}

[REDProp("scale")]
public float Scale { get; set;}

[REDProp("isSonarIncreasing")]
public bool IsSonarIncreasing { get; set;}

[REDProp("enemyFlashFX")]
public CName EnemyFlashFX { get; set;}

[REDProp("actorsCount")]
public Int32 ActorsCount { get; set;}

[REDProp("apBonus")]
public float ApBonus { get; set;}

#endregion
}
}