using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskArachasPull : CBTTask3StateProjectileAttack
{
#region RED Properties

[REDProp("finishAttack")]
public bool FinishAttack { get; set;}

[REDProp("m_projectilesShot")]
public Int32 M_projectilesShot { get; set;}

[REDProp("m_projectilesMissed")]
public Int32 M_projectilesMissed { get; set;}

#endregion
}
}