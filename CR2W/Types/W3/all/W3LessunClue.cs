using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3LessunClue : CFlyingCrittersLairEntityScript
{
#region RED Properties

[REDProp("pathWaypoints")]
public Array<Handle<W3ClueWaypoint>> PathWaypoints { get; set;}

[REDProp("factTriggeredAtEnd")]
public string FactTriggeredAtEnd { get; set;}

[REDProp("loopFlying")]
public bool LoopFlying { get; set;}

[REDProp("swarmAttractorEntity")]
public Handle<CEntityTemplate> SwarmAttractorEntity { get; set;}

[REDProp("isCurrentSoundClue")]
public bool IsCurrentSoundClue { get; set;}

[REDProp("swarmAttractor")]
public Handle<CEntity> SwarmAttractor { get; set;}

[REDProp("pathIndex")]
public Int32 PathIndex { get; set;}

[REDProp("clueSeen")]
public bool ClueSeen { get; set;}

[REDProp("targetPosition")]
public Vector TargetPosition { get; set;}

[REDProp("destroyTriggered")]
public bool DestroyTriggered { get; set;}

[REDProp("groupPosition")]
public Vector GroupPosition { get; set;}

[REDProp("accuracy")]
public float Accuracy { get; set;}

[REDProp("cameraDir")]
public Vector CameraDir { get; set;}

[REDProp("camHeading")]
public float CamHeading { get; set;}

[REDProp("toClueVec")]
public Vector ToClueVec { get; set;}

[REDProp("toClueHeading")]
public float ToClueHeading { get; set;}

[REDProp("currentClueState")]
public CName CurrentClueState { get; set;}

[REDProp("groupEffectSpawnPointComponent")]
public Handle<CComponent> GroupEffectSpawnPointComponent { get; set;}

#endregion
}
}