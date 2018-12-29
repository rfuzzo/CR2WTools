using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFlyAround : CBTTaskVolumetricMove
{
#region RED Properties

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("altitude")]
public float Altitude { get; set;}

[REDProp("tolerance")]
public float Tolerance { get; set;}

[REDProp("frontalHeadingOffset")]
public Int32 FrontalHeadingOffset { get; set;}

[REDProp("landingGroundOffset")]
public float LandingGroundOffset { get; set;}

[REDProp("randomHeight")]
public Int32 RandomHeight { get; set;}

[REDProp("anchorPoint")]
public Handle<CEncounter> AnchorPoint { get; set;}

[REDProp("anchorPointAC")]
public Handle<CAreaComponent> AnchorPointAC { get; set;}

[REDProp("anchorPointPos")]
public Vector AnchorPointPos { get; set;}

[REDProp("anchorPointToNpcVector")]
public Vector AnchorPointToNpcVector { get; set;}

[REDProp("anchorPointToNpcHeight")]
public float AnchorPointToNpcHeight { get; set;}

[REDProp("anchorPointToNpcDistance2D")]
public float AnchorPointToNpcDistance2D { get; set;}

[REDProp("npcToDestVector")]
public Vector NpcToDestVector { get; set;}

[REDProp("npcToDestVector2")]
public Vector NpcToDestVector2 { get; set;}

[REDProp("npcToDestDistance")]
public float NpcToDestDistance { get; set;}

[REDProp("npcToDestAngle")]
public float NpcToDestAngle { get; set;}

[REDProp("flightMaxDuration")]
public float FlightMaxDuration { get; set;}

[REDProp("flightStartTime")]
public float FlightStartTime { get; set;}

[REDProp("flightDuration")]
public float FlightDuration { get; set;}

#endregion
}
}