using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateSkatingRun : CExplorationStateAbstract
{
#region RED Properties

[REDProp("skateGlobal")]
public Handle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

[REDProp("m_Sprinting")]
public bool M_Sprinting { get; set;}

#endregion
}
}