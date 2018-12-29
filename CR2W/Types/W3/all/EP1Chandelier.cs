using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class EP1Chandelier : CGameplayEntity
{
#region RED Properties

[REDProp("m_fallSpeed")]
public float M_fallSpeed { get; set;}

[REDProp("m_damagePercent")]
public float M_damagePercent { get; set;}

[REDProp("m_fallDelay")]
public float M_fallDelay { get; set;}

[REDProp("m_floorLevel")]
public float M_floorLevel { get; set;}

[REDProp("m_radius")]
public float M_radius { get; set;}

[REDProp("m_height")]
public float M_height { get; set;}

[REDProp("m_falling")]
public bool M_falling { get; set;}

[REDProp("m_currTime")]
public float M_currTime { get; set;}

#endregion
}
}