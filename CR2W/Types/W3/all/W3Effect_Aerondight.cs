using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_Aerondight : CBaseGameplayEffect
{
#region RED Properties

[REDProp("m_maxCount")]
public Int32 M_maxCount { get; set;}

[REDProp("m_currCount")]
public Int32 M_currCount { get; set;}

[REDProp("m_wasDischarged")]
public bool M_wasDischarged { get; set;}

[REDProp("m_aerondightTime")]
public float M_aerondightTime { get; set;}

[REDProp("m_attribute")]
public SAbilityAttributeValue M_attribute { get; set;}

[REDProp("m_stacksPerLevel")]
public SAbilityAttributeValue M_stacksPerLevel { get; set;}

[REDProp("m_currChargingEffect")]
public CName M_currChargingEffect { get; set;}

[REDProp("m_aerondightDelay")]
public float M_aerondightDelay { get; set;}

[REDProp("timeOfPause")]
public GameTime TimeOfPause { get; set;}

#endregion
}
}