using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CReactionAttitudeChange : IReactionAction
{
#region RED Properties

[REDProp("attitude")]
public EAIAttitude Attitude { get; set;}

[REDProp("towardSource")]
public bool TowardSource { get; set;}

[REDProp("noticeActor")]
public bool NoticeActor { get; set;}

#endregion
}
}