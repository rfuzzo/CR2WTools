using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateIdleJump : CExplorationStateTransitionAbstract
{
#region RED Properties

[REDProp("behEnded")]
public CName BehEnded { get; set;}

[REDProp("enabled")]
public bool Enabled { get; set;}

#endregion
}
}