using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStatePrepareJump : CExplorationStateAbstract
{
#region RED Properties

[REDProp("m_JumpIsInstantB")]
public bool M_JumpIsInstantB { get; set;}

[REDProp("m_JumpTimeGapF")]
public float M_JumpTimeGapF { get; set;}

[REDProp("m_EndingTimeF")]
public float M_EndingTimeF { get; set;}

[REDProp("m_EndEventNameN")]
public CName M_EndEventNameN { get; set;}

[REDProp("m_EndedEventNameN")]
public CName M_EndedEventNameN { get; set;}

[REDProp("m_TimeEndedB")]
public bool M_TimeEndedB { get; set;}

#endregion
}
}