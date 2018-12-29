using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskNPCNotInFrontOfPLayer : IBehTreeTask
{
#region RED Properties

[REDProp("coneAngle")]
public float ConeAngle { get; set;}

[REDProp("angleOffset")]
public float AngleOffset { get; set;}

[REDProp("coneRange")]
public float ConeRange { get; set;}

[REDProp("playerHeading")]
public float PlayerHeading { get; set;}

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("testedAngle")]
public float TestedAngle { get; set;}

#endregion
}
}