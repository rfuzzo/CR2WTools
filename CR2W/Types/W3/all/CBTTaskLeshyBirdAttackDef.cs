using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskLeshyBirdAttackDef : CBTTaskAttackDef
{
#region RED Properties

[REDProp("loopTime")]
public float LoopTime { get; set;}

[REDProp("attackRange")]
public float AttackRange { get; set;}

[REDProp("projEntity")]
public Handle<CEntityTemplate> ProjEntity { get; set;}

[REDProp("raiseEventName")]
public CName RaiseEventName { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

#endregion
}
}