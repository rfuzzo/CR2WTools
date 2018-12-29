using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleBossFocus : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_bossEntity")]
public Handle<CActor> M_bossEntity { get; set;}

[REDProp("m_bossName")]
public string M_bossName { get; set;}

[REDProp("m_fxSetBossName")]
public Handle<CScriptedFlashFunction> M_fxSetBossName { get; set;}

[REDProp("m_fxSetBossHealth")]
public Handle<CScriptedFlashFunction> M_fxSetBossHealth { get; set;}

[REDProp("m_fxSetEssenceDamage")]
public Handle<CScriptedFlashFunction> M_fxSetEssenceDamage { get; set;}

[REDProp("m_lastHealthPercentage")]
public Int32 M_lastHealthPercentage { get; set;}

[REDProp("m_delay")]
public float M_delay { get; set;}

#endregion
}
}