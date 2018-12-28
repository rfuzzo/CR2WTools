using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SBehaviorGroup : CObject
{
#region RED Properties

[REDProp("behavior")]
public Soft<CBehaviorGraph> Behavior { get; set;}

[REDProp("affectedNPCs")]
public TagList AffectedNPCs { get; set;}

[REDProp("expectedCount")]
public uint ExpectedCount { get; set;}

#endregion
}
}