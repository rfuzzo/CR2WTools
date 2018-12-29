using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMoveTRGPlayerManualMovement : CMoveTRGScript
{
#region RED Properties

[REDProp("currVelocity")]
public float CurrVelocity { get; set;}

[REDProp("m_heading")]
public float M_heading { get; set;}

[REDProp("m_orientationWODump")]
public float M_orientationWODump { get; set;}

[REDProp("m_headingChangeVal")]
public float M_headingChangeVal { get; set;}

[REDProp("m_headingHistoryTime")]
public float M_headingHistoryTime { get; set;}

[REDProp("m_headingHistory")]
public Array<SHeadingHistory> M_headingHistory { get; set;}

[REDProp("lastKnownPlayerHeading")]
public float LastKnownPlayerHeading { get; set;}

#endregion
}
}