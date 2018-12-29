using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SummonerComponent : CScriptedComponent
{
#region RED Properties

[REDProp("forgetDeadEntities")]
public bool ForgetDeadEntities { get; set;}

[REDProp("m_SummonedEntities")]
public Array<Handle<CEntity>> M_SummonedEntities { get; set;}

#endregion
}
}