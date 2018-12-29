using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MapInitData : W3MenuInitData
{
#region RED Properties

[REDProp("m_triggeredExitEntity")]
public bool M_triggeredExitEntity { get; set;}

[REDProp("m_usedFastTravelEntity")]
public Handle<CEntity> M_usedFastTravelEntity { get; set;}

[REDProp("m_isSailing")]
public bool M_isSailing { get; set;}

#endregion
}
}