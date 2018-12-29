using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SummonedEntityComponent : CScriptedComponent
{
#region RED Properties

[REDProp("m_Summoner")]
public Handle<CActor> M_Summoner { get; set;}

[REDProp("m_SummonedTime")]
public float M_SummonedTime { get; set;}

[REDProp("shouldUseSummonerGuardArea")]
public bool ShouldUseSummonerGuardArea { get; set;}

[REDProp("killOnSummonersDeath")]
public bool KillOnSummonersDeath { get; set;}

#endregion
}
}