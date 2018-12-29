using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFlyAroundDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("distance")]
public CBehTreeValFloat Distance { get; set;}

[REDProp("altitude")]
public CBehTreeValFloat Altitude { get; set;}

[REDProp("tolerance")]
public CBehTreeValFloat Tolerance { get; set;}

[REDProp("frontalHeadingOffset")]
public CBehTreeValInt FrontalHeadingOffset { get; set;}

[REDProp("landingGroundOffset")]
public CBehTreeValFloat LandingGroundOffset { get; set;}

[REDProp("randomHeight")]
public CBehTreeValInt RandomHeight { get; set;}

[REDProp("flightMaxDuration")]
public CBehTreeValFloat FlightMaxDuration { get; set;}

[REDProp("anchorPoint")]
public Handle<CEncounter> AnchorPoint { get; set;}

[REDProp("anchorPointAC")]
public Handle<CComponent> AnchorPointAC { get; set;}

#endregion
}
}