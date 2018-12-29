using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFormationKeepAwaylLeaderSteeringTask : IFormationFragmentarySteeringTask
{
#region RED Properties

[REDProp("importance")]
public float Importance { get; set;}

[REDProp("minLeaderDistance")]
public float MinLeaderDistance { get; set;}

[REDProp("noticeLeaderDistance")]
public float NoticeLeaderDistance { get; set;}

#endregion
}
}